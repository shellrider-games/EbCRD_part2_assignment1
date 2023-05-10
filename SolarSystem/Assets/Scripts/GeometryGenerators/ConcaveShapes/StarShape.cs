using System.Collections;
using System.Collections.Generic;
using GeometryGenerators;
using UnityEngine;

public class StarShape : GeometryGenerator
{
    protected override Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[]
        {
            //front middle
            new Vector3(0, 0, -.1f),

            //outside points
            new Vector3(.7f * Mathf.Sin(0 * 2 * Mathf.PI / 5), .7f * Mathf.Cos(0 * 2 * Mathf.PI / 5), 0),
            new Vector3(.7f * Mathf.Sin(1 * 2 * Mathf.PI / 5), .7f * Mathf.Cos(1 * 2 * Mathf.PI / 5), 0),
            new Vector3(.7f * Mathf.Sin(2 * 2 * Mathf.PI / 5), .7f * Mathf.Cos(2 * 2 * Mathf.PI / 5), 0),
            new Vector3(.7f * Mathf.Sin(3 * 2 * Mathf.PI / 5), .7f * Mathf.Cos(3 * 2 * Mathf.PI / 5), 0),
            new Vector3(.7f * Mathf.Sin(4 * 2 * Mathf.PI / 5), .7f * Mathf.Cos(4 * 2 * Mathf.PI / 5), 0),

            //inside points

            new Vector3(.2f * Mathf.Sin(0 * 2 * Mathf.PI / 5 + Mathf.PI),
                .2f * Mathf.Cos(0 * 2 * Mathf.PI / 5 + Mathf.PI), 0),
            new Vector3(.2f * Mathf.Sin(1 * 2 * Mathf.PI / 5 + Mathf.PI),
                .2f * Mathf.Cos(1 * 2 * Mathf.PI / 5 + Mathf.PI), 0),
            new Vector3(.2f * Mathf.Sin(2 * 2 * Mathf.PI / 5 + Mathf.PI),
                .2f * Mathf.Cos(2 * 2 * Mathf.PI / 5 + Mathf.PI), 0),
            new Vector3(.2f * Mathf.Sin(3 * 2 * Mathf.PI / 5 + Mathf.PI),
                .2f * Mathf.Cos(3 * 2 * Mathf.PI / 5 + Mathf.PI), 0),
            new Vector3(.2f * Mathf.Sin(4 * 2 * Mathf.PI / 5 + Mathf.PI),
                .2f * Mathf.Cos(4 * 2 * Mathf.PI / 5 + Mathf.PI), 0),

            //back middle
            new Vector3(0, 0, .1f)
        };

        mesh.vertices = vertices;
        mesh.triangles = new int[]
        {
            
            0, 10, 3,
            0, 3, 6,
            
            0, 6, 4,
            0, 4, 7,
            
            0, 7, 5,
            0, 5, 8,
            
            0, 8, 1,
            0, 1, 9,
            
            0, 9, 2,
            0, 2, 10,
            
            11, 3, 10,
            11, 6, 3,
            
            11, 4, 6,
            11, 7, 4,
            
            11, 5, 7,
            11, 8, 5,
            
            11, 1, 8,
            11, 9, 1,
            
            11, 2, 9,
            11, 10, 2
        };
        mesh.RecalculateNormals();

        return mesh;
    }
}