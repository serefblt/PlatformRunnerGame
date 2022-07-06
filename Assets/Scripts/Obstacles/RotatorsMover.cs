using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorsMover : MonoBehaviour
{
    [SerializeField] [Range(20f, 300f)] float _rotatorTurnSpeed;
    [Header("Rotate")] [SerializeField] private RotateEnum rotateXY;
    private Vector3 rotationPos;
    void Start()
    {
        RotatorMovers();
    }

    // Update is called once per frame
    void Update()
    {
        Rotator();
    }


    public void Rotator()
    {
        //transform.Rotate(new Vector3(0, _rotatorTurnSpeed * Time.deltaTime,0));
        transform.Rotate(rotationPos, Time.deltaTime * _rotatorTurnSpeed);
    }


   private void RotatorMovers()
    {
        switch (rotateXY)
        {
            case RotateEnum.X:
                rotationPos = Vector3.right;
                break;
            case RotateEnum.Y:
                rotationPos = Vector3.up;
                break;
            case RotateEnum.Z:
                rotationPos = Vector3.forward;    
                break;
        }
    }

    internal enum RotateEnum
    {
        X,
        Y,
        Z
    }
}
