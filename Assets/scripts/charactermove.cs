﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cir : MonoBehaviour
{
    public float jump = 10f;
    public float jump2 = 12f;
    int jumpCount = 0;
    public void Jump()
    {
        if (jumpCount == 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
            jumpCount += 1;
        }
        else if (jumpCount == 1)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
            jumpCount += 1;
        }
    }
    private void OncollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
