using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RivalController : MonoBehaviour
{
    [SerializeField] GameObject _finishLine, _rival;
    [SerializeField] Rigidbody _playerRb;
    [SerializeField] float _impactSpeed;
   public NavMeshAgent _navMeshAgent;
    [SerializeField] Animator _animator;
    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _navMeshAgent.SetDestination(_finishLine.transform.position);
            _animator.SetBool("__isRunGirl", true);
        }
       
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rotating"))
        {
            _playerRb.velocity = -Vector3.forward * _impactSpeed * Time.deltaTime;
        
        }
        if (other.gameObject.CompareTag("HalfDonut"))
        {
            _playerRb.velocity = Vector3.left * _impactSpeed * Time.deltaTime;
            
        }
        if (other.gameObject.CompareTag("FinishLine"))
        {
            _rival.SetActive(false);

        }
    }
}
