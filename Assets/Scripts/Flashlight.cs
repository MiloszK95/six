using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject lightSource;
    public bool isOn = true;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey("f"))
         {
             if (isOn == false && failSafe == false)
                 {
                     failSafe = true;
                     Debug.Log("bonk");
                     lightSource.SetActive(true);
                     isOn = true;
                     StartCoroutine(FailSafe());
                 }
            
             if (isOn == true && failSafe == false)
             {
                 failSafe = true;
                 lightSource.SetActive(false);
                 isOn = false;
                 StartCoroutine(FailSafe());
             }
         }

        IEnumerator FailSafe()
        {
            
            yield return new WaitForSeconds(0.25f);
            failSafe = false;
        } 
        
    }
}
