using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvas : Page
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private CurrentUser currentUser;
    [SerializeField] private EnterCanvas enterCanvas;
    [SerializeField] private Button buttonToExit;
    [SerializeField] private Button buttonOrderCar;
    [SerializeField] private Button buttonChange;
    [SerializeField] private Button buttonStory;
    [SerializeField] private OrderCanvas orderCanvas;
    

    private void Awake()
    {
        buttonToExit.onClick.AddListener(() =>
        {
            currentUser.DeleteUser();
            this.HideCanvas();
            enterCanvas.ShowCanvas();
        });
        
        buttonOrderCar.onClick.AddListener(() =>
        {
            this.HideCanvas();
            orderCanvas.ShowCanvas();
        });
        
        buttonChange.onClick.AddListener(() =>
        {

        });
        
        buttonStory.onClick.AddListener(() =>
        {

        });
    }

    #region PageMethods

    public override void HideCanvas()
    {
        base.HideCanvas();
    }

    public override void ShowCanvas()
    {
        base.ShowCanvas();
        nameText.text = CarsharingDB.GetUserName(currentUser.user_ID);

    }

    #endregion
}