using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class HandsController : MonoBehaviour
{

    [SerializeField] private InputActionReference gripInput;

    [SerializeField] private InputActionReference triggerInput;

    
    // Private Variables
    private Animator _animator;
    private float grip;
    private float trigger;

    private void Awake()
    {
        // Obtenmos el componente Animator
        _animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        // Leemos los valores
        grip = gripInput.action.ReadValue<float>();
        trigger = triggerInput.action.ReadValue<float>();
        
        
        // Asignamos los valores a los parámetros del Animator
        _animator.SetFloat("Grip",grip);
        _animator.SetFloat("Trigger",trigger);
        
    }
}
