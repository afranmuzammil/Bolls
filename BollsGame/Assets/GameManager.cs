using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool pauseTheGame = false;
    public GameObject pauseManuUi;
    public GameObject pasueactive;
    public Slider SpeedSlider;
    public Button settings;
    public GameObject ButtonSound;
    public GameObject GameOverUI;
     
    // Start is called before the first frame update
    void Start()
    {
      
    }
    void Update()
    {
        
       
    }

    public void gameOver()
    {
        GameOverUI.SetActive(true);
    }

    public void setting()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        pauseManuUi.SetActive(true);
        Time.timeScale = 0f;
        pauseTheGame = true;
        Destroy(B, 0.5f);
    }
    public void SpeedContorller()
    {   
        //float speedChager = GetComponent<RingMOve>().Speed;
        //SpeedSlider.maxValue = speedChager;
    }
     
    public void Resume()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        pauseManuUi.SetActive(false);
        Time.timeScale = 1f;
        pauseTheGame = false;
        Destroy(B, 0.5f);
        GameOverUI.SetActive(false);
        // pasueactive.SetActive(false);
        // pauseManuUi.SetActive(true);
    }

    public void Repalay()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        Destroy(B, 0.5f);
        GameOverUI.SetActive(false);
    }
    
    public void Quit()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        Application.Quit();
        Debug.Log("application Quit");
        Destroy(B, 0.5f);
        GameOverUI.SetActive(false);
    }
    public void MainManu()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        SceneManager.LoadScene("MainMenu");
        Destroy(B, 0.5f);
        GameOverUI.SetActive(false);
        Debug.Log("application main manu");
    }
}
