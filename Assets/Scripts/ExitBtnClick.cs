using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitBtnClick : MonoBehaviour
{
    [SerializeField]
    private Button exitBtn;
    void Awake()
    {
        exitBtn.onClick.AddListener(CloseApp);
    }

    private void CloseApp()
    {
        Application.Quit();
    }

    void Update()
    {
        
    }
}
