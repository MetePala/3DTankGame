using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _mermi1, _mermi2;
    [SerializeField] GameObject _spawn1, _spawn2;
    [SerializeField] GameObject _player1, _player2;
    float timer1,timer2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        timer1 += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (Input.GetKey(KeyCode.L))
        {
           if(timer1>=0.4f)
            {
                Instantiate(_mermi1, _spawn1.transform.position, _player1.transform.rotation);
                timer1 = 0;
            }
           
        }
            


        if (Input.GetKey(KeyCode.Space))
        {
            if (timer2 >= 0.4f)
            {
                Instantiate(_mermi2, _spawn2.transform.position, _player2.transform.rotation);
                timer2 = 0;
            }
        }
           
    }
}
