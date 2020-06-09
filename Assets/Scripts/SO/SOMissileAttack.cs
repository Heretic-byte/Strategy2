using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="NewMissleAttack",menuName ="AttackBehavior/Missile")]
public class SOMissileAttack : SOAttackBase
{
    public float DamageModifier=100;
    public override void ExecuteAttack()
    {
        Debug.Log("MissileAttack !! +"+DamageModifier);
    }
}
