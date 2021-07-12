using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Range(0.1f, 10f)]
    [SerializeField] private float _sensitive;
    private Vector2 _rot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        CharacterRotation();
    }

    private void CharacterRotation()
    {
        _rot.x += Input.GetAxisRaw("Mouse X") * _sensitive * 100 * Time.deltaTime;
        _rot.y += Input.GetAxisRaw("Mouse Y") * _sensitive * 100 * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(-_rot.y, _rot.x, 0);
    }

}
