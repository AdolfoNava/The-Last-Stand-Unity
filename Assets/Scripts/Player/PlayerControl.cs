using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Status { Alive, Dead }
public class PlayerControl : MonoBehaviour
{
    //To Generate the bullet from my collection of prefabs
    [SerializeField] private GameObject bullet;
    //The player input for the rotation to ensure the bullets flies towards the intended direction
    [SerializeField] private Transform aimDirection;
    //Where all bullet objects will reside when the player happens to die so that I can delete every bullet in the scene
    [SerializeField]
    public GameObject collection;
    //The status of the player so everything in the scene can deal with the player respawns
    public static Status Status { get; private set; }
    //New input system controls for the player
    private MainControl inputs;
    //To deal with the collisions
    private Rigidbody2D rb;
    //Make a cooldown period to shoot again
    private bool canShoot;
    //Deal with a grace period after dying
    int respawnCooldown;
    //Speed of the ship flying across the scene
    [SerializeField] private float speed = 5f;
    //Make calls to the audio source to the prefab on the scene
    AudioSource ShootingSound;

    void Awake()
    {
        inputs = new MainControl();
        rb = GetComponent<Rigidbody2D>();
        //To make the controller of the direction seperately from the control of the ship's movement and deal with the spawning point of the bullets
        aimDirection = rb.transform.GetChild(0).transform;
        collection = GameObject.Find("Collection");
        ShootingSound = GetComponent<AudioSource>();
    }
    void Start()
    {
        //Handler for when the player wants to shoot
        inputs.Gameplay.Shoot.performed += _ => Shooting();
        canShoot = true;
        Status = Status.Alive; 
        
    }
    private void OnEnable()
    {
        inputs.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
    }

    void FixedUpdate()
    {
        
        if (ScoreSystem.Lives != 0) 
        { 
            //Controls for the player gets called when it is alive
        if (Status == Status.Alive)
        {
        Movement();
        Aiming();
        }
        else
        {
            //Since the ship would still move after it dies setting the velocity to zero makes it stay still until its back alive
            rb.velocity = new Vector2(0,0);
            respawnCooldown++;
        }
        if (respawnCooldown > 60 && ScoreSystem.Lives > 0)
        {
            //Ending the grace period
            Status = Status.Alive;
            respawnCooldown = 0;
        }
        }
        else
        {
            //Removes the ship from the scene to ensure no more audio plays from the ship shooting
            Destroy(this);
        }
    }
    //This is to deal with the player where they want to shoot
    //Also rotates the player to the location of the cursor
    private void Aiming()
    {
        Vector2 AimingPosition = inputs.Gameplay.Aim.ReadValue<Vector2>();
        Vector3 AimWorldPosition = Camera.main.ScreenToWorldPoint(AimingPosition);
        Vector3 targetDirection = AimWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y,targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
    //Handling all the actions of shooting the gun which includes the audio effects
    private void Shooting()
    {
        if (Status == Status.Dead)
            return;
        if (!canShoot) return;
        //var parent = transform.SetParent(transform.Find)
        ShootingSound.Play();
        Instantiate(bullet, aimDirection.position, aimDirection.rotation, collection.transform);

        Vector2 aimPosition = inputs.Gameplay.Aim.ReadValue<Vector2>();
        aimPosition = Camera.main.ScreenToViewportPoint(aimPosition);
        StartCoroutine(CanShoot());
    }
    //Making the a grace period to stop the player from shooting too mucch
    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(.1f);
        canShoot = true;
    }
    //Handling the movement of the player
    private void Movement()
    {
        Vector2 moveInput = inputs.Gameplay.Movement.ReadValue<Vector2>();
        rb.velocity = moveInput * speed;
    }
    //Gets called from the enemies collison method calls to begin the despawning of all enemies and bullets from the scene
    public static void Dying()
    {
        Status = Status.Dead;
        var children = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject child in children)
            Destroy(child);
        ScoreSystem.Respawn();
    }
}
