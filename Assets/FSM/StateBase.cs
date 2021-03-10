using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateBase : MonoSingleton<StateBase>
{
    /* 
     * 作为状态基类，应指明所有状态均需要处理输入
     * 所有状态均需要编写输入判断，指明下一个状态
     */
    public abstract StateBase HandleInput(FSMBase fsm);

    /*
     * 所有状态也可能出现需要持续作用的方法，例如：蓄力
     */

    public abstract void OnUpdate();
}
