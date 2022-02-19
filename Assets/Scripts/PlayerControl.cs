using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform aimDirection;
    [SerializeField] public GameObject collection;
    private MainControl inputs;
    private Rigidbody2D rb;
    private bool canShoot;

    [SerializeField] private float speed = 5f;
    void Awake()
    {
        inputs = new MainControl();
        rb = GetComponent<Rigidbody2D>();
        aimDirection = rb.transform.GetChild(0).transform;
    }
    void Start()
    {
        inputs.Gameplay.Shoot.performed += _ => Shooting();
        canShoot = true;
        
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
        Movement();
        //Shooting();
        Aiming();
    }

    private void Aiming()
    {
        Vector2 AimingPosition = inputs.Gameplay.Aim.ReadValue<Vector2>();
        Vector3 AimWorldPosition = Camera.main.ScreenToWorldPoint(AimingPosition);
        Vector3 targetDirection = AimWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y,targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    private void Shooting()
    {
        if (!canShoot) return;
        //var parent = transform.SetParent(transform.Find)
        Instantiate(bullet, aimDirection.position, aimDirection.rotation, collection.transform);

        Vector2 aimPosition = inputs.Gameplay.Aim.ReadValue<Vector2>();
        aimPosition = Camera.main.ScreenToViewportPoint(aimPosition);
        StartCoroutine(CanShoot());
    }

    IEnumerator CanShoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(.1f);
        canShoot = true;
    }

    private void Movement()
    {
        Vector2 moveInput = inputs.Gameplay.Movement.ReadValue<Vector2>();
        rb.velocity = moveInput * speed;
    }

}
