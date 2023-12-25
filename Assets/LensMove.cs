using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LensMove : MonoBehaviour
{
    public GameObject cam2;
    public Button but;
    private Vector3 mousepos;
    private Vector3 mousepos2;
    private Camera cam;
    

    
    void Start()
    {
        cam = Camera.main;
        but.onClick.AddListener(test);
    }
    void test()
    {
        cam2.SetActive(!cam2.activeInHierarchy);
    }
  
    void OnGUI()
    {
        
      
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x-100, mousePos.y+100, cam.nearClipPlane + 21));
        cam2.transform.position = point;
        
       

    }


}
