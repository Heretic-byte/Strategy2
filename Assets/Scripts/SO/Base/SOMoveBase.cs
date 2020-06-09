using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SOMoveBase : ScriptableObject, IMoveBehavior
{
    public abstract void ExecuteMove();
}
