using JetBrains.Annotations;
using System;
using System.Collections;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int maxHealth = 100;
    public float invincibilityTime = 2f;
    private bool canReciveDamage = true;
    private float currentHealth;
    private bool invincibility;

    public delegate void OnHealthChangedHandler(float newhealth, float amountChanged);
    public event OnHealthChangedHandler OnHealthChanged;

    public delegate void OnHealthInitilizedHandler(float newhealth);
    public event OnHealthInitilizedHandler OnHealthInitialized;


    private void Start()
    {
        currentHealth = maxHealth;
        OnHealthInitialized?.Invoke(currentHealth);
    }

    public void ReceiveDamage(float amount)
    {
        if (invincibility)
        {
            currentHealth -= amount;
            OnHealthChanged?.Invoke(currentHealth, amount);
            invincibility = true;
            StartCoroutine(ResetInvincibility(3));
        }

        if (canReciveDamage)
        {
            canReciveDamage = false;
            currentHealth -= amount;
            StartCoroutine(RunInvincibilityTimer(invincibilityTime, RefreshInvincibility));
            OnHealthChanged?.Invoke(currentHealth, amount);
            //Debug.Log(currentHealth);
        }
    }

    IEnumerator ResetInvincibility(float resetTime)
    {
        yield return new WaitForSeconds(resetTime);
        invincibility = false;
    }
    

    public void AddHealth(float amount)
    {
        currentHealth += amount;
        OnHealthChanged?.Invoke(currentHealth, amount);
       //Debug.Log(currentHealth);
    }

    IEnumerator RunInvincibilityTimer(float waitTime, Action callback)
    {
        yield return new WaitForSeconds(waitTime);
        callback.Invoke();
    }

    private void RefreshInvincibility()
    {
        canReciveDamage = true;
        //Debug.Log("Reset");
    }
}
