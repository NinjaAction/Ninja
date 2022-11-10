using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_JumpAttack : JumpAttack
{
    private Boss boss;
    private Movement movement;

    public Boss_JumpAttack(Entity etity, FinteStateMachine stateMachine, string animBoolName, Transform attackPosition, D_JumpAttack jumpAttack, Boss boss, Movement movement) : base(etity, stateMachine, animBoolName, attackPosition, jumpAttack)
    {
        this.boss = boss;
        this.movement = movement;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        movement?.SetVelocity(jumpAttack.JumpAttack,movement.FacingDirection);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();


        if (isAnimationFinished)
        {
            if (isPlayerInMinAgroRange)
            {
                stateMachine.ChangeState(boss.playerDetectedState);

            }
            else
            {
                stateMachine.ChangeState(boss.lookForPlayerState);
            }
        }
    }
}
