//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class PopUp : MonoBehaviour
{
    private GameObject Yeni_takipci_prefab, Video_rec_prefab, Yorum_prefab, Sponsor_prefab;
    private GameObject dokunuan_obje,kanvas;
    private float waitTime = 10f;

    //kaydırma deneme
    RectTransform cerceve;
    RectTransform pupupObj;
    public float speed;
    float horizontalSpeedMultiplier = 1f; // +1 moves right, -1 moves left
    float verticalSpeedMultiplier = -1f; // +1 moves upward, -1 moves downward


    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<Image>().fillAmount = 1f;
        pupupObj = gameObject.GetComponent<RectTransform>();
        cerceve = GameObject.Find("popup_cerceve").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).GetComponent<Image>().fillAmount -= 1.0f / waitTime * Time.deltaTime;
        if(transform.GetChild(0).GetComponent<Image>().fillAmount==0)
        {
            Destroy(gameObject);
        }
        speed = 2f;
        transform.DOLocalMove(new Vector3(transform.localPosition.x+horizontalSpeedMultiplier * speed, transform.localPosition.y+verticalSpeedMultiplier * speed, 0f),0f);

        if (pupupObj.localPosition.y > cerceve.rect.yMax)
        {
            verticalSpeedMultiplier = -1f; 
        }

        if (pupupObj.localPosition.y < cerceve.rect.yMin)
        {
            verticalSpeedMultiplier = 1f;
        }

        if (pupupObj.localPosition.x < cerceve.rect.xMin)
        {
            horizontalSpeedMultiplier = 1f;
        }

        if (pupupObj.localPosition.x > cerceve.rect.xMax)
        {
            horizontalSpeedMultiplier = -1f;
        }
    }
    public void popupac()
    {
       //
      //  Debug.Log(GameObject.Find("Canvas").transform.childCount);
        int say = 0;
        /*if (EventSystem.current.currentSelectedGameObject.transform.parent.tag == "Yeni_takipci_prefab")
        {
            dokunuan_obje = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        }
        else if (EventSystem.current.currentSelectedGameObject.transform.parent.tag == "Video_rec_prefab")
        {
            dokunuan_obje = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        }
        else if (EventSystem.current.currentSelectedGameObject.transform.parent.tag == "Yorum_prefab")
        {
            dokunuan_obje = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        }
        else if (EventSystem.current.currentSelectedGameObject.transform.parent.tag == "Sponsor_prefab")
        {
            dokunuan_obje = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        }
        else if (EventSystem.current.currentSelectedGameObject.transform.parent.tag == "Sponsor_reklam_prefab")
        {
            dokunuan_obje = EventSystem.current.currentSelectedGameObject.transform.parent.gameObject;
        }*/

        kanvas = GameObject.Find("Canvas");
        if (kanvas!=null)
        {
           // kanvas = GameObject.Find("Canvas");
            while (say < kanvas.transform.childCount)
            {
               // Debug.Log(EventSystem.current.currentSelectedGameObject.transform.parent.name);
                if (gameObject.tag== kanvas.transform.GetChild(say).tag)//(dokunuan_obje.tag== kanvas.transform.GetChild(say).tag)
                {
                    kanvas.transform.GetChild(say).gameObject.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<AlllGame>().popup_cerceve.SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<AlllGame>().popup_panel_hazirlik();
                    if(gameObject.tag=="Yeni_takipci_prefab")
                    {
                        GameObject.Find("Main Camera").GetComponent<AlllGame>().tbt_popup_ayarla();
                    }
                    else if (gameObject.tag == "Sponsor_prefab")
                    {
                        GameObject.Find("Main Camera").GetComponent<AlllGame>().sponsor_panel_resim_degistir();
                    }
                    else if (gameObject.tag == "Sponsor_reklam_prefab")
                    {
                        GameObject.Find("Main Camera").GetComponent<AlllGame>().sponsor_reklam_panel_resim_degistir();
                    }
                    Destroy(gameObject);
                    break;
                }
                say += 1;
            }
        }
        
    }
}
