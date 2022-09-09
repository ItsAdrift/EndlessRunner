using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    [SerializeField] float gravity;

    private void Awake()
    {
        Vector2 g = Physics2D.gravity;
        g.y = gravity;
        Physics2D.gravity = g;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Physics2D.gravity *= -1;
        }
    }
}
