using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public GameObject referance;
    public Vector3 cameraOffset;

    void Start()
    {
        cameraOffset = transform.position - referance.transform.position;
    }

    void LateUpdate()
    {
        transform.position = referance.transform.position + cameraOffset;
    }
}
