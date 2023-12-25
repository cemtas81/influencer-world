using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kiyafet_alma : MonoBehaviour
{
    // Start is called before the first frame update
    private Material mat;
    private GameObject obje, kiyafet;
    private void Update()
    {
        if (PlayerPrefs.GetFloat("para") >= System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text) && PlayerPrefs.GetInt("" + gameObject.name) == 0)
        {

            transform.GetChild(8).gameObject.SetActive(true);

        }
        else
        {
            transform.GetChild(8).gameObject.SetActive(false);
        }
    }
    public void baslangic_kontrol()
    {
        if (gameObject.tag != "ayak")
        {
            obje = GameObject.Find("Main Camera");
            for (int i = 0; i < obje.GetComponent<AlllGame>().kiyafet_matlar.Length; i++)
            {
                if (obje.GetComponent<AlllGame>().kiyafet_matlar[i].name == gameObject.name)
                {
                    mat = obje.GetComponent<AlllGame>().kiyafet_matlar[i];
                }
            }
            for (int i = 0; i < obje.GetComponent<AlllGame>().kiyafetler.Length; i++)
            {
                if (obje.GetComponent<AlllGame>().kiyafetler[i].gameObject.name == gameObject.name)
                {
                    kiyafet = obje.GetComponent<AlllGame>().kiyafetler[i].gameObject.transform.GetChild(obje.GetComponent<AlllGame>().kiyafetler[i].gameObject.transform.childCount - 1).gameObject;
                    // Debug.Log("--" + kiyafet.transform.parent.name);
                }
                // Debug.Log("--"+ obje.GetComponent<AlllGame>().kiyafetler[i].gameObject.transform.GetChild(obje.GetComponent<AlllGame>().kiyafetler[i].gameObject.transform.childCount - 1).gameObject.name);
            }
        }
        if (PlayerPrefs.GetInt("" + gameObject.name) == 0)
        {
            if (kiyafet)
            {
                kiyafet.GetComponent<Renderer>().enabled = true;
                kiyafet.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_transparan;
            }
            else if (gameObject.tag == "kafa")
            {
                //Debug.Log("gözlük");
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("gozlukler");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        for (int j = 0; j < bull[i].transform.childCount; j++)
                        {
                            // Debug.Log("" + bull[i].transform.GetChild(j).gameObject.name);
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().enabled = true;
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_transparan;
                        }
                    }
                }
            }
            else
            {
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("ayakbak");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        bull[i].gameObject.GetComponent<Renderer>().enabled = true;
                        bull[i].gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_transparan;
                    }
                }
            }

            transform.GetChild(3).gameObject.SetActive(true);
            transform.GetChild(5).gameObject.SetActive(false);
            transform.GetChild(6).gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("" + gameObject.name) == 1)
        {
            if (kiyafet)
            {
                kiyafet.GetComponent<Renderer>().enabled = true;
                kiyafet.GetComponent<Renderer>().sharedMaterial = mat;
            }
            else if (gameObject.tag == "kafa")
            {
                //Debug.Log("99999999999999999999999999");
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("gozlukler");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        for (int j = 0; j < bull[i].transform.childCount; j++)
                        {
                            // Debug.Log("" + bull[i].transform.GetChild(j).gameObject.name);
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().enabled = true;
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];
                        }
                    }
                }
            }
            else
            {
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("ayakbak");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        bull[i].gameObject.GetComponent<Renderer>().enabled = true;
                        bull[i].gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];

                    }
                }
            }
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.SetActive(false);
            transform.GetChild(6).gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("" + gameObject.name) == 2)
        {
            if (kiyafet)
            {
                kiyafet.GetComponent<Renderer>().enabled = true;
                kiyafet.GetComponent<Renderer>().sharedMaterial = mat;
            }
            else if (gameObject.tag == "kafa")
            {
                // Debug.Log("99999999999999999999999999");
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("gozlukler");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        for (int j = 0; j < bull[i].transform.childCount; j++)
                        {
                            // Debug.Log("" + bull[i].transform.GetChild(j).gameObject.name);
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().enabled = true;
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];
                        }
                    }
                }
            }
            else
            {
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("ayakbak");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        bull[i].gameObject.GetComponent<Renderer>().enabled = true;
                        bull[i].gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];

                    }
                }
            }
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(6).gameObject.SetActive(true);
            if (gameObject.tag == "ayak")
            {
                ayakkabi_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "bacak")
            {
                bacak_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "kafa")
            {
                kafa_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "govde")
            {
                govde_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "kiyafet")
            {
                elbise_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "saclar")
            {
                sac_ackapa(gameObject.name);
            }
        }
        else
        {
            transform.GetChild(3).gameObject.SetActive(false);
        }
    }
    public int fiyat_kontrol()
    {
        if (PlayerPrefs.GetFloat("para") >= System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public void kiyafet_al()
    {
        if (PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") >=
            System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text) &&
            System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text) != 0)
        {
            kiyafet_cikar();
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(6).gameObject.SetActive(true);
            PlayerPrefs.SetInt("" + gameObject.name, 2);
            PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text));
            PlayerPrefs.SetInt("" + transform.tag + "_ta", System.Int32.Parse(transform.GetChild(2).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(2).gameObject.GetComponent<Text>().text.Length - 2)));
            PlayerPrefs.SetInt("" + transform.tag + "_pa", System.Int32.Parse(transform.GetChild(1).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(1).gameObject.GetComponent<Text>().text.Length - 2)));
            PlayerPrefs.SetInt("popi" + transform.tag, System.Int32.Parse(transform.GetChild(4).gameObject.GetComponent<Text>().text));
            // Debug.Log(""+transform.tag+"fiyat "+"artisi=" + PlayerPrefs.GetInt("" + transform.tag + "_pa"));
            GameObject.Find("Main Camera").GetComponent<AlllGame>().satinalma_fonk();
            if (kiyafet)
            {
                kiyafet.GetComponent<Renderer>().enabled = true;
                kiyafet.GetComponent<Renderer>().sharedMaterial = mat;
            }
            else if (gameObject.tag == "kafa")
            {
                //Debug.Log("99999999999999999999999999");
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("gozlukler");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        for (int j = 0; j < bull[i].transform.childCount; j++)
                        {
                            // Debug.Log("" + bull[i].transform.GetChild(j).gameObject.name);
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().enabled = true;
                            bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];
                        }
                    }
                }
            }
            else
            {
                obje = GameObject.Find("Main Camera");
                var bull = GameObject.FindGameObjectsWithTag("ayakbak");
                for (int i = 0; i < bull.Length; i++)
                {
                    if (bull[i].gameObject.name == gameObject.name)
                    {
                        bull[i].gameObject.GetComponent<Renderer>().enabled = true;
                        bull[i].gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];

                    }
                }
            }
            if (gameObject.tag == "ayak")
            {
                ayakkabi_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "bacak")
            {
                kiyafet_cikar2("kiyafet");
                bacak_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "kafa")
            {
                kafa_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "govde")
            {
                kiyafet_cikar2("kiyafet");
                govde_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "kiyafet")
            {
                kiyafet_cikar2("bacak");
                kiyafet_cikar2("govde");
                elbise_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "saclar")
            {
                sac_ackapa(gameObject.name);
            }
            GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }
        else if (PlayerPrefs.GetInt("" + gameObject.name) == 0 && PlayerPrefs.GetFloat("para") <
            System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text)&&
            System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text)!=0)
        {
            GameObject.Find("Main Camera").GetComponent<AlllGame>().yetersiz_para_fonk();
        }
        else if(System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text)==0&& PlayerPrefs.GetInt("" + gameObject.name) == 0)
        {
            Reklam.odul_bak = 13;
            Reklam.reklam_kiyaket = gameObject;
            //GameObject.Find("Game_Manager").GetComponent<Reklam>().reklam_izlet();
           
        }
        else if (PlayerPrefs.GetInt("" + gameObject.name) == 1)
        {
            kiyafet_cikar();
            transform.GetChild(3).gameObject.SetActive(false);
            transform.GetChild(5).gameObject.SetActive(true);
            transform.GetChild(6).gameObject.SetActive(true);
            PlayerPrefs.SetInt("" + transform.tag + "_ta", System.Int32.Parse(transform.GetChild(2).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(2).gameObject.GetComponent<Text>().text.Length - 2)));
            PlayerPrefs.SetInt("" + transform.tag + "_pa", System.Int32.Parse(transform.GetChild(1).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(1).gameObject.GetComponent<Text>().text.Length - 2)));
            PlayerPrefs.SetInt("popi" + transform.tag, System.Int32.Parse(transform.GetChild(4).gameObject.GetComponent<Text>().text));
            //Debug.Log("popi" + transform.tag);
            // Debug.Log("" + transform.tag + "fiyat " + "artisi=" + PlayerPrefs.GetInt("" + transform.tag + "_pa"));
            PlayerPrefs.SetInt("" + gameObject.name, 2);
            if (gameObject.tag == "ayak")
            {
                ayakkabi_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "bacak")
            {
                kiyafet_cikar2("kiyafet");
                bacak_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "kafa")
            {
                kafa_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "govde")
            {
                kiyafet_cikar2("kiyafet");
                govde_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "kiyafet")
            {
                kiyafet_cikar2("bacak");
                kiyafet_cikar2("govde");
                elbise_ackapa(gameObject.name);
            }
            else if (gameObject.tag == "saclar")
            {
                sac_ackapa(gameObject.name);
            }
        }
        else
        {

        }
    }
    public void kiyafet_cikar()
    {
        foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
        {
            if (obje.gameObject.transform.tag == transform.tag)
            {
                if (PlayerPrefs.GetInt("" + obje.gameObject.name) == 2)
                {
                    PlayerPrefs.SetInt("" + obje.gameObject.name, 1);
                    obje.gameObject.transform.GetChild(3).gameObject.SetActive(false);
                    obje.gameObject.transform.GetChild(5).gameObject.SetActive(false);
                    obje.gameObject.transform.GetChild(6).gameObject.SetActive(false);
                }
            }
            //
        }

    }
    public void kiyafet_cikar2(string tag)
    {
        foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
        {
           // Debug.Log("" + obje.gameObject.transform.childCount);
            if (PlayerPrefs.GetInt("" + obje.gameObject.name) == 2 && obje.transform.tag == tag)
            {
                
                PlayerPrefs.SetInt("" + obje.gameObject.name,1);
                obje.transform.GetChild(3).gameObject.SetActive(false);
                obje.transform.GetChild(5).gameObject.SetActive(false);
                obje.transform.GetChild(6).gameObject.SetActive(false);
            }
        }
    }
    public void kafa_ackapa(string obj_ad)
    {

        GameObject karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_etkinlik;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_yatakodasi;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_video;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
       
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_disko;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().gym_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().muzik_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().dolap_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "bas")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void govde_ackapa(string obj_ad)
    {
        GameObject karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_etkinlik;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_yatakodasi;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_video;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
       
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_disko;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().gym_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().muzik_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().dolap_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void bacak_ackapa(string obj_ad)
    {
        GameObject karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_etkinlik;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_yatakodasi;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_video;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
       
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_disko;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().gym_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().muzik_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().dolap_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void ayakkabi_ackapa(string obj_ad)
    {
        GameObject karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_etkinlik;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_yatakodasi;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_video;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_disko;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().gym_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().muzik_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().dolap_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ayakkabi")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void elbise_ackapa(string obj_ad)
    {
        GameObject karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_etkinlik;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_yatakodasi;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_video;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
       
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_disko;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().gym_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().muzik_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().dolap_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)//bacak kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "alt")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//üst kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "ust")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kiyafet kapama
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "kiyafet")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)//kıyafet açma
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void sac_ackapa(string obj_ad)
    {
        GameObject karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_etkinlik;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_yatakodasi;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }

        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_video;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
      
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().giyinme_odasi_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().kiz_disko;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().gym_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().muzik_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().mutfak_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
        karakter = Camera.main.gameObject.GetComponent<AlllGame>().dolap_kiz;
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.tag == "sac")
            {
                karakter.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < karakter.transform.childCount; i++)
        {
            if (karakter.transform.GetChild(i).gameObject.name == "" + obj_ad)
            {
                karakter.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }



   public void Reklamla_al()
    {
        
        kiyafet_cikar();
        transform.GetChild(3).gameObject.SetActive(false);
        transform.GetChild(5).gameObject.SetActive(true);
        transform.GetChild(6).gameObject.SetActive(true);
        transform.GetChild(9).gameObject.SetActive(false);
        PlayerPrefs.SetInt("" + gameObject.name, 2);
        //PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") - System.Int32.Parse(transform.GetChild(3).transform.GetChild(0).gameObject.GetComponent<Text>().text));
        PlayerPrefs.SetInt("" + transform.tag + "_ta", System.Int32.Parse(transform.GetChild(2).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(2).gameObject.GetComponent<Text>().text.Length - 2)));
        PlayerPrefs.SetInt("" + transform.tag + "_pa", System.Int32.Parse(transform.GetChild(1).gameObject.GetComponent<Text>().text.Substring(1, transform.GetChild(1).gameObject.GetComponent<Text>().text.Length - 2)));
        PlayerPrefs.SetInt("popi" + transform.tag, System.Int32.Parse(transform.GetChild(4).gameObject.GetComponent<Text>().text));
        // Debug.Log(""+transform.tag+"fiyat "+"artisi=" + PlayerPrefs.GetInt("" + transform.tag + "_pa"));
        Camera.main.gameObject.GetComponent<AlllGame>().satinalma_fonk();
        if (kiyafet)
        {
            kiyafet.GetComponent<Renderer>().enabled = true;
            kiyafet.GetComponent<Renderer>().sharedMaterial = mat;
        }
        else if (gameObject.tag == "kafa")
        {
            //Debug.Log("99999999999999999999999999");
            obje = Camera.main.gameObject;
            var bull = GameObject.FindGameObjectsWithTag("gozlukler");
            for (int i = 0; i < bull.Length; i++)
            {
                if (bull[i].gameObject.name == gameObject.name)
                {
                    for (int j = 0; j < bull[i].transform.childCount; j++)
                    {
                        // Debug.Log("" + bull[i].transform.GetChild(j).gameObject.name);
                        bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().enabled = true;
                        bull[i].transform.GetChild(j).gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];
                    }
                }
            }
        }
        else
        {
            obje = Camera.main.gameObject;
            var bull = GameObject.FindGameObjectsWithTag("ayakbak");
            for (int i = 0; i < bull.Length; i++)
            {
                if (bull[i].gameObject.name == gameObject.name)
                {
                    bull[i].gameObject.GetComponent<Renderer>().enabled = true;
                    bull[i].gameObject.GetComponent<Renderer>().sharedMaterial = obje.GetComponent<AlllGame>().kiyafet_matlar[0];

                }
            }
        }
        StartCoroutine(kiyafet_ac_reklam());
       
    }
    IEnumerator kiyafet_ac_reklam()
    {
       
        yield return new WaitForSeconds(0.5f);
        if (gameObject.tag == "ayak")
        {
            ayakkabi_ackapa(gameObject.name);
        }
        else if (gameObject.tag == "bacak")
        {
            kiyafet_cikar2("kiyafet");
            bacak_ackapa(gameObject.name);
        }
        else if (gameObject.tag == "kafa")
        {
            kafa_ackapa(gameObject.name);
        }
        else if (gameObject.tag == "govde")
        {
            kiyafet_cikar2("kiyafet");
            govde_ackapa(gameObject.name);
        }
        else if (gameObject.tag == "kiyafet")
        {
            kiyafet_cikar2("bacak");
            kiyafet_cikar2("govde");
            elbise_ackapa(gameObject.name);
        }
        else if (gameObject.tag == "saclar")
        {
            sac_ackapa(gameObject.name);
        }
        
       
    }
}
