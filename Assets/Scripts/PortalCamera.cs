using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    private Camera playerCamera;
    private Transform basePortal;
    private Transform targetPortal;

    private float myAngle;


    private void Start()
    {
        playerCamera = Camera.main;
        basePortal = transform.parent;
        targetPortal = basePortal.GetComponentInChildren<PortalTeleport>().GetReciever(); //wzi¹æ pozycje z obiektu który ma ten komponent

    }

    private void PortalCameraControler()
    {
        targetPortal.GetComponentInChildren<PortalCamera>().transform.rotation = playerCamera.transform.rotation;
        // przypisz do rotacji kamery w portalu docelowym rotacjê kamery g³ównej ;

    }

    private void Update()
    {
        PortalCameraControler();
    }

}
