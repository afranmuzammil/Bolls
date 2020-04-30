using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject ButtonSound;
    //public Animator transitionAnim;
    //public GameObject animHOlder;
   // public string scenceName;


    // Start is called before the first frame update
    void Start()
    {
       // animHOlder.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Infinate()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
       // StartCoroutine(LoadScence());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
        Time.timeScale = 1f;
       

    }
    public void Timmer()
    {
        GameObject B = Instantiate(ButtonSound, transform.position, Quaternion.identity);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       // StartCoroutine(LoadScence2());
        Time.timeScale = 1f;
        //animHOlder.SetActive(false);
    }

    //IEnumerator LoadScence()
    //{
    //    transitionAnim.SetTrigger("end");
    //    yield return new WaitForSeconds(1.5f);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    //    //SceneManager.LoadScene(scenceName);
       

    //}

    //IEnumerator LoadScence2()
    //{
    //    transitionAnim.SetTrigger("end");
    //    yield return new WaitForSeconds(1.5f);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //    //SceneManager.LoadScene(scenceName);
       
    //}
}
