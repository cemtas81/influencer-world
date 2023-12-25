using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mobilya_alma : MonoBehaviour
{
    GameObject mobilya;
    // Start is called before the first frame update
    public void baslangic_kontrol()
    {
        if (transform.GetChild(1).gameObject.name=="1")
        {
            mobilya = GameObject.Find("mobilyalar");
        }
        else if (transform.GetChild(1).gameObject.name == "2")
        {
            mobilya = GameObject.Find("gym_mobilyalar");
        }
        else if (transform.GetChild(1).gameObject.name == "3")
        {
            mobilya = GameObject.Find("muzik_mobilyalar");
        }
        else if (transform.GetChild(1).gameObject.name == "4")
        {
            mobilya = GameObject.Find("mutfak_mobilyalar");
        }


        if (PlayerPrefs.GetInt("" + gameObject.name) == 2)
        {
            for (int i = 0; i < mobilya.transform.childCount; i++)
            {
                if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
                {
                    mobilya.transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            AllPP.mobilya_para_ek++;
            AllPP.mobilya_takipci_ek++;
        }
    }
    // Update is called once per frame
    public void mobilya_al()
    {
        if(AlllGame.mobilya_kontrol_bool)
        {
            if (transform.GetChild(1).gameObject.name == "1")
            {
                mobilya = GameObject.Find("mobilyalar");
            }
            else if (transform.GetChild(1).gameObject.name == "2")
            {
                mobilya = GameObject.Find("gym_mobilyalar");
            }
            else if (transform.GetChild(1).gameObject.name == "3")
            {
                mobilya = GameObject.Find("muzik_mobilyalar");
            }
            else if (transform.GetChild(1).gameObject.name == "4")
            {
                mobilya = GameObject.Find("mutfak_mobilyalar");
            }



            if (PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") >=
                    System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text) && 
                    System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text) !=0)
            {
                GameObject.Find("Main Camera").GetComponent<AlllGame>().satinalma_fonk();//satinalma ses
                transform.GetChild(6).gameObject.SetActive(false);
                transform.GetChild(7).gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(8).gameObject.SetActive(true);
                //GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
                PlayerPrefs.SetInt("" + gameObject.name, 2);
                GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera(transform.GetChild(0).gameObject.name);
                PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text));
                PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + System.Int32.Parse(transform.GetChild(5).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(5).gameObject.GetComponent<Text>().text.Length - 1)));
                /* for (int i = 0; i < mobilya.transform.childCount; i++)
                 {
                     if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
                     {
                         mobilya.transform.GetChild(i).gameObject.SetActive(true);
                     }
                 }*/
                StartCoroutine(mobilya_ac());
            }
            else if (PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") <
                System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text)&&
                    System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text) != 0)
            {
                GameObject.Find("Main Camera").GetComponent<AlllGame>().yetersiz_para_fonk();
            }
            else if(System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text) == 0&& PlayerPrefs.GetInt("" + gameObject.name) == 0)
            {
                Reklam.odul_bak = 11;
                Reklam.reklam_mobilya = gameObject;
                //GameObject.Find("Game_Manager").GetComponent<Reklam>().reklam_izlet();
                
            }
            else if (PlayerPrefs.GetInt("" + gameObject.name) == 1)
            {
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(8).gameObject.SetActive(true);

                PlayerPrefs.SetInt("" + gameObject.name, 2);

                for (int i = 0; i < mobilya.transform.childCount; i++)
                {
                    if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
                    {
                        mobilya.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
            }
            else if (PlayerPrefs.GetInt("" + gameObject.name) == 2)
            {
               /* transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(8).gameObject.SetActive(false);
                PlayerPrefs.SetInt("" + gameObject.name, 1);


                for (int i = 0; i < mobilya.transform.childCount; i++)
                {
                    if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
                    {
                        mobilya.transform.GetChild(i).gameObject.SetActive(false);
                    }
                }*/
            }
            else
            {
            }
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") >=
                System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text))
        {
            transform.GetChild(9).gameObject.SetActive(true);

        }
        else
        {
            transform.GetChild(9).gameObject.SetActive(false);
        }
    }
    public int fiyat_kontrol()
    {
        if (PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") >=
                System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text) && System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text) > 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    IEnumerator mobilya_ac()
    {
        AlllGame.mobilya_kontrol_bool = false;
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < mobilya.transform.childCount; i++)
        {
            if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
            {
                mobilya.transform.GetChild(i).gameObject.SetActive(true);
                Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, mobilya.transform.GetChild(i).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            }
        }
        yield return new WaitForSeconds(1.5f);
        if (transform.GetChild(1).gameObject.name == "1")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("main");
        }
        else if (transform.GetChild(1).gameObject.name == "2")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("gym_main");
        }
        else if (transform.GetChild(1).gameObject.name == "3")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("muzik_main");
        }
        else if (transform.GetChild(1).gameObject.name == "4")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("mutfak_main");
        }
        yield return new WaitForSeconds(1f);
        AlllGame.mobilya_kontrol_bool = true;
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
    }
    IEnumerator mobilya_ac2()
    {
        AlllGame.mobilya_kontrol_bool = false;
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < mobilya.transform.childCount; i++)
        {
            if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
            {
                mobilya.transform.GetChild(i).gameObject.SetActive(true);
                Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, mobilya.transform.GetChild(i).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            }
        }
        yield return new WaitForSeconds(1.5f);
        if (transform.GetChild(1).gameObject.name == "1")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("main");
        }
        else if (transform.GetChild(1).gameObject.name == "2")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("gym_main");
        }
        else if (transform.GetChild(1).gameObject.name == "3")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("muzik_main");
        }
        else if (transform.GetChild(1).gameObject.name == "4")
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera("mutfak_main");
        }
        yield return new WaitForSeconds(1f);
        AlllGame.mobilya_kontrol_bool = true;
        //GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
    }
    public void Reklamla_al()
    {
        GameObject.Find("Main Camera").GetComponent<AlllGame>().satinalma_fonk();//satinalma ses
        transform.GetChild(6).gameObject.SetActive(false);
        transform.GetChild(7).gameObject.SetActive(false);
        transform.GetChild(10).gameObject.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(8).gameObject.SetActive(true);
        //GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
        PlayerPrefs.SetInt("" + gameObject.name, 2);
        GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_alma_kamera(transform.GetChild(0).gameObject.name);
       // PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(transform.GetChild(7).gameObject.GetComponent<Text>().text));
        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + System.Int32.Parse(transform.GetChild(5).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(5).gameObject.GetComponent<Text>().text.Length - 1)));
        //GameAnalytics.NewDesignEvent("BedroomBuy:" + gameObject.name);
        /* for (int i = 0; i < mobilya.transform.childCount; i++)
         {
             if (gameObject.name == mobilya.transform.GetChild(i).gameObject.name)
             {
                 mobilya.transform.GetChild(i).gameObject.SetActive(true);
             }
         }*/
        StartCoroutine(mobilya_ac2());
    }
}