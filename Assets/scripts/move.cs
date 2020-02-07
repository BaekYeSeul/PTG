using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    Vector3 position;
    public float speed=1;
    private Rigidbody2D rd2D;
    public float jumpforce;
    // Start is called before the first frame update
    void Start()
    {
        rd2D = GetComponent<Rigidbody2D>();
        jumpforce = 200;
        position = transform.position;
    }
    public void JumpByGround()
    {
        rd2D.velocity = new Vector2(rd2D.velocity.x, 0);
        rd2D.AddForce(new Vector2(0, jumpforce));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= speed * Time.deltaTime;
        }
        transform.position = position;


    }
}
/*public class move : MonoBehaviour
{
    Vector3 position;
    Rigidbody2D rigid;
    public float speed = 1;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    float bounce = 5f;
    void OnCollisionEnter2D(Collision2D other)
    {
        GetComponent<Boxcollider2D>().isTrigger = true;
        rigid.velocity = Vector2.zero;
        Vector2 Jump = new Vector2(0, bounce);
        if (other.gameObject.tag == "Block")
        {
            rigid.AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<Boxcollider2D>().isTrigger = true;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
   /* void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= speed * Time.deltaTime;
        }
        transform.position = position;

    
    }
    
}*/
/*
public class move : MonoBehaviour
{
  
   
    private Rigidbody2D cookie;
    public PolygonCollider2D cookieIdle;
    public PolygonCollider2D cookieSlide;
    Vector3 position;
    private const float POWER = 15.0f;
    private bool jump = false;
    private bool slide = false;
    private int jumpCount = 0;
    
    public float speed = 1;
    private void Start()
    {
        cookie = GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()
    {
        Mov();
        if (jumpCount > 0 && jump)
        {
            cookie.velocity = (Vector2.up * POWER);
            
            jump = false;
        }
    }
    private void Mov()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - 3f * Time.deltaTime, transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + 3f * Time.deltaTime, transform.position.y);
        }
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            slide = true;
            cookieSlide.enabled = true;
            cookieIdle.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
           
            slide = false;
            cookieIdle.enabled = true;
            cookieSlide.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount < 2 && !slide)
        {
            jumpCount++;
            jump = true;
           
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
           
        }
    }

    
   

   
}
*/