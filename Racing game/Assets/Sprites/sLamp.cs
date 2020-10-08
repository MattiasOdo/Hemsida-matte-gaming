using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sLamp : MonoBehaviour
{
    public float speed = 1;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * speed;
        transform.position += Vector3.down * offset;
    }
}
