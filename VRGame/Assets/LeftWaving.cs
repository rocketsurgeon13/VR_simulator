using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWaving : MonoBehaviour{
    public GameObject Player;
    public float rotationResetSpeed;
  
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "HeadCollider") {
            Player.transform.rotation = transform.rotation;         
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "HeadCollider") {
            //Player.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.identity, rotationResetSpeed);
        }
    }   
}
