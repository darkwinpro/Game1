using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] 
    private Gun _gun;

    [SerializeField]
    private  PlayerController _playerController;

    private void StartGame()
    {
        _playerController.enabled = true;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
