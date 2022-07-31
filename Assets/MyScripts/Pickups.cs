using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public int number;

    public bool redMushRoom = false;
    public bool blueFlower = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (redMushRoom)
            {
                if (InventoryItems.redMushrooms == 0)
                {
                    DisplayIcons();
                }
                InventoryItems.redMushrooms++;
                Destroy(gameObject);
            }
            else if (blueFlower)
            {
                if (InventoryItems.blueFlowers == 0)
                {
                    DisplayIcons();
                }
                InventoryItems.blueFlowers++;
                Destroy(gameObject);
            }
            else
            {
                DisplayIcons();
                Destroy(gameObject);
            }
        }
    }

    private void DisplayIcons()
    {
        InventoryItems.newIcon = number;
        InventoryItems.iconUpdate = true;
    }
}
