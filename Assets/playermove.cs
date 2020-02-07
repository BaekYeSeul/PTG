using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    private Rigidbody2D cookie;
    public float jump = 10f;
    public float jump2 = 12f;
    int jumpCount = 0;
    private Animator playerAni;
    public CircleCollider2D playerjump;
    public CircleCollider2D playerslide;
    private void Start()
    {
        cookie = GetComponent<Rigidbody2D>();
        playerAni = GetComponent<Animator>();
        
    }
    public void Jump()
    {
        if (jumpCount == 0)
        {
               
            playerjump.enabled = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
            jumpCount += 1;
        }
        else if (jumpCount == 1)
        {
            playerjump.enabled = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
            jumpCount += 1;
        }
    }
 /* public void slide()
    {
        //cookie= gameObject.GetComponent<Rigidbody2D>();
       // cookie = playerAni.SetBool("S", true);
       // playerjump.enabled = false;
       // playerAni.SetTrigger("S");
        playerAni.SetBool("slide", true); 
        playerslide.enabled = true;


    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.CompareTo("ground") == 0)
        {
            jumpCount = 0;
        }
       // playerAni.SetBool("slide", true);
    }
  
}
