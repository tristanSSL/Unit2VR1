using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    Transform Camera;
    Vector2 camUp;
    void Start()
    {
        Camera = gameObject.transform;
        Camera.position = new Vector3(0,0,-10);
        camUp = new Vector2(0,.8f);
    }

    void Update()
    {
        if (Camera.position.y < 21)
        {
            Camera.Translate(camUp * Time.deltaTime);
        }
        else
        {
            Camera.position = new Vector3(0,21,-10);
        }
    }
}
