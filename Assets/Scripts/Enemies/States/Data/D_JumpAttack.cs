using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newJumpAttackStateData", menuName = "Data/State Data/Jump Attack State")]


public class D_JumpAttack : ScriptableObject
{
    public float JumpHeight = 5.0f;
    public Vector2 JumpAttack;
}
