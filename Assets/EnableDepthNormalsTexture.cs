using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDepthNormalsTexture : MonoBehaviour
{
    public Camera Camera;

    void Start()
    {
        Camera.depthTextureMode |= DepthTextureMode.DepthNormals;
    }
}
