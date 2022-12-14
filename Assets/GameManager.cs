using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [ReadOnly] public int points;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
}
