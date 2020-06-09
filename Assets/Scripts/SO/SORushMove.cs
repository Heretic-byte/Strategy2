using UnityEngine;
[CreateAssetMenu(fileName = "NewRushMove", menuName = "MoveBehavior/Rush")]
public class SORushMove : SOMoveBase
{
    public float MoveModifier = 100;
    public float RushDamage = 100;
    public override void ExecuteMove()
    {
        Debug.Log("RushMove !! +" + MoveModifier);
        Debug.Log("Rush Damage !! +" + RushDamage);
    }
}

