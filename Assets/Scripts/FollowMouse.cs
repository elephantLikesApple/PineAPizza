﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowMouse : MonoBehaviour
{

    public float speed = 3.0f;
    public float distanceFromCamera = 5.0f;



    void Awake()
    {

    }

    // ...

    void Start()
    {

    }

    // ...

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distanceFromCamera;

        Vector3 mouseScreenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 position = Vector3.Lerp(transform.position, mouseScreenToWorld, 1.0f - Mathf.Exp(-speed * Time.deltaTime));

        transform.position = position;
    }

    // ...

    void LateUpdate()
    {

    }

    // =================================	
    // End functions.
    // =================================

}

