using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HintMessage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hintBox;
    public TextMeshProUGUI message;
    bool displaying = true;
    bool overIcon = false;
    public int objectType = 0;

    Vector3 screenPoint;

    public void OnPointerEnter(PointerEventData eventData)
    {
        overIcon = true;
        if (displaying)
        {
            hintBox.SetActive(true);
            screenPoint.x = Input.mousePosition.x + 400;
            screenPoint.y = Input.mousePosition.y;
            screenPoint.z = 1f;
            hintBox.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
            MessageDisplay();
        }
    }

    private void MessageDisplay()
    {
        if (objectType==0)
        {
            message.text = "empty";
        }
        if (objectType == 1)
        {
            message.text = $"{InventoryItems.redMushrooms} red mushrooms to be used in potions";
        }
        if (objectType == 2)
        {
            message.text = $"{InventoryItems.purpleMushrooms} purple mushrooms to be used in potions";
        }
        if (objectType == 3)
        {
            message.text = $"{InventoryItems.brownMushrooms} brown mushrooms to be used in potions";
        }
        if (objectType == 4)
        {
            message.text = $"{InventoryItems.blueFlowers} blue flowers to be used in potions";
        }
        if (objectType == 5)
        {
            message.text = $"{InventoryItems.redFlowers} red flowers to be used in potions";
        }
        if (objectType == 6)
        {
            message.text = $"{InventoryItems.roots} roots to be used in potions";
        }
        if (objectType == 7)
        {
            message.text = $"{InventoryItems.leafDew} leaf dews to be used in potions";
        }
        if (objectType == 8)
        {
            message.text = $"key to open chests";
        }
        if (objectType == 9)
        {
            message.text = $"{InventoryItems.dragonEggs} dragon eggs to be used in potions";
        }
        if (objectType == 10)
        {
            message.text = $"{InventoryItems.bluePotions} blue potions to be used in potions";
        }
        if (objectType == 11)
        {
            message.text = $"{InventoryItems.purplePotions} purple potions to be used in potions";
        }
        if (objectType == 12)
        {
            message.text = $"{InventoryItems.greenPotions} green potions to be used in potions";
        }
        if (objectType == 13)
        {
            message.text = $"{InventoryItems.redPotions} red potions to be used in potions";
        }
        if (objectType == 14)
        {
            message.text = $"{InventoryItems.purpleMushrooms} bread used to replenish health";
        }
        if (objectType == 15)
        {
            message.text = $"{InventoryItems.cheeses} cheese used to replenish health";
        }
        if (objectType == 16)
        {
            message.text = $"{InventoryItems.meats} meat used to replenish health";
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        overIcon=false;
        hintBox.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (overIcon)
        {
            if (Input.GetMouseButtonDown(0))
            {
                displaying = false;
                hintBox.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            displaying = true;
        }
    }

}
