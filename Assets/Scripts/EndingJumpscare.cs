using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingJumpscare : MonoBehaviour
{


   public GameObject spooky;
   public GameObject granpa;


    
     void OnTriggerEnter(Collider other)
    {

       
       spooky.SetActive(true);
       granpa.SetActive(true);
    }
}
