using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelloader : MonoBehaviour
{
    public Animator Transition;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadEndlessLevel()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void LoadGameOver()
    {
        StartCoroutine(LoadLevel(2));
    }

    IEnumerator LoadLevel(int Level)
    {
        Transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(Level);
    }



}
