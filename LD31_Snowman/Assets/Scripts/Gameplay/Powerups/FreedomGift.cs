using UnityEngine;
using System.Collections;

public class FreedomGift : MonoBehaviour {
    public Sprite giftHat;
    public SpriteRenderer hatRenderer;
    public GameObject range;
    public float rangeMultiplier = 10;
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            audio.Play();
            hatRenderer.sprite = giftHat;
            range.transform.localScale = range.transform.localScale * rangeMultiplier;
            collider2D.enabled = false;
            renderer.enabled = false;
            Destroy(this);
            Destroy(gameObject, 3);
        }
            

    }
}
