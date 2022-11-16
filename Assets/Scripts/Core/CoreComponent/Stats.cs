using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : CoreComponent
{
    public event Action OnHealthZero;

    [SerializeField] private float maxHealth;
    private float currentHealth;

    private Boss boss;

    protected override void Awake()
    {
        base.Awake();

        currentHealth = maxHealth;
    }

    public void DecraseHealth(float amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;

            OnHealthZero?.Invoke();           
            
                       
            

            Debug.Log("Health is zero!");
        }
    }

    public float GetHP()
    {
        return currentHealth;
    }

    public float GetMaxHP()
    {
        return maxHealth;
    }


    public void IncreaseHealth(float amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
    }

}
