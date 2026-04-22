
using System;
using TMPro;
using UnityEngine;

public class UI_HealthDisplay : MonoBehaviour
{
    public HealthComponent healthComponent;
    public TextMeshProUGUI textComponent; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        healthComponent.OnHealthChanged += OnHealthChanged;
        healthComponent.OnHealthInitialized += OnHealthInitialized;
    }

    private void OnHealthInitialized(float newhealth)
    {
        textComponent.text = newhealth.ToString();
    }

    private void OnHealthChanged(float newhealth, float amountChanged)
    {
        //Debug.Log(newhealth + ":" + amountChanged);
        textComponent.text = newhealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}