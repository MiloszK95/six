using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutOff : MonoBehaviour
{
   
   public GameObject theWall;
   public GameObject sound;


    
     void OnTriggerEnter(Collider other)
    {
           
       
      
       theWall.SetActive(true);
       sound.SetActive(false);

    }
}
