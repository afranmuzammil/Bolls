using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeanceMager : MonoBehaviour
{
    public Animator transitionAnim;
    public string scenceName;

    private void Update()
    {
        StartCoroutine(LoadScence());
    }


    IEnumerator LoadScence()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scenceName);
    }
}
