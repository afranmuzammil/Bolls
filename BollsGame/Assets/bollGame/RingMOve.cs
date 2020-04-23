using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMOve : MonoBehaviour
{
    [Range(0.2f, 10f)]
    public float Speed = 10.0f;
   
    public GameObject SparkEffect;
    public GameObject BlastEffect;
    public Transform myTransfrom;
    
    float dirX;
    public Rigidbody rb;
   

    // Update is called once per frame
    void Update()
    {

        dirX = Input.acceleration.x * Speed;


        if (Input.GetKey(KeyCode.A)){

            transform.Translate(Vector3.left*Speed*Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right*Speed*Time.fixedDeltaTime);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x + dirX, 0);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Dibree"))
        {
            Destroy(col.gameObject);
            GameObject B = Instantiate(SparkEffect, myTransfrom.position, Quaternion.identity);
            Destroy(B, 0.8f);

        }
        else if (col.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
            GameObject G = Instantiate(BlastEffect, myTransfrom.position, Quaternion.identity);
            Destroy(G, 0.8f);
            Debug.Log("Bomb went off");
            Time.timeScale = 0f;//temp most e replced by game over inshallah
            Debug.Log("GameOver");

        }

    }
}
    