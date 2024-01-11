using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaterial : MonoBehaviour {
    public Material[] materials;
    private int materialIndex;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
        materialIndex = 0;

        LetsRotateMaterial();
    }

    public void LetsRotateMaterial() {
        materialIndex = (++materialIndex) % materials.Length;
        meshRenderer.material = materials[materialIndex];
        Debug.Log(materialIndex);
    }

}
