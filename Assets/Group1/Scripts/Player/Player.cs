using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _activateAfterWinning; 

    public void Win()
    {
        _activateAfterWinning?.Invoke();
        gameObject.SetActive(false);
    }
}
