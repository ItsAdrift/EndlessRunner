using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Obstacle", menuName = "Obstacle")]
public class Obstacle : ScriptableObject
{
    public string id;
    public GameObject prefab;
    
}
