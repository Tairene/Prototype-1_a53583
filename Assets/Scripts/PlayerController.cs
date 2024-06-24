using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//private Variables

   [SerializeField]  private float  speed = 20f;
   private  const  float  turnSpeed = 45f;
   private float  horizontalInput;
   private float  verticalInput;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void Update()
    {
        //this is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward *Time.deltaTime *  speed  * verticalInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime *  turnSpeed  * horizontalInput);
        
    }
}
