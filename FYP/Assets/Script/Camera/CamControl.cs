using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    private Animator cam;
    public GameObject followCam;
    public GameObject doorCam1;
    public GameObject doorCam2;

    // Update is called once per frame
    void Start()
    {
        cam = doorCam1.GetComponent<Animator>();
    }

    void Update()
    {
        if(cam != null)
        {
           //need to be replace
            if (Input.GetKeyDown(KeyCode.B))
            {
                DoorCamPush();
            }
        }

        //need to be replace
        if (Input.GetKeyDown(KeyCode.F))
        {
            followCam.SetActive(false);
            doorCam1.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            followCam.SetActive(true);
            doorCam1.SetActive(false);
        }
    }
    public void DoorCamPush()
    {
        cam.SetTrigger("DoorCam");
    }

    /*public void SwitchDoorCam()
    {

    }*/
}
