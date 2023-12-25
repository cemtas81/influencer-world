using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_konumlar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ucak;
    private Vector3 ev_konum,deneme,deneme2;
    public GameObject harita;
    public GameObject foto_kamera;
    public GameObject animasyon_panel_UI;
    public GameObject[] konum_popuplar;
    private GameObject popup;
    private GameObject buton;
    private float zaman;
    private GameObject obj;
    private float kalan_zaman;
    void Start()
    {
        ev_konum = ucak.transform.localPosition;
        deneme = harita.transform.position;
        // Debug.Log("//deneme konum//" + deneme);
        // transform.GetChild(0).gameObject.SetActive(false);
        zaman = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (zaman!=0&&Time.time>zaman+120)
        {
            zaman = 0;
            buton.GetComponent<Button>().interactable = true;
            buton.transform.parent.transform.GetChild(2).transform.GetChild(0).gameObject.SetActive(false);
            Debug.Log("açtım");
        }
        else if (zaman != 0 && Time.time < zaman + 120)
        {
            buton.transform.parent.transform.GetChild(2).transform.GetChild(0).gameObject.SetActive(true);
            kalan_zaman = (zaman + 120)-Time.time;
            //var ts = System.TimeSpan.FromSeconds(kalan_zaman);
            buton.transform.parent.transform.GetChild(2).transform.GetChild(0).gameObject.GetComponent<Image>().fillAmount =1- (kalan_zaman / 120);
           // buton.transform.parent.transform.GetChild(6).gameObject.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
        }
    }
    public void popup_ackapa()
    {
        for (int i = 0; i < konum_popuplar.Length; i++)
        {
            if(konum_popuplar[i].gameObject.name==gameObject.name)
            {
                popup = konum_popuplar[i].gameObject;
            }
        }
        if(popup.gameObject.activeSelf)
        {
            popup.gameObject.SetActive(false);
            gameObject.GetComponent<Animator>().Play("Base Layer.Level_button_anim", 0, 0);
            gameObject.GetComponent<Animator>().speed = 1;
        }
        else
        {
            for (int i = 0; i < konum_popuplar.Length; i++)
            {
                konum_popuplar[i].gameObject.SetActive(false);
            }
            popup.gameObject.SetActive(true);
            gameObject.GetComponent<Animator>().Play("Base Layer.Level_button_anim", 0,0);
            gameObject.GetComponent<Animator>().speed = 0;
        }
        GameObject.Find("Main Camera").GetComponent<AlllGame>().button_ses_fok();
    }
    public void button_kapa()
    {
        for (int i = 0; i < konum_popuplar.Length; i++)
        {
            if (konum_popuplar[i].gameObject.name == gameObject.name)
            {
               buton=konum_popuplar[i].gameObject.transform.GetChild(2).gameObject;
            }
        }
        buton.GetComponent<Button>().interactable = false;
        zaman = Time.time;
        Debug.Log("kapadım");
    }
    public void ucak_git()
    {
        for (int i = 0; i < konum_popuplar.Length; i++)
        {
            if (konum_popuplar[i].gameObject.name == gameObject.name)
            {
                obj = konum_popuplar[i].gameObject;
            }
        }
        if(PlayerPrefs.GetFloat("para") >= System.Int32.Parse(obj.transform.GetChild(4).gameObject.GetComponent<Text>().text))
        {
            PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(obj.transform.GetChild(4).gameObject.GetComponent<Text>().text));
            for (int i = 0; i < konum_popuplar.Length; i++)
            {
                if (konum_popuplar[i].gameObject.name == gameObject.name)
                {
                    buton = konum_popuplar[i].gameObject.transform.GetChild(2).gameObject;
                }
            }
            for (int i = 0; i < konum_popuplar.Length; i++)
            {
                if (konum_popuplar[i].gameObject.name == gameObject.name)
                {
                    popup = konum_popuplar[i].gameObject;
                }
            }
            AlllGame.exit_fonk_bak = false;
            deneme2 = harita.transform.position;
            PlayerPrefs.SetInt("ucak_pa", PlayerPrefs.GetInt("ucak_pa") + System.Int32.Parse(popup.transform.GetChild(1).GetComponent<Text>().text.Substring
                (1, popup.gameObject.transform.GetChild(1).GetComponent<Text>().text.Length - 2)));
            popup_ackapa();
            konum_degistir(gameObject);
            animasyon.ulke_name = popup.gameObject.transform.GetChild(5).name;
            animasyon.ulke_artis = System.Int32.Parse(popup.gameObject.transform.GetChild(1).gameObject.GetComponent<Text>().text.Substring(1, popup.gameObject.transform.GetChild(1).GetComponent<Text>().text.Length - 2));
        }
        else
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().yetersiz_para_fonk();
        }
    }
    public void konum_degistir(GameObject konum)
    {
        //int rnd = Random.Range(0, konumlar.Length);
        // rnd = sayac;
        ucak.transform.right = konum.transform.position - ucak.transform.position;
        if (ucak.transform.localPosition.x > konum.transform.localPosition.x)
        {
            ucak.transform.Rotate(-180, 0, 0);
        }
        harita.transform.DOMove(deneme, 0f);
        ucak.transform.DOLocalMove(konum.transform.localPosition, 3f);
       // Debug.Log("//nokta konum//" + konum.transform.position);
        harita.transform.DOMove(deneme2, 2.5f);
        StartCoroutine(scale_ayara());
        StartCoroutine(foto_ekran_ac());
        // sayac++;
        
    }
    public IEnumerator scale_ayara()
    {
        ucak.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 0.25f);
        yield return new WaitForSeconds(2.0f);
        ucak.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        yield return new WaitForSeconds(1.0f);
       // ucak.transform.localPosition = ev_konum;
    }
    public IEnumerator foto_ekran_ac()
    {
        
        yield return new WaitForSeconds(3.0f);
        AlllGame.exit_fonk_bak = true;
        ucak.transform.localPosition = ev_konum;
        animasyon.anim_bak = true;
        GameObject.Find("kiz_Final_etkinlik(pozlar)").GetComponent<pozlar>().poz_sec();
        GameObject fotolar = GameObject.Find("fotograflar").gameObject;
        for (int i = 0; i < fotolar.transform.childCount; i++)
        {
            //Debug.Log("fotolar.transform.GetChild(i).gameObject.name=" + fotolar.transform.GetChild(i).gameObject.name);
           // Debug.Log("popup.transform.GetChild(popup.transform.childCount - 1).gameObject.name=" + popup.transform.GetChild(popup.transform.childCount - 1).gameObject.name);
            if (fotolar.transform.GetChild(i).gameObject.name== popup.transform.GetChild(5).gameObject.name)
            {
                fotolar.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                
                fotolar.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        GameObject.Find("Main Camera").GetComponent<AlllGame>().foto_ekran_ac();
        button_kapa();
    }
    public void popup_kapa()
    {
        for (int i = 0; i < konum_popuplar.Length; i++)
        {
            konum_popuplar[i].gameObject.SetActive(false);
        }
        
    }
    }
