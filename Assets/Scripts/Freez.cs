using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freez : Pickups
{
    [SerializeField] int freezTime;
    Timer timer;

    private void Start()
    {
        timer = FindObjectOfType<Timer>();
    }
    public override void PickedUp()
    {
        timer.FreezTime(freezTime);


        base.PickedUp();
    }
}
