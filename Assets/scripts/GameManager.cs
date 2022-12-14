using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    bool _gameHasEnded = false;
    public float restartDelay = 3f;
    public Text text;
    public PlayerMovement pm;
    public Rigidbody rb;
    public int score;
    public int bestScore;
    private const string PlayerTag = "Player";

    public void EndGame()
    {
        if (_gameHasEnded == false)
        {
            _gameHasEnded = true;
            Invoke("Restart", restartDelay);  
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
    public void DisableRotation()
    {
        if (CompareTag(PlayerTag))
        {
            rb.freezeRotation = false;
        }
    }

}
