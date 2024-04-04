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
    [SerializeField] private float _maxMount;
    [SerializeField] private float _changeMount;
    
    private float _mount;
    private float _minMount = 0;

    public float MaxMount => _maxMount;
    public float Mount => _mount;

    public Action OnChanged;

    private void Start()
    {
        _mount = _maxMount;
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
        _mount = Mathf.Clamp(_mount - _changeMount, _minMount, _maxMount);

        OnChanged.Invoke();
    }

    public void Add()
    {
        _mount = Mathf.Clamp(_mount + _changeMount, _minMount, _maxMount);

        OnChanged.Invoke();
    }
}
