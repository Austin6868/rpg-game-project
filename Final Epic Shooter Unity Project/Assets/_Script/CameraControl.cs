using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        var vcam = GetComponent<CinemachineVirtualCamera>();
        vcam.Follow = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
