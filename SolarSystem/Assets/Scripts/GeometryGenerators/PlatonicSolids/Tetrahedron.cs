using System;
using System.Collections;
using System.Collections.Generic;
using GeometryGenerators;
using UnityEngine;

public class Tetrahedron : GeometryGenerator
{
    protected override Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0, .5f, 0),
            new Vector3(-3f / (2 * Mathf.Sqrt(6)), -.5f, -3 * Mathf.Tan(Mathf.PI / 6) / (2 * Mathf.Sqrt(6))),
            new Vector3(3f / (2 * Mathf.Sqrt(6)), -.5f, -3 * Mathf.Tan(Mathf.PI / 6) / (2 * Mathf.Sqrt(6))),
            new Vector3(0, -.5f, (3f / (Mathf.Sqrt(6) * 2)) / Mathf.Cos(Mathf.PI / 6)),

            new Vector3(0, .5f, 0),
            new Vector3(-3f / (2 * Mathf.Sqrt(6)), -.5f, -3 * Mathf.Tan(Mathf.PI / 6) / (2 * Mathf.Sqrt(6))),
            new Vector3(3f / (2 * Mathf.Sqrt(6)), -.5f, -3 * Mathf.Tan(Mathf.PI / 6) / (2 * Mathf.Sqrt(6))),
            new Vector3(0, -.5f, (3f / (Mathf.Sqrt(6) * 2)) / Mathf.Cos(Mathf.PI / 6)),

            new Vector3(0, .5f, 0),
            new Vector3(-3f / (2 * Mathf.Sqrt(6)), -.5f, -3 * Mathf.Tan(Mathf.PI / 6) / (2 * Mathf.Sqrt(6))),
            new Vector3(3f / (2 * Mathf.Sqrt(6)), -.5f, -3 * Mathf.Tan(Mathf.PI / 6) / (2 * Mathf.Sqrt(6))),
            new Vector3(0, -.5f, (3f / (Mathf.Sqrt(6) * 2)) / Mathf.Cos(Mathf.PI / 6))
        };
        mesh.vertices = vertices;
        mesh.triangles = new int[]
        {
            0, 1, 3,
            0 + 4 * 1, 2, 1 + 4 * 1,
            0 + 4 * 2, 3 + 4 * 1, 2 + 4 * 1,
            1 + 4 * 2, 2 + 4 * 2, 3 + 4 * 2
        };
        mesh.RecalculateNormals();
        return mesh;
    }
}