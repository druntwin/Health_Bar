using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{    
    [SerializeField] private int _maxHealth;
    
    private int _health;
    private int _minHealth = 0;

    public UnityEvent<float> MaxHealthAssigned;
    public UnityEvent<float> HealthChanged;

    private void Start()
    {
        _health = _maxHealth;
        MaxHealthAssigned.Invoke(_maxHealth);
        HealthChanged.Invoke(_health);
    }

    public void Reduse(int reducer)
    {
        _health = Mathf.Clamp(_health - reducer, _minHealth, _maxHealth);

        HealthChanged.Invoke(_health);
    }

    public void Add(int health)
    {
        _health = Mathf.Clamp(_health + health, _minHealth, _maxHealth);

        HealthChanged.Invoke(_health);
    }
}
