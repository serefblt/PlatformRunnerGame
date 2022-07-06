using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform _playerTransform;
    [SerializeField] Animator _playerAnim;
    [SerializeField] float _playerSpeed, _playerXSpeed, _smooth , _amount;
    bool _running;
    private void FixedUpdate()
    {

        if (_running)
            _playerTransform.Translate(_playerTransform.forward * Time.deltaTime * _playerSpeed);


    }



    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _running = true;
            _playerAnim.SetBool("__isRun", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            _running = false;
            _playerAnim.SetBool("__isRun", false);
        }
    }

    public void Hareket(float x)
    {
        _amount = x * _playerXSpeed * Time.deltaTime;

        Vector3 target = new Vector3(_amount, _playerTransform.position.y, _playerTransform.position.z);
        _playerTransform.position = Vector3.Lerp(_playerTransform.position, target, _smooth);

    }
}
