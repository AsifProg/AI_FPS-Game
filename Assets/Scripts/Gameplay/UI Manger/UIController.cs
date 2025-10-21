using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI  m_CurrentHealth, m_TotalHealth;

    private void Start()
    {
        UpdateHealth(100, 100);
    }

    private void OnEnable()
    {
        GameEvents.m_UIHealthUpdate.Register(UpdateHealth);
    }

    private void OnDisable()
    {
        GameEvents.m_UIHealthUpdate.UnRegister(UpdateHealth);
    }

    public void UpdateHealth(float CurHealth, float TotalHealth)
    {
        m_CurrentHealth.text = CurHealth.ToString();
        m_TotalHealth.text = TotalHealth.ToString();
    }
}
