using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 细分并实现挂载对象在特定状态下，对应特定输入，产生特定反馈的所有函数与方法
 */

public class Hero_States
{
    public class IdleState : StateBase<IdleState>
    {
        public override void OnEnter(FSMBase fsm, ParamBase param)
        {
            ((Hero_Parameter)param).anim.Play("Player_Idle");
        }

        public override void HandleInput(FSMBase fsm, ParamBase param)
        {
            
        }

        public override void OnExit(FSMBase fsm, ParamBase param)
        {
            throw new System.NotImplementedException();
        }

        public override void OnUpdate(FSMBase fsm, ParamBase param)
        {
            throw new System.NotImplementedException();
        }
    }

    //public class RunState : StateBase
    //{
    //    public override void OnEnter()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override StateBase HandleInput(FSMBase fsm, ParamBase param)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnExit()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnUpdate()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public class JumpState : StateBase
    //{
    //    public override void OnEnter()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override StateBase HandleInput(FSMBase fsm, ParamBase param)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnExit()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnUpdate()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public class DropState : StateBase
    //{
    //    public override void OnEnter()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override StateBase HandleInput(FSMBase fsm, ParamBase param)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnExit()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnUpdate()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public class LightATK_01_State : StateBase
    //{
    //    public override void OnEnter()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override StateBase HandleInput(FSMBase fsm, ParamBase param)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnExit()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnUpdate()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public class LightATK_02_State : StateBase
    //{
    //    public override void OnEnter()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override StateBase HandleInput(FSMBase fsm, ParamBase param)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnExit()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnUpdate()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public class LightATK_03_State : StateBase
    //{
    //    public override void OnEnter()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override StateBase HandleInput(FSMBase fsm, ParamBase param)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnExit()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void OnUpdate()
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}
