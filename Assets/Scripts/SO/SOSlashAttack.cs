using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewSlashAttack", menuName = "AttackBehavior/Slash")]
public class SOSlashAttack : SOAttackBase
{
    public float CriticalChanceBonus = 20;
    public override void ExecuteAttack()
    {
        Debug.Log("Slash Attack !!!!!!!! :"+CriticalChanceBonus);


    }
}
