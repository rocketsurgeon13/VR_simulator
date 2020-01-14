using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremovement : MonoBehaviour
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

    public float min = 1f;
    public float max = 2f;
    // Use this for initialization
    void Start()
    {

        min = transform.position.y;
        max = transform.position.x + 2;

    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 1, max - min) + min, transform.position.x, transform.position.z);

    }
}
// Update is called once per frame


