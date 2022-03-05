using UnityEngine;

public class Friend : MonoBehaviour
{
   public Flashlight latarenka;
   public GameObject lightSource;

   


    
     void OnTriggerEnter(Collider other)
    {
       if(latarenka.isOn == false)
       {
          Debug.Log("Pepe");
       }
       else
       {
           Debug.Log("Pan dziobak");
           lightSource.SetActive(false);
       }
       

   
       
        
    }
}
