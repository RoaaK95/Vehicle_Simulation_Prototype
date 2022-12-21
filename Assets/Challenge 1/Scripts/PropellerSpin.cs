using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    
    private Vector3 rotateVector = new Vector3(0, 0, 1);
    public float rotationSpeed = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateVector * rotationSpeed);
    }
}
