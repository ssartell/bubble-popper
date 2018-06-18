using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    private Vector3 _origin = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (this._origin == Vector3.zero)
        {
            this._origin = this.transform.position;
        }

        var newPosition = this.transform.position;
        newPosition.y += 0.1f * Time.deltaTime;

        if (newPosition.y > -this._origin.y)
        {
            newPosition = this._origin;
        }

        this.transform.position = newPosition;
    }
}
