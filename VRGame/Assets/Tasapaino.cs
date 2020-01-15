using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class Tasapaino : MonoBehaviour
{
    //public float rotationSpeed = 1f;
    public Transform child;
    public float currentAmplitude = 0f;
    public float frequency = 5f;
    public float amplitudeIncrease = 2f;
    public float dropTick = 10f;
    float maxAmplitude = 90f;
    //float maxfrequency = 5f;
    float tickTimer = 0f;
    float tick = 0.5f;
    float dropTicktimer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        if (GetComponent<Throwable>() !=null && GetComponent<Throwable>().attached) {
            tickTimer += Time.deltaTime;
            dropTicktimer += Time.deltaTime;
            while (tickTimer > tick) {
                if (currentAmplitude <= maxAmplitude) {
                    currentAmplitude += amplitudeIncrease;
                }
                //if (frequency <= maxfrequency) {
                //    frequency += 0.5f;
                //}
                tickTimer -= tick;
            }

            if(dropTicktimer > dropTick) {
                currentAmplitude = 0f;
                dropTicktimer = 0f;
                //    Destroy(GetComponent<Throwable>());
                //    Destroy(GetComponent<Interactable>()); 
                //    //transform.Translate(0, -5, 0, Space.World);
                //    gameObject.AddComponent<Interactable>();
                //    gameObject.AddComponent<Throwable>();
            }
            
            var f = Mathf.Sin(Time.time * frequency * (2 * Mathf.PI)) * currentAmplitude;
            child.localRotation = Quaternion.Euler(0, 0, f);
        } else if (currentAmplitude > 0.5f) {
            currentAmplitude = 0;
            dropTicktimer = 0f;
        }
    }
}
