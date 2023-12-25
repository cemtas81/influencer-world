using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
public class UserCar : MonoBehaviour
{
    public VariableJoystick joy;
    protected CarUserControl control;
    public Button door;
    public bool next;
    public GameObject player;
    public GameObject talk;
    public GameObject write;
    public GameObject bubble;
    public GameObject cam2;
    private GameObject cam;
    public GameObject indicator1;
   
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<CarUserControl>();
        door.onClick.AddListener(handle);
        next = false;
        cam = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        control.Hinput2 = joy.Horizontal;
        control.Vinput2 = joy.Vertical;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="detection")
        {
            next = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "detection")
        {
            next = false;
        }
    }
    void handle()
    {
        if (next==true)
        {
            indicator1.SetActive(!indicator1.activeInHierarchy);
            player.SetActive(!player.activeInHierarchy);
            cam2.SetActive(!cam2.activeInHierarchy);
            cam.SetActive(!cam.activeInHierarchy);
            bubble.SetActive(false);
            talk.SetActive(!talk.activeInHierarchy);
            write.SetActive(false);
            GetComponent<CarUserControl>().enabled = !GetComponent<CarUserControl>().enabled;
            GetComponent<CarController>().enabled = !GetComponent<CarController>().enabled;
            //player.transform.position = new Vector3(this.gameObject.transform.position.x - 2, 0, this.gameObject.transform.position.z);
            player.transform.localPosition = new Vector3(transform.localPosition.x-2,0,transform.localPosition.z);
        }
    }
}
