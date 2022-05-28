using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    Rigidbody _rb;
    bool _inActive = true;
   
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
     if(_inActive==true)
        _rb.velocity= transform.forward * 10;
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("plane"))
        {
            _inActive = false;
            Destroy(gameObject.GetComponent<Rigidbody>());
            transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(Destroyy());
            
        }
        if (col.gameObject.CompareTag("player1") || col.gameObject.CompareTag("player2"))
        {
            _inActive = false;
            Destroy(gameObject.GetComponent<Rigidbody>());
            transform.GetChild(0).gameObject.SetActive(true);
            StartCoroutine(Destroyy());

        }
    }

    IEnumerator Destroyy()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}
