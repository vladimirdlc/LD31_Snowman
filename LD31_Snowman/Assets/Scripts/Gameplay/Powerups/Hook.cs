using UnityEngine;
using System.Collections;

public class Hook : MonoBehaviour {
    public float force = 400;
    public float retractForce = 3;
    public CircleCollider2D controlRadius;
    private bool isRetracting;
    public float retractUntilDiff = 0.02f;
    public GameObject hookGuide;
    public float currentRetractTime;
    public float maxRetractTime = 1;

	// Update is called once per frame
	void Update () {
        if (!isRetracting)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody2D.AddForce(transform.up * force);
                currentRetractTime = 0;
                //origin = transform.position;
                ////originQuaternion = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            }

            if (!controlRadius.bounds.Contains(transform.position))
            {
                rigidbody2D.velocity = Vector2.zero;
                isRetracting = true;
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
}
