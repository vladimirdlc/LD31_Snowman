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
            hatRenderer.sprite = giftHat;
            range.transform.localScale = range.transform.localScale * rangeMultiplier;
            Destroy(gameObject);
        }
            

    }
}
