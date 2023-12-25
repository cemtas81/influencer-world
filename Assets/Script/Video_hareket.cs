using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Video_hareket : MonoBehaviour
{
    public DynamicJoystick dynamicJoystick;
    public GameObject kamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((5 - (25 * dynamicJoystick.Vertical)) < 10 && (5 - (25 * dynamicJoystick.Vertical)) > -3 && (135 + (25 * dynamicJoystick.Horizontal)) < 143 && (135 + (25 * dynamicJoystick.Horizontal)) > 127)
        {
            //  Debug.Log("içerde");
        }
        else
        {
            // Debug.Log("dışarda");
        }
    }
    public void deneme()
    {
        Debug.Log("girdim");
        kamera.transform.DORotate(new Vector3(5 - (25 * dynamicJoystick.Vertical), 135 + (25 * dynamicJoystick.Horizontal), 0), 0.1f);
    }
}
