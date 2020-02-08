using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{//캐릭터 움직이는것
    private Rigidbody2D cookie;
    public float jump = 10f;
    public float jump2 = 12f;
    int jumpCount = 0;
    private Animator playerAni;
    bool isJumping=false;
  //  public CircleCollider2D playerjump;
   // public CircleCollider2D playerslide;
   /* private void Start()
    {
        cookie = GetComponent<Rigidbody2D>();
        playerAni = GetComponent<Animator>();
        
    }
 */ 
  /*  void Jump()
    {
        if (!isJumping)
            return;

        rdb2.velocity = Vector3.zero;

        Vector3 jumpVelocity = new Vector3(0, jumpPower, 0);
        rdb2.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJumping = false;
    }*/
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
  public void slide()
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
