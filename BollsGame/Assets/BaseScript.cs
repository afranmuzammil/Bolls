﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BaseScript : MonoBehaviour
{
    public int lifes=3;
    public float missBollCount;
    /*public*/ Text LostBOllText;

  
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Dibree"))
        {
            missBollCount++;
            lifes--;
           // LostBOllText.text = lifes.ToString("0");
         //   Debug.Log(missBollCount);
       
        }
    }

   
    // Update is called once per frame
    void Update()
    {
        if (missBollCount >= 3f)
        {
            Debug.Log("GameOver");
            Time.timeScale = 0f;//temp most e replced by game over inshallah
        }
    }
}
