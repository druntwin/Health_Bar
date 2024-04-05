using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected Health Health => _health;

    private void OnEnable()
    {
        Health.OnChanged += UpdateBar;
    }

    private void OnDisable()
    {
        Health.OnChanged -= UpdateBar;
    }

    public virtual void UpdateBar() { }

    public float GetNewSliderValue()
    {
        return Health.Value / Health.MaxValue;
    }
}
