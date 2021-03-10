using System;
using System.Collections;
using System.Collections.Generic;

/*
 * 使得参数类可在Unity编辑器中可见
 */

/*
 * 注意！Serializable属性无法被继承
 * 无论基类还是派生类都必须重复打上[Serializable]标签来进行序列化
 */

[Serializable]
public abstract class ParamBase
{
    /*
     * 参数基类中定义一些所有物体均拥有的属性，若无可为空。
     */

    // public float something;
}
