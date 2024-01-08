using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemSelector : Selector
{
    [Header("Component References")]
    [SerializeField] private Image _buttonImage;
    [SerializeField] private Image _itemImage;
    [SerializeField] private TextMeshProUGUI _itemText;
    [Header("Button Sprites")]
    [SerializeField] private Sprite _selectedSprite;
    [SerializeField] private Sprite _unselectedSprite;
    [Header("Properties")]
    [SerializeField] private Color _activeColor;
    [SerializeField] private Color _inactiveColor;

    protected void Start()
    {
        _buttonImage.sprite = _unselectedSprite;
        _itemText.color = _inactiveColor;
    }

    public void SetName(string name)
    {
        _itemText.text = name;
    }
    
    public void SetHairSprite(Sprite sprite)
    {
        _itemImage.sprite = sprite;
    }
    
    public override void Select()
    {
        _buttonImage.sprite = _selectedSprite;
        _itemText.color = _activeColor;
        owner.SetActiveItem(this);
    }

    public override void Deselect()
    {
        _itemText.color = _inactiveColor;
        _buttonImage.sprite = _unselectedSprite;
    }
}
