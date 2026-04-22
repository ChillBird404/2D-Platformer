using JetBrains.Annotations;
using System;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<HealthComponent>().ReceiveDamage(damage);
    }
}
