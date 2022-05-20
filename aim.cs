using UnityEngine;
using System.Collections;
 
public class aim : MonoBehaviour
{
 
    public Camera aimCam;
    public Camera mainCam;
 
 
    void Update ()
    {
        if (Input.GetMouseButtonDown(1))
        {
            aimCam.enabled = true;
            mainCam.enabled = false;
        }
        if (Input.GetMouseButtonUp(1))
        {
            aimCam.enabled = false;
            mainCam.enabled = true;
        }
    }
}