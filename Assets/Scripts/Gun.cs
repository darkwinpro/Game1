using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _ballPrefab;

    [SerializeField] 
    private float _power = 10f;

    [SerializeField]
    private PathRendering _pathRendering;
    
    private Camera mainCamera;
    
    void Start()
    {
        mainCamera = Camera.main;
    }
    
    void Update()
    {
        float _enter;
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        new Plane(-Vector3.up, transform.position).Raycast(ray, out _enter);
        Vector3 _mouseInWorld = ray.GetPoint(_enter);

        Vector3 _speed = (_mouseInWorld - transform.position) * _power;
        transform.rotation = Quaternion.LookRotation(_speed);
        
        _pathRendering.ShowPath(transform.position, _speed);

        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody ball = Instantiate(_ballPrefab, transform.position, Quaternion.identity)
                .GetComponent<Rigidbody>();
            ball.AddForce(_speed, ForceMode.VelocityChange);
            
        }
    }
}
