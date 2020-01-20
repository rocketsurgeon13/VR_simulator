using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PlayerChecking : MonoBehaviour{

    public GameObject playerData;
    Player pData;
    
    void Start(){
        pData = FindObjectOfType<Player>();
        if(pData == null) {
            pData = Instantiate(playerData).GetComponent<Player>();
        }
        
    }
}
