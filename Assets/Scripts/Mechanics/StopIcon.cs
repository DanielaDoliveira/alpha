using System;
using UnityEngine;

public class StopIcon : MonoBehaviour
{
     public PlayerMove player;


     private void Start()
     {
         if (player == null)
         {
             try
             {
                 player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
                 
             }
             catch
             {
                 throw new Exception("PlayerInputController can't be found ");
             }
           
         }
       
     }

     private void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("Player"))
         {
            player.StopMove();
           
         }
     }
}
