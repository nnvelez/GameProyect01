using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject Cam1, Cam2;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            index++;
            
        }
        if (index == 0)
            {
                Cam1.SetActive(true);
                Cam2.SetActive(false);
            }
        if (index==1)
        {
            
            
                Cam1.SetActive(false);
                Cam2.SetActive(true);
            
        }
        if (index == 2)
        {
            index = 0;
        }
    }
}