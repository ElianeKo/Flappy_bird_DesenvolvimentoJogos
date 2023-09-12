using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    public GameObject pipePrefab;
    public float time = 2f;
    public float minY = -2f, maxY= 2f;
    

    void Start()
    {
        
        InvokeRepeating(nameof(Spawn), time, time);
    }

    
    void Update()
    {
       
    }

    void Spawn()
    {
        GameObject newPipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);  
        newPipes.transform.position += new Vector3(0, Random.Range(minY, maxY));
    }
}
