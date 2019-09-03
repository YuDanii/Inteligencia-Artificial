using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    
    Vector3 velocity = new Vector3(-2,3,0);
    Vector3 aceleracion = new Vector3(0,-9.8f,0);

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        velocity += aceleracion * Time.deltaTime;

        if(transform.position.y < -5){
            Debug.Log("Llego al piso");
            velocity.y *= -1;

        }
        if(transform.position.x < -10){
            Debug.Log("Llego al muro");
            velocity.x *= -1;

        }
        if(transform.position.x > 10){
            Debug.Log("Llego al muro");
            velocity.x *= -1;

        }
    }
}
