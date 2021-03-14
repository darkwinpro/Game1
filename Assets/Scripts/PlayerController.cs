using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;

    private Vector3 _startGamePosition;
    
    private Quaternion _startGameRotion;

    private Vector3 _targetPosition;

    private float laneOffset = 2.5f;

    private float laneChangeSpeed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _startGamePosition = transform.position;
        _startGameRotion = transform.rotation;
        _targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && _targetPosition.x >= -laneOffset)
        {
            _targetPosition = new Vector3(_targetPosition.x - laneOffset, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.D) && _targetPosition.x <= laneOffset)
        {
            _targetPosition = new Vector3(_targetPosition.x + laneOffset, transform.position.y, transform.position.z);
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, laneChangeSpeed * Time.deltaTime);
    }
}
