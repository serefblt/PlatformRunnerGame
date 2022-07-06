using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacle : MonoBehaviour
{
    
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
            col.transform.position = new Vector3(-0.56F, 0.8155599F, -9);
        }
        if (col.gameObject.CompareTag("Girl"))
        {
            col.transform.position = new Vector3(1.17999995F, 0.815559924F, -10.4200001F);

           
        }
    }
}
