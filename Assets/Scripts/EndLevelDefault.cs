﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelDefault : MonoBehaviour
{
   
    public string nextLevelDefault;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (FadeInOutDefault.sceneStartingDefault == false)
        {
            FadeInOutDefault.sceneEndDefault = true;
            
        }



    }
    

}
