using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    [SerializeField] 
    private GameObject _brickPrefab;

    [SerializeField]
    private Transform brickSpawn;

    [SerializeField] 
    private int _countLayer = 5;
    
    private float _cooldownSpawn = 0.5f;
    private float _nextTimeSpawn;
    
    private void SpawnCubes()
    {
        var positionSpawn = new Vector3(brickSpawn.position.x, brickSpawn.position.y, brickSpawn.position.z);
        Instantiate(_brickPrefab, positionSpawn, Quaternion.identity);
    }
   
    void Update()
    {
        if (_countLayer > 0 && Time.time >= _nextTimeSpawn)
        {
            _countLayer -= 1;
            _nextTimeSpawn = Time.time + _cooldownSpawn;
            SpawnCubes();
        }
    }
}
