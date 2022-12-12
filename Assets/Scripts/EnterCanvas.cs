using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnterCanvas : Page
{
    [SerializeField] private Button enterButton;
    [SerializeField] private TMP_InputField nameField;
    [SerializeField] private MainCanvas mainCanvas;

    private void Awake()
    {
        nameField.onEndEdit.AddListener((name) =>
        {
            
        });

        enterButton.onClick.AddListener(() =>
        {
            this.gameObject.SetActive(false);
            mainCanvas.gameObject.SetActive(true);
        });
        
        
    }
}