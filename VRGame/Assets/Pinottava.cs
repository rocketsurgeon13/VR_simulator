using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinottava : MonoBehaviour
{
    public bool pinottu = false;
    GameObject triggerPlate;
    List<GameObject> pinotut;

    private void OnTriggerEnter(Collider other) {
        var pinottava = other.GetComponent<Pinottava>();
        if (pinottava != null && pinottava.pinottu == true && pinottu == false) {
            pinotut.Add(gameObject);
            pinottu = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        pinotut.Remove(gameObject);
        pinottu = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        triggerPlate = GameObject.Find("TriggerPlate");
        pinotut = triggerPlate.GetComponent<TriggerThing>().pinotut;
    }

    // Update is called once per frame
    void Update()
    {
        //if (pinottu) {
        //    gameObject.AddComponent<TriggerThing>();
        //    pinottu = false;
        //}
    }
}
