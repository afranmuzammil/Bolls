﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BaseScript : MonoBehaviour
{
    public int lifes=5;
    public float missBollCount;
    public Text LostBollText;
    public GameManager Manager;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Dibree"))
        {
            missBollCount++;
            lifes--;
            LostBollText.text = lifes.ToString("0");
            // Debug.Log(missBollCount);

        }else if (col.gameObject.CompareTag("Bomb"))
        {
            Destroy(col.gameObject, 0.5f);
        }
    }

    //private void OnTriggerEnter(Collider col)
    //{
    //    if (col.gameObject.CompareTag("Dibree"))
    //    {
    //        missBollCount++;
    //        lifes--;
    //       // LostBOllText.text = lifes.ToString("0");
    //     //   Debug.Log(missBollCount);
       
    //    }
    //}

   
    // Update is called once per frame
    void Update()
    {
        if (missBollCount >= 5f)
        {
            Debug.Log("GameOver");
            Time.timeScale = 0f;//temp most e replced by game over inshallah
            Manager.gameOver();
        }
    }
}
