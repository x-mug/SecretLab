using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_FSM : FSMBase
{
    /*
     * 派生状态机需要将状态注册在这里
     */

    public Hero_Parameter parameter;
    /*
     * TODO：暂时这样写，没有想到如何强制派生类给基类传变量
     */

    private void Awake()
    {
        base.Init(parameter);
    }
}
