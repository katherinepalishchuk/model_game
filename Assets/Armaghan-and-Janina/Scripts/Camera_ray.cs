﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Camera_ray : MonoBehaviour
{
    public int _layermask;
    public Vector3 _direction;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(new Vector3(0,0.1f,0), ForceMode.Impulse);
        }
    }
}
