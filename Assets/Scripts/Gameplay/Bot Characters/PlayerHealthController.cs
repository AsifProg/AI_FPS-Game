using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : HealthController
{
    protected override void OnEnable()
    {
        base.OnEnable();
        GameEvents.m_HealthUpdate.Register(ApplyDamage);
    }
    protected override void OnDisable()
    {
        base.OnDisable();
        GameEvents.m_HealthUpdate.Unregister(ApplyDamage);
    }

    public override void ApplyDamage(float damage)
    {
        base.ApplyDamage(damage);
        Debug.Log(m_CurrentHealth);
        Debug.Log($"Enemy Health {m_CurrentHealth}");
        GameEvents.m_UIHealthUpdate.Raise(m_CurrentHealth,m_Health);
    }
}
