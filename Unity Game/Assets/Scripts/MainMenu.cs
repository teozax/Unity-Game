using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayFunc()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Stop("FarCry");
        FindObjectOfType<AudioManager>().Play("Drama");
    }

    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("Drama");
        FindObjectOfType<AudioManager>().Play("FarCry");
    }

    public void QuitFunc()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
