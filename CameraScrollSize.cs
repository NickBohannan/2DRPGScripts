using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScrollSize : MonoBehaviour
{
    public int sizeMin, sizeMax;
    public Camera topCamera;
    // Start is called before the first frame update
    void Start()
    {
        topCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0 && topCamera.orthographicSize > sizeMin)
        {
            topCamera.orthographicSize -= 1;
        } else if (Input.mouseScrollDelta.y < 0 && topCamera.orthographicSize < sizeMax)
        {
            topCamera.orthographicSize += 1;
        } 
    }
}
