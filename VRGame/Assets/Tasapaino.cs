using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class Tasapaino : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public Transform child;
    public float currentAmplitude = 0f;
    public float frequency = 2f;
    float maxAmplitude = 90f;
    float maxfrequency = 2f;
    float tickTimer = 0f;
    float tick = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        if (GetComponent<Throwable>().attached) {
            tickTimer += Time.deltaTime;
            if(tickTimer > tick) {
                if (currentAmplitude <= maxAmplitude) {
                    currentAmplitude += 0.5f;
                }
                //if (frequency <= maxfrequency) {
                //    frequency += 0.03f;
                //}
                tickTimer -= tick;
            }
            
            var f = Mathf.Sin(Time.time * frequency * (2 * Mathf.PI)) * currentAmplitude;
            child.localRotation = Quaternion.Euler(0, 0, f);
            //if (transform.rotation.z >= 0) {
            //    transform.Rotate(0f, 0f, rotationSpeed, Space.World);
            //}
            //else {
            //    transform.Rotate(0f, 0f, -rotationSpeed, Space.World);
            //}
        }
    }
}
