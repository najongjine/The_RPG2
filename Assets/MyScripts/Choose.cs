using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choose : MonoBehaviour
{
    public GameObject[] characters;
    int p = 0;
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    public void Next()
    {
        if(p<=characters.Length-1)
        {
            characters[p].SetActive(false);
            p++;
            if (p >= characters.Length)
            {
                p = characters.Length - 1;
            }
            characters[p].SetActive(true);
        }
    }
    public void Prev()
    {
        if (p >= 0)
        {
            characters[p].SetActive(false);
            p--;
            if (p < 0)
            {
                p = 0;
            }
            characters[p].SetActive(true);
        }
    }
    public void Accept()
    {
        SaveScript.pchar = p;
        SaveScript.pname = playerName.text;
        SceneManager.LoadScene(1);
    }

}
