using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewUnitTable",menuName ="Tables/UnitTable")]
public class UnitTable : ScriptableObject
{
    [System.Serializable]
    public struct UnitStats
    {
        public string m_ClassName;
        public Sprite m_CharSprite;
        public float m_HealthPoint;
        public float m_MoveSpeed;
        public float m_Armour;
        public float m_AttackRange;
        public float m_AttackDamage;
        public SOAttackBase m_AttackBehav;
        public SOMoveBase m_MoveBehav;
    }


    public UnitStats[] m_Units;
}
