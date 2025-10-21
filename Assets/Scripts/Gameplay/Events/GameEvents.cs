using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public partial class GameEvents : MonoBehaviour
{
    public static GameEvent<float> m_HealthUpdate=new();
    public static GameEvent<float,float> m_UIHealthUpdate=new();
}
