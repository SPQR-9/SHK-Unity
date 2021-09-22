using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public event UnityAction Dead;
    private bool _isDie = false;

    public bool IsDie => _isDie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Player _))
        {
            _isDie = true;
            Dead?.Invoke();
            gameObject.SetActive(false);
        }
    }
}
