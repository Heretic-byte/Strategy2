using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSiegeMove", menuName = "MoveBehavior/Siege")]
public class SOSiegeNotMove : SOMoveBase
{
    public override void ExecuteMove()
    {
        Debug.Log("SiegeNotMove");
    }
}
