﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopTab
{
    [SerializeField] Sprite tabIcon;
    [SerializeField] List<Item> shopItems;

    GameObject shopItemsGrid;

    public Sprite GetShopTabIcon()
    {
        return tabIcon;
    }

    public List<Item> getShopItems()
    {
        return shopItems;
    }

    public GameObject ShopItemsGrid
    {
        get
        {
            return shopItemsGrid;
        }

        set
        {
            shopItemsGrid = value;
        }
    }

    public int GetPagesCount()
    {
        int pagesCount = Mathf.CeilToInt(shopItems.Count / 8.0f);
        return pagesCount;
    }
}
