using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopifyIntegrate : MonoBehaviour
{

    public GameObject ShopifyPrefab;
    private ShopPopup shop;
    
    

    // Start is called before the first frame update
    void Start()
    {
        shop = ShopifyPrefab.gameObject.GetComponent<ShopPopup>();
         
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
                shop.ShowPopup();
            }

            

        }

    }
}
