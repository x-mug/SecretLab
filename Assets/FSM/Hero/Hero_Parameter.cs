using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class Hero_Parameter : ParamBase
{
    public float hp;
    public float mp;
    public float speedScale;
    public float jumpScale;

    /*
     * 如果需要武器，请写在单独的武器状态和状态机中，以保证可拓展性
     */
}
