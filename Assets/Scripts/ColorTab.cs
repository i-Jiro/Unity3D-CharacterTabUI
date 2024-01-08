using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ColorTab : Tab
{
    
    [SerializeField] private GameObject _colorSelectorPrefab;
    [SerializeField] private List<SkinColor> _colors = new List<SkinColor>();

    protected void Awake()
    {
        //Create color buttons for grid container.
        foreach (var color in _colors)
        {
           var colorButton = Instantiate(_colorSelectorPrefab, tabContent.transform).GetComponent<ColorSelector>();
           colorButton.SetColor(color.Color);
           colorButton.SetOwner(this);
        }
    }
}
