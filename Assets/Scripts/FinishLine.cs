using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _cam1, _cam2 , _wall;
    [SerializeField] PlayerController _playerController;
    [SerializeField] InputManager _inputManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _cam1.SetActive(false);
            _cam2.SetActive(true);
            _wall.SetActive(true);
            other.transform.position = new Vector3(-0.56f, 0.8155599f, 90.6f);
            _animator.SetBool("__isPaint", true);
            _playerController.enabled = false;
            _inputManager.enabled = false;

        }
    }
}
