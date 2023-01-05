using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float  linearVelocity = 15f;
    public float  angularVelocity = 60f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            this.transform.Translate(Vector3.forward * Time.deltaTime * linearVelocity);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            this.transform.Translate(Vector3.forward * Time.deltaTime * -1 * linearVelocity);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * -1 * angularVelocity);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * angularVelocity);
        }

       

    }
   

}
