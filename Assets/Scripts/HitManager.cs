using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody _rdPlayer;

    [SerializeField] 
    private Collider _playerCollider;

    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Cubes")
        {
            Debug.Log("Contact!!");
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
