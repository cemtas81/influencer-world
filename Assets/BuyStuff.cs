using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyStuff : MonoBehaviour
{
    public GameObject shoeShelf;
    private Transform cam;
    public GameObject joystick;
    private Rigidbody rigid;
    public GameObject ask;
    public Button shoe;
    public Button leave;
    public Button exit;
    public Transform camoriginal;
    public GameObject speech;
    public GameObject getout;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
        rigid = GetComponent<Rigidbody>();
        shoe.onClick.AddListener(shoebuy);
        leave.onClick.AddListener(leav);
        exit.onClick.AddListener(exit1);
    }
    void exit1()
    {
        rigid.constraints = RigidbodyConstraints.None;
        rigid.constraints = RigidbodyConstraints.FreezeRotation;
        shoeShelf.SetActive(!shoeShelf.activeInHierarchy);
        cam.position = camoriginal.position;
        cam.rotation = camoriginal.rotation;
        speech.SetActive(!speech.activeInHierarchy);
        getout.SetActive(!getout.activeInHierarchy);
    }
    void leav()
    {
        Time.timeScale = 1f;
        ask.SetActive(!ask.activeInHierarchy);
    }
    void shoebuy()
    {
        shoeShelf.SetActive(true);
        cam.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z + 1f);
        rigid.constraints = RigidbodyConstraints.FreezeAll;
        cam.Rotate(Vector3.up, 180);
        Time.timeScale = 1f;
        ask.SetActive(!ask.activeInHierarchy);
        speech.SetActive(!speech.activeInHierarchy);
        getout.SetActive(!getout.activeInHierarchy);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="buyshoes")
        {
            ask.SetActive(true);
            Time.timeScale = 0f;
            
        }
    }

}
