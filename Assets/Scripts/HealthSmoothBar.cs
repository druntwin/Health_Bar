using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSmoothBar : HealthBar
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothStep;

    private float _newValue;

    public override void UpdateBar()
    {
        if (_slider != null)
        {            
            _newValue = GetNewSliderValue();
            StartCoroutine(UpdateSmoothSlider());
        }
    }

    private IEnumerator UpdateSmoothSlider()
    {
        float minValuesDifference = 0.001f;

        while (_slider.value != _newValue)
        {
            _slider.value = Mathf.SmoothStep(_slider.value, _newValue, _smoothStep);

            if (Mathf.Abs(_slider.value - _newValue) < minValuesDifference)
                _slider.value = _newValue;

            yield return null;
        }
    }
}
