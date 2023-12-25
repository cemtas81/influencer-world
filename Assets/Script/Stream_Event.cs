using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stream_Event : MonoBehaviour
{
    public Image fillbar;
    private bool basma,control;
    public GameObject game_manager;
    public Text takipci_text;
    // Start is called before the first frame update
    void Start()
    {
        baslangic();
    }

    // Update is called once per frame
    void Update()
    {
        if(basma&&control)
        tiklama();
        if(fillbar.fillAmount>=1)
        {
            control = false;
            fillbar.fillAmount = 0.99f;
            Reklam.odul_bak = 1;
            //game_manager.GetComponent<Reklam>().reklam_izlet();
        }
    }
    public void baslangic()
    {
        fillbar.fillAmount = 0;
        takipci_text.text="+"+(1000 + ((PlayerPrefs.GetInt("takipci") / 100) * 10));
        basma = false;
        control = true;
    }

    private void tiklama()
    {
        fillbar.fillAmount = fillbar.fillAmount + 0.005f;
    }

    public void basildi()
    {
        basma = true;
    }
    public void cekildi()
    {
        basma = false;
    }



}
