using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GangDance : MonoBehaviour
{
    public Button house;
    public Button hip;
    private Animator ani;
    public GameObject fail;
    public GameObject cluby;
    private ClubMove club;
    public bool h;
    public bool b;
    IEnumerator Start()
    {
        club =cluby. GetComponent<ClubMove>();
        ani = GetComponent<Animator>();
        while (true)
        {
            yield return new WaitForSeconds(3);
            house.onClick.AddListener(House);
            hip.onClick.AddListener(Hip);
        }
    }
    void House()
    {
        if (fail.activeSelf == false)
        {
            if (b==false&&h==false)
            {
                ani.SetInteger("danceindex", 0);
                ani.SetTrigger("dances");
                StartCoroutine(nodance());
                ani.SetBool("nodance", false);
            }
           
        }
        if (fail.activeSelf ==true)
        {
            ani.ResetTrigger("dances");
            ani.SetBool("nodance", true);
        }
       
    }
    void Hip()
    {
        if (fail.activeSelf == false)
        {
            if (b == false && h==false)
            {
                ani.SetInteger("danceindex", 1);
                ani.SetTrigger("dances");
                StartCoroutine(nodance2());
                ani.SetBool("nodance", false);
            }
            
        }
        if (fail.activeSelf == true)
        {
            ani.ResetTrigger("dances");
            ani.SetBool("nodance", true);
        }
    }
    IEnumerator nodance()
    {
        yield return new WaitForSeconds(19.23f);
        ani.ResetTrigger("dances");
        ani.SetBool("nodance", true);
    }
    IEnumerator nodance2()
    {
        yield return new WaitForSeconds(13.18f);
        ani.ResetTrigger("dances");
        ani.SetBool("nodance", true);
    }
    private void Update()
    {
        if (fail.activeSelf == true)
        {
            ani.SetBool("nodance", true);
            //ani.enabled = false;
        }
        //if (fail.activeSelf == false)
        //{
        //    ani.SetBool("nodance", false);
        //    //ani.enabled = true;
        //}
        if (h == true || b == true)
        {
            ani.SetBool("nodance", false);
        }
        h = club.house;
        b = club.breakdance;
    }

}
