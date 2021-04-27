using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    

    public void Start()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        GetComponent<Transform>().position= new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        
    }

    public void Reset()
    {
        GetComponent<Transform>().position = new Vector3(0,0,0);
    }


}
