using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signalization : MonoBehaviour
{
    [SerializeField] private UnityEvent _detected;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider.TryGetComponent(out Player player))
        {
            _detected?.Invoke();
        }
    }
}
