using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] private float _boostTime = 2f;
    [SerializeField] private float _boostValue = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerMover playerMover))
        {
            playerMover.ActivateBoostedSpeed(_boostTime, _boostValue);
            gameObject.SetActive(false);
        }
    }
}
