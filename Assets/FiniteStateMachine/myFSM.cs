using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class myFSM : MonoBehaviour
{
    /*
     * 状态应当拥有数值，hp、mp、速度、攻击力、攻击距离等等
     */

    /*
     * 基类状态中，每个状态都需要处理相应的输入来转化状态
     * 为了方便使用，不同个体应当都可以拥有状态，因此传入个体索引
     */

    //public override void HandleInput(GameObject gameObject, Input input)
    //{
    //    // if(Input fufill condition)
    //    // {
    //    //      Do Something;
    //    //      Transact State to another state
    //    // }
    //    throw new NotImplementedException();
    //}

    /*
     * 预留出可以随游戏运行而改变的方法，例如：蓄力、连续受伤、持续减速
     */
    //public override void OnUpdate()
    //{
    //    throw new NotImplementedException();
    //}


}