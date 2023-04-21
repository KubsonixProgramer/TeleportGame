using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Settings
   [SerializeField] float basemoveSpeed = 12;
    [SerializeField] LayerMask layerMask;
    
    

    //References
    [SerializeField] Transform groundChecker;
    CharacterController characterController; //odwo³anie do character controller

    //State
    float moveSpeed;
    bool isOverlaping;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        
    }

    private void PlayerMove()
    {
        RaycastHit hit;

        if (Physics.Raycast(groundChecker.position, transform.TransformDirection(Vector3.down), out hit, 0.4f, layerMask))
        {
            string terrainType = hit.collider.gameObject.tag;

            switch (terrainType)
            {
                case "LowSpeed":
                    moveSpeed = basemoveSpeed*0.25f;
                    break;
                case "HighSpeed":
                    moveSpeed = basemoveSpeed*1.66f;
                    break;
                default:
                    moveSpeed = basemoveSpeed;
                    break;
            }
        }
        Vector3 forward = transform.forward * Input.GetAxis("Vertical") * Time.deltaTime;
        Vector3 strafe = transform.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        Vector3 move = forward * moveSpeed + strafe * moveSpeed;
        characterController.Move(move);

        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.GetComponent<Pickups>() != null) //jeœli uderzony przedmiot ma skrypt pickups
        {
            hit.collider.GetComponent<Pickups>().PickedUp(); // wywo³aj t¹ metodê
        }
    }

    public bool GetIsOverlaping() => isOverlaping;
    
        // lub return isOverlaping;

    /// <summary>
    /// Ustaw przechodzenie gracza przez portal
    /// </summary>
    /// <param name="isOverlaping">Czy gracz przechodzi przez portal</param>
    
    public void SetIsOverlaping(bool isOverlaping)
    {
        this.isOverlaping = isOverlaping;
    }
    
}
