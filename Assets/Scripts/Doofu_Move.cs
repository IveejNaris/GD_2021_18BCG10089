using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doofu_Move : MonoBehaviour
{

    public float movementSpeed = 0.8f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
 
         if(Input.GetKey(KeyCode.W)) {
             transform.position += Vector3.forward * movementSpeed;
         }
         else if(Input.GetKey(KeyCode.S)) {
             rigidbody.position += Vector3.back *  movementSpeed;
         }
         else if(Input.GetKey(KeyCode.A)) {
             rigidbody.position += Vector3.left *  movementSpeed;
         }
         else if(Input.GetKey(KeyCode.D)) {
             rigidbody.position += Vector3.right *  movementSpeed;
         }
    }
}
