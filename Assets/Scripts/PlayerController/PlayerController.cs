using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Config")]
    [SerializeField] Transform _playerTransform, _playerTransform2;
    [SerializeField] Rigidbody _playerrigidbody, _playerrigidbody2;

    [SerializeField] float _speed;
    bool _isRotate,_isRotate2;
    MoveController _movecontroller;
    void Start()
    {
        _movecontroller = new MoveController();
    }

    void Update()
    {
      if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            _isRotate2 = true;
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            _isRotate2 = false;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            _isRotate = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            _isRotate = false;
        }


    }
    private void FixedUpdate()
    {
        Walk1();
        Walk2();

       if (_isRotate)
        Rotatee();

        if (_isRotate2)
            Rotatee2();


    }
    void Walk1()
    {
        _movecontroller.Horizontal(_playerTransform, _speed);
        _movecontroller.Vertical(_playerTransform, _speed);
    }
    void Walk2()
    {
        _movecontroller.Horizontal2(_playerTransform2, _speed);
        _movecontroller.Vertical2(_playerTransform2, _speed);
    }
    void Rotatee()
    {
       
        _movecontroller.Rotate(_playerTransform,300);
    }
    void Rotatee2()
    {

       _movecontroller.Rotate2(_playerTransform2, 300);
    }
}
