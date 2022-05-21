using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBlockMovement : MonoBehaviour
{
    float xRotation = 0.01f;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.useGravity = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.transform.position += new Vector3(xRotation, 0, 0);
        }
        if (counter == 1750)
        {
            xRotation *= -1;
            counter = 0;
        }
        counter++;
        
    }
}
