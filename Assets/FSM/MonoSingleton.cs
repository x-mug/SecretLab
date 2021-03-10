using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    public static T Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = (T)this;
            transform.DetachChildren();
            DontDestroyOnLoad(Instance);
        }
        else
            Destroy(this);
    }
}
