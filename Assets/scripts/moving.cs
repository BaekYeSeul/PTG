using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    int jumpCount = 0;
    public float jump = 10f;
    public float jump2 = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Jump()
    {
        if (jumpCount == 0)
        {

            //   playerjump.enabled = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
            jumpCount += 1;
        }
        else if (jumpCount == 1)
        {
            //   playerjump.enabled = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
            jumpCount += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("ground") == 0)
        {
            jumpCount = 0;
        }

    }
}
