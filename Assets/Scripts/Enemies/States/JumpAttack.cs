using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAttack : AttackState
{
    protected D_JumpAttack jumpAttack;

    public JumpAttack(Entity etity, FinteStateMachine stateMachine, string animBoolName, Transform attackPosition, D_JumpAttack jumpAttack) : base(etity, stateMachine, animBoolName, attackPosition)
    {
        this.jumpAttack = jumpAttack;
    }

    public override void DoChecks()
    {
        base.DoChecks();
        isPlayerInMinAgroRange = entity.CheckPlayerInMinAgroRange();
    }

    public override void Enter()
    {
        base.Enter();
        isAnimationFinished = false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    
   
}

    
