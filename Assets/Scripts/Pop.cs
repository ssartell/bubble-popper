using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name.StartsWith("Bubble"))
                {
                    var newPosition = hit.transform.position;
                    newPosition.y = -5f;
                    hit.transform.position = newPosition;
                }
            }
        }
        
    }
}
