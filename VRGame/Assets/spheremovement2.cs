using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremovement2 : MonoBehaviour
{
    /*public float moveSpeed = 2.0f;
    private float distanceTravelled;
    private Vector3 originalPosition;


    // Use this for initialization
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceTravelled += Vector3.Distance(originalPosition, transform.position);

        if (distanceTravelled < 1f)
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);


        if (distanceTravelled >= 1f)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }*/

    public float min = 2f;
    public float max = 3f;
    
    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + 3;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 1, max - min) + min, transform.position.y, transform.position.z);

    }
}
// Update is called once per frame


