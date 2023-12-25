using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class admin_panel : MonoBehaviour
{
    public InputField level_input,para_input,takipci_input;
    public GameObject admin_panel_UI;
    public InputField t_zaman_input, para_artis_oran_input, rnd_y_input, rnd_x_input, rnd_k_input, rnd_z_input;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void pp_sifirla_fonk()
    {
        PlayerPrefs.DeleteAll();
        foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
        {
            obje.baslangic_kontrol();
        }
        foreach (Ekipman_Gelistirme obje in Resources.FindObjectsOfTypeAll<Ekipman_Gelistirme>())
        {
            obje.baslangic_kontrol();
        }
        foreach (mobilya_alma obje in Resources.FindObjectsOfTypeAll<mobilya_alma>())
        {
            obje.baslangic_kontrol();
        }
        GameObject.Find("Game_Manager").GetComponent<AllPP>().Awake();
        GameObject.Find("Game_Manager").GetComponent<AllPP>().level_text.text = "Level " + PlayerPrefs.GetFloat("level");
        
    }

    public void level_ata_fonk()
    {
        PlayerPrefs.SetFloat("level", float.Parse("" + level_input.text, CultureInfo.InvariantCulture.NumberFormat));
        GameObject.Find("Game_Manager").GetComponent<AllPP>().level_text.text = "Level " + PlayerPrefs.GetFloat("level");
    }
    public void para_ata_fonk()
    {
        PlayerPrefs.SetFloat("para", System.Int32.Parse(para_input.text));
    }
    public void takipci_ata_fonk()
    {
        PlayerPrefs.SetInt("takipci", System.Int32.Parse(takipci_input.text));
    }
    public void rnd_y_fonk()
    {
        PlayerPrefs.SetInt("rnd_y", System.Int32.Parse(rnd_y_input.text)+1);
    }
    public void rnd_x_fonk()
    {
        PlayerPrefs.SetInt("rnd_x", System.Int32.Parse(rnd_x_input.text));
    }
    public void rnd_k_fonk()
    {
        PlayerPrefs.SetInt("rnd_k", System.Int32.Parse(rnd_k_input.text)+1);
    }
    public void rnd_z_fonk()
    {
        PlayerPrefs.SetInt("rnd_z", System.Int32.Parse(rnd_z_input.text));
    }

    public void para_artis_oran_fonk()
    {
        PlayerPrefs.SetFloat("p_artis", float.Parse("" + para_artis_oran_input.text, CultureInfo.InvariantCulture.NumberFormat));
    }

    public void t_zaman_fonk()
    {
        PlayerPrefs.SetInt("t_zaman", System.Int32.Parse(t_zaman_input.text));
    }

    public void admin_ac_kapa()
    {
        if (admin_panel_UI.activeSelf)
            admin_panel_UI.SetActive(false);
        else
            admin_panel_UI.SetActive(true);
    }




}
