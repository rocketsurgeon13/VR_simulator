using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class NextScene : MonoBehaviour{

    public string loadThisScene;
    public string rightObject;
    

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == rightObject ) {
            // tuhoa vanha pelaaja ja lataa sitten vasta uusi scene jossa on uusi pelaaja valmiina
            var temp = FindObjectOfType<Player>(); 
            Destroy(temp.gameObject);
            SceneManager.LoadScene(loadThisScene);
        }
    }
}
