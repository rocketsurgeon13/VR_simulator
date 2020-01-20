using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiotrigger3 : MonoBehaviour
{
    public AudioClip soundtoplay;
    public float Volume;
    AudioSource audio;
    public bool AlreadyPlayed = false;
    public float lightTimer = 1f;
    Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter()
    {
        light.enabled = true;
        if (!AlreadyPlayed)
        {
            audio.PlayOneShot(soundtoplay, Volume);
            AlreadyPlayed = true;
        }
    }

    private void Update() {
        if (light.enabled) {
            lightTimer -= Time.deltaTime;
            if(lightTimer < 0) {
                light.enabled = false;
                lightTimer = 1f;
            }
        }
    }
}
