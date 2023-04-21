using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    
    [SerializeField] private Transform reciever;

    private Transform player;
    private PlayerController playerController;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        playerController = FindObjectOfType<PlayerController>();
        //lub playerController = player.GetComponent<PlayerController>();
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && !playerController.GetIsOverlaping())
        {
            playerController.SetIsOverlaping(true);
            // ustaw przechodzenie gracza na true;

            Teleportation();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerController.SetIsOverlaping(false);
           // ustaw przechodzenie gracza na fa³sz;
        }
    }

    private void Teleportation()
    {
        //Po co to?

        float dot = Vector3.Dot(transform.forward, player.forward); 
        if (dot < 0 ) { return; } //czy przechodze z odpowiedniej strony

        if (playerController.GetIsOverlaping())
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.position = reciever.position;
            player.GetComponent<CharacterController>().enabled = true;
        }

        //je¿eli gracz przechodzi przez portal to:
        //{
        //    wy³¹cz CharacterControler (inaczej nie mo¿emy go przenosiæ)
        //    ustaw gracza w miejscu drugiego portalu
        //    w³¹cz CharacterController
        //}
    }

    public Transform GetReciever() => reciever;




}
