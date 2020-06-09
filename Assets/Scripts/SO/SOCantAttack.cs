using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCantAttack", menuName = "AttackBehavior/CantAttack")]
public class SOCantAttack : SOAttackBase
{
    public override void ExecuteAttack()
    {
        Debug.Log("ICant Attack.. TT");
    }
}
