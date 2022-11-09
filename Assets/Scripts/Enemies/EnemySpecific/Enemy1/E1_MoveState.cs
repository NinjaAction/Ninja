using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_MoveState : MoveState
{
    private Enemy1 enemy;

    public E1_MoveState(Entity etity, FinteStateMachine stateMachine, string animBoolName, D_MoveState stateDate, Enemy1 enemy) : base(etity, stateMachine, animBoolName, stateDate)
    {
        this.enemy = enemy;
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

        if (isPlayerInMinAgroRange)
        {
            stateMachine.ChangeState(enemy.playerDetectedState);
        }
        //壁と崖の当たり判定
        else if (isDetectingWall || !isDetectingLedge)
        {
            enemy.idleState.SetFlipAfteridle(true);
            stateMachine.ChangeState(enemy.idleState);
        }
    }


    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

    }
}
