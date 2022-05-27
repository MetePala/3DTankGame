using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    Rigidbody _rb;
  
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
     
        _rb.velocity= transform.forward * 15;
    }
}
