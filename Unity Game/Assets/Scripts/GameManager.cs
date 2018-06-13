using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    bool gameHasEnded = false;

    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;

    public float restartDelay = 0.5f;

    public GameObject completeLevelUI;
    public GameObject myplayer;
    public GameObject[] obstacles;
    public GameObject[] boosts;

    float nextSpawn = 0f;
    float spawnRate = 1f;
    int spawnObstacle;
    float spawnplace;
    float spawnplace2;


    Vector3 pos;
    Vector3 pos1;

    void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        boosts = GameObject.FindGameObjectsWithTag("BoostUps");
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            spawnObstacle = Random.Range(0, obstacles.Length);
            spawnplace = Random.Range(-9, 10);
            spawnplace2 = Random.Range(-9, 10);

            pos = new Vector3(spawnplace, myplayer.transform.position.y, myplayer.transform.position.z+20f);
            pos1 = new Vector3(spawnplace2, 0.51f, myplayer.transform.position.z + 30f);

            Instantiate(obstacles[spawnObstacle], pos, Quaternion.identity);
            Instantiate(boosts[0], pos1, Quaternion.identity);

            nextSpawn = Time.time + spawnRate;
        }
    }


    public void CompleteLevel()
    {
        scoreText2.text = scoreText1.text;
        scoreText4.text = scoreText3.text;
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            scoreText2.text = scoreText1.text;
            scoreText4.text = scoreText3.text;
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {       
        completeLevelUI.SetActive(true);
    }

}
