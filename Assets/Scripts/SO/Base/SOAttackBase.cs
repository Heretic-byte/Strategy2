using UnityEngine;

public abstract class SOAttackBase : ScriptableObject, IAttackBehavior
{
    public abstract void ExecuteAttack();
}
