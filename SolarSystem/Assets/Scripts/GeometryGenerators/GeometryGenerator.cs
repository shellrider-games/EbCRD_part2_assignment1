using UnityEngine;

namespace GeometryGenerators
{
    public abstract class GeometryGenerator : MonoBehaviour
    {
        [SerializeField] private Material material;
        private MeshRenderer _meshRenderer;
        private MeshFilter _meshFilter;
        private MeshCollider _meshCollider;

        void Start()
        {
            GenerateMeshComponents();
        }

        private void GenerateMeshComponents()
        {
            Mesh mesh = GenerateMesh();
            _meshRenderer = gameObject.AddComponent<MeshRenderer>();
            _meshRenderer.sharedMaterial = material;
            _meshFilter = gameObject.AddComponent<MeshFilter>();
            _meshFilter.mesh = mesh;
            _meshCollider = gameObject.AddComponent<MeshCollider>();
            _meshCollider.sharedMesh = mesh;
        }

        protected abstract Mesh GenerateMesh();
    }
}