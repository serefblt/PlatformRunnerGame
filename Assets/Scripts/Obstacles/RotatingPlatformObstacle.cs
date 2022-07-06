using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(transform);

        }
    }
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.transform.eulerAngles = new Vector3(0, 0, 0);
            col.collider.transform.SetParent(null);

        }
    }
}
