using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
   public float speed = -2f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0 ,0);
        if(transform.position.x <= -9.5f)
                {
                    Destroy(gameObject);
                }

    }
}
