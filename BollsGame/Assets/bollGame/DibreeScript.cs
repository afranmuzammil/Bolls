using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibreeScript : MonoBehaviour
{
    public GameObject BlastEffect;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Base"))
        {
            
            GameObject G = Instantiate(BlastEffect, transform.position, Quaternion.identity);
            Destroy(G, 2);
            Destroy(gameObject, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
