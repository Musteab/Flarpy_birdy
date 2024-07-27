using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipescrit : MonoBehaviour
{
    public float pipespeed = 5;
    public float deadzone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipespeed) * Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}