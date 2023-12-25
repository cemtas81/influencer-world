using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class json_ekipman : MonoBehaviour
{
    public Sprite[] ekipman_sprite;
    public GameObject ekipman_layout;
    public GameObject ekipman_prefab;
    public GameObject[] ekipmanlar;

    [Serializable]
    public class EkipmanData
    {
        public List<EkipmanBilgiler> EkipmanDataList = new List<EkipmanBilgiler>();
    }
    [Serializable]
    public class EkipmanBilgiler
    {
        public int ID;
        public string IDNanem;
        public int IlkFiyat;
        public int FiyatArtis;
        public int TakipciArtis;

    }
    void Start()
    {
        ekipman_olustur();
    }

   
    void Update()
    {
        
    }
    public void ekipman_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Ekipmanlar" + ".json");
        EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(json);
        for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = Instantiate(ekipman_prefab, ekipman_layout.transform);
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].IDNanem;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].IDNanem;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;

            if (PlayerPrefs.HasKey("" + ekipmanReaded.EkipmanDataList[i].IDNanem))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem, 0);
            }


            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)) + "%</color>" + "click/money";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + ((PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)+1) * ekipmanReaded.EkipmanDataList[i].TakipciArtis);
            obj.transform.GetChild(3).GetComponent<Text>().text = "Up " + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);



            if (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1); 
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }

            GameObject obje = ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if (ekipmanlar[l].name == ekipmanReaded.EkipmanDataList[i].IDNanem)
                {
                    obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }

            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Ekipmanlar" + ".json");
         EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(json);
         for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = Instantiate(ekipman_prefab, ekipman_layout.transform);
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].IDNanem;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].IDNanem;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;

            if (PlayerPrefs.HasKey("" + ekipmanReaded.EkipmanDataList[i].IDNanem))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem, 0);
            }


            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)) + "%</color>" + "click/money";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + ((PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)+1) * ekipmanReaded.EkipmanDataList[i].TakipciArtis);
            obj.transform.GetChild(3).GetComponent<Text>().text = "Up " + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);



            if (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1); 
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }

            GameObject obje = ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if (ekipmanlar[l].name == ekipmanReaded.EkipmanDataList[i].IDNanem)
                {
                    obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }

            }
        }
#elif UNITY_ANDROID
      StartCoroutine(LoadLocalizedTextOnAndroid2());

#else
        
#endif



        // string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Ekipmanlar" + ".json");
        /*EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(json);
        for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = Instantiate(ekipman_prefab, ekipman_layout.transform);
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].ID;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].ID;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;

            if (PlayerPrefs.HasKey("" + ekipmanReaded.EkipmanDataList[i].ID))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + ekipmanReaded.EkipmanDataList[i].ID, 0);
            }


            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID)) + "%</color>" + "click/money"; 
            obj.transform.GetChild(5).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID)) + "%</color>" + "click/money";
            obj.transform.GetChild(3).GetComponent<Text>().text = "Lv" + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID);



            if(PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + ekipmanReaded.EkipmanDataList[i].ItemFiyat;
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + AllPP.gelistirme_fiyat[PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID) - 1];
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }

            GameObject obje= ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if(ekipmanlar[l].name== ekipmanReaded.EkipmanDataList[i].ID)
                {
                   obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].ID);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name==""+ ekipmanReaded.EkipmanDataList[i].ID+""+ (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].ID + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }
               
            }
        }*/
    }
    public void ekipman_oyunici_guncelle(string obje_ad)
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Ekipmanlar" + ".json");
        EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(json);
        for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = ekipman_layout.transform.GetChild(i).gameObject;
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].IDNanem;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].IDNanem;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;
            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)) + "%</color>" + "click/money";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + ((PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1) * ekipmanReaded.EkipmanDataList[i].TakipciArtis);
            obj.transform.GetChild(3).GetComponent<Text>().text = "Up " + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }


            GameObject obje = ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if (ekipmanlar[l].name == ekipmanReaded.EkipmanDataList[i].IDNanem)
                {
                    obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                if((ekipmanReaded.EkipmanDataList[i].IDNanem==obje_ad && x % 5 == 0) || (ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x == 1))
                {
                    Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, obje.transform.GetChild(x / 5).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                    if ((ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x % 5 == 0) || (ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x == 1))
                    {
                        Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, obje.transform.GetChild(x / 5).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
                    }
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }

            }


        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Ekipmanlar" + ".json");
      EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(json);
        for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = ekipman_layout.transform.GetChild(i).gameObject;
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].IDNanem;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].IDNanem;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;
            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)) + "%</color>" + "click/money";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + ((PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1) * ekipmanReaded.EkipmanDataList[i].TakipciArtis);
            obj.transform.GetChild(3).GetComponent<Text>().text = "Up " + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }


            GameObject obje = ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if (ekipmanlar[l].name == ekipmanReaded.EkipmanDataList[i].IDNanem)
                {
                    obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                if((ekipmanReaded.EkipmanDataList[i].IDNanem==obje_ad && x % 5 == 0) || (ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x == 1))
                {
                    Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, obje.transform.GetChild(x / 5).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                    if ((ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x % 5 == 0) || (ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x == 1))
                    {
                        Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, obje.transform.GetChild(x / 5).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
                    }
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }

            }


        }
#elif UNITY_ANDROID
         
         StartCoroutine(LoadLocalizedTextOnAndroid(obje_ad));
#else
        
