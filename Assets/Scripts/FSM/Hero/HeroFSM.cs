using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 实现挂载对象的通用函数(类似Util)
 */

public class HeroFSM : FSMBase
{
    /*
     * 派生状态机需要将状态注册在这里
     */

    public HeroParameter parameter;
    /*
     * TODO：暂时这样写，没有想到如何强制派生类给基类传变量
     */

    private void Start()
    {
        base.Init(HeroStates.idleState, parameter);
    }

    private void Update()
    {
        /*
         * 持续检测AnyState
        */

        HeroStates.anyState.HandleInput(this);
        HeroStates.anyState.OnUpdate(this);

        base.OnUpdate();
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
