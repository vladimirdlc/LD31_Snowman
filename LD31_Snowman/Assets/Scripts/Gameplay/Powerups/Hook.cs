using UnityEngine;
using System.Collections;

public class Hook : MonoBehaviour {
    public float force = 400;
    public float playerPushForce = 40000;
    public float retractForce = 3;
    public CircleCollider2D controlRadius;
    private bool isRetracting;
    public float retractUntilDiff = 0.02f;
    public GameObject hookGuide;
    public float currentRetractTime;
    public float maxRetractTime = 1;
    public GameObject player;
    public bool isFlying;

	// Update is called once per frame
	void Update () {
        if (!isRetracting)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody2D.velocity = transform.up * force;
                currentRetractTime = 0;
                isFlying = true;
                collider2D.enabled = true;
            }

            if (!controlRadius.bounds.Contains(transform.position))
            {
                rigidbody2D.velocity = Vector2.zero;
                isFlying = false;
                isRetracting = true;
                collider2D.enabled = false;
            }
        }
        else retractHook();
	}

    void retractHook()
    {
        currentRetractTime += Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, hookGuide.transform.position, Time.deltaTime * retractForce);
        transform.rotation = Quaternion.Lerp(transform.rotation, hookGuide.transform.rotation, Time.deltaTime * retractForce);
        if (Vector3.Distance(transform.position, hookGuide.transform.position) < retractUntilDiff)
        {
            isRetracting = false;
            goToHelper();
        }

        if(currentRetractTime > maxRetractTime)
        {
            goToHelper();
        }
    }

    void goToHelper()
    {
        transform.position = hookGuide.transform.position;
        transform.rotation = hookGuide.transform.rotation;
    }

    /// <summary>
    /// Hook has collided with something
    /// </summary>
    /// <param name="coll">Other object</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        rigidbody2D.velocity = Vector3.zero;
        collider2D.enabled = false;
        if (coll.gameObject.tag == "Enemy")
        {

        }
        else
        {
            player.rigidbody2D.velocity = transform.up * playerPushForce;
        }

        isRetracting = true;
    }
}
