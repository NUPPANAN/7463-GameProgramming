using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip footstep1Sound, footstep2Sound, footstep3Sound, footstep4Sound, footstep5Sound, jumpSound, powerupSound, blackgroundSound;
    private AudioSource audioSrc;

    void Start()
    {
        footstep1Sound = Resources.Load<AudioClip>("footstep_grass_000");
        footstep2Sound = Resources.Load<AudioClip>("footstep_grass_001");
        footstep3Sound = Resources.Load<AudioClip>("footstep_grass_002");
        footstep4Sound = Resources.Load<AudioClip>("footstep_grass_003");
        footstep5Sound = Resources.Load<AudioClip>("footstep_grass_004");
        jumpSound = Resources.Load<AudioClip>("jump");
        powerupSound = Resources.Load<AudioClip>("powerUp");
        blackgroundSound = Resources.Load<AudioClip>("Mishief Stroll");

        audioSrc = GetComponent<AudioSource>();
        
    }

    //Update is called once per frame
    void Awake()
    {
        var numSoundManager = FindObjectsOfType<SoundManager>().Length;

        if (numSoundManager < 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlaySound(string clip)
    {
        switch (clip)
        {
            case "powerUp":
                audioSrc.PlayOneShot(powerupSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "footstep_grass_000":
                audioSrc.PlayOneShot(footstep1Sound);
                break;
            case "footstep_grass_001":
                audioSrc.PlayOneShot(footstep2Sound);
                break;
            case "footstep_grass_002":
                audioSrc.PlayOneShot(footstep3Sound);
                break;
            case "footstep_grass_003":
                audioSrc.PlayOneShot(footstep4Sound);
                break;
            case "footstep_grass_004":
                audioSrc.PlayOneShot(footstep5Sound);
                break;
        }
    }  
}
