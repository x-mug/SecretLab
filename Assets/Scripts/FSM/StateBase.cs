using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: 单例模式，会不会造成死锁

/* 状态基类定义了一个基本状态必须拥有的方法，可以pass */
/* 所有状态类默认为单例，方便管理与引用 */

/* 
 * OnUpdate函数中定义无需接受输入，随世界与时间变化的方法（多为AI部分，与无碰撞器的部分有关）
 * HandleInput函数中定义接收到输入，指定对象做出的特定反馈（多与玩家与其他物体有关，与有碰撞器的部分有关）
 * OnEnter函数中定义指定对象进入该状态时的默认动作（类似于构造函数，不过每次进入该状态都会重新构造）
 * OnExit函数中定义指定对象离开并切换状态时的清理动作（类似析构函数，不过不会删除状态本身，但是会清除一些冗余）
 */

public abstract class StateBase
{
    /* 
     * 作为状态基类，应指明所有状态均需要处理输入
     * 所有状态均需要编写输入判断，指明下一个状态
     */

    public abstract void OnEnter(FSMBase _fsm);

    public abstract void HandleInput(FSMBase _fsm);

    public abstract void OnExit(FSMBase _fsm);

    /*
     * 所有状态也可能出现需要持续作用的方法，例如：蓄力
     */

    public abstract void OnUpdate(FSMBase _fsm);
}
