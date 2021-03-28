using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    
    [SerializeField]
    private  GameObject _playerController;
    
    public void StartGame()
    {
        _playerController.SetActive(true);
    }

    public void GameOver()
    {
        
    }
}
