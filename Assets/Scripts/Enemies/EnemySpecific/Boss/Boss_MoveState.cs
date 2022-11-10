using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_MoveState : MoveState
{
    private Boss boss;
    private Movement movement;
    public Boss_MoveState(Entity etity, FinteStateMachine stateMachine, string animBoolName, D_MoveState stateDate, Boss boss, Movement movement) : base(etity, stateMachine, animBoolName, stateDate)
    {
        this.boss = boss;
        this.movement=movement;
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
        if (isPlayerInMaxAgroRange)
        {
            stateMachine.ChangeState(boss.jumpAttackState);
        }
        if (isPlayerInMinAgroRange)
        {
            stateMachine.ChangeState(boss.playerDetectedState);
        }
        //壁と崖の当たり判定
        else if (isDetectingWall || !isDetectingLedge)
        {
            boss.idleState.SetFlipAfteridle(true);
            stateMachine.ChangeState(boss.idleState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
