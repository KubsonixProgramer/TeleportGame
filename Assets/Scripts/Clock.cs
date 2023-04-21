using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : Pickups //dziedziczy z  Pickups - wszystko co public w pickups to i w clock
{
    [SerializeField]uint timeToAdd = 5;
    [SerializeField] bool addTime = true;

    Timer timer;

    private void Start()
    {
        timer = FindObjectOfType<Timer>(); //znajdü obiekt z Timer
    }

    public override void PickedUp()//override znaczy øe nadpisuje metode
    {
        int sign;
        if (!addTime)
        {
            sign = -1;
        }
        else
        {
            sign = 1;
        }
        timer.AddTime((int)timeToAdd*sign);

        base.PickedUp();
    }
}
