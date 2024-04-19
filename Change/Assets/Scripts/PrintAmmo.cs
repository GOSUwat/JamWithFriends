using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrintAmmo : MonoBehaviour
{

    public static Action<int> setValue;

    private TextMeshProUGUI gui;


    void SetValue(int val)
    {
        if(gui != null)
        {
            gui.text = $"AMMO : {val}";
        }
        
    }

    private void OnEnable()
    {
        setValue += SetValue;
    }

    private void OnDisable()
    {
        setValue -= SetValue;
    }

    void Start()
    {
        gui = GetComponent<TextMeshProUGUI>();
    } 
}
