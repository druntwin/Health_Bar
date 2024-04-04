using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeathTextBar : HealthBar
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Color _color;

    private void Start()
    {
        _healthText.color = _color;
    }

    public override void UpdateBar()
    {
        if (_healthText != null)
        {
            _healthText.text = $"Health {_health.Mount} / {_health.MaxMount}";
        }
    }
}
