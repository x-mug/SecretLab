using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 实现挂载对象的通用函数(类似Util)
 */

public class Hero_FSM : FSMBase
{
    /*
     * 派生状态机需要将状态注册在这里
     */

    public Hero_Parameter parameter;
    /*
     * TODO：暂时这样写，没有想到如何强制派生类给基类传变量
     */

    private void Start()
    {
        base.Init(Hero_States.IdleState.Instance, parameter);
    }
}
