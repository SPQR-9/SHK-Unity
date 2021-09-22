using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _radius = 4f;

    private Vector3 _target;


    private void Start()
    {
        _target = Random.insideUnitCircle * _radius;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        if (transform.position == _target)
            _target = Random.insideUnitCircle * _radius;
    }
}
