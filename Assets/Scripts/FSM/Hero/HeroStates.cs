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

    public static IdleState idleState = new IdleState();
    public static RunState runState = new RunState();
    public static JumpState jumpState = new JumpState();
    public static DropState dropState = new DropState();

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

            if (Input.GetAxisRaw("Horizontal") != 0)
                _fsm.TransactionState(runState);
            else
                fsm.parameter.rb.velocity = Vector2.zero;
        }

        public override void OnExit(FSMBase _fsm)
        {
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
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
            if (x_Input == 0)
                fsm.TransactionState(idleState);
            else
            {
                fsm.parameter.transform.localScale = new Vector3(x_Input, 1, 1);
                fsm.parameter.rb.velocity = new Vector2(x_Input * fsm.parameter.speedScale, fsm.parameter.rb.velocity.y);
            }
        }

        public override void OnExit(FSMBase _fsm)
        {
            return;
        }

        public override void OnUpdate(FSMBase _fsm)
        {
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
