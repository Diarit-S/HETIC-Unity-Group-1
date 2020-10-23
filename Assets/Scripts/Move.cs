﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public Vector3 Direction;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Direction * Time.deltaTime);
    }
}
