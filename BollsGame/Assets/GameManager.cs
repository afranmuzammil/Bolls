using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Slider SpeedSlider;
     
    // Start is called before the first frame update
    void Start()
    {
      
    }
    void Update()
    {
       
    }
    public void SpeedContorller()
    {   
        float speedChager = GetComponent<RingMOve>().Speed;
        SpeedSlider.maxValue = speedChager;
    }
 
    public void Replay()
    {

    }

    public void Pause()
    {

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("application Quit");
    }
    public void MainManu()
    {

    }
}
