using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaterial : MonoBehaviour
{
    public Material[] materials;
    private int materialIndex = 0;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    public void Rotate()
    {
        materialIndex = ++materialIndex % materials.Length;
        meshRenderer.material = materials[materialIndex];
    }
}
