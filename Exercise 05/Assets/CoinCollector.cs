using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour

{
    int coinsCollected = 0;
    public TMP_Text coinsCollectedCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            coinsCollected++;
            coinsCollectedCount.text = coinsCollected.ToString();
            Debug.Log(coinsCollected);
            Destroy(other.gameObject);
            //GameObject CoinEffect = (GameObject)Instantiate(coineffect, transform.position, transform.rotation);
            

        }
    }
}

