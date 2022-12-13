using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CurrentUser : MonoBehaviour
{
    [SerializeField] private MainCanvas mainCanvas;
    [SerializeField] private EnterCanvas enterCanvas;
    private const string USER_ID = "USER_ID";
    public int user_ID;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(USER_ID))
        {
            user_ID = PlayerPrefs.GetInt(USER_ID);
            enterCanvas.HideCanvas();
            mainCanvas.ShowCanvas();
        }
    }

    public void SaveUser(int user_ID)
    {
        PlayerPrefs.SetInt(USER_ID, user_ID);
        this.user_ID = user_ID;
    }

    public void DeleteUser()
    {
        PlayerPrefs.DeleteKey(USER_ID);
    }

#if UNITY_EDITOR
    
    [MenuItem("PlayerPrefs/Clear")]
    public static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    
#endif
}