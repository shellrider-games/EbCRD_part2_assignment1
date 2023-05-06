using UnityEngine;

namespace GeometryGenerators
{
    public abstract class GeometryGenerator : MonoBehaviour
    {
        [SerializeField] private Material material;
        private MeshRenderer _meshRenderer;
        private MeshFilter _meshFilter;
        void Start()
        {
            GenerateMeshComponents();
        }
        
        private void GenerateMeshComponents()
        {
            _meshRenderer = gameObject.AddComponent<MeshRenderer>();
            _meshRenderer.sharedMaterial = material;
            _meshFilter = gameObject.AddComponent<MeshFilter>();
            _meshFilter.mesh = GenerateMesh();
        }

        protected abstract Mesh GenerateMesh();
    }
}