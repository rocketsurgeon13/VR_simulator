using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class Tasapaino : MonoBehaviour
{
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Throwable>().attached) {
            transform.Rotate(0f, 0f, rotationSpeed, Space.World);
        }

        if (transform.rotation.z > 90) {
            
        }
    }
}
