using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ItemTab : Tab
{
    [SerializeField] private List<Hair> _items;
    [SerializeField] private GameObject _itemSelectorPrefab;

    protected void Awake()
    {
        //Create buttons for grid container.
        foreach (var item in _items)
        {
            var itemSelector = Instantiate(_itemSelectorPrefab,tabContent.transform).GetComponent<ItemSelector>();
            itemSelector.SetOwner(this);
            itemSelector.SetName(item.HairName);
            itemSelector.SetHairSprite(item.HairSprite);
        }
    }
}
