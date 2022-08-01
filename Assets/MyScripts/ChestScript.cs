using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    Animator anim;
    public int goldAmount = 50;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (InventoryItems.key)
            {
                anim.SetTrigger("open");
                InventoryItems.gold += goldAmount;
                goldAmount = 0;
                Debug.Log($"## Gold amt: {InventoryItems.gold}");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (InventoryItems.key)
            {
                anim.SetTrigger("close");
            }
        }
    }
    public void DestoryChest()
    {
        Destroy(gameObject);
    }

}
