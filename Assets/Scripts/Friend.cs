using UnityEngine;

public class Friend : MonoBehaviour
{
   public Flashlight latarenka;
   public GameObject lightSource;

   public GameObject spooky;
   public GameObject grandma;


    
     void OnTriggerEnter(Collider other)
    {
       if(latarenka.isOn == false)
       {
          Debug.Log("Boo!");
          
       }
       else
       {
           Debug.Log("Boooooo!");
           lightSource.SetActive(false);
           
       }
       spooky.SetActive(true);
       grandma.SetActive(false);

   
       
        
    }
}
