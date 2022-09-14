using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ObjectFollow;
    public float smoothTime;
    private Vector3 vel = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = ObjectFollow.transform.position;
        targetPosition.z = -10f;
        targetPosition.x = 0f;
        

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, smoothTime);       //follows the target
    }
}
