using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slideHP;
    private void Awake()
    {
        slideHP = GetComponent<Slider>();
    }

    public void ChangeSlider(float currentValue, float maxValue)
    {
        slideHP.value = currentValue / maxValue;
    }
}
