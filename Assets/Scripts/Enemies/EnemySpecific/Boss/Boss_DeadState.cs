using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_DeadState : DeadState
{
    private Boss boss;
    public Boss_DeadState(Entity etity, FinteStateMachine stateMachine, string animBoolName, D_DeadState stateData, Boss boss) : base(etity, stateMachine, animBoolName, stateData)
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
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
