using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class json_mobilya : MonoBehaviour
{
    public Sprite[] mobilyalar_sprite;
    public GameObject mainoda_layout,gymoda_layout, muzikoda_layout, mutfakoda_layout;
    public GameObject mobilya_prefab;
    GameObject obj;


    [Serializable]
    public class MobilyaData
    {
        public List<MobilyaBilgiler> MobilyaDataList = new List<MobilyaBilgiler>();
    }
    [Serializable]
    public class MobilyaBilgiler
    {
        public int ID;
        public string IDName;
        public int ResimID;
        public int TakipciArtis;
        public int ItemFiyat;
        public int Kamera;
        public int Oda;

    }


    void Awake()
    {
        mobilya_olustur();
    }

    void Update()
    {

    }
    public void mobilya_olustur()
    {
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "Mobilyalar" + ".json");
        MobilyaData mobilyaReaded = new MobilyaData();
        mobilyaReaded = JsonUtility.FromJson<MobilyaData>(json);
        for (int i = 0; i < mobilyaReaded.MobilyaDataList.Count; i++)
        {

           // GameObject obj = Instantiate(mobilya_prefab, gymoda_layout.transform);
            if (mobilyaReaded.MobilyaDataList[i].Oda==1)
            {
                 obj = Instantiate(mobilya_prefab, mainoda_layout.transform);
            }
            else if(mobilyaReaded.MobilyaDataList[i].Oda == 2)
            {
                obj = Instantiate(mobilya_prefab, gymoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 3)
            {
                obj = Instantiate(mobilya_prefab, muzikoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 4)
            {
                obj = Instantiate(mobilya_prefab, mutfakoda_layout.transform);
            }


            obj.gameObject.name = mobilyaReaded.MobilyaDataList[i].IDName;
            obj.transform.GetChild(3).GetComponent<Text>().text = "" + mobilyaReaded.MobilyaDataList[i].IDName;
            obj.transform.GetChild(2).GetComponent<Image>().sprite = mobilyalar_sprite[mobilyaReaded.MobilyaDataList[i].ResimID];
            //obj.transform.GetChild(4).GetComponent<Text>().text = "+" + mobilyaReaded.MobilyaDataList[i].ParaArtis + "%";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + mobilyaReaded.MobilyaDataList[i].TakipciArtis ;
            obj.transform.GetChild(7).GetComponent<Text>().text = "" + mobilyaReaded.MobilyaDataList[i].ItemFiyat;
            obj.transform.GetChild(0).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Kamera;
            obj.transform.GetChild(1).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Oda;

            if (PlayerPrefs.HasKey("" + mobilyaReaded.MobilyaDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + mobilyaReaded.MobilyaDataList[i].IDName, 0);
            }
            //obj.transform.GetChild(0).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Durum;


            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 0)//alınmamış
            {
                if(mobilyaReaded.MobilyaDataList[i].ItemFiyat==0)
                {
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(0).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                    obj.transform.GetChild(7).gameObject.SetActive(false);
                    obj.transform.GetChild(10).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(0).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                    obj.transform.GetChild(10).gameObject.SetActive(false);
                }
                
            }
            else if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(0).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
                obj.transform.GetChild(7).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(10).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(9).gameObject.SetActive(false);
                obj.transform.GetChild(7).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(10).gameObject.SetActive(false);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "Mobilyalar" + ".json");
         MobilyaData mobilyaReaded = new MobilyaData();
        mobilyaReaded = JsonUtility.FromJson<MobilyaData>(json);
          for (int i = 0; i < mobilyaReaded.MobilyaDataList.Count; i++)
        {

           // GameObject obj = Instantiate(mobilya_prefab, gymoda_layout.transform);
            if (mobilyaReaded.MobilyaDataList[i].Oda==1)
            {
                 obj = Instantiate(mobilya_prefab, mainoda_layout.transform);
            }
            else if(mobilyaReaded.MobilyaDataList[i].Oda == 2)
            {
                obj = Instantiate(mobilya_prefab, gymoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 3)
            {
                obj = Instantiate(mobilya_prefab, muzikoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 4)
            {
                obj = Instantiate(mobilya_prefab, mutfakoda_layout.transform);
            }


            obj.gameObject.name = mobilyaReaded.MobilyaDataList[i].IDName;
            obj.transform.GetChild(3).GetComponent<Text>().text = "" + mobilyaReaded.MobilyaDataList[i].IDName;
            obj.transform.GetChild(2).GetComponent<Image>().sprite = mobilyalar_sprite[mobilyaReaded.MobilyaDataList[i].ResimID];
            //obj.transform.GetChild(4).GetComponent<Text>().text = "+" + mobilyaReaded.MobilyaDataList[i].ParaArtis + "%";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + mobilyaReaded.MobilyaDataList[i].TakipciArtis ;
            obj.transform.GetChild(7).GetComponent<Text>().text = "" + mobilyaReaded.MobilyaDataList[i].ItemFiyat;
            obj.transform.GetChild(0).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Kamera;
            obj.transform.GetChild(1).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Oda;

            if (PlayerPrefs.HasKey("" + mobilyaReaded.MobilyaDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + mobilyaReaded.MobilyaDataList[i].IDName, 0);
            }
            //obj.transform.GetChild(0).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Durum;


            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 0)//alınmamış
            {
                if(mobilyaReaded.MobilyaDataList[i].ItemFiyat==0)
                {
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(0).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                    obj.transform.GetChild(7).gameObject.SetActive(false);
                    obj.transform.GetChild(10).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(0).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                    obj.transform.GetChild(10).gameObject.SetActive(false);
                }
                
            }
            else if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(0).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
                obj.transform.GetChild(7).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(10).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(9).gameObject.SetActive(false);
                obj.transform.GetChild(7).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(10).gameObject.SetActive(false);
            }
        }
#elif UNITY_ANDROID
         StartCoroutine(LoadLocalizedTextOnAndroid());

#else

      
       
#endif


    }
    public void mobilya_guncelle(string ad, int durum)
    {
        PlayerPrefs.SetInt("" + ad, durum);
    }
    IEnumerator LoadLocalizedTextOnAndroid()
    {
       
        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "Mobilyalar.json");
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
        
        MobilyaData mobilyaReaded = new MobilyaData();
        mobilyaReaded = JsonUtility.FromJson<MobilyaData>(dataAsJson);
        for (int i = 0; i < mobilyaReaded.MobilyaDataList.Count; i++)
        {

            // GameObject obj = Instantiate(mobilya_prefab, gymoda_layout.transform);
            if (mobilyaReaded.MobilyaDataList[i].Oda == 1)
            {
                obj = Instantiate(mobilya_prefab, mainoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 2)
            {
                obj = Instantiate(mobilya_prefab, gymoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 3)
            {
                obj = Instantiate(mobilya_prefab, muzikoda_layout.transform);
            }
            else if (mobilyaReaded.MobilyaDataList[i].Oda == 4)
            {
                obj = Instantiate(mobilya_prefab, mutfakoda_layout.transform);
            }


            obj.gameObject.name = mobilyaReaded.MobilyaDataList[i].IDName;
            obj.transform.GetChild(3).GetComponent<Text>().text = "" + mobilyaReaded.MobilyaDataList[i].IDName;
            obj.transform.GetChild(2).GetComponent<Image>().sprite = mobilyalar_sprite[mobilyaReaded.MobilyaDataList[i].ResimID];
            //obj.transform.GetChild(4).GetComponent<Text>().text = "+" + mobilyaReaded.MobilyaDataList[i].ParaArtis + "%";
            obj.transform.GetChild(5).GetComponent<Text>().text = "+" + mobilyaReaded.MobilyaDataList[i].TakipciArtis;
            obj.transform.GetChild(7).GetComponent<Text>().text = "" + mobilyaReaded.MobilyaDataList[i].ItemFiyat;
            obj.transform.GetChild(0).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Kamera;
            obj.transform.GetChild(1).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Oda;

            if (PlayerPrefs.HasKey("" + mobilyaReaded.MobilyaDataList[i].IDName))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + mobilyaReaded.MobilyaDataList[i].IDName, 0);
            }
            //obj.transform.GetChild(0).gameObject.name = "" + mobilyaReaded.MobilyaDataList[i].Durum;


            for (int k = 0; k < obj.transform.childCount; k++)
            {
                obj.transform.GetChild(k).gameObject.SetActive(true);
            }

            if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 0)//alınmamış
            {
                if (mobilyaReaded.MobilyaDataList[i].ItemFiyat == 0)
                {
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(0).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                    obj.transform.GetChild(7).gameObject.SetActive(false);
                    obj.transform.GetChild(10).gameObject.SetActive(true);
                }
                else
                {
                    obj.transform.GetChild(8).gameObject.SetActive(false);
                    obj.transform.GetChild(0).gameObject.SetActive(false);
                    obj.transform.GetChild(9).gameObject.SetActive(false);
                    obj.transform.GetChild(10).gameObject.SetActive(false);
                }

            }
            else if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 1)//alınmış
            {
                obj.transform.GetChild(8).gameObject.SetActive(false);
                obj.transform.GetChild(0).gameObject.SetActive(false);
                obj.transform.GetChild(9).gameObject.SetActive(false);
                obj.transform.GetChild(7).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(10).gameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("" + mobilyaReaded.MobilyaDataList[i].IDName) == 2)//giyilmiş
            {
                obj.transform.GetChild(9).gameObject.SetActive(false);
                obj.transform.GetChild(7).gameObject.SetActive(false);
                obj.transform.GetChild(6).gameObject.SetActive(false);
                obj.transform.GetChild(10).gameObject.SetActive(false);
            }
        }
    }
}
