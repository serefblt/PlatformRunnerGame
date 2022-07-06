using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintFinishWall : MonoBehaviour
{
    [SerializeField] GameObject paints;
    [SerializeField] float paintSize = 0.1f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray , out hit) && hit.transform.CompareTag("Wall"))
            {
                var go = Instantiate(paints, hit.point + Vector3.up * 0.1f, Quaternion.identity, transform);
                go.transform.localScale = Vector3.one * paintSize;
            }
        }
    }
}
