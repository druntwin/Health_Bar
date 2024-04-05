using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

public class Health : MonoBehaviour
{
    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;
    [SerializeField] private float _maxValue;
    [SerializeField] private float _changeValue;
    
    private float _value;
    private float _minValue = 0;

    public float MaxValue => _maxValue;
    public float Value => _value;

    public delegate void ChangeDelegate();
    public event ChangeDelegate OnChanged;

    private void Start()
    {
        _value = _maxValue;
        OnChanged.Invoke();
    }

    private void OnEnable()
    {
        _plusButton.onClick.AddListener(() => Add());
        _minusButton.onClick.AddListener(() => Reduse());
    }

    private void OnDisable()
    {
        _plusButton.onClick.RemoveAllListeners();
        _minusButton.onClick.RemoveAllListeners();
    }

    public void Reduse()
    {
        _value = Mathf.Clamp(_value - _changeValue, _minValue, _maxValue);

        OnChanged.Invoke();
    }

    public void Add()
    {
        _value = Mathf.Clamp(_value + _changeValue, _minValue, _maxValue);

        OnChanged.Invoke();
    }
}
