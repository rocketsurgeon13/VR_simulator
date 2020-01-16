using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrigger2 : MonoBehaviour
{
    public AudioClip soundtoplay;
    public float Volume;
    AudioSource audio;
    public bool AlreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter()
    {
            audio.PlayOneShot(soundtoplay, Volume);

     
    }
    // Update is called once per frame

}
