using UnityEngine;
using System.Collections;

public class SwitchActivator : MonoBehaviour {
    public GameObject activateObject;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GetComponent<Animator>().SetBool("activated", true);
            activateObject.SetActive(true);
            Destroy(this);
        }
    }
}
