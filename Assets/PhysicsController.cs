using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    [SerializeField] bool allowPlayerControl = true;
    [Space]

    [SerializeField] float gravity;

    [SerializeField] float time;
    float t;

    private void Awake()
    {
        Vector2 g = Physics2D.gravity;
        g.y = gravity;
        Physics2D.gravity = g;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && allowPlayerControl)
        {
            if (Time.time > t)
            {
                SwapGravity();
            }
        }
    }

    public void SwapGravity()
    {
        Physics2D.gravity *= -1;
        t = Time.time + time;
    }

}
