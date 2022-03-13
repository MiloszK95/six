using UnityEngine;

public class Another : MonoBehaviour
{
   


   public GameObject grandma;


    
     void OnTriggerEnter(Collider other)
    {
      
       grandma.SetActive(true);
    }

}
