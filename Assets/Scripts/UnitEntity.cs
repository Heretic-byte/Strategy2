using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitEntity : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer { get; set; }

    public string m_ClassName;
    public float m_HealthPoint;
    public float m_MoveSpeed;
    public float m_Armour;
    public float m_AttackRange;
    public float m_AttackDamage;

    IAttackBehavior m_AttackBehavior;

    IMoveBehavior m_MoveBehavior;

    public void Start()
    {
        if(m_ClassName!=null)
        {
            SetUnit(m_ClassName);
            Move();
            Attack();
        }
    }

    public void SetUnit(string className)
    {
        var UnitData= GameManager.Get.GetUnitData(className);

        m_ClassName = UnitData.m_ClassName;
        gameObject.name += "-"+m_ClassName;

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.sprite = UnitData.m_CharSprite;

        m_AttackBehavior =Instantiate( UnitData.m_AttackBehav);
        //m_AttackBehavior = UnitData.m_AttackBehav;
        //인스턴싱 안하는것도 방법일수 있지만 
        //복잡한 게임 특성상 해당 비헤이비어가 따로 변수를 저장해야하는 케이스가 생길 확률이 높음,
        //그럴 경우 인스턴스가 타 유닛과 공유되면 문제 야기함.
        //전부 파라미터로 받아버리는것도 방법이 될수 있음.
        m_MoveBehavior = Instantiate(UnitData.m_MoveBehav);
    }


    public void Move()
    {
        m_MoveBehavior.ExecuteMove();
    }

    public void Attack()
    {
        m_AttackBehavior.ExecuteAttack();
    }
}
