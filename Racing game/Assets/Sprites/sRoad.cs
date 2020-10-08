using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class sRoad : MonoBehaviour
{
    public float speed = 1;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * speed;

        
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}
