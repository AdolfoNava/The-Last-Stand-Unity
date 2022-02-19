using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This obtains audio files from the resources folder and play sounds based on which enemy calls it
public class EnemyAudioManager : MonoBehaviour
{
    public static AudioClip WandererDeath,ChaserDeath,SeekerDeath,BlackHoleDeath;
    private static AudioSource AudioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        AudioPlayer = GetComponent<AudioSource>();

        WandererDeath = Resources.Load<AudioClip>("Audio/Wanderer");
        ChaserDeath = Resources.Load<AudioClip>("Audio/Chaser");
        SeekerDeath = Resources.Load<AudioClip>("Audio/Seeker");
        BlackHoleDeath = Resources.Load<AudioClip>("Audio/BlackHole");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlayDeathAudio(string name) {
        switch (name)
        {
            case "Wanderer":
                AudioPlayer.PlayOneShot(WandererDeath);
                break;
            case "Chaser":
                AudioPlayer.PlayOneShot(ChaserDeath);
                break;
            case "Seeker":
                AudioPlayer.PlayOneShot(SeekerDeath);
                break;
            case "BlackHole":
                AudioPlayer.PlayOneShot(BlackHoleDeath);
                break;
            default:
                break;
        }
    }
}
