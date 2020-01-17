using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour{

    public string loadThisScene;
    public string rightObject;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == rightObject ) {
            SceneManager.LoadScene(loadThisScene);
        }
    }
}
