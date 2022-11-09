using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName) : base(player, stateMachine, playerData, animBoolName)
    {
    }

    public override void DoCheck()
    {
        base.DoCheck();
    }

    public override void Enter()
    {
        base.Enter();
        Movement?.SetVelocityZero();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();


        //終了状態じゃなければ実行
        if (!isExitingState)
        {
            //プレイヤーが移動していれば実行
            if (xInput != 0.0f)
            {
                //プレイヤーのステータスをMoveStateに変更
                stateMachine.ChangeState(player.MoveState);
            }
            //しゃがみ込んでいたら実行
            else if (yInput == -1)
            {
                //プレイヤーのステータスをCrouchIdleStateに変更
                stateMachine.ChangeState(player.CrouchIdleState);
            }
        }
        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
