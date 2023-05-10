using System.Collections;
using System.Collections.Generic;
using GeometryGenerators;
using UnityEngine;

public class SquareHourglass : GeometryGenerator
{
    protected override Mesh GenerateMesh()
    {
        Mesh mesh = new Mesh();

        mesh.vertices = new Vector3[]
        {
            new Vector3(-.5f, .5f, -.5f),
            new Vector3(.5f, .5f, -.5f),
            new Vector3(.5f, .5f, .5f),
            new Vector3(-.5f, .5f, .5f),

            new Vector3(-.3f, 0f, -.3f),
            new Vector3(.3f, 0f, -.3f),
            new Vector3(.3f, 0f, .3f),
            new Vector3(-.3f, 0f, .3f),

            new Vector3(-.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, -.5f),
            new Vector3(.5f, -.5f, .5f),
            new Vector3(-.5f, -.5f, .5f),
        };
        mesh.triangles = new int[]
        {
            //top face
            0, 3, 1,
            2, 1, 3,
            //top ring
            0, 5, 4,
            0, 1, 5,
            1, 6, 5,
            1, 2, 6,
            2, 7, 6,
            2, 3, 7,
            3, 4, 7,
            3, 0, 4,
            //bottom ring
            4, 9, 8,
            4, 5, 9,
            5, 10, 9,
            5, 6, 10,
            6, 11, 10,
            6, 7, 11,
            7, 8, 11,
            7, 4, 8,
            //bottom face
            8, 9, 11,
            10, 11, 9
        };
        mesh.RecalculateNormals();
        return mesh;
    }
}