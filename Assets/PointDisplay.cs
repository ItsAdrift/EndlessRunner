using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text pointDisplayText;

    public void Update()
    {
        pointDisplayText.text = "" + GameManager.Instance.points;
    }

}
