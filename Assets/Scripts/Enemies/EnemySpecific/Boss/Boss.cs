using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Entity
{
    public Boss_IdleState idleState { get; private set; }
    public Boss_MoveState moveState { get; private set; }
    public Boss_PlayerdetectedState playerDetectedState { get; private set; }
    public Boss_ChargeState chargeState { get; private set; }
    public Boss_LookForPlayerState lookForPlayerState { get; private set; }
    public Boss_MeleeAttackState meleeAttackState { get; private set; }
    public Boss_StunState stunState { get; private set; }
    public Boss_DeadState deadState { get; private set; }
    public Boss_JumpAttack jumpAttackState { get; private set; }
    

    [SerializeField]
    private D_IdleState idleStateData;
    [SerializeField]
    private D_MoveState moveStateData;
    [SerializeField]
    private D_PlayerDetected playerDetectedData;
    [SerializeField]
    private D_ChargeState chargeStateData;
    [SerializeField]
    private D_LookForPlayer lookForPlayerStateData;
    [SerializeField]
    private D_MeleeAttack meleeAttackStateData;
    [SerializeField]
    private D_StunState stunStateData;
    [SerializeField]
    private D_DeadState deadStateData;
    [SerializeField]
    private D_JumpAttack jumpAttackData;



    [SerializeField]
    private Transform meleeAttackPosition;

    public bool alive;


    public override void Awake()
    {
        base.Awake();
        moveState = new Boss_MoveState(this, stateMachine, "move", moveStateData, this,Movement);
        idleState = new Boss_IdleState(this, stateMachine, "idle", idleStateData, this);
        playerDetectedState = new Boss_PlayerdetectedState(this, stateMachine, "playerDetected", playerDetectedData, this);
        chargeState = new Boss_ChargeState(this, stateMachine, "charge", chargeStateData, this);
        lookForPlayerState = new Boss_LookForPlayerState(this, stateMachine, "lookForPlayer", lookForPlayerStateData, this);
        meleeAttackState = new Boss_MeleeAttackState(this, stateMachine, "meleeAttack", meleeAttackPosition, meleeAttackStateData, this);
        stunState = new Boss_StunState(this, stateMachine, "stun", stunStateData, this);
        deadState = new Boss_DeadState(this, stateMachine, "dead", deadStateData, this);
        jumpAttackState = new Boss_JumpAttack(this, stateMachine, "jumpAttack", meleeAttackPosition, jumpAttackData, this, Movement);


    }


    private void Start()
    {
        stateMachine.Initialize(moveState);
        alive = true;
    }


    public override void OnDrawGizmos()
    {
        base.OnDrawGizmos();


        Gizmos.DrawWireSphere(meleeAttackPosition.position, meleeAttackStateData.attackRadius);
    }


    public bool Alive()
    {
        return alive;
    }
}
