using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class StandardMove : MonoBehaviour
{

    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, speed * Time.deltaTime, 0);

    }
}
