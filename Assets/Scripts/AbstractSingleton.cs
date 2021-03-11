using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSingleton<T> : MonoBehaviour where T : AbstractSingleton<T>
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = (T)this;
            this.transform.DetachChildren();
            DontDestroyOnLoad(this);
        }
        else
            Destroy(this);
    }

    //public abstract void IMCALLED()
    //{
    //    print("IM CALLED FROM ABSTRACT BASE CLASS!");
    //}

    public virtual void IMCALLED()
    {
        print("IM CALLED FROM VIRTUAL BASE CLASS!");
    }
}
