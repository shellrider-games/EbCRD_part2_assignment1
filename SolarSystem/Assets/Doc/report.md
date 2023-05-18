# Explanation of assignment implementation

## Part 1 Create Five 3D geometric objects procedurally that serves as obstacles in the scene

The Scene "SampleScene" in the project includes 5 game objects with the following hierarchy:

- Star
  - Hexahedron
    - Octahedron
  - Tetrahedron
    - Hourglass

All these objects have a respective behaviour that inherits from an abstract class called `GeometryGenerator`.
`GeometryGenerator` includes the logic for generating all components for having a visible Mesh and colliders for the application.
The child classes implement the function `GenerateMesh()` that implements the vertex and triangle data for the given shape.

Concave shapes:
- Star
- Hourglass

## Part 2 The objects should rotate slantly around their parent objects automatically

Code that achieves this behaviour is implemented in the RotateAroundParent component. I use some linear algebra to construct a new up axis to rotate around by orthonormalizing the objects position with the parents up direction as tangent.

## Part 3 Raycasting with reflection from a Shooter Object

I created a model of a small spaceship in blender and imported it into the engine. The Shooter object has a child object LaserOrigin that uses the `RaycastLaser`component to emit raycasts that bounce and is rendered with a LineRenderer component. The `RaycastLaser`component can be configured with raycast length and number of possible bounces.

## Part 4 Constrain the movement of Shotter Object on a 3D Bezier curve

This is implemented in the `FollowBezier`component that references 4 `Transform` as control points. The component moves the object back and forth using a cubic Bezier interpolation. The component exposes a Time Frame property which can be used to change the objects speed along the curve.

## Part 5 Additional design to make the scene looks nice

I implemented different materials with emission properties and make us of an post processing stack to give the whole scene a spacy look with a lot of laser effects.

## Other files

I created 2 very simple behaviours `LookAt` and  `Spin` to add some additional movement to scene objects.