using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeathText : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Color _color;

    private float _maxHealth;
    private float _newValue;

    private void Start()
    {
        _healthText.color = _color;
    }

    public void SetMaxHealth(float maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void UpdateText(float healthMount)
    {
        _newValue = healthMount / _maxHealth;

        if (_healthText != null)
        {
            _healthText.text = $"Health {healthMount} / {_maxHealth}";
        }
    }
}
