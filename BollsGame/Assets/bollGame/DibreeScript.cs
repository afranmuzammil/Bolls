using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DibreeScript : MonoBehaviour
{
    public GameObject SmokeEffect;
    public GameObject waterSplash;

    

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Base"))
        { 
            GameObject S = Instantiate(SmokeEffect, transform.position, Quaternion.identity);
            GameObject w = Instantiate(waterSplash, transform.position, Quaternion.identity);
            Destroy(w, 1f);
            Destroy(S, 0.8f);
            Destroy(gameObject, 0.5f);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
