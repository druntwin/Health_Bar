using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.OnChanged += UpdateBar;
    }

    private void OnDisable()
    {
        _health.OnChanged -= UpdateBar;
    }

    public virtual void UpdateBar() { }

    public float GetNewSliderValue()
    {
        return _health.Mount / _health.MaxMount;
    }
}
