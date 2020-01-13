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
    void OnGUI()
    {
        string[] names = QualitySettings.names;
        GUILayout.BeginVertical();
        for (int i = 0; i < names.Length; i++)
        {
            if (GUILayout.Button(names[i]))
            {
                QualitySettings.SetQualityLevel(i, true);
            }
        }
        GUILayout.EndVertical();
    }
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
