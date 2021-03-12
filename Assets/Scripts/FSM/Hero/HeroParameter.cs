using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 存储挂载对象的所有属性
 */

[Serializable]
public class HeroParameter : ParamBase
{
    public float hp;
    public float mp;
    public float speedScale;
    public float jumpScale;
    public int jumpLimit;
    [HideInInspector]
    public int jumpTimes;

    /*
     * 获取一些必要的组件
     */
    public Transform transform;
    public Rigidbody2D rb;
    public Animator anim;
    public AudioSource[] audioSource;

    /*
     * 如果需要武器，请写在单独的武器状态和状态机中，以保证可拓展性
     */
}
