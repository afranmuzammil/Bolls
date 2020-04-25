using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject ButtonSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Infinate()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        Time.timeScale = 1f;
    }
    public void Timmer()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
}
