using UnityEngine;

public class PickingUpBimber : MonoBehaviour
{
   

   public GameObject bimber;
   public GameObject theWall;
   public GameObject pickUpSound;
   public GameObject turnOffSomeScripts;
   public GameObject turnOnSomeScripts;
   public GameObject turnOnLastJumpscare;


    
     void OnTriggerEnter(Collider other)
    {
           
       
       bimber.SetActive(false);
       theWall.SetActive(false);
       pickUpSound.SetActive(true);
       turnOffSomeScripts.SetActive(false);
       turnOnSomeScripts.SetActive(true);
       turnOnLastJumpscare.SetActive(true);


    }


}