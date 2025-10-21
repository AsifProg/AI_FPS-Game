using System.Collections;
using System.Collections.Generic;
using Gameplay.Weapons;
using UnityEngine;

public class BotsWithWeapon : NavigationAgent
{
   [SerializeField] private float m_BotAttackRate;
   [SerializeField] private PlayerHealthController m_PlayerHealth;

   [SerializeField] private float m_EnemyDamge;

   protected override void Init()
   {
      base.Init();
   }

   public override void AttackState()
   {
      base.AttackState();
      m_AnimatorController.Punch(ApplyDamageWithWeapon);
   }

   private void ApplyDamageWithWeapon()
   {
      // if(m_Target is null || !m_BotLook.CheckUnderView(m_Target))
      //    return;
      
      if (m_Target.TryGetComponent(out HealthController healthController))
      {
         Debug.Log(healthController.CurrentHealth());
         healthController.ApplyDamage(m_EnemyDamge);
      }
   }
   protected override void OnSwitchToAttack()
   {
      base.OnSwitchToAttack();
      m_AnimatorController.SetAimPose(true);
   }

   protected override void OnSwitchToChase()
   {
      base.OnSwitchToChase();
      m_AnimatorController.SetAimPose(false);
   }
}
