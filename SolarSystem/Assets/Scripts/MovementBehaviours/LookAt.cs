using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform lookTarget;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(lookTarget, Vector3.up);
    }
}
