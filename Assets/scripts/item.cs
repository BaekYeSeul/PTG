﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public float mapSpeed = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "player")
        {
               Destroy(gameObject);
         }
        
    }
    void Update()
    {
        transform.Translate(-mapSpeed * Time.deltaTime, 0, 0);
    }

}