#endif
    }
    public void ekipman_guncelle(string ad)
    {
        PlayerPrefs.SetInt("" + ad, PlayerPrefs.GetInt("" + ad) + 1);
    }
    IEnumerator LoadLocalizedTextOnAndroid(string obje_ad)
    {
        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Ekipmanlar.json");
        string dataAsJson;
        if (filePath.Contains("://") || filePath.Contains(":///"))
        {
            UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(filePath);
            yield return www.Send();
            dataAsJson = www.downloadHandler.text;
        }
        else
        {
            UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(filePath);
            yield return www.Send();
            dataAsJson = www.downloadHandler.text;
            //dataAsJson = File.ReadAllText(filePath);
        }

       
        EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(dataAsJson);
        for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = ekipman_layout.transform.GetChild(i).gameObject;
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].IDNanem;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].IDNanem;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;
            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)) + "%</color>" + "click/money";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + ((PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1) * ekipmanReaded.EkipmanDataList[i].TakipciArtis);
            obj.transform.GetChild(3).GetComponent<Text>().text = "Up " + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }


            GameObject obje = ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if (ekipmanlar[l].name == ekipmanReaded.EkipmanDataList[i].IDNanem)
                {
                    obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                if ((ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x % 5 == 0) || (ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x == 1))
                {
                    Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, obje.transform.GetChild(x / 5).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                    if ((ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x % 5 == 0) || (ekipmanReaded.EkipmanDataList[i].IDNanem == obje_ad && x == 1))
                    {
                        Instantiate(GameObject.Find("Main Camera").GetComponent<AlllGame>().mobilya_konfeti, obje.transform.GetChild(x / 5).gameObject.transform.position, Quaternion.Euler(0, 0, 0));
                    }
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }

            }


        }
    }
    IEnumerator LoadLocalizedTextOnAndroid2()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Ekipmanlar.json");
        string dataAsJson;
        if (filePath.Contains("://") || filePath.Contains(":///"))
        {
            UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(filePath);
            yield return www.Send();
            dataAsJson = www.downloadHandler.text;
        }
        else
        {
            UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(filePath);
            yield return www.Send();
            dataAsJson = www.downloadHandler.text;
            //dataAsJson = File.ReadAllText(filePath);
        }
        EkipmanData ekipmanReaded = new EkipmanData();
        ekipmanReaded = JsonUtility.FromJson<EkipmanData>(dataAsJson);
        for (int i = 0; i < ekipmanReaded.EkipmanDataList.Count; i++)
        {
            GameObject obj = Instantiate(ekipman_prefab, ekipman_layout.transform);
            obj.gameObject.name = ekipmanReaded.EkipmanDataList[i].IDNanem;
            obj.transform.GetChild(2).GetComponent<Text>().text = ekipmanReaded.EkipmanDataList[i].IDNanem;
            //obj.transform.GetChild(0).gameObject.name = "" + ekipmanReaded.EkipmanDataList[i].Durum;

            if (PlayerPrefs.HasKey("" + ekipmanReaded.EkipmanDataList[i].IDNanem))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem, 0);
            }


            obj.transform.GetChild(4).GetComponent<Text>().text = "<color=green>+" + (5 * PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem)) + "%</color>" + "click/money";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + ((PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1) * ekipmanReaded.EkipmanDataList[i].TakipciArtis);
            obj.transform.GetChild(3).GetComponent<Text>().text = "Up " + PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);



            if (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) == 0)
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = 0f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }
            else
            {
                obj.transform.GetChild(8).GetComponent<Text>().text = "" + fiyat_hesapla(ekipmanReaded.EkipmanDataList[i].IlkFiyat, ekipmanReaded.EkipmanDataList[i].FiyatArtis, PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) + 1);
                obj.transform.GetChild(6).transform.GetChild(0).GetComponent<Image>().fillAmount = (PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem) % 5) * 0.2f;
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(3).gameObject.SetActive(true);
            }

            GameObject obje = ekipmanlar[0];
            for (int l = 0; l < ekipmanlar.Length; l++)
            {
                if (ekipmanlar[l].name == ekipmanReaded.EkipmanDataList[i].IDNanem)
                {
                    obje = ekipmanlar[l];
                }
            }
            for (int y = 0; y < obje.transform.childCount; y++)
            {
                obje.transform.GetChild(y).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("" + ekipmanReaded.EkipmanDataList[i].IDNanem);
            if (x / 5 > obje.transform.childCount - 1)
            {
                x = (obje.transform.childCount - 1) * 5;
                obje.transform.GetChild((obje.transform.childCount - 1)).gameObject.SetActive(true);
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (obje.transform.childCount - 1))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                    }
                }
            }
            else
            {
                if (x != 0)
                {
                    obje.transform.GetChild(x / 5).gameObject.SetActive(true);
                }
                for (int k = 0; k < ekipman_sprite.Length; k++)
                {
                    if (ekipman_sprite[k].name == "" + ekipmanReaded.EkipmanDataList[i].IDNanem + "" + (x / 5))
                    {
                        obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ekipman_sprite[k];
                        // obj.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = GameObject.Find("Main Camera").GetComponent<AlllGame>().isiklar_list[x / 5];
                    }
                }

            }
        }
    }
    public int fiyat_hesapla(int ilk_fiyat,int fiyat_artis,int level)
    {

        int x = ilk_fiyat + (fiyat_artis * ((level * (level + 1)) / 2));


        return x;
    }
}
