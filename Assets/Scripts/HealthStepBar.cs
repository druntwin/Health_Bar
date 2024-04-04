using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthStepBar : HealthBar
{
    [SerializeField] private Slider _slider;

    public override void UpdateBar()
    {        
        if (_slider != null)
        {
            _slider.value = GetNewSliderValue();
        }
    }
}
