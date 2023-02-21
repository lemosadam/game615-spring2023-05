using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    float rotateSpeed = 100f;
    public float coinsCollected = 0;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        
    }
private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
       {
          Destroy(gameObject);
          //GameObject CoinEffect = (GameObject)Instantiate(coineffect, transform.position, transform.rotation);
            coinsCollected = coinsCollected++;

        }
    }
}

