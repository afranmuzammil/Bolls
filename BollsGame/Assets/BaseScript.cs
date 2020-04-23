using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    public float missBollCount;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Dibree"))
        {
            missBollCount++;
            Debug.Log(missBollCount);
           

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
