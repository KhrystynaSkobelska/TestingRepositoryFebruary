using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEventSubscriber : MonoBehaviour
{
    [SerializeField] private TestingEventSystem testES;

    // Update is called once per frame
    void Start()
    {
        testES.SetCubeColor(Color.green , () => { Debug.Log("The colr was changed successfully!"); });
    }

    
}
