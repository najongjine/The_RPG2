using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    public GameObject inventoryMenu;
    public GameObject openBook;
    public GameObject closedBook;

    public Image[] emptySlots;
    public Sprite[] icons;
    public Sprite emptyIcon;

    public static int redMushrooms = 0;
    public static int purpleMushrooms = 0;
    public static int brownMushrooms = 0;
    public static int blueFlowers = 0;
    public static int redFlowers = 0;
    public static int roots = 0;
    public static int leafDew = 0;
    public static int dragonEggs = 0;
    public static int bluePotions = 0;
    public static int purplePotions = 0;
    public static int greenPotions = 0;
    public static int redPotions = 0;
    public static int breads = 0;
    public static int cheeses = 0;
    public static int meats = 0;

    public static bool key = true;

    public static int newIcon = 0;
    public static int gold = 0;
    public static bool iconUpdate = false;
    int max;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        CloseMenu();
        max = emptySlots.Length;

        // Temp code
        redMushrooms = 0;
        purpleMushrooms = 0;
        brownMushrooms = 0;
        blueFlowers = 0;
        redFlowers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (iconUpdate)
        {
            for(int i = 0; i < max; i++)
            {
                if(emptySlots[i].sprite == emptyIcon)
                {
                    // max 를 조정해서 loop을 빠져나오는 기법
                    max = i;
                    emptySlots[i].sprite = icons[newIcon];
                    emptySlots[i].transform.gameObject.GetComponent<HintMessage>().objectType = newIcon;
                }
            }
            StartCoroutine(Reset());
        }
    }
    public void OpenMenu()
    {
        inventoryMenu.SetActive(true);
        openBook.SetActive(false);
        closedBook.SetActive(true);
        Time.timeScale = 0;
    }
    public void CloseMenu()
    {
        inventoryMenu.SetActive(false);
        openBook.SetActive(true);
        closedBook.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.1f);
        iconUpdate = false;
        max=emptySlots.Length;
    }

}
