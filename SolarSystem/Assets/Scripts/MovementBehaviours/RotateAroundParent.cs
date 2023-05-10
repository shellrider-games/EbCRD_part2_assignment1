using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundParent : MonoBehaviour
{
    private Vector3 _rotationUp;
    [SerializeField] private float orbitSpeed = 20f;

    void Start()
    {
        Vector3 tangent = transform.parent.transform.up;
        Vector3 normal = transform.localPosition;
        
        Vector3.OrthoNormalize(ref normal, ref tangent);
        _rotationUp = tangent;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, _rotationUp, orbitSpeed * Time.deltaTime);
        transform.eulerAngles = new Vector3(0,transform.eulerAngles.y, 0);
    }
}
