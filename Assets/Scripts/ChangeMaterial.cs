using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    private MeshRenderer _meshRenderer = null;
    
    private void Awake()
    {
         // obtenemos el componente MeshRenderer 
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void ChangeMaterials(Material changeMaterial)
    {
        _meshRenderer.material =changeMaterial;
    }

}
