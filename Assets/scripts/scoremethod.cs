using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremethod : MonoBehaviour
{
    public GameObject coin;
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  /*  void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
        scoreText.text = score.ToString();
    }*/
}
