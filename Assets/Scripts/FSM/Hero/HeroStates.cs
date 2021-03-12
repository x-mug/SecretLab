using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 细分并实现挂载对象在特定状态下，对应特定输入，产生特定反馈的所有函数与方法
 */

public class HeroStates
{
    /*
     * 状态注册在这里
     */

    public static AnyState anyState = new AnyState();
    public static IdleState idleState = new IdleState();
    public static RunState runState = new RunState();
    public static JumpState jumpState = new JumpState();
    public static DropState dropState = new DropState();

    public class AnyState : StateBase
    {
        public override void OnEnter(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
        }

        public override void HandleInput(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;

            // 获取通用移动所有可能的输入
            float h_move = Input.GetAxisRaw("Horizontal"); //左右移动
            bool isCrouch = Input.GetKey(KeyCode.S); //下蹲
            float jump = Input.GetAxis("Jump"); //跳跃

            // 跳跃次数用完了便不允许跳跃
            if (--fsm.parameter.jumpTimes < 0)
                jump = 0;

            // 赋予左右移动的速度(奔跑或下蹲)与跳跃速度
            fsm.parameter.rb.velocity = new Vector2(isCrouch ? h_move * fsm.parameter.speedScale / 2 : h_move * fsm.parameter.speedScale,
                                   jump != 0 ? jump * fsm.parameter.jumpScale : fsm.parameter.rb.velocity.y);

            // 转向
            fsm.parameter.transform.localScale = new Vector3(Vector3.Dot(fsm.parameter.rb.velocity, Vector3.right)==0 ? 
                fsm.parameter.transform.localScale.x : Vector3.Dot(fsm.parameter.rb.velocity, Vector3.right) > 0 ? 1 : -1, 1, 1);

        }

        public override void OnExit(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;

            // 没血了就死
            if (fsm.parameter.hp <= 0)
                fsm.Destroy();

            return;
        }
    }

    public class IdleState : StateBase
    {
        public override void OnEnter(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            fsm.parameter.anim.Play("Player_Idle");
        }

        public override void HandleInput(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;

            
        }

        public override void OnExit(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;

            // 进入静止状态，重置跳跃次数
            fsm.parameter.jumpTimes = fsm.parameter.jumpLimit;

            // 人物角色移动方向在人物面朝方向的变量上有分量时，进入跑步状态
            if (Vector3.Dot(fsm.parameter.rb.velocity, new Vector3(1 * fsm.parameter.transform.localScale.x,0,0)) > 0)
                fsm.TransactionState(runState);

            return;
        }
    }

    public class RunState : StateBase
    {
        public override void OnEnter(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            fsm.parameter.anim.Play("Player_Run");
        }

        public override void HandleInput(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;

            float x_Input = Input.GetAxisRaw("Horizontal");

            // 如果没速度了，该站立了
            if (Vector3.Dot(fsm.parameter.rb.velocity, new Vector3(1 * fsm.parameter.transform.localScale.x, 0, 0)) == 0)
                fsm.TransactionState(HeroStates.idleState);
        }

        public override void OnExit(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }
    }

    public class JumpState : StateBase
    {
        public override void OnEnter(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            fsm.parameter.anim.Play("Player_Jump");
        }

        public override void HandleInput(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
        }

        public override void OnExit(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }
    }

    public class DropState : StateBase
    {
        public override void OnEnter(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            fsm.parameter.anim.Play("Player_Drop");
        }

        public override void HandleInput(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
        }

        public override void OnExit(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }
    }

    public class LightATK01State : StateBase
    {
        public override void OnEnter(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            fsm.parameter.anim.Play("Player_LightATK01");
        }

        public override void HandleInput(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
        }

        public override void OnExit(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
            HeroFSM fsm = (HeroFSM)_fsm;
            return;
        }
    }
}
