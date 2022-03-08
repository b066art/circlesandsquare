using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameMng;

    public GameObject squarePrefab;
    public GameObject circleColliderPrefab;
    public GameObject gameOverMenu;    

    private Vector2 playerPos;

    void Start()
    {
        Time.timeScale = 1f;
        GameObject Square = Instantiate(squarePrefab);
        playerPos = GameObject.FindGameObjectWithTag("Square").transform.position;
        SpawnObjects();
    }

    void Update()
    {
        if (Input.GetKey("escape")) {
            Application.Quit();
        }

        if (Score.scoreTxt.playerScore == 5) {
            RestartButton();
        }
    }

    void SpawnObjects()
    {
        for (int i = 0; i < 5; i++) {
            GameObject CircleCollider = Instantiate(circleColliderPrefab);    
        }
    }

        void RestartButton()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }

}
