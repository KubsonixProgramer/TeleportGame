using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private int timeAtStart = 10;
    /// <summary>
    /// Czasz do pierwszego tiku w sekundach
    /// </summary>
    private float timeToFirstTick = 2;

    public void FreezTime(int freezTime)
    {
        CancelInvoke(nameof(Stopper));
        InvokeRepeating(nameof(Stopper), freezTime, tickTime);
    }

    /// <summary>
    /// Czas tiku w sekundach
    /// </summary>
    private float tickTime = 1;

   private int timeToEnd;


   
    void Start()
    {
        timeToEnd = timeAtStart;
        InvokeRepeating(nameof(Stopper),timeToFirstTick,tickTime);
    }

    
    private void Stopper()
    {
        Debug.Log(timeToEnd + " s");
        timeToEnd --;
        if(timeToEnd <= 0)
        {
            CancelInvoke(nameof(Stopper));
            GameManager.Instance.EndGame();
        }
    }

    public void AddTime(int time)
    {
        timeToEnd += time;
    }
}
