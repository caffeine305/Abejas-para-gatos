using System;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int gamePoints;
    public TMP_Text pointsDisplay;
    public bool active;
    private string gamePointsString;

    void Start()
    {
        pointsDisplay.text = "Probando";
        active = true;
        gamePoints = 0;
    }


    public void UpdatePoints(int obtainedPoints)
    {
        gamePoints = gamePoints + obtainedPoints; 

        gamePointsString = gamePoints.ToString();
        pointsDisplay.text = gamePointsString;

        Debug.Log("Puntos: "+gamePoints);
    }
}
