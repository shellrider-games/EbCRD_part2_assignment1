using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float speed = 60f;

    private void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
