using System.Collections;
using System.Collections.Generic;
using GeometryGenerators;
using UnityEngine;

public class Hexahedron : GeometryGenerator
{
    protected override Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(-.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, .5f),
            new Vector3(-.5f, -.5f, .5f),
            new Vector3(-.5f, .5f, -.5f),
            new Vector3(.5f, .5f, -.5f),
            new Vector3(.5f, .5f, .5f),
            new Vector3(-.5f, .5f, .5f),

            new Vector3(-.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, .5f),
            new Vector3(-.5f, -.5f, .5f),
            new Vector3(-.5f, .5f, -.5f),
            new Vector3(.5f, .5f, -.5f),
            new Vector3(.5f, .5f, .5f),
            new Vector3(-.5f, .5f, .5f),

            new Vector3(-.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, .5f),
            new Vector3(-.5f, -.5f, .5f),
            new Vector3(-.5f, .5f, -.5f),
            new Vector3(.5f, .5f, -.5f),
            new Vector3(.5f, .5f, .5f),
            new Vector3(-.5f, .5f, .5f),

            new Vector3(-.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, .5f),
            new Vector3(-.5f, -.5f, .5f),
            new Vector3(-.5f, .5f, -.5f),
            new Vector3(.5f, .5f, -.5f),
            new Vector3(.5f, .5f, .5f),
            new Vector3(-.5f, .5f, .5f),

            new Vector3(-.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, .5f),
            new Vector3(-.5f, -.5f, .5f),
            new Vector3(-.5f, .5f, -.5f),
            new Vector3(.5f, .5f, -.5f),
            new Vector3(.5f, .5f, .5f),
            new Vector3(-.5f, .5f, .5f)
        };
        mesh.vertices = vertices;
        mesh.triangles = new int[]
        {
            0, 4, 1,
            4 + 8 * 1, 5, 1 + 8 * 1,

            1 + 8 * 2, 5 + 8 * 1, 2,
            5 + 8 * 2, 6, 2 + 8 * 1,

            2 + 8 * 2, 6 + 8 * 1, 3,
            6 + 8 * 2, 7, 3 + 8 * 1,

            3 + 8 * 2, 7 + 8 * 1, 0 + 8 * 1,
            7 + 8 * 2, 4 + 8 * 2, 0 + 8 * 2,

            0 + 8 * 3, 1 + 8 * 3, 3 + 8 * 3,
            2 + 8 * 3, 3 + 8 * 4, 1 + 8 * 3,

            4 + 8 * 3, 7 + 8 * 3, 5 + 8 * 3,
            6 + 8 * 3, 5 + 8 * 4, 7 + 8 * 4
        };
        mesh.RecalculateNormals();
        return mesh;
    }
}