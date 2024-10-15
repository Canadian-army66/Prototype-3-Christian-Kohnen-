using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 30;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
