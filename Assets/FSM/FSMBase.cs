using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FSMBase : MonoBehaviour
{
    private StateBase currentState;
    private ParamBase parameter;

    /*
     * 作为状态机基类，要求子类传入玩家属性
     */

    public virtual void Init(ParamBase param)
    {
        if(param != null)
            parameter = param;
        else
            throw new System.NotImplementedException();
    }

    /*
     * 所有状态机均需要处理状态的转换
     */

    public void TransactionState(StateBase state)
    {
        /*
         * 状态退出的收尾工作
         */

        //if(currentState!=null)
        //    currentState.OnExit()

        /*
         * 切换状态
         */

        currentState = state;

        /*
         * 调用状态的构造函数
         */

        // currentState.OnEnter();
    }

}
