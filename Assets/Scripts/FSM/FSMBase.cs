using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 基本状态机所需要具备的一切特性
 */

public abstract class FSMBase : MonoBehaviour
{
    private StateBase defaultState;
    private StateBase currentState;

    /*
     * 作为状态机基类，要求子类传入玩家属性
     */

    public virtual void Init(StateBase defaultState, ParamBase parameter)
    {
        this.defaultState = defaultState;

        /*
         * 状态机进入默认状态
         */

        TransactionState(defaultState);
    }

    private void Update()
    {
        /* 
         * 持续处理Input与状态本身的update
         */

        currentState.HandleInput(this);
        currentState.OnUpdate(this);
    }


    /*
     * 所有状态机均需要处理状态的转换
     */

    public void TransactionState(StateBase state)
    {
        /*
         * 状态退出的收尾工作
         */

        if (currentState != null)
            currentState.OnExit(this);
        /*
         * 切换状态
         */

        currentState = state;

        /*
         * 调用状态的构造函数
         */

        currentState.OnEnter(this);
    }

}
