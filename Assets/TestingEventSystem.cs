using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingEventSystem : MonoBehaviour
{
    private Action OnSetColor;
    public Renderer cubeRenderer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSetColor();
        }
    }

    public void SetCubeColor(Color color, Action OnSetColor)
    {
        this.OnSetColor = OnSetColor;
        cubeRenderer.material.color = color;
    }
    
        
    
}
