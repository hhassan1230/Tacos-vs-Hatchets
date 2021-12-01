using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    public GameObject throwObj;
    public float launchVelocity = 700f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject thrownObj = GameObject.Instantiate(throwObj, gameObject.transform.position, gameObject.transform.rotation);
            thrownObj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0,launchVelocity));
        }
    }
}
