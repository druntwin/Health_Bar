using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothBar : MonoBehaviour
{
    [SerializeField] private Slider _healthSmoothSlider;
    [SerializeField] private float _smoothStep;

    private float _maxHealth;
    private float _newValue;

    public void SetMaxHealth(float maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void UpdateSmoothBar(float healthMount)
    {
        _newValue = healthMount / _maxHealth;

        if (_healthSmoothSlider != null)
        {
            StartCoroutine(UpdateSmoothSlider());
        }
    }

    IEnumerator UpdateSmoothSlider()
    {
        float minValuesDifference = 0.001f;

        while (_healthSmoothSlider.value != _newValue)
        {
            _healthSmoothSlider.value = Mathf.SmoothStep(_healthSmoothSlider.value, _newValue, _smoothStep);

            if (Mathf.Abs(_healthSmoothSlider.value - _newValue) < minValuesDifference)
                _healthSmoothSlider.value = _newValue;

            yield return null;
        }
    }
}
