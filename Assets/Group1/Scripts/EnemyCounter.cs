using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Enemy[] _enemies;

    private void Awake()
    {
        _enemies = GetComponentsInChildren<Enemy>();
        foreach (var enemy in _enemies)
        {
            enemy.Dead += CheckNumberLiveEnemies;
        }
    }

    private void CheckNumberLiveEnemies()
    {
        foreach (var enemy in _enemies)
        {
            if (!enemy.IsDie)
                return;
        }
        _player.Win();
    }

    private void OnDisable()
    {
        foreach (var enemy in _enemies)
        {
            enemy.Dead -= CheckNumberLiveEnemies;
        }
    }
}
