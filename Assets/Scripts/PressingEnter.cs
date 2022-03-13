using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressingEnter : MonoBehaviour
{
    void Update()
    {
        if(Input. GetKeyDown("space"))
        {
            
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }

}
