using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class json_deneme : MonoBehaviour
{
    public GameObject prefab;
    public GameObject ana_obje;


    [Serializable]
    public class WrapperLevelData
    {
        public List<LevelData> LevelDataList = new List<LevelData>();
    }
    [Serializable]
    public class LevelData
    {
        public int ID;
        public int ResimID;
        public int ParaArtis;
        public int TakipciArtis;
        public int PopiArtis;
        public int ItemFiyat;
        
    }
    public int ID(int stage)
    {
        string json = File.ReadAllText(Application.dataPath + "/ StreamingAssets /" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        return wlpReaded.LevelDataList[stage].ID;
    }
    public int ResimID(int level)
    {
        string json = File.ReadAllText(Application.dataPath + "/ StreamingAssets /" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        return wlpReaded.LevelDataList[level].ResimID;
    }
    public int ParaArtis(int level)
    {
        string json = File.ReadAllText(Application.dataPath + "/ StreamingAssets /" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        return wlpReaded.LevelDataList[level].ParaArtis;
    }
    public int TakipciArtis(int level)
    {
        string json = File.ReadAllText(Application.dataPath + "/ StreamingAssets /" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        return wlpReaded.LevelDataList[level].TakipciArtis;
    }
    public int PopiArtis(int level)
    {
        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        return wlpReaded.LevelDataList[level].PopiArtis;
    }
    public int ItemFiyat(int level)
    {
        string json = File.ReadAllText(Application.dataPath + "/ StreamingAssets /" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        return wlpReaded.LevelDataList[level].ItemFiyat;
    }

    // Start is called before the first frame update
    void Start()
    {
        /*string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        wlpReaded.LevelDataList[0].ItemFiyat = 111;
        string s = JsonUtility.ToJson(wlpReaded, true);
        string json1 = Application.dataPath + "/StreamingAssets/" + "LevelDataList" + ".json";
        File.WriteAllText(json1, s);*/

        string json = File.ReadAllText(Application.dataPath + "/StreamingAssets/" + "LevelDataList" + ".json");
        WrapperLevelData wlpReaded = new WrapperLevelData();
        wlpReaded = JsonUtility.FromJson<WrapperLevelData>(json);
        // Debug.Log("***************" + wlpReaded.LevelDataList.Count);
        for (int i = 0; i < wlpReaded.LevelDataList.Count; i++)
        {
           GameObject obj= Instantiate(prefab, ana_obje.transform);
            obj.gameObject.name =""+wlpReaded.LevelDataList[i].ID;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
#if UNITY_ANDROID


#elif UNITY_IOS
#else
#endif

    /*string path2 = Application.streamingAssetsPath + "/Level" + PlayerPrefs.GetInt("Level") + ".json";
    UnityEngine.Networking.UnityWebRequest www = UnityEngine.Networking.UnityWebRequest.Get(path2);
    www.SendWebRequest();
        /WWW reader = new WWW(path2);/
       /* while (!reader.isDone) { }*/
    /*  while (!www.isDone)
      {
      }
      jsonString = www.downloadHandler.text;
      tests.text = jsonString;*/
}