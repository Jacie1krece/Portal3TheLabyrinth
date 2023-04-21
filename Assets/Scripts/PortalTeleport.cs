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
        //playerController = ;
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" )
        {
           // ustaw przechodzenie gracza na true;
           
            Teleportation();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
           // ustaw przechodzenie gracza na fa�sz;
        }
    }

    private void Teleportation()
    {
        //Po co to?

        float dot = Vector3.Dot(transform.forward, player.forward);
        if (dot < 0 ) { return; }
     

        //je�eli gracz przechodzi przez portal to:
        //{
        //    wy��cz CharacterControler (inaczej nie mo�emy go przenosi�)
        //    ustaw gracza w miejscu drugiego portalu
        //    w��cz CharacterController
        //}
    }

    public Transform GetReciever() => reciever;




}
