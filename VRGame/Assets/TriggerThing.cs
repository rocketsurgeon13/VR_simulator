using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerThing : MonoBehaviour
{
    public List<GameObject> pinotut;
    bool voitettu = false;
    float tickTimer = 0f;
    float tick = 2f;

    private void OnTriggerEnter(Collider other) {
        LisaaPinoon(other);
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

    private void OnTriggerStay(Collider other) {
        LisaaPinoon(other);
    }

    void LisaaPinoon(Collider other) {
        if (other.gameObject.layer != 9) {
            var pinottava = other.GetComponent<Pinottava>();
            if (pinottava != null && pinotut.Count < 1) {
                pinotut.Add(other.gameObject);
                pinottava.pinottu = true;
            }
        }
    }

    // Start is called before the first frame update
    void Start() {
        Debug.Log(pinotut.Count + " " + gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (pinotut.Count >= 4 && !voitettu) {
            tickTimer += Time.deltaTime;
            if (tickTimer > tick) {
                Debug.Log("voitit pelin");
                voitettu = true;
            }
        }
        if (pinotut.Count < 4 && voitettu) {
            voitettu = false;
        }
    }
}
