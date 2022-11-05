using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = input.getAxis("Horizontal");
        float vertical = input.getAxis("Vertical");

        transform.Translate(new Vector3(hor, 0.0f, vertical));
    }
}
