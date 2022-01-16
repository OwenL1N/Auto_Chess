using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager<T> : MonoBehaviour
    where T : Manager<T>
{
    // static instance of a manager
    public static T instance;

    // assures only one is made (singleton)
    protected void Awake() {
        instance = (T) this;
    }

}
