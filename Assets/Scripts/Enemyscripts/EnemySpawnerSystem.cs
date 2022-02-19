
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerSystem : MonoBehaviour
{
    //This is to setup the prefabs for the game to choose what to spawn in
    public List<GameObject> EnemyPrefab;
    //SpawnPoints is for the different positions in scene that will not change at any point throughout the game
    public Spawn[] SpawnPoints;
    //To get the reference for the player ship
    public GameObject Player;
    //This is to set the cooldown period of the next enemy to spawn and be adjusted in the editor
    public int SpawnCooldownCounter;
    //This is to go up in increments as the literal cooldown variable meant to always reset when a enemy begins to spawn or to ensure nothing spawns while the player is dead
    private int SpawnCooldown;
    // This is for the rng variable
    int PrefabIdentifier;
    // This is for the rng factor
    int SpawnPointIdentifer;
    // Start is called before the first frame update
    void Start()
    {
        //This is to deal with if the rng chooses a spawner that was deactivated
        SpawnPoints = GameObject.Find("SpawnPoints").GetComponentsInChildren<Spawn>();
        //Ensures that every enemy gets the reference to the player on the scene
        Player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        CheckPlayerStatus();
        Spawning();

    }

    void Spawning()
    {
        SpawnCooldown++;
        if (SpawnCooldown > SpawnCooldownCounter&&PlayerControl.Status == Status.Alive)
        {
            PrefabIdentifier = Random.Range(0, 4);
            SpawnPointIdentifer = Random.Range(0, SpawnPoints.Length);
            if(!SpawnPoints[SpawnPointIdentifer].Deactivated)
            Instantiate(EnemyPrefab[PrefabIdentifier], SpawnPoints[SpawnPointIdentifer].transform.position, Quaternion.identity);
            else
            {
                for (int count = 0; count < SpawnPoints.Length - 1; count++)
                {
                    if (!SpawnPoints[count].Deactivated)
                    {
                        Instantiate(EnemyPrefab[PrefabIdentifier], SpawnPoints[count].transform.position, Quaternion.identity);
                        break;
                    }
                }
            }
            SpawnCooldown = 0;
        }
    }
    //Self explanetory
    void CheckPlayerStatus()
    {
        if (PlayerControl.Status != Status.Alive)
        {
            SpawnCooldown = 0;
        }
    }
}

