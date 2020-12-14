using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip playerLaserSound, enemyLaserSound, enemyDeathSound, playerDeathSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        // the  different types of sounds are located in the resources folder and will load each individual audio clip when prompted
        playerLaserSound = Resources.Load<AudioClip> ("playerLaser");
        enemyLaserSound = Resources.Load<AudioClip> ("enemyLaser");
        enemyDeathSound = Resources.Load<AudioClip> ("enemyDeath");
        playerDeathSound = Resources.Load<AudioClip> ("playerDeath");

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // will play the sound clip that you choose.
    public static void PlaySound (string clip)
    {
        // plays the "EnemyDeath" sound clip
        switch (clip) {
        case "EnemyDeath":
            audioSrc.PlayOneShot (enemyDeathSound);
            break;
        // plays the "EnemyLaser" sound clip
        case "EnemyLaser":
            audioSrc.PlayOneShot (enemyLaserSound);
            break;
        // plays the "PlayerLaser" sound clip
        case "PlayerLaser":
            audioSrc.PlayOneShot (playerLaserSound);
            break;
        // plays the "PlayerDeath" sound clip
        case "PlayerDeath":
            audioSrc.PlayOneShot (playerDeathSound);
            break;
        }
    }
}
