using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] int redKey = 0;
    [SerializeField] int greenKey = 0;
    [SerializeField] int goldKey = 0;

    public void AddKey(KeyColor color)
    {
        /*
         * Je�eli z�apany klucz jest czerwony dodaj do czerwonych kluczy
         * Je�eli z�apany klucz jest zielony dodaj do zielonych kluczy
         * Je�eli z�apany klucz jest z�oty dodaj do z�otych
         */

        if(color == KeyColor.Red)
        {
            redKey++;
        }
        if (color == KeyColor.Green)
        {
            greenKey++;
        }
        if (color == KeyColor.Gold)
        {
            goldKey++;
        }
    }
}
