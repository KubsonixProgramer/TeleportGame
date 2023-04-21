using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public virtual void PickedUp()// virtual znaczy ¿e mo¿e byæ nadpisana w dziedzicz¹cej klasie
    {
        Debug.Log("Podnios³eœ" + gameObject.name);
        Destroy(gameObject);
    }

    protected void Rotation()
    {
        transform.Rotate(0, 5f, 0);
    }

    private void Update()
    {
        Rotation();
    }
}
