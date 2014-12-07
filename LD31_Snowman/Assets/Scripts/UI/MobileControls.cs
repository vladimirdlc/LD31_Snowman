using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MobileControls : MonoBehaviour {
    public float speed = 4.0f;
    public float smoothSteer = 4.0f;
    public bool isUsingTouch;

    void Update()
    {
        lookAtTouch(transform);
    }
        

    public void lookAtTouch(Transform caller)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //transform.LookAt(new Vector3(mousePosition.x, mousePosition.y, transform.position.x));
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
    }

}
    