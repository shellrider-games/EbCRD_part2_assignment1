using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RaycastLaser : MonoBehaviour
{
    [SerializeField] private int bounces;
    [SerializeField] private float length;

    private LineRenderer _lineRenderer;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        ShootLaser();
    }

    private void ShootLaser()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        float remainingLength = length;

        _lineRenderer.positionCount = 1;
        _lineRenderer.SetPosition(0, transform.position);

        for (int i = 0; i < bounces; i++)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, remainingLength))
            {
                _lineRenderer.SetPosition(_lineRenderer.positionCount++, hit.point);
                remainingLength -= hit.distance;
                ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
            }
            else
            {
                _lineRenderer.SetPosition(_lineRenderer.positionCount++, ray.origin + remainingLength * ray.direction);
                break;
            }
        }
    }
}