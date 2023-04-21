using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int points = 0;
    

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
    }
}
