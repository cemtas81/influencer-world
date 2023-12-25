using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Scope : MonoBehaviour
{
    public GameObject cam2;
    public GameObject cursor;
    private Vector3 mousepos;
    private Vector3 mousepos2;
    private Camera cam;
    //public GameObject camera;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = cam2.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        //mousepos = Input.mousePosition;
        mousepos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        //mousepos2 = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    private void OnMouseDown()
    {
        //cam2.SetActive(true);
        //camera.SetActive(false);
    }
    private void OnMouseUp()
    {
        //cam2.SetActive(false);
        //camera.SetActive(true);
    }
    private void OnMouseDrag()
    {
        cursor.transform.position = new Vector3(mousepos.x*10, mousepos.y*10,21);
        //cam2.transform.position = new Vector3(mousepos2.x, mousepos2.y, 0);
        //cursor.transform.position = new Vector3(mousepos2.x, mousepos2.y, 0);
       
    }
    
}
