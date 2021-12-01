using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDeleter : MonoBehaviour
{
    public float waitTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(TurnOff());
    }
    
    IEnumerator TurnOff()
    {
        //print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return new WaitForSeconds(waitTime);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
