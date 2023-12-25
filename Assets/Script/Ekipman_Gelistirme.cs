
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ekipman_Gelistirme : MonoBehaviour
{
    // Start is called before the first frame update
    public void baslangic_kontrol()
    {
        
       /* if(PlayerPrefs.GetInt("" + gameObject.name)==0)
        {
            if (gameObject.name == "sandalye")
            {
                if (GameObject.Find("ilk_sandalye"))
                    GameObject.Find("ilk_sandalye").SetActive(true);
            }
            else if (gameObject.name == "masa")
            {
                if (GameObject.Find("ilk_masa"))
                    GameObject.Find("ilk_masa").SetActive(true);
            }
            else if (gameObject.name == "telefon")
            {
                Texture[] obje = GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_mat_sprite;
                int x = PlayerPrefs.GetInt("" + gameObject.name);
               
                GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_mat.mainTexture = obje[0];
                transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_liste[0];
            }
            else if (gameObject.name == "bilgisayar")
            {
               GameObject obje2 = GameObject.Find("bilgisayarlar");
                for (int i = 0; i < obje2.transform.childCount; i++)
                {
                    obje2.transform.GetChild(i).gameObject.SetActive(false);
                }
                obje2.transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().bilgisayar_liste[0];
            }
            else if (gameObject.name == "saat")
            {
                GameObject obje = GameObject.Find("saatler");
                for (int i = 0; i < obje.transform.childCount; i++)
                {
                    obje.transform.GetChild(i).gameObject.SetActive(false);
                }
                
                transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().saat_liste[0];
            }
        }
        else
        {
            transform.GetChild(6).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
            transform.GetChild(8).GetComponent<Text>().text = "" + AllPP.gelistirme_fiyat[PlayerPrefs.GetInt("" + gameObject.name) - 1];
            transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + gameObject.name) % 5) * 0.2f;
            transform.GetChild(3).gameObject.GetComponent<Text>().text = "Lv " + PlayerPrefs.GetInt("" + gameObject.name);
            transform.GetChild(4).gameObject.GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + gameObject.name)) + "%</color>" + "click/money";
            transform.GetChild(5).gameObject.GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + gameObject.name)) + "%</color>" + "click/follower";

            if (gameObject.name == "sandalye")
            {
                if (GameObject.Find("ilk_sandalye"))
                    GameObject.Find("ilk_sandalye").SetActive(false);
                GameObject obje = GameObject.Find("sandalyeler");
                for (int i = 0; i < obje.transform.childCount; i++)
                {
                    obje.transform.GetChild(i).gameObject.SetActive(false);
                }
                int x = PlayerPrefs.GetInt("" + gameObject.name);
                if (x / 5 > obje.transform.childCount - 1)
                {
                    x = (obje.transform.childCount - 1) * 5;
                    obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().sandalyelar_list[obje.transform.childCount - 1];
                }
                else
                {
                    obje.transform.GetChild((x / 5)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().sandalyelar_list[x / 5];
                }
            }
            else if (gameObject.name == "isik")
            {
                GameObject obje = GameObject.Find("isiklar");
                for (int i = 0; i < obje.transform.childCount; i++)
                {
                    obje.transform.GetChild(i).gameObject.SetActive(false);
                }
                int x = PlayerPrefs.GetInt("" + gameObject.name);
                if (x / 5 > obje.transform.childCount - 1)
                {
                    x = (obje.transform.childCount - 1) * 5;
                    obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[obje.transform.childCount - 1];
                }
                else
                {
                    obje.transform.GetChild((x / 5)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];

                }
            }
            else if (gameObject.name == "masa")
            {
                if (GameObject.Find("ilk_masa"))
                    GameObject.Find("ilk_masa").SetActive(false);
                GameObject obje = GameObject.Find("masalar");
                for (int i = 0; i < obje.transform.childCount; i++)
                {
                    obje.transform.GetChild(i).gameObject.SetActive(false);
                }
                int x = PlayerPrefs.GetInt("" + gameObject.name);
                if (x / 5 > obje.transform.childCount - 1)
                {
                    x = (obje.transform.childCount - 1) * 5;
                    obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().masalar_list[obje.transform.childCount - 1];
                }
                else
                {
                    obje.transform.GetChild((x / 5)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().masalar_list[x / 5];
                }
            }
            else if (gameObject.name == "saat")
            {
                GameObject obje = GameObject.Find("saatler");
                for (int i = 0; i < obje.transform.childCount; i++)
                {
                    obje.transform.GetChild(i).gameObject.SetActive(false);
                }
                int x = PlayerPrefs.GetInt("" + gameObject.name);
                if (x / 5 > obje.transform.childCount - 1)
                {
                    x = (obje.transform.childCount - 1) * 5;
                    obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true); 
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().sandalyelar_list[obje.transform.childCount - 1];
                }
                else
                {
                    obje.transform.GetChild((x / 5)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().sandalyelar_list[x / 5];
                }
            }
            else if (gameObject.name == "telefon")
            {
                Texture[] obje = GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_mat_sprite;
                int x = PlayerPrefs.GetInt("" + gameObject.name);
                if (x / 5 > obje.Length - 1)
                {
                    GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_mat.mainTexture=obje[obje.Length - 1];
                   // Debug.Log("mat isin=" + obje[obje.Length - 1].name);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_liste[obje.Length - 1];
                }
                else
                {
                    GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_mat.mainTexture=obje[x / 5];
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().telefon_liste[x / 5];
                    //Debug.Log("mat isin="+ obje[x / 5].name);
                }
            }
            else if (gameObject.name == "bilgisayar")
            {
                GameObject obje = GameObject.Find("bilgisayarlar");
                for (int i = 0; i < obje.transform.childCount; i++)
                {
                    obje.transform.GetChild(i).gameObject.SetActive(false);
                }
                int x = PlayerPrefs.GetInt("" + gameObject.name);
                if (x / 5 > obje.transform.childCount - 1)
                {
                    obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().bilgisayar_liste[obje.transform.childCount - 1];
                }
                else
                {
                    obje.transform.GetChild((x / 5)).gameObject.SetActive(true);
                    transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().bilgisayar_liste[x / 5];
                }
            }
        }*/
    }
    // Update is called once per frame
    
    public void Al_gelistir()
    {
       
            if(PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") >=System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text))
            {
                Debug.Log("satin aldım");
                GameObject.Find("Main Camera").GetComponent<AlllGame>().satinalma_fonk();
                PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text));
                PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + System.Int32.Parse(transform.GetChild(5).GetComponent<Text>().text.Substring(1, transform.GetChild(5).gameObject.GetComponent<Text>().text.Length - 1)));////////
                PlayerPrefs.SetInt("" + gameObject.name, PlayerPrefs.GetInt("" + gameObject.name) + 1);
                GameObject.Find("Game_Manager").GetComponent<json_ekipman>().ekipman_oyunici_guncelle(gameObject.name);
            //GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
            GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }
            else if(PlayerPrefs.GetInt("" + gameObject.name) > 0 && PlayerPrefs.GetFloat("para") >= System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text))
            {
                GameObject.Find("Main Camera").GetComponent<AlllGame>().satinalma_fonk();
                PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text));
                PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + System.Int32.Parse(transform.GetChild(5).GetComponent<Text>().text.Substring(1, transform.GetChild(5).gameObject.GetComponent<Text>().text.Length - 1)));
                PlayerPrefs.SetInt("" + gameObject.name, PlayerPrefs.GetInt("" + gameObject.name) + 1);
                GameObject.Find("Game_Manager").GetComponent<json_ekipman>().ekipman_oyunici_guncelle(gameObject.name);
            // GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
            GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }
            else
            {
                GameObject.Find("Main Camera").GetComponent<AlllGame>().yetersiz_para_fonk();
                Debug.Log("Paran yetmedi fakir");
            }
        
    }
    public int fiyat_kontrol()
    {
        if (PlayerPrefs.GetFloat("para") >= System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text)&& System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text)>0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetFloat("para") >= System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text))
        {

            transform.GetChild(9).gameObject.SetActive(true);

        }
        else
        {
            transform.GetChild(9).gameObject.SetActive(false);
        }
    }
}
