using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private KeyCode pauseKey = KeyCode.P;

    private bool gamePaused = false;
    private bool gameEnded = false;
    private bool win = false;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Istnieje ju¿ 1 obiekt typu GameManager");
            Destroy(gameObject); //Odwo³anie do siebie
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            CheckPause();
        }
    }

    private void CheckPause()
    {
        if (!gamePaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
        gamePaused = false;
        Debug.Log("Gra Wznowiona");
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        gamePaused = true;
        Debug.Log("Gra Zatrzymana");
    }

    public void EndGame()
    {
        gameEnded = true;
        if (win)
        {
            Debug.Log("Wygra³eœ");
        }
        else
        {
            Debug.Log("Przegra³eœ");
        }
    }
}
