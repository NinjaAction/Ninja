using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_StunState : StunState
{
    private Boss boss;
    public Boss_StunState(Entity etity, FinteStateMachine stateMachine, string animBoolName, D_StunState stateData, Boss boss) : base(etity, stateMachine, animBoolName, stateData)
    {
        this.boss = boss;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();


        if (isStunTimeOver)
        {
            if (perfromCloseRangeAction)
            {
                stateMachine.ChangeState(boss.meleeAttackState);
            }
            else if (isPlayerInMinAgroRange)
            {
                stateMachine.ChangeState(boss.chargeState);
            }
            else
            {
                boss.lookForPlayerState.SetTurnImmdiately(true);
                stateMachine.ChangeState(boss.lookForPlayerState);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
