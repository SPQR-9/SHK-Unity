using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;

    private Vector3 _moveVector;
    private float _boostedSpeed = 1f;
    private float _boostSpeedTimer = 0f;

    private const string _horisontal = "Horizontal";
    private const string _vertical = "Vertical";
    private const float _basicValueBooostedSpeed = 1f;


    private void Update()
    {
        CheckBoostSpeed();
        _moveVector.x = Input.GetAxis(_horisontal);
        _moveVector.y = Input.GetAxis(_vertical);
        transform.position += _moveVector * _speed * _boostedSpeed * Time.deltaTime;
    }

    private void CheckBoostSpeed()
    {
        if (_boostSpeedTimer >= 0)
            _boostSpeedTimer -= Time.deltaTime;
        else
            _boostedSpeed = _basicValueBooostedSpeed;
    }

    public void ActivateBoostedSpeed(float boostTime,float boostValue)
    {
        _boostedSpeed = boostValue;
        _boostSpeedTimer += boostTime;
    }
}
