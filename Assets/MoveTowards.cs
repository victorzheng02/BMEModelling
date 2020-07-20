using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform Coronavirus;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Coronavirus.transform.position, speed * Time.deltaTime);
    }
}
