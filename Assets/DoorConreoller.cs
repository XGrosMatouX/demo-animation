using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorConreoller : MonoBehaviour
{
    [SerializeReference] Animator door; 
  
   private void OnTriggerEnter(Collider other)
   {
        if(other.CompareTag("Player")){
            print("Open Door!");
            door.SetBool("IsOpen", true);
        }
   }

      private void OnTriggerExit(Collider other)
   {
        if(other.CompareTag("Player")){
            print("Close Door!");
            door.SetBool("IsOpen", false);
        }
   }

}
