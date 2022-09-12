using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleData : MonoBehaviour
{
    public Transform nextPoint;
    public BoxCollider2D point;

    public void PointGained()
    {
        GameManager.Instance.points++;
    }

    public void SwapGravity()
    {
        FindObjectOfType<PhysicsController>().SwapGravity();
    }
}
