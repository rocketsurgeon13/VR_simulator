using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionLow : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
   
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            QualitySettings.masterTextureLimit = 100;
            

        }
        if (Input.GetKeyDown("z"))
        {
            QualitySettings.masterTextureLimit = 1;
        }
    }
}
