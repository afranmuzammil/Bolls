using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingMOve : MonoBehaviour
{
   // [Range(0.2f, 10f)]
    public  float Speed = 2.0f;
   
    public GameObject SparkEffect;
    public GameObject BlastEffect;
    public Transform myTransfrom;
    public Rigidbody rb;
    public GameObject sparkSound;
    public GameManager Manager;
   // public GameObject WaterMoveSound;
  /*  public*/ int ScorePoints;

    float dirX;
    public Text scoreText;

   


    // Update is called once per frame
    void Update()
    {

        dirX = Input.acceleration.x * Speed;
        //  Instantiate(WaterMoveSound, transform.position, Quaternion.identity);
         
        
        if (Input.GetKey(KeyCode.A)){

            transform.Translate(Vector3.left*Speed*Time.fixedDeltaTime);
           // Instantiate(WaterMoveSound, transform.position, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right*Speed*Time.fixedDeltaTime);
            //Instantiate(WaterMoveSound, transform.position, Quaternion.identity);
        }
    }
    void FixedUpdate()
    {
        //rb.velocity = new Vector2(rb.velocity.x + dirX, 0);
        rb.velocity = new Vector2( dirX, 0f);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Dibree"))
        {
            GameObject ss = Instantiate(sparkSound, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            GameObject B = Instantiate(SparkEffect, myTransfrom.position, Quaternion.identity);
            Destroy(B, 0.8f);
            Destroy(ss, 0.8f);
            ScorePoints++;
            Debug.Log(ScorePoints);
            scoreText.text = ScorePoints.ToString("0");

        }
        else if (col.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
            GameObject G = Instantiate(BlastEffect, myTransfrom.position, Quaternion.identity);
            Destroy(G, 0.8f);
            Debug.Log("Bomb went off");
           Time.timeScale = 0f;//temp most e replced by game over inshallah
            Manager.gameOver();
            Debug.Log("GameOver");

        }

    }
}
    