using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    Idle, Jump, Run, Drop, LightATK01, LightATK02, LightATK03
}

[Serializable]
public class Parameter
{
    public float HP;
    public float MP;
    public float speedScale;
    public float jumpScale;
    public float damage;
    public float attackFrequency;
}

public class FSM : AbstractSingleton<FSM>
{
    public Parameter parameter;

    private BaseState currentState;
    private Dictionary<StateType, BaseState> states = new Dictionary<StateType, BaseState>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransactionState(StateType type)
    {
        if (currentState != null)
            currentState.OnExit();
        currentState = states[type];
        currentState.OnEnter();
    }
}
