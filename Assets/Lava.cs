using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public static Lava instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

}
