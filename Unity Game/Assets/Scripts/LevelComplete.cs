using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public void retry () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

    public void return_to_main_menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

}
