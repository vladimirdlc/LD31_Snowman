using UnityEngine;
using System.Collections;

public class SwitchActivator : MonoBehaviour {
    public GameObject activateObject;
    private bool activated;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (!activated) audio.Play();
            GetComponent<Animator>().SetBool("activated", true);
            activateObject.SetActive(true);
            activated = true;
        }
    }
}
