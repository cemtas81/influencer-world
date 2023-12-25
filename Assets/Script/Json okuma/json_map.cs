using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class json_map : MonoBehaviour
{

    public GameObject[] konumlar;
    public Sprite[] fotolar;

    [Serializable]
    public class MapData
    {
        public List<MapBilgiler> KonumDataList = new List<MapBilgiler>();
    }
    [Serializable]
    public class MapBilgiler
    {
        public int ID;
        public string Name;
        public int Maliyet;
        public int Boost;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        map_olustur();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void map_olustur()
    {
       
#if UNITY_EDITOR
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "MapKonumlar" + ".json");
        MapData mapReaded = new MapData();
        mapReaded = JsonUtility.FromJson<MapData>(json);
        for (int i = 0; i < mapReaded.KonumDataList.Count; i++)
        {
            konumlar[i].transform.GetChild(4).GetComponent<Text>().text = "" + mapReaded.KonumDataList[i].Maliyet;
            konumlar[i].transform.GetChild(1).GetComponent<Text>().text = "+" + mapReaded.KonumDataList[i].Boost + "%";
            konumlar[i].transform.GetChild(5).name = mapReaded.KonumDataList[i].Name;
            
            for (int j = 0; j < fotolar.Length; j++)
            {
                if (fotolar[j].name == mapReaded.KonumDataList[i].Name)
                {
                    konumlar[i].transform.GetChild(5).GetComponent<Image>().sprite = fotolar[j];
                    break;
                }
            }

            if (PlayerPrefs.HasKey("" + mapReaded.KonumDataList[i].Name))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + mapReaded.KonumDataList[i].Name, 0);
            }
        }
#elif UNITY_IOS
        string json = File.ReadAllText(Application.dataPath + "/Raw/" + "MapKonumlar" + ".json");
         MapData mapReaded = new MapData();
        mapReaded = JsonUtility.FromJson<MapData>(json);
        for (int i = 0; i < mapReaded.KonumDataList.Count; i++)
        {
            konumlar[i].transform.GetChild(4).GetComponent<Text>().text = "" + mapReaded.KonumDataList[i].Maliyet;
            konumlar[i].transform.GetChild(1).GetComponent<Text>().text = "+" + mapReaded.KonumDataList[i].Boost + "%";
            konumlar[i].transform.GetChild(5).name = mapReaded.KonumDataList[i].Name;
            
            for (int j = 0; j < fotolar.Length; j++)
            {
                if (fotolar[j].name == mapReaded.KonumDataList[i].Name)
                {
                    konumlar[i].transform.GetChild(5).GetComponent<Image>().sprite = fotolar[j];
                    break;
                }
            }

            if (PlayerPrefs.HasKey("" + mapReaded.KonumDataList[i].Name))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + mapReaded.KonumDataList[i].Name, 0);
            }
        }
#elif UNITY_ANDROID
         StartCoroutine(map_olustur_enum());

#else

#endif
    }
    IEnumerator map_olustur_enum()
    {

        string filePath;
        filePath = Path.Combine(Application.streamingAssetsPath + "/", "MapKonumlar.json");
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

        MapData mapReaded = new MapData();
        mapReaded = JsonUtility.FromJson<MapData>(dataAsJson);
        for (int i = 0; i < mapReaded.KonumDataList.Count; i++)
        {
            konumlar[i].transform.GetChild(4).GetComponent<Text>().text = "" + mapReaded.KonumDataList[i].Maliyet;
            konumlar[i].transform.GetChild(1).GetComponent<Text>().text = "+" + mapReaded.KonumDataList[i].Boost + "%";
            konumlar[i].transform.GetChild(5).name = mapReaded.KonumDataList[i].Name;

            for (int j = 0; j < fotolar.Length; j++)
            {
                if (fotolar[j].name == mapReaded.KonumDataList[i].Name)
                {
                    konumlar[i].transform.GetChild(5).GetComponent<Image>().sprite = fotolar[j];
                    break;
                }
            }

            if (PlayerPrefs.HasKey("" + mapReaded.KonumDataList[i].Name))
            {

            }
            else
            {
                PlayerPrefs.SetInt("" + mapReaded.KonumDataList[i].Name, 0);
            }
        }
    }
}
