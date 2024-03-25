using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{    
    [SerializeField] private Slider _healthSlider;

    private float _maxHealth;
    private float _newValue;

    public void SetMaxHealth(float maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void UpdateBar(float healthMount)
    {
        _newValue = healthMount / _maxHealth;

        if (_healthSlider != null)
        {
            _healthSlider.value = _newValue;
        }
    }
}
