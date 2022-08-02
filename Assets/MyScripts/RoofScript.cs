using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofScript : MonoBehaviour
{
    public GameObject roof;
    // Start is called before the first frame update
    void Start()
    {
        roof.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            roof.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            roof.SetActive(true);
        }
    }

}
