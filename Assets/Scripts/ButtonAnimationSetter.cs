using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ButtonAnimationSetter : MonoBehaviour
{
    [SerializeField] private bool _isJumping;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        _animator.SetBool("IsJumping", _isJumping);
    }

    public void Expand()
    {
        _animator.SetBool("isExpanded", true);
    }

    public void Contract()
    {
        _animator.SetBool("isExpanded", false);
    }    

}
