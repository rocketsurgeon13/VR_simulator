using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerThing : MonoBehaviour
{
    public List<GameObject> pinotut;

    private void OnTriggerEnter(Collider other) { 
        var pinottava = other.GetComponent<Pinottava>();
        if (pinottava != null && pinotut.Count < 1) {
            pinotut.Add(other.gameObject);
            pinottava.pinottu = true;
        }
        Debug.Log(pinotut.Count + " enter " + gameObject);
    }

    private void OnTriggerExit(Collider other) {
        if (pinotut.Count < 2) {
            pinotut.Remove(other.gameObject);
            var pinottava = other.GetComponent<Pinottava>();
            pinottava.pinottu = false;
        }
        Debug.Log(pinotut.Count + " exit " + gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(pinotut.Count + " " + gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
