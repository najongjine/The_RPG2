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
            message.text = $"{InventoryItems.redMushrooms} red mushrooms to be used in potions";
        }
        if (objectType == 3)
        {
            message.text = $"{InventoryItems.redMushrooms} red mushrooms to be used in potions";
        }
        if (objectType == 4)
        {
            message.text = $"{InventoryItems.blueFlowers} blue flowers to be used in potions";
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
