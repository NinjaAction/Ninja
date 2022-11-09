using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    private Movement Movement { get => movement ?? core.GetCoreComponent(ref movement); }
    private Movement movement;
    

    protected D_IdleState stateData;

    protected bool flipAfteerIdle;
    protected bool isIdleTimeOver;
    protected bool isPlayerInMinAgroRange;

    protected float idleTime;

    public IdleState(Entity etity,FinteStateMachine stateMachine,string animBoolName, D_IdleState stateData) : base(etity, stateMachine, animBoolName)
    {
        this.stateData = stateData;
    }


    public override void DoChecks()
    {
        base.DoChecks();

        isPlayerInMinAgroRange = entity.CheckPlayerInMinAgroRange();
    }


    public override void Enter()
    {
        base.Enter();

        Movement?.SetVelocityX(0.0f);
        isIdleTimeOver = false;
        
        SetRandomIdleTime();

        
    }

    public override void Exit()
    {
        base.Exit();

        if (flipAfteerIdle)
        {
            Movement?.Flip();
        }
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        Movement?.SetVelocityY(0.0f);

        if (Time.time >= startTime + idleTime)
        {
            isIdleTimeOver = true;
        }

    }


    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

       
    }


    public void SetFlipAfteridle(bool flip)
    {
        flipAfteerIdle = flip;
    }

    [System.Obsolete]
    private void SetRandomIdleTime()
    {
        idleTime = Random.RandomRange(stateData.minIdleTime, stateData.maxIdleTime);
    }
}
