using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            MainCharacterMovement.hasKey = true;
            coll.gameObject.AddComponent<ParticleSystem>();
            audio.Play();
            renderer.enabled = false;
            collider2D.enabled = false;
            Destroy(this);
            Destroy(transform.parent.gameObject, 0.1f);
        }
    }
}
