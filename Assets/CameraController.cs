using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float time = 2f;
    public Transform target;

    public float y = 0;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, target.position, time * Time.deltaTime);
        Vector3 pos = transform.position;
        pos.y = y;
        pos.z = -10;
        transform.position = pos;
    }
}
