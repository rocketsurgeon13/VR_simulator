using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerMovement : MonoBehaviour
{

    public GameObject Player;
    public float movementSpeed = 4;
    void Update()
    {
        transform.LookAt(Player.transform);



    }
}



