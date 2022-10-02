using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Signalization : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private UnityEvent _detected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player player))
        {
            _sound.volume = 0;
            Debug.Log("Входит");
            _detected?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Выходит");
        _detected?.Invoke();
    }
}
