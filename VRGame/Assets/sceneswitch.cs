using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneswitch : MonoBehaviour
    
{






    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {

       

    }

    private void OnCollisionEnter(Collision collision)
    {
        print("osui");
    }
    void Update()
    {

       
    }
}
