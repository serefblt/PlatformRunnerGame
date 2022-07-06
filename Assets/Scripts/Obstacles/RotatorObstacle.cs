using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorObstacle : MonoBehaviour
{
    [SerializeField] Rigidbody _playerRb;
    [SerializeField] float _speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _playerRb.velocity = -Vector3.forward * _speed * Time.deltaTime;
          
        }
    }
}
