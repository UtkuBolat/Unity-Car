using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botController: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private int speed = 7;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
