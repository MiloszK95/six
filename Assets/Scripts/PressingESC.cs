﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressingESC : MonoBehaviour
{
    void Update()
    {
        if(Input. GetKeyDown("escape"))
        {
             Debug.Log("Quittingthegame");
             Application. Quit();
            
        }
    }

}
