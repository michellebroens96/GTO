﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Resource))]
public class ResourceUI : MonoBehaviour {

    public Text Label;
    public Text Value;

    private Resource resource;

    private void Awake()
    {
        resource = GetComponent<Resource>();
        //adds listener to when onvaluechanged is activated
        resource.OnValueChanged.AddListener(UpdateUI);
    }

    private void Start()
    {
        Label.text = resource.Name;
        Value.text = resource.Amount.ToString();
    }

    public void UpdateUI()
    {
        Value.text = resource.Amount.ToString();
    }
}
