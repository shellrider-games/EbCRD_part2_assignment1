using System.Collections;
using System.Collections.Generic;
using GeometryGenerators;
using UnityEngine;

public class Octahedron : GeometryGenerator
{
    protected override Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = GenerateVertices();
        // The multiplication and adding takes place because I need individual vertices to achieve a flat shaded look
        mesh.triangles = new[]
        {
            0, 2, 1,
            0 + 6 * 1, 3, 2 + 6 * 1,
            0 + 6 * 2, 4, 3 + 6 * 1,
            0 + 6 * 3, 1 + 6 * 1, 4 + 6 * 1,
            5, 1 + 6 * 2, 2 + 6 * 2,
            5 + 6 * 1, 2 + 6 * 3, 3 + 6 * 2,
            5 + 6 * 2, 3 + 6 * 3, 4 + 6 * 2,
            5 + 6 * 3, 4 + 6 * 3, 1 + 6 * 3
        };
        mesh.RecalculateNormals();
        return mesh;
    }

    private Vector3[] GenerateVertices()
    {
        // To get 8 flat shaded surfaces we need 3*8 vertices due to how shading in unity uses the vertex normal and
        Vector3[] vertices = new Vector3[3 * 8]
        {
            new Vector3(0f, .5f, 0f),
            new Vector3(-.5f, 0f, 0f),
            new Vector3(0f, 0f, -.5f),
            new Vector3(.5f, 0f, 0f),
            new Vector3(0f, 0f, .5f),
            new Vector3(0f, -.5f, 0f),
            new Vector3(0f, .5f, 0f),
            new Vector3(-.5f, 0f, 0f),
            new Vector3(0f, 0f, -.5f),
            new Vector3(.5f, 0f, 0f),
            new Vector3(0f, 0f, .5f),
            new Vector3(0f, -.5f, 0f),
            new Vector3(0f, .5f, 0f),
            new Vector3(-.5f, 0f, 0f),
            new Vector3(0f, 0f, -.5f),
            new Vector3(.5f, 0f, 0f),
            new Vector3(0f, 0f, .5f),
            new Vector3(0f, -.5f, 0f),
            new Vector3(0f, .5f, 0f),
            new Vector3(-.5f, 0f, 0f),
            new Vector3(0f, 0f, -.5f),
            new Vector3(.5f, 0f, 0f),
            new Vector3(0f, 0f, .5f),
            new Vector3(0f, -.5f, 0f)
        };


        return vertices;
    }
}