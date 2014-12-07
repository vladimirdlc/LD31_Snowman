using UnityEngine;
using System.Collections;

public class RotZClamper : MonoBehaviour {
    public float minZClamp = 135.0f;
    public float maxZClamp = 225.0f;
	
	// Update is called once per frame
	void Update () {
        Vector3 touchPosition = Input.mousePosition;

        foreach (Touch touch in Input.touches)
        {
            if (Vector3.Distance(transform.localPosition, touch.position)
                < Vector3.Distance(transform.localPosition, touchPosition))
                touchPosition = touch.position;
        }

        float curZ = transform.rotation.eulerAngles.z;
        if (curZ > minZClamp && curZ < maxZClamp)
            if (touchPosition.x < transform.position.x)
            {
                transform.rotation =
                    Quaternion.Euler(transform.rotation.eulerAngles.x, 
                    transform.rotation.eulerAngles.y, minZClamp);
            }
            else
            {
                transform.rotation =
                    Quaternion.Euler(transform.rotation.eulerAngles.x,
                    transform.rotation.eulerAngles.y, maxZClamp);
            }
	}
}
