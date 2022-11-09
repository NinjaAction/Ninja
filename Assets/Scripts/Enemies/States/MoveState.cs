using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveState : State
{
    private Movement Movement { get => movement ?? core.GetCoreComponent(ref movement); }
    private CollisionSenses CollisionSenses { get => collisionSenses ?? core.GetCoreComponent(ref collisionSenses); }

    private Movement movement;
    private CollisionSenses collisionSenses;

    protected D_MoveState stateData;   

    protected bool isDetectingWall;
    protected bool isDetectingLedge;

    protected bool isPlayerInMinAgroRange;

    public MoveState(Entity etity,FinteStateMachine stateMachine,string animBoolName, D_MoveState stateDate) : base(etity, stateMachine, animBoolName)
    {
        this.stateData = stateDate;
    }

    public override void DoChecks()
    {
        base.DoChecks();
        if (CollisionSenses)
        {
            isDetectingLedge = CollisionSenses.LedgeVertical;
            isDetectingWall = CollisionSenses.WallFront;
            isPlayerInMinAgroRange = entity.CheckPlayerInMinAgroRange();
        }
        
        
    }


    public override void Enter()
    {
        base.Enter();
        Movement?.SetVelocityX(stateData.movementSpeed * Movement.FacingDirection);
        
        DoChecks();
        
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        Movement?.SetVelocityX(stateData.movementSpeed * Movement.FacingDirection);
    }


    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        
    }

}
