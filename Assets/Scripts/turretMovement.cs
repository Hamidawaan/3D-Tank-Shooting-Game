using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretMovement : MonoBehaviour
{
    public float angularVelocity = 60;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * -1 * angularVelocity);
        }
        if (Input.GetKey(KeyCode.D))
        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * angularVelocity);
        }
    }
}
