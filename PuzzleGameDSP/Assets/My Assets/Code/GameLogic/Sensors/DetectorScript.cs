using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public bool queenInSensor = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Queen")
        {
            queenInSensor = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Queen")
        {
            queenInSensor = false;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
