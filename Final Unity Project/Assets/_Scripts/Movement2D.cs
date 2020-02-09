using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 10.0f;

    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        transform.position += movement * Time.deltaTime * speed;

    }
}