using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public TMP_InputField inputField;

    public string playerName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        playerName = inputField.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }
}
