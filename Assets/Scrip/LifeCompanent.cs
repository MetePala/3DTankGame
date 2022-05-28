using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCompanent : MonoBehaviour
{
    [SerializeField] float _currentTime;
    [SerializeField] float _destroyTime=3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;

        if (_destroyTime <= _currentTime)
        {
            Destroy(this.gameObject);
        }
           
    }
}
