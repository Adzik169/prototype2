using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsManager : MonoBehaviour
{
    public TMP_Text score;
    public float points = 0;

    void Start()
    {
        score.text = "Points: "+ points.ToString();
    }

    public void AddPoint(float number)
    {
        points += number;
        score.text = "Points: " + points.ToString();
    }
}
