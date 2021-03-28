using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MainManager : MonoBehaviour
{
    
    [SerializeField]
    private  GameObject _playerController;

    [SerializeField]
    private GameObject _gameOverScreen;

    public void StartGame()
    {
        _playerController.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        _gameOverScreen.SetActive(true);
    }
}
