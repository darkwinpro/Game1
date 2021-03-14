using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 _targetPosition;

    private float laneOffset = 2.5f;

    private float laneChangeSpeed = 3;
    
    void Start()
    {;
        _targetPosition = transform.position;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && _targetPosition.x > -laneOffset)
        {
            _targetPosition = new Vector3(_targetPosition.x - laneOffset, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D) && _targetPosition.x < laneOffset)
        {
            _targetPosition = new Vector3(_targetPosition.x + laneOffset, transform.position.y, transform.position.z);
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, laneChangeSpeed * Time.deltaTime);
    }
}
