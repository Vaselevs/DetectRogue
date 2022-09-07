using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.A))
            {
                _animator.SetBool("side", true);
                _spriteRenderer.flipX = false;
                transform.Translate(-(_speed * Time.deltaTime), 0, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                _animator.SetBool("side", true);
                _spriteRenderer.flipX = true;
                transform.Translate(_speed * Time.deltaTime, 0, 0);
            }
        } 
        else
        {
            _animator.SetBool("side", false);
        }
    }
}
