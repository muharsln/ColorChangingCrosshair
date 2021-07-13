using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _xMove, _zMove;

    private Vector3 _xAngle, _zAngle;
    private Vector3 _moveAngle;
    private void Update()
    {
        _xMove = Input.GetAxis("Horizontal");
        _zMove = Input.GetAxis("Vertical");

        _xAngle = transform.right * _xMove;
        _zAngle = transform.forward * _zMove;

        _moveAngle = (_xAngle + _zAngle) * _speed;
    }

    private void FixedUpdate()
    {
        transform.position += _moveAngle * Time.fixedDeltaTime;
    }
}
