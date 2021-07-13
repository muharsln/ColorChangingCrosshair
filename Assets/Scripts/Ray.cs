using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ray : MonoBehaviour
{
    private RaycastHit _rayInfo;
    [SerializeField] private Image[] _crosshair;

 
    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out _rayInfo, 100f))
        {
            if (_rayInfo.collider.gameObject.tag == "Enemy")
            {
                for (int i = 0; i < _crosshair.Length; i++)
                {
                    _crosshair[i].color = new Color(255, 0, 0);
                }
            }
            else if (_rayInfo.collider.gameObject.tag == "Team")
            {
                for (int i = 0; i < _crosshair.Length; i++)
                {
                    _crosshair[i].color = new Color(0, 255, 0);
                }
            }
            else
            {
                for (int i = 0; i < _crosshair.Length; i++)
                {
                    _crosshair[i].color = new Color(0, 0, 0);
                }
            }
        }

    }
}
