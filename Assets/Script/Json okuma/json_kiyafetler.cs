using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class json_kiyafetler : MonoBehaviour
{

    public GameObject prefab;
    public GameObject ayakkabi_layout, bacak_layout, govde_layout, kafa_layout;
    public Sprite[] ayakkabi_sprites,bacak_sprites, govde_sprites, kiyafet_sprites, sac_sprites, gozluk_sprites;

    [Serializable]
    public class AyakkabiData
    {
        public List<KiyafetBilgiler> AyakkabiDataList = new List<KiyafetBilgiler>();
    }
    [Serializable]
    public class BacakData
    {
        public List<KiyafetBilgiler> BacakDataList = new List<KiyafetBilgiler>();
    }
    [Serializable]
    public class GovdeData
    {
        public List<KiyafetBilgiler> GovdeDataList = new List<KiyafetBilgiler>();
    }
    [Serializable]
    public class KiyafetData
    {
        public List<KiyafetBilgiler> KiyafetDataList = new List<KiyafetBilgiler>();
    }
    [Serializable]
    public class SacData
    {
        public List<KiyafetBilgiler> SactDataList = new List<KiyafetBilgiler>();
    }
    [Serializable]
    public class GozlukData
    {
        public List<KiyafetBilgiler> GozluktDataList = new List<KiyafetBilgiler>();
    }
    [Serializable]
    public class KiyafetBilgiler
    {
        public int ID;
        public string IDName;
        public int ResimID;
        public int ParaArtis;
        public int TakipciArtis;
        public int PopiArtis;
        public int ItemFiyat;
        public int Durum;
        public string Tag;
    }

    public void Awake()
    {
        ayakkabi_olustur();
        bacak_olustur();
        govde_olustur();
        kiyafet_olustur();
        gozluk_olustur();
        sac_olustur();
    }
    void Start()
    {
        /* string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Kiyafetler" + ".json");
         AyakkabiData ayakReaded = new AyakkabiData();
         ayakReaded = JsonUtility.FromJson<AyakkabiData>(json);
         ayakReaded.AyakkabiDataList[0].ItemFiyat = 111;
         string s = JsonUtility.ToJson(ayakReaded, true);
         string json1 = Application.dataPath + "/StreamingAssets/" + "Kiyafetler" + ".json";
         File.WriteAllText(json1, s);*/
         /*ayakkabi_olustur();
         bacak_olustur();
         govde_olustur();
         kiyafet_olustur();
         gozluk_olustur();
         sac_olustur();*/
        /*string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Gozlukler" + ".json");
        GozlukData gozlukReaded = new GozlukData();
        gozlukReaded = JsonUtility.FromJson<GozlukData>(json);
        for (int i = 0; i < gozlukReaded.GozluktDataList.Count; i++)
        {
            gozlukReaded.GozluktDataList[i].ID = "kafa" + (i + 1);
            gozlukReaded.GozluktDataList[i].Tag = "kafa";
            gozlukReaded.GozluktDataList[i].Durum = 0;
        }

        string s = JsonUtility.ToJson(gozlukReaded, true);
        string json1 = Application.dataPath + "/StreamingAssets/" + "Gozlukler" + ".json";
        File.WriteAllText(json1, s); */



    }
    public void ayakkabi_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Ayakkabilar" + ".json");
        AyakkabiData ayakReaded = new AyakkabiData();
        ayakReaded = JsonUtility.FromJson<AyakkabiData>(json);
        for (int i = 0; i < ayakReaded.AyakkabiDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, ayakkabi_layout.transform);
            obj.gameObject.name = ayakReaded.AyakkabiDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = ayakkabi_sprites[ayakReaded.AyakkabiDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + ayakReaded.AyakkabiDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + ayakReaded.AyakkabiDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + ayakReaded.AyakkabiDataList[i].TakipciArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + ayakReaded.AyakkabiDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + ayakReaded.AyakkabiDataList[i].Durum;
            obj.transform.tag = ayakReaded.AyakkabiDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + ayakReaded.AyakkabiDataList[i].IDName))
            {

            }
            else
            {
                if(ayakReaded.AyakkabiDataList[i].ID%100==1)
                {
                    PlayerPrefs.SetInt("" + ayakReaded.AyakkabiDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + ayakReaded.AyakkabiDataList[i].IDName, 0);
                }
                
            }


            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 0)//alınmamış
            {

                if(ayakReaded.AyakkabiDataList[i].ItemFiyat==0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Ayakkabilar" + ".json");
          AyakkabiData ayakReaded = new AyakkabiData();
        ayakReaded = JsonUtility.FromJson<AyakkabiData>(json);
        for (int i = 0; i < ayakReaded.AyakkabiDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, ayakkabi_layout.transform);
            obj.gameObject.name = ayakReaded.AyakkabiDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = ayakkabi_sprites[ayakReaded.AyakkabiDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + ayakReaded.AyakkabiDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + ayakReaded.AyakkabiDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + ayakReaded.AyakkabiDataList[i].TakipciArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + ayakReaded.AyakkabiDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + ayakReaded.AyakkabiDataList[i].Durum;
            obj.transform.tag = ayakReaded.AyakkabiDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + ayakReaded.AyakkabiDataList[i].IDName))
            {

            }
            else
            {
                if(ayakReaded.AyakkabiDataList[i].ID%100==1)
                {
                    PlayerPrefs.SetInt("" + ayakReaded.AyakkabiDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + ayakReaded.AyakkabiDataList[i].IDName, 0);
                }
                
            }


            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 0)//alınmamış
            {

                if(ayakReaded.AyakkabiDataList[i].ItemFiyat==0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
      StartCoroutine(ayakkabi_olustur_enum());

#else
        
#endif
    }
    public void bacak_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Bacaklar" + ".json");
        BacakData bacakReaded = new BacakData();
        bacakReaded = JsonUtility.FromJson<BacakData>(json);
        for (int i = 0; i < bacakReaded.BacakDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, bacak_layout.transform);
            obj.gameObject.name = bacakReaded.BacakDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = bacak_sprites[bacakReaded.BacakDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + bacakReaded.BacakDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + bacakReaded.BacakDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + bacakReaded.BacakDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + bacakReaded.BacakDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + bacakReaded.BacakDataList[i].Durum;
            obj.transform.tag = bacakReaded.BacakDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + bacakReaded.BacakDataList[i].IDName))
            {

            }
            else
            {
                if (bacakReaded.BacakDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + bacakReaded.BacakDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + bacakReaded.BacakDataList[i].IDName, 0);
                }
              
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }


            if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 0)//alınmamış
            {
                if (bacakReaded.BacakDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Bacaklar" + ".json");
         BacakData bacakReaded = new BacakData();
        bacakReaded = JsonUtility.FromJson<BacakData>(json);
         for (int i = 0; i < bacakReaded.BacakDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, bacak_layout.transform);
            obj.gameObject.name = bacakReaded.BacakDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = bacak_sprites[bacakReaded.BacakDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + bacakReaded.BacakDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + bacakReaded.BacakDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + bacakReaded.BacakDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + bacakReaded.BacakDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + bacakReaded.BacakDataList[i].Durum;
            obj.transform.tag = bacakReaded.BacakDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + bacakReaded.BacakDataList[i].IDName))
            {

            }
            else
            {
                if (bacakReaded.BacakDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + bacakReaded.BacakDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + bacakReaded.BacakDataList[i].IDName, 0);
                }
              
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }


            if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 0)//alınmamış
            {
                if (bacakReaded.BacakDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
      StartCoroutine(bacak_olustur_enum());

#else
        
#endif

    }
    public void govde_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Govde" + ".json");
        GovdeData govdeReaded = new GovdeData();
        govdeReaded = JsonUtility.FromJson<GovdeData>(json);
        for (int i = 0; i < govdeReaded.GovdeDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, govde_layout.transform);
            obj.gameObject.name = govdeReaded.GovdeDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = govde_sprites[govdeReaded.GovdeDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + govdeReaded.GovdeDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + govdeReaded.GovdeDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + govdeReaded.GovdeDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + govdeReaded.GovdeDataList[i].ItemFiyat;
            // obj.transform.GetChild(0).gameObject.name = "" + govdeReaded.GovdeDataList[i].Durum;
            obj.transform.tag = govdeReaded.GovdeDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + govdeReaded.GovdeDataList[i].IDName))
            {

            }
            else
            {
                if (govdeReaded.GovdeDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + govdeReaded.GovdeDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + govdeReaded.GovdeDataList[i].IDName, 0);
                }
               
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 0)//alınmamış
            {
                if (govdeReaded.GovdeDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Govde" + ".json");
         GovdeData govdeReaded = new GovdeData();
        govdeReaded = JsonUtility.FromJson<GovdeData>(json);
       for (int i = 0; i < govdeReaded.GovdeDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, govde_layout.transform);
            obj.gameObject.name = govdeReaded.GovdeDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = govde_sprites[govdeReaded.GovdeDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + govdeReaded.GovdeDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + govdeReaded.GovdeDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + govdeReaded.GovdeDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + govdeReaded.GovdeDataList[i].ItemFiyat;
            // obj.transform.GetChild(0).gameObject.name = "" + govdeReaded.GovdeDataList[i].Durum;
            obj.transform.tag = govdeReaded.GovdeDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + govdeReaded.GovdeDataList[i].IDName))
            {

            }
            else
            {
                if (govdeReaded.GovdeDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + govdeReaded.GovdeDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + govdeReaded.GovdeDataList[i].IDName, 0);
                }
               
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 0)//alınmamış
            {
                if (govdeReaded.GovdeDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
      StartCoroutine(govde_olustur_enum());

#else
        
#endif

    }
    public void kiyafet_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Kiyafetler" + ".json");
        KiyafetData kiyafetReaded = new KiyafetData();
        kiyafetReaded = JsonUtility.FromJson<KiyafetData>(json);
        for (int i = 0; i < kiyafetReaded.KiyafetDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, govde_layout.transform);
            obj.gameObject.name = kiyafetReaded.KiyafetDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = kiyafet_sprites[kiyafetReaded.KiyafetDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + kiyafetReaded.KiyafetDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + kiyafetReaded.KiyafetDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + kiyafetReaded.KiyafetDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + kiyafetReaded.KiyafetDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + kiyafetReaded.KiyafetDataList[i].Durum;
            obj.transform.tag = kiyafetReaded.KiyafetDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + kiyafetReaded.KiyafetDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + kiyafetReaded.KiyafetDataList[i].IDName, 0);
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 0)//alınmamış
            {
                if (kiyafetReaded.KiyafetDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Kiyafetler" + ".json");
        KiyafetData kiyafetReaded = new KiyafetData();
        kiyafetReaded = JsonUtility.FromJson<KiyafetData>(json);
         for (int i = 0; i < kiyafetReaded.KiyafetDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, govde_layout.transform);
            obj.gameObject.name = kiyafetReaded.KiyafetDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = kiyafet_sprites[kiyafetReaded.KiyafetDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + kiyafetReaded.KiyafetDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + kiyafetReaded.KiyafetDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + kiyafetReaded.KiyafetDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + kiyafetReaded.KiyafetDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + kiyafetReaded.KiyafetDataList[i].Durum;
            obj.transform.tag = kiyafetReaded.KiyafetDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + kiyafetReaded.KiyafetDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + kiyafetReaded.KiyafetDataList[i].IDName, 0);
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 0)//alınmamış
            {
                if (kiyafetReaded.KiyafetDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
      StartCoroutine(kiyafet_olustur_enum());

#else
        
#endif
        //string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Kiyafetler" + ".json");

    }
    public void gozluk_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Gozlukler" + ".json");
        GozlukData gozlukReaded = new GozlukData();
        gozlukReaded = JsonUtility.FromJson<GozlukData>(json);
        for (int i = 0; i < gozlukReaded.GozluktDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, kafa_layout.transform);
            obj.gameObject.name = gozlukReaded.GozluktDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = gozluk_sprites[gozlukReaded.GozluktDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + gozlukReaded.GozluktDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + gozlukReaded.GozluktDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + gozlukReaded.GozluktDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + gozlukReaded.GozluktDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + gozlukReaded.GozluktDataList[i].Durum;
            obj.transform.tag = gozlukReaded.GozluktDataList[i].Tag;

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.HasKey("" + gozlukReaded.GozluktDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + gozlukReaded.GozluktDataList[i].IDName, 0);

            }

            if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 0)//alınmamış
            {
                if (gozlukReaded.GozluktDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Gozlukler" + ".json");
        GozlukData gozlukReaded = new GozlukData();
        gozlukReaded = JsonUtility.FromJson<GozlukData>(json);
         for (int i = 0; i < gozlukReaded.GozluktDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, kafa_layout.transform);
            obj.gameObject.name = gozlukReaded.GozluktDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = gozluk_sprites[gozlukReaded.GozluktDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + gozlukReaded.GozluktDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + gozlukReaded.GozluktDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + gozlukReaded.GozluktDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + gozlukReaded.GozluktDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + gozlukReaded.GozluktDataList[i].Durum;
            obj.transform.tag = gozlukReaded.GozluktDataList[i].Tag;

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.HasKey("" + gozlukReaded.GozluktDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + gozlukReaded.GozluktDataList[i].IDName, 0);

            }

            if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 0)//alınmamış
            {
                if (gozlukReaded.GozluktDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
      StartCoroutine(gozluk_olustur_enum());

#else
        
#endif
        // string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Gozlukler" + ".json");

    }
    public void sac_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Saclar" + ".json");
        SacData sacReaded = new SacData();
        sacReaded = JsonUtility.FromJson<SacData>(json);
        for (int i = 0; i < sacReaded.SactDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, kafa_layout.transform);
            obj.gameObject.name = sacReaded.SactDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = sac_sprites[sacReaded.SactDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + sacReaded.SactDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + sacReaded.SactDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + sacReaded.SactDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + sacReaded.SactDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + sacReaded.SactDataList[i].Durum;
            obj.transform.tag = sacReaded.SactDataList[i].Tag;

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.HasKey("" + sacReaded.SactDataList[i].IDName))
            {

            }
            else
            {
                if (sacReaded.SactDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + sacReaded.SactDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + sacReaded.SactDataList[i].IDName, 0);
                }
                
            }

            if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 0)//alınmamış
            {
                if (sacReaded.SactDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Saclar" + ".json");
         SacData sacReaded = new SacData();
        sacReaded = JsonUtility.FromJson<SacData>(json);
         for (int i = 0; i < sacReaded.SactDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, kafa_layout.transform);
            obj.gameObject.name = sacReaded.SactDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = sac_sprites[sacReaded.SactDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + sacReaded.SactDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + sacReaded.SactDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + sacReaded.SactDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + sacReaded.SactDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + sacReaded.SactDataList[i].Durum;
            obj.transform.tag = sacReaded.SactDataList[i].Tag;

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.HasKey("" + sacReaded.SactDataList[i].IDName))
            {

            }
            else
            {
                if (sacReaded.SactDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + sacReaded.SactDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + sacReaded.SactDataList[i].IDName, 0);
                }
                
            }

            if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 0)//alınmamış
            {
                if (sacReaded.SactDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
      StartCoroutine(sac_olustur_enum());

#else
        
#endif
        // string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Saclar" + ".json");

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ayakkabi_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Ayakkabilar.json");
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
        AyakkabiData ayakReaded = new AyakkabiData();
        ayakReaded = JsonUtility.FromJson<AyakkabiData>(dataAsJson);
        for (int i = 0; i < ayakReaded.AyakkabiDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, ayakkabi_layout.transform);
            obj.gameObject.name = ayakReaded.AyakkabiDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = ayakkabi_sprites[ayakReaded.AyakkabiDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + ayakReaded.AyakkabiDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + ayakReaded.AyakkabiDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + ayakReaded.AyakkabiDataList[i].TakipciArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + ayakReaded.AyakkabiDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + ayakReaded.AyakkabiDataList[i].Durum;
            obj.transform.tag = ayakReaded.AyakkabiDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + ayakReaded.AyakkabiDataList[i].IDName))
            {

            }
            else
            {
                if (ayakReaded.AyakkabiDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + ayakReaded.AyakkabiDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + ayakReaded.AyakkabiDataList[i].IDName, 0);
                }

            }


            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 0)//alınmamış
            {

                if (ayakReaded.AyakkabiDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + ayakReaded.AyakkabiDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
    }
    IEnumerator bacak_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Bacaklar.json");
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
        BacakData bacakReaded = new BacakData();
        bacakReaded = JsonUtility.FromJson<BacakData>(dataAsJson);
        for (int i = 0; i < bacakReaded.BacakDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, bacak_layout.transform);
            obj.gameObject.name = bacakReaded.BacakDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = bacak_sprites[bacakReaded.BacakDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + bacakReaded.BacakDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + bacakReaded.BacakDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + bacakReaded.BacakDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + bacakReaded.BacakDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + bacakReaded.BacakDataList[i].Durum;
            obj.transform.tag = bacakReaded.BacakDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + bacakReaded.BacakDataList[i].IDName))
            {

            }
            else
            {
                if (bacakReaded.BacakDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + bacakReaded.BacakDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + bacakReaded.BacakDataList[i].IDName, 0);
                }

            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }


            if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 0)//alınmamış
            {
                if (bacakReaded.BacakDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + bacakReaded.BacakDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
    }
    IEnumerator govde_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Govde.json");
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
        GovdeData govdeReaded = new GovdeData();
        govdeReaded = JsonUtility.FromJson<GovdeData>(dataAsJson);
       for (int i = 0; i < govdeReaded.GovdeDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, govde_layout.transform);
            obj.gameObject.name = govdeReaded.GovdeDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = govde_sprites[govdeReaded.GovdeDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + govdeReaded.GovdeDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + govdeReaded.GovdeDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + govdeReaded.GovdeDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + govdeReaded.GovdeDataList[i].ItemFiyat;
            // obj.transform.GetChild(0).gameObject.name = "" + govdeReaded.GovdeDataList[i].Durum;
            obj.transform.tag = govdeReaded.GovdeDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + govdeReaded.GovdeDataList[i].IDName))
            {

            }
            else
            {
                if (govdeReaded.GovdeDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + govdeReaded.GovdeDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + govdeReaded.GovdeDataList[i].IDName, 0);
                }
               
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 0)//alınmamış
            {
                if (govdeReaded.GovdeDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + govdeReaded.GovdeDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
    }
    IEnumerator kiyafet_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Kiyafetler.json");
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
        KiyafetData kiyafetReaded = new KiyafetData();
        kiyafetReaded = JsonUtility.FromJson<KiyafetData>(dataAsJson);
        for (int i = 0; i < kiyafetReaded.KiyafetDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, govde_layout.transform);
            obj.gameObject.name = kiyafetReaded.KiyafetDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = kiyafet_sprites[kiyafetReaded.KiyafetDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + kiyafetReaded.KiyafetDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + kiyafetReaded.KiyafetDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + kiyafetReaded.KiyafetDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + kiyafetReaded.KiyafetDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + kiyafetReaded.KiyafetDataList[i].Durum;
            obj.transform.tag = kiyafetReaded.KiyafetDataList[i].Tag;

            if (PlayerPrefs.HasKey("" + kiyafetReaded.KiyafetDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + kiyafetReaded.KiyafetDataList[i].IDName, 0);
            }

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 0)//alınmamış
            {
                if (kiyafetReaded.KiyafetDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + kiyafetReaded.KiyafetDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
    }
    IEnumerator gozluk_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Gozlukler.json");
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

        GozlukData gozlukReaded = new GozlukData();
        gozlukReaded = JsonUtility.FromJson<GozlukData>(dataAsJson);
        for (int i = 0; i < gozlukReaded.GozluktDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, kafa_layout.transform);
            obj.gameObject.name = gozlukReaded.GozluktDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = gozluk_sprites[gozlukReaded.GozluktDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + gozlukReaded.GozluktDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + gozlukReaded.GozluktDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + gozlukReaded.GozluktDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + gozlukReaded.GozluktDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + gozlukReaded.GozluktDataList[i].Durum;
            obj.transform.tag = gozlukReaded.GozluktDataList[i].Tag;

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.HasKey("" + gozlukReaded.GozluktDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + gozlukReaded.GozluktDataList[i].IDName, 0);

            }

            if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 0)//alınmamış
            {
                if (gozlukReaded.GozluktDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + gozlukReaded.GozluktDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
    }
    IEnumerator sac_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Saclar.json");
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
        SacData sacReaded = new SacData();
        sacReaded = JsonUtility.FromJson<SacData>(dataAsJson);
        for (int i = 0; i < sacReaded.SactDataList.Count; i++)
        {
            GameObject obj = Instantiate(prefab, kafa_layout.transform);
            obj.gameObject.name = sacReaded.SactDataList[i].IDName;
            obj.transform.GetChild(7).GetComponent<Image>().sprite = sac_sprites[sacReaded.SactDataList[i].ResimID];
            obj.transform.GetChild(1).GetComponent<Text>().text = "+" + sacReaded.SactDataList[i].ParaArtis + "%";
            obj.transform.GetChild(2).GetComponent<Text>().text = "+" + sacReaded.SactDataList[i].TakipciArtis + "%";
            obj.transform.GetChild(4).GetComponent<Text>().text = "" + sacReaded.SactDataList[i].PopiArtis;
            obj.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "" + sacReaded.SactDataList[i].ItemFiyat;
            //obj.transform.GetChild(0).gameObject.name = "" + sacReaded.SactDataList[i].Durum;
            obj.transform.tag = sacReaded.SactDataList[i].Tag;

            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.HasKey("" + sacReaded.SactDataList[i].IDName))
            {

            }
            else
            {
                if (sacReaded.SactDataList[i].ID % 100 == 1)
                {
                    PlayerPrefs.SetInt("" + sacReaded.SactDataList[i].IDName, 2);
                }
                else
                {
                    PlayerPrefs.SetInt("" + sacReaded.SactDataList[i].IDName, 0);
                }

            }

            if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 0)//alınmamış
            {
                if (sacReaded.SactDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(5).gameObject.SetActive(false);
                    obj.transform.GetChild(6).gameObject.SetActive(false);
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(5).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + sacReaded.SactDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(3).gameObject.SetActive(false);
                obj.transform.GetChild(5).gameObject.SetActive(true);
                obj.transform.GetChild(6).gameObject.SetActive(true);
                obj.transform.GetChild(9).gameObject.SetActive(false);
            }
        }
    }
}
