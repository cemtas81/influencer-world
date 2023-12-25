using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_panel : MonoBehaviour
{
    // Start is called before the first frame update
    
   
    private int kazanilan_takipci = 10;

    public GameObject disko;

    void Start()
    {
       
        transform.GetChild(5).GetComponent<Text>().text = "+" + kazanilan_takipci+"%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void event_button()//eski
    {
        /*if (PlayerPrefs.GetInt("takipci")>=System.Int32.Parse(transform.GetChild(8).GetComponent<Text>().text) && 
            PlayerPrefs.GetInt("para") >= System.Int32.Parse(transform.GetChild(6).GetComponent<Text>().text))
        {
            PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") - gerekli_para * PlayerPrefs.GetInt("event"));
            PlayerPrefs.SetInt("event", PlayerPrefs.GetInt("event") + 1);
            GameObject.Find("Main Camera").GetComponent<AlllGame>().disko_panel_fonk();
        }*/
    }
    public void event_odul_ver()
    {
        GameObject.Find("Game_Manager").GetComponent<AllPP>().dans_artis_ayarla_cagir(10);
        // AllPP.dans_bust = 10;
        // PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + kazanilan_takipci * PlayerPrefs.GetInt("event"));
        // transform.GetChild(8).GetComponent<Text>().text = "" + gerekli_takipci * PlayerPrefs.GetInt("event");
        // transform.GetChild(6).GetComponent<Text>().text = "" + gerekli_para * PlayerPrefs.GetInt("event");
        // transform.GetChild(10).GetComponent<Text>().text = "" + kazanilan_takipci * PlayerPrefs.GetInt("event");
    }
    public void event_x2odul_ver()
    {
        GameObject.Find("Game_Manager").GetComponent<AllPP>().dans_artis_ayarla_cagir(20);
        //AllPP.dans_bust = 20;
        // PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + kazanilan_takipci * PlayerPrefs.GetInt("event"));
        // transform.GetChild(8).GetComponent<Text>().text = "" + gerekli_takipci * PlayerPrefs.GetInt("event");
        // transform.GetChild(6).GetComponent<Text>().text = "" + gerekli_para * PlayerPrefs.GetInt("event");
        // transform.GetChild(10).GetComponent<Text>().text = "" + kazanilan_takipci * PlayerPrefs.GetInt("event");
    }
}
