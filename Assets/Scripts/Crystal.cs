using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : Pickups
{
    [SerializeField] int pointsForCrystal = 7;

    ScoreKeeper scoreKeeper;
    

    private void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public override void PickedUp()
    {
        scoreKeeper.AddPoints(pointsForCrystal);
        base.PickedUp();
        
    }
}
