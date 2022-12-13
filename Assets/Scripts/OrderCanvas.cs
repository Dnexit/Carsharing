using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderCanvas : Page
{
    [SerializeField] private Button buttonBack;
    [SerializeField] private MainCanvas mainCanvas;

    private void Awake()
    {
        buttonBack.onClick.AddListener(() =>
        {
            HideCanvas();
            mainCanvas.ShowCanvas();
            
        });
    }
}
