using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShapeto : MonoBehaviour
{
    [SerializeField] private Mesh ChangeShapeTo;

        private void OnCollisionEnter()
    {
        // First we'll get the material used by this game object's 'Renderer'.
        var meshFilter = GetComponent<MeshFilter>();

        meshFilter.sharedMesh = this.ChangeShapeTo;
    }
}
