using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClick : MonoBehaviour
{
    private Animator _animator;


    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown() //click or touch
    {
        _animator.SetTrigger("Mushroom");
    }
}
