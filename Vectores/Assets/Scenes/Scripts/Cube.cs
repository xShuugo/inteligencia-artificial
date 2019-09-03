using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{    
    public Vector2 velocity = Vector2.zero;
    public Vector2 acceleration = Vector2.zero;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position += (Vector3)velocity * Time.deltaTime;
        velocity += acceleration * Time.deltaTime;

        if(transform.position.y<-7){
            velocity.y *= -1;
            Debug.Log("Grounded");
        }

        if(transform.position.x<-8.5){
            velocity.x *= -1;
        } else if (transform.position.x>8.5)
            velocity.x *= -1;
    }
}
