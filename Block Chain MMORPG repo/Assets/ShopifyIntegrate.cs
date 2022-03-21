using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopifyIntegrate : MonoBehaviour
{
    private LevelManager manager;
    //public GameObject ShopifyPrefab;
    private ShopPopup shopPopUP;
    public GameObject Shopify;
    

    // Start is called before the first frame update
    void Start()
    {
        Shopify = GameObject.Find("Shopify interactions");
        

        shopPopUP = Shopify.transform.gameObject.GetComponentInChildren<ShopPopup>();
         
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Shop"))
        {

            if (Input.GetKey(KeyCode.E))
            {
                shopPopUP.ShowPopup();
            }

            

        }

    }
}
