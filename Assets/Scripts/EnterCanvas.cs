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
    [SerializeField] private CurrentUser currentUser;
    private int user_id;

    private void Awake()
    {
        nameField.onEndEdit.AddListener((user_ID) =>
        {
            if (user_ID != "" | user_ID != null | int.TryParse(user_ID, out int user_id_number))
            {
                enterButton.interactable = true;
                user_id = user_id_number;
            }
            else 
            {
                enterButton.interactable = false;
            }
            
        });

        enterButton.onClick.AddListener(() =>
        {
            if (CarsharingDB.CheckUser(user_id))
            {
                currentUser.SaveUser(user_id);
                HideCanvas();
                mainCanvas.ShowCanvas();
                
            }
            else
            {
                // тут если такого пользователя нет в БД
            }
        });

        enterButton.interactable = false;
    }
}