using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (camera1.activeInHierarchy)
            { 
                camera1.SetActive(false);
                camera2.SetActive(true); 
            }
            else if (camera2.activeInHierarchy)
            {
                camera2.SetActive(false);
                camera1.SetActive(true);
            }
        }
    }
}
