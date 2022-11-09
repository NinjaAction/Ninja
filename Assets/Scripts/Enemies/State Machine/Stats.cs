using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected FinteStateMachine stateMachine;
    protected Entity entity;
    protected Core core;   


    public float startTime { get; private set; }


    protected string animBoolName;

    public State(Entity etity,FinteStateMachine stateMachine,string animBoolName)
    {
        this.entity = etity;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;
        core = entity.core;
    }

    public virtual void Enter()
    {
        startTime = Time.time;
        entity.anim.SetBool(animBoolName, true);
        DoChecks();
    }


    public virtual void Exit()
    {
        entity.anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate()
    {

    }


    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }

    public virtual void DoChecks()
    {

    }
}
