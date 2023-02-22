using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    
    public float forwardSpeed = .7f;
    //float rotateSpeed = 100f;
    public CoinCollector cc;
   

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.MoveForward == true)
        {
        float hAxis = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        }
        
    }
}
