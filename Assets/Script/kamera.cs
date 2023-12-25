using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class kamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.10f;
    public Vector3 offset;
    public static bool kamera_takip;
    public static Vector3 konum;
    // Start is called before the first frame update
    void Start()
    {
        kamera_takip = true;
    }
    private void FixedUpdate()
    {
        if(kamera_takip)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        else
        {
           
           if(transform.position.z<konum.z)
            {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = new Vector3(offset.x, offset.y, smoothedPosition.z);
            }
            else
            {
                Debug.Log("konum=" + konum);
                Debug.Log("kamera konum=" + transform.position);
            }

            /*if (target.position.y<7)
            {
                transform.DOLookAt(target.transform.position,0.2f);
                transform.position = new Vector3(0, smoothedPosition.y, smoothedPosition.z);
            }
            else
            {
                transform.position = new Vector3(0, 9, smoothedPosition.z);
            }*/
        }
        
    }
    // Update is called once per frame
    
}
