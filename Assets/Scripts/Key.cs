using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Red = 0, 
    Green = 1 , 
    Gold = 2
}

[ExecuteAlways] //wykonuj skrypt nie wa¿ne czy w kreatorze czy w grze

public class Key : Pickups
{
    [SerializeField] private KeyColor color;
    [SerializeField] private Material[] materials;
    [SerializeField] private MeshRenderer mesh;

    private Inventory inventory;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }
    public override void PickedUp()
    {
        inventory.AddKey(color);
        base.PickedUp();
    }

    private void Update()
    {
         
        mesh.material = materials[(int)color];
        
    }

}
