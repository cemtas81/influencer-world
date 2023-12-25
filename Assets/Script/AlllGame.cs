
using MoreMountains.NiceVibrations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AlllGame : MonoBehaviour
{
    public GameObject Disko_Panel_UI,Oyun_Panel_UI, Settings_Panel_UI, Bedroom_Panel_UI, Wardrobe_Panel_UI, Improvements_Panel_UI, Information_Panel_UI;
    public GameObject Character_Panel_UI, Ranking_Panel_UI, Shop_Panel_UI, Welcome_Back_Panel_UI, Stream_Event_Panel_UI, Word_Map_Panel_UI,Event_Panel_UI;
    public GameObject Followers_Panel_UI, Video_Yorum_Panel_UI, Sponsor_Panel_UI, Video_kayit_Panel_UI,animation_panel_UI, Sponsor_Reklam_Panel_UI;
    public GameObject kiyafet_kafa_go, kiyafet_govde_go, kiyafet_bacak_go, kiyafet_ayak_go;
   
    public Button kafa_button,govde_button,bacak_button,ayak_button;
    public GameObject popup_cerceve;
    public GameObject[] popuplar;
    public GameObject donanim_secim, mobilya_secim;
    public Sprite titresim_on_image,titresim_off_image, ses_on_image, ses_off_image;
   // public Image donanim_button_image, mobilya_button_image;
    public Button titresim_button,ses_button;
    private int sayac;
    public GameObject time_text;
    public float time, time2;
    public static bool gerisay, gerisay2;
    public Button x3_button;
    public GameObject game_manager;
    //fps 
    public float timer, refresh, avgFramerate;
    public string display = "{0}FPS";
    public Text fps_text;
    
    public GameObject camera_foto;
    public GameObject[] dolap_kiyafetler;
    // Start is called before the first frame update
    public GameObject ana_muzik_obje;
    public AudioClip button_ses,yetersizpara_ses,satinalma_ses;
    public AudioSource efekt_oynatici;
    public static bool exit_fonk_bak;
    private Animator anim;
    public Slider anim_slider;
    public Scrollbar scrollbar;
    public Sprite[] isiklar_list;
    public Sprite[] masalar_list;
    public Sprite[] sandalyelar_list;
    public Sprite[] telefon_liste;
    public Sprite[] bilgisayar_liste;
    public Sprite[] saat_liste;
    public GameObject boyama_panel_UI,giyinme_dolabi_UI;
    public Button duvar_boya_button, zemin_boya_button,tavan_boya_button;
   // public Sprite duvar_boya_button_on, duvar_boya_button_off, zemin_boya_button_on, zemin_boya_button_off,tavan_boya_button_on, tavan_boya_button_off;
    private int uyari_dolap_sayac, uyari_kafa_sayac, uyari_govde_sayac, uyari_bacak_sayac, uyari_ayak_sayac;
    private int uyari_ekipman_sayac, uyari_ekipman_donanim_sayac, uyari_ekipman_mobilya_sayac;
    public GameObject kiz_video,giyinme_odasi;
    public Material[] kiyafet_matlar;
    public Material kiyafet_transparan;
    public GameObject[] kiyafetler;
    public Material telefon_mat;
    public Texture[] telefon_mat_sprite;
    

    //level ödül panel
    public Image level_odul_bar;
    public Text level_odul_derece1_text, level_odul_derece2_text, level_odul_rank1_text, level_odul_rank2_text, level_popi_text, level_takipci_text, level_para_text;
    public Button level_odul_3x_button, level_odul_button;
    public Image level_image;
    public Sprite level_sprite_duz, level_sprite_odul;
    public GameObject level_rank,level_bar;
    /// 
    public GameObject disko_oda;

    public GameObject giyinme_odasi_kiz;
    public GameObject oyun_tutorial;
    public GameObject geri_sayim_gameobject;
    public Image geri_sayim_image;
    
    public Text seyahat_zaman_text;

    public Image dans_gerisayim_image; 
    public static float dans_gecen_zaman, dans_image_baryuzde;
    public static bool dans_gerisay;
    public GameObject para_anim,takipci_anim,popup_parent;
    public Image bedroom_panel_image;
    public Sprite bedrom_panel_buy_sprite, bedrom_panel_upgrade_sprite;
    public GameObject bedroom_kameralar;
    public GameObject bedroom_kamera1, bedroom_kamera2, bedroom_kamera3,bedroom_kamera_main;
    public GameObject wardrobe_kamera_ayak, wardrobe_kamera_bacak, wardrobe_kamera_govde, wardrobe_kamera_kafa, wardrobe_kamera_vucut;
    public GameObject mobilya_konfeti;
    public static bool mobilya_kontrol_bool;
    public Image wardrobe_panel_image;
    public Sprite wardrobe_ayakkabi_sprite, wardrobe_etec_sprite, wardrobe_gozluk_sprite, wardrobe_ust_sprite;
    public Text versiyon_text;
    public Sprite buy_image_secildi, buy_image_secilmedi, upgrade_image_secildi, upgrade_image_secilmedi;


    public Image bedrom_buy_image, bedrom_upgrade_image;
    public GameObject kiz_disko;
    public Sprite effect_off_image, effect_on_image;
    public Button effect_button;
    private float ParaFloat_timer,tbt_popup_timer;
    public Text tbt_popup_text;
    public Sprite[] tbt_sprites;
    public Image tbt_image;
    public Sprite[] sponsor_sprites;
    public Image sponsor_image, sponsor_reklam_image;
    public Text sponsor_isim_text, sponsor_reklam_isim_text;
    private string[] sponsor_isim_list = { "Mary", "Charles", "Joseph", "Daniel", "Patricia", "Margaret", "Dorothy" };
    public GameObject gym_kameralar;
    public GameObject gym_kamera1, gym_kamera2, gym_kamera3, gym_kamera4, gym_kamera5, gym_kamera_main;
    public GameObject muzik_kameralar;
    public GameObject muzik_kamera1, muzik_kamera2, muzik_kamera3, muzik_kamera4, muzik_kamera_main;
    public GameObject mutfak_kameralar;
    public GameObject mutfak_kamera1, mutfak_kamera2, mutfak_kamera3, mutfak_kamera_main;
    public Animator gym_kamera_anim, muzik_oda_kamera_anim, mutfak_kamera_anim;
    public GameObject gym_kamera, muzik_kamera, mutfak_kamera;
    public GameObject gym_kiz_paket, muzik_kiz_paket, mutfak_kiz_paket;
    public GameObject gym_kiz, muzik_kiz, mutfak_kiz,dolap_kiz;
    public static int oda_durumu;
    public GameObject mobilya_secim_gym, mobilya_secim_muzik, mobilya_secim_mutfak;
    public GameObject donanim_button, mobilya_button;
    public GameObject bedroom_button, wardrobe_button, improvements_button, world_map_button, stram_event_button, boyama_button, settins_button, level_button;
    public GameObject gym_oda_button, mutfak_oda_button, muzik_button, dolop_button, yatakodasi_button;
    private GameObject[] button_dizi = new GameObject[4];
    public GameObject mutfak_cerceve, gym_cerceve, muzik_cerceve, dolap_cerceve, yatakodasi_cerceve;
    public GameObject muzik_odasi_obje, gym_odasi_obje, mutfak_odasi_obje;
    public GameObject duvar_boya, zemin_boya, tavan_boya, gym_duvar_boya, gym_zemin_boya, gym_tavan_boya;
    public GameObject muzik_duvar_boya, muzik_zemin_boya, muzik_tavan_boya, mutfak_duvar_boya, mutfak_zemin_boya, mutfak_tavan_boya;
    public GameObject giyinme_odasi_duvar_boya, giyinme_odasi_zemin_boya, giyinme_odasi_tavan_boya;
    public GameObject gym_boya_konum, muzik_boya_konum, mutfak_boya_konum, giyinme_boya_konum;
    public Sprite mobilya_yeni_odalar_sprite;
    public GameObject kiz_yatakodasi,kiz_etkinlik;
    private void Awake()
    {
       
        //GameAnalytics.Initialize();

    }
    void Start()
    {
        hazirlik();
        panel_ac(Oyun_Panel_UI);

       /* muzik_odasi_obje.SetActive(false);
        gym_odasi_obje.SetActive(false);
        mutfak_odasi_obje.SetActive(false);*/

        mutfak_cerceve.SetActive(false); 
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(true);


        bedroom_kameralar.SetActive(false);
        oda_durumu = 1;
        gym_kamera.SetActive(false); 
        muzik_kamera.SetActive(false); 
        mutfak_kamera.SetActive(false);
        gym_kiz_paket.SetActive(false);
        muzik_kiz_paket.SetActive(false);
        mutfak_kiz_paket.SetActive(false);
        bedrom_buy_image.sprite = buy_image_secildi;
        bedrom_upgrade_image.sprite = upgrade_image_secilmedi;
        versiyon_text.text= "v" +Application.version;
        mobilya_kontrol_bool = true;
        para_anim.SetActive(false);
        takipci_anim.SetActive(false);
        dans_gecen_zaman = 60;
        dans_image_baryuzde = 60;
        dans_gerisay = true;
        seyahat_zaman_text.gameObject.SetActive(false);
        
        geri_sayim_gameobject.SetActive(false);
        geri_sayim_image.gameObject.SetActive(false);
        exit_fonk_bak = true;
        gerisay = false;
        gerisay2 = false;
        time = 180f;
        time2 = 180f;
        sayac = 0;
        ParaFloat_timer = 0f;
        tbt_popup_timer = 0f;
        
        popup_cerceve.SetActive(true);
        if (PlayerPrefs.HasKey("back"))
        {
            //Welcome_Back_Panel_UI.SetActive(true);
        }
        else
        {
            StartCoroutine(GameObject.Find("Game_Manager").GetComponent<AllPP>().tiklama_anim());
            PlayerPrefs.SetInt("back", 0);
        }

        if (PlayerPrefs.GetInt("titresim") == 1)
        {
            titresim_button.GetComponent<Image>().sprite = titresim_on_image;
        }
        else
        {
            titresim_button.GetComponent<Image>().sprite = titresim_off_image;
        }
        if (PlayerPrefs.GetInt("ses") == 1)
        {
            ana_muzik_obje.SetActive(true);
            ses_button.GetComponent<Image>().sprite = ses_on_image;
        }
        else
        {
            ana_muzik_obje.SetActive(false);
            ses_button.GetComponent<Image>().sprite = ses_off_image;
        }
        if (PlayerPrefs.GetInt("ses_effect") == 1)
        {
            effect_button.GetComponent<Image>().sprite = effect_on_image;
        }
        else
        {
            effect_button.GetComponent<Image>().sprite = effect_off_image;
        }
       
        anim = GetComponent<Animator>();
        giyinme_odasi.SetActive(false);
        level_odul_panel_fonk();
       /* if(PlayerPrefs.GetInt("oyun_tutorial") ==0)//tutorial_goster
        {
            oyun_tutorial.SetActive(true);
        }
        else
        {
            oyun_tutorial.SetActive(false);
        }*/
        geri_sayim_image.fillAmount = 1f;
        bool testUniversal = MMVibrationManager.HapticsSupported();
        if(!testUniversal)
        {
            titresim_button.gameObject.SetActive(false);
        }
       
    }
    // Update is called once per frame
    void Update()
    {

        /*if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }*/


        ParaFloat_timer += Time.deltaTime;
        tbt_popup_timer += Time.deltaTime;
        // 23 saatte bir ödül vermek için
        /*string saat = "" + System.DateTime.Now;
        string saat2 = "" + saat[saat.Length - 8] + saat[saat.Length - 7];
        int deger = System.Int32.Parse(saat2);
        deger = (deger + 23) % 24;
        Debug.Log("saat=" + deger);
        Debug.Log("saat=" + saat);*/

        if (ParaFloat_timer > 120&&popup_cerceve.transform.childCount==0)
        {
            ParaFloat_timer = 0;
            Instantiate(popuplar[5], new Vector3(0, 0, 0), Quaternion.identity, popup_cerceve.transform).transform.localPosition = new Vector3(0, 0, 0);
        }
        if (tbt_popup_timer > 45 && popup_cerceve.transform.childCount == 0)
        {
            tbt_popup_timer = 0;
            Instantiate(popuplar[6], new Vector3(0, 0, 0), Quaternion.identity, popup_cerceve.transform).transform.localPosition = new Vector3(0, 0, 0);
        }

        // float timelapse = Time.smoothDeltaTime;
        //timer = timer <= 0 ? refresh : timer -= timelapse;
        //if (timer <= 0) avgFramerate = (int)(1f / timelapse);
        // fps_text.text = string.Format(display, avgFramerate.ToString());
        if (PlayerPrefs.GetInt("toplam_tiklama_sayisi") % 200 == 0)//popup için tıklama sayisi
        {
            PlayerPrefs.SetInt("toplam_tiklama_sayisi", PlayerPrefs.GetInt("toplam_tiklama_sayisi") + 1);
            if (sayac >= 2)
            {
                sayac = 0;
            }
            
            deneme_olustur();
            sayac++;
        }
        if(PlayerPrefs.GetInt("takipci")> PlayerPrefs.GetInt("sponsorcikar"))
        {
            PlayerPrefs.SetInt("sponsorcikar", PlayerPrefs.GetInt("sponsorcikar") + 2500);
            GameObject.Find("GameAnalytics").GetComponent<ga_script>().Follower_ga((PlayerPrefs.GetInt("sponsorcikar") - 2500) / 2500);
            int k = 0;
            for (int i = 0; i < popup_parent.transform.childCount; i++)
            {
               if(popup_parent.transform.GetChild(i).tag=="Sponsor_prefab")
                {
                    k++;
                }
            }
            if(k==0)
            {
                Instantiate(popuplar[3], new Vector3(0, 0, 0), Quaternion.identity, popup_cerceve.transform).transform.localPosition = new Vector3(0, 0, 0);
            }
        }
        
        uyari_dolap_sayac = 0;
        uyari_kafa_sayac = 0;
        uyari_govde_sayac = 0;
        uyari_bacak_sayac = 0;
        uyari_ayak_sayac = 0;
       
        foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
        {
            if(obje.fiyat_kontrol()==1 && PlayerPrefs.GetInt("" + obje.gameObject.name) == 0)
            {
                if(obje.tag=="kafa"|| obje.tag == "saclar")
                {
                    uyari_kafa_sayac++;
                }
                if (obje.tag == "govde" || obje.tag == "kiyafet")
                {
                    uyari_govde_sayac++;
                }
                if (obje.tag == "bacak")
                {
                    uyari_bacak_sayac++;
                }
                if (obje.tag == "ayak")
                {
                    uyari_ayak_sayac++;
                }
               // uyari_dolap_sayac++;
            }
        }
        uyari_dolap_sayac =  uyari_kafa_sayac + uyari_govde_sayac + uyari_bacak_sayac + uyari_ayak_sayac;
        if (uyari_dolap_sayac > 0)
        {
            if(GameObject.Find("Wardrobe_Button"))
                 GameObject.Find("Wardrobe_Button").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("Wardrobe_Button"))
                GameObject.Find("Wardrobe_Button").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        if (uyari_kafa_sayac > 0)
        {
            if(GameObject.Find("kafa_Button"))
            GameObject.Find("kafa_Button").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("kafa_Button"))
                GameObject.Find("kafa_Button").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        if (uyari_govde_sayac > 0)
        {
            if (GameObject.Find("govde_Button"))
                GameObject.Find("govde_Button").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("govde_Button"))
                GameObject.Find("govde_Button").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        if (uyari_bacak_sayac > 0)
        {
            if (GameObject.Find("bacak_Button"))
                GameObject.Find("bacak_Button").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("bacak_Button"))
                GameObject.Find("bacak_Button").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        if (uyari_ayak_sayac > 0)
        {
            if (GameObject.Find("ayak_Button"))
                GameObject.Find("ayak_Button").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("ayak_Button"))
                GameObject.Find("ayak_Button").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }

        uyari_ekipman_sayac = 0;
        uyari_ekipman_donanim_sayac = 0;
        uyari_ekipman_mobilya_sayac = 0;
        foreach (Ekipman_Gelistirme obje in Resources.FindObjectsOfTypeAll<Ekipman_Gelistirme>())
        {
            if (obje.fiyat_kontrol() == 1 )
            {
               
                if (obje.tag == "donanim")
                {
                    uyari_ekipman_sayac++;
                    uyari_ekipman_donanim_sayac++;
                }
            }
        }

        foreach (mobilya_alma obje in Resources.FindObjectsOfTypeAll<mobilya_alma>())
        {
            if (obje.fiyat_kontrol() == 1)
            {
                
                if (obje.tag == "mobilya")
                {
                   
                    uyari_ekipman_sayac++;
                    uyari_ekipman_mobilya_sayac++;
                }
            }
        }
        if (uyari_ekipman_sayac > 0)
        {
            if (GameObject.Find("Bedroom_Button"))
                GameObject.Find("Bedroom_Button").gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("Bedroom_Button"))
                GameObject.Find("Bedroom_Button").gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
        if (uyari_ekipman_donanim_sayac > 0)
        {
            if (GameObject.Find("Donanim_Button"))
                GameObject.Find("Donanim_Button").gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("Donanim_Button"))
                GameObject.Find("Donanim_Button").gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (uyari_ekipman_mobilya_sayac > 0)
        {
            if (GameObject.Find("Mobilya_Button"))
                GameObject.Find("Mobilya_Button").gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            if (GameObject.Find("Mobilya_Button"))
                GameObject.Find("Mobilya_Button").gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }



        anim_slider.value = (1 - scrollbar.value);
        if (anim.gameObject.activeSelf) anim.Play("Base Layer.kamera_sağ_sol_hareket", 0, anim_slider.value);
        if (gym_kamera_anim.gameObject.activeSelf) gym_kamera_anim.Play("Base Layer.gyn_kamera_sag_sol", 0, anim_slider.value);
        if (muzik_oda_kamera_anim.gameObject.activeSelf) muzik_oda_kamera_anim.Play("Base Layer.muzikodasi_kamera_sag_sol", 0, anim_slider.value);
        if(mutfak_kamera_anim.gameObject.activeSelf) mutfak_kamera_anim.Play("Base Layer.mutfak_kamera_sag_sol", 0, anim_slider.value);
    }
    private void LateUpdate()
    {
        
        
        if (gerisay)
        {
            time -= Time.deltaTime;
            geri_sayim_image.fillAmount = (time * 1 / 180);
           var ts = System.TimeSpan.FromSeconds(time);
           // time_text.GetComponent<TextMeshProUGUI>().text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            stram_event_button.GetComponent<Button>().interactable = false;
            geri_sayim_image.gameObject.SetActive(true);
        }
        if(gerisay && time<=0)
        {
            gerisay = false;
            AllPP.x3 = 1;
            time = 180f;
            x3_button.gameObject.SetActive(true);
           // time_text.gameObject.SetActive(false);
            stram_event_button.GetComponent<Button>().interactable = true;
            geri_sayim_gameobject.SetActive(false);
            geri_sayim_image.gameObject.SetActive(true);

        }

        if (dans_gerisay)
        {
            dans_gecen_zaman -= Time.deltaTime;
            dans_gerisayim_image.fillAmount = 1-(dans_gecen_zaman * 1 / dans_image_baryuzde);
            //var ts = System.TimeSpan.FromSeconds(dans_gecen_zaman);
            // time_text.GetComponent<TextMeshProUGUI>().text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            improvements_button.GetComponent<Button>().interactable = false;
            improvements_button.transform.GetChild(1).gameObject.SetActive(false);
           
        }
        if (dans_gerisay && dans_gecen_zaman <= 0)
        {
            improvements_button.transform.GetChild(1).gameObject.SetActive(true);
            dans_gerisay = false;
            dans_gecen_zaman = dans_image_baryuzde;
            improvements_button.GetComponent<Button>().interactable = true;
            AllPP.dans_bust = 0;
        }



        if (gerisay2)
        {
            seyahat_zaman_text.gameObject.SetActive(true);
            time2 -= Time.deltaTime;
            var ts = System.TimeSpan.FromSeconds(time2);
            seyahat_zaman_text.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            world_map_button.GetComponent<Button>().interactable = false;
           
        }
        if (gerisay2 && time2 <= 0)
        {
            gerisay2 = false;
            time2 = 180f;
            PlayerPrefs.SetInt("ucak_ta",0);
            world_map_button.GetComponent<Button>().interactable = true;
            seyahat_zaman_text.gameObject.SetActive(false);
        }
    }
    public void giyinme_dolabi_panel_fonk()
    {
        panel_ac(Oyun_Panel_UI);
        popup_cerceve.SetActive(true);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);


        if (oda_durumu!=5)
        {
            //GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }

        oda_durumu = 5;
        

        gym_kamera.SetActive(false);
        muzik_kamera.SetActive(false);
        mutfak_kamera.SetActive(false);
        bedroom_kameralar.SetActive(false);
        bedroom_kameralar.SetActive(false);
        gym_kameralar.SetActive(false);
        muzik_kameralar.SetActive(false);
        mutfak_kameralar.SetActive(false);

        muzik_odasi_obje.SetActive(false);
        gym_odasi_obje.SetActive(false);
        mutfak_odasi_obje.SetActive(false);


        panel_ac(giyinme_dolabi_UI);
        giyinme_odasi.SetActive(true);
        GameObject.Find("giyinme_odasi").GetComponent<Kiyafetodasi>().geri_don();
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
        if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }
        gym_oda_button.SetActive(true);
        mutfak_oda_button.SetActive(true);
        muzik_button.SetActive(true);
        dolop_button.SetActive(true);
        yatakodasi_button.SetActive(true);
        world_map_button.SetActive(true);
        stram_event_button.SetActive(true);
        boyama_button.SetActive(true);
        settins_button.SetActive(true);
        level_button.SetActive(true);
        geri_sayim_gameobject.SetActive(true);

        gym_oda_button.GetComponent<Button>().interactable = true;
        mutfak_oda_button.GetComponent<Button>().interactable = true;
        muzik_button.GetComponent<Button>().interactable = true;
        dolop_button.GetComponent<Button>().interactable = false;
        yatakodasi_button.GetComponent<Button>().interactable = true;

        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(true);
        yatakodasi_cerceve.SetActive(false);
       
       
    }
    public void yatakodasi_button_fonk()
    {
        panel_ac(Oyun_Panel_UI);
        popup_cerceve.SetActive(true);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);



        if (oda_durumu != 1)
        {
           // GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }

        //exit_button_fonk();
        oda_durumu = 1;
        gym_kamera.SetActive(false);
        muzik_kamera.SetActive(false);
        mutfak_kamera.SetActive(false);
        bedroom_kameralar.SetActive(false);
        bedroom_kameralar.SetActive(false);
        gym_kameralar.SetActive(false);
        muzik_kameralar.SetActive(false);
        mutfak_kameralar.SetActive(false);

        muzik_odasi_obje.SetActive(false);
        gym_odasi_obje.SetActive(false);
        mutfak_odasi_obje.SetActive(false);

        gym_kiz_paket.SetActive(false);
        muzik_kiz_paket.SetActive(false);
        mutfak_kiz_paket.SetActive(false);
        giyinme_odasi.SetActive(false);
        if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }
        gym_oda_button.SetActive(true);
        mutfak_oda_button.SetActive(true);
        muzik_button.SetActive(true);
        dolop_button.SetActive(true);
        yatakodasi_button.SetActive(true);
        world_map_button.SetActive(true);
        stram_event_button.SetActive(true);
        boyama_button.SetActive(true);
        settins_button.SetActive(true);
        level_button.SetActive(true);
        geri_sayim_gameobject.SetActive(true);


        gym_oda_button.GetComponent<Button>().interactable = true;
        mutfak_oda_button.GetComponent<Button>().interactable = true;
        muzik_button.GetComponent<Button>().interactable = true;
        dolop_button.GetComponent<Button>().interactable = true;
        yatakodasi_button.GetComponent<Button>().interactable = false;

        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(true);
        if (oda_durumu == 1)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.5f;
        }
        else if (oda_durumu == 2)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.65f;
        }
        else if (oda_durumu == 3)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.52f;
        }
        else if (oda_durumu == 4)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.33f;
        }
    }
    public void gym_oda_button_fonk()
    {
        panel_ac(Oyun_Panel_UI);
        popup_cerceve.SetActive(true);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);


        if (oda_durumu != 2)
        {
            //GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }
        oda_durumu = 2;
        gym_kamera.SetActive(true);
        muzik_kamera.SetActive(false);
        mutfak_kamera.SetActive(false);
        bedroom_kameralar.SetActive(false);
        bedroom_kameralar.SetActive(false);
        gym_kameralar.SetActive(false);
        muzik_kameralar.SetActive(false);
        mutfak_kameralar.SetActive(false);

        muzik_odasi_obje.SetActive(false);
        gym_odasi_obje.SetActive(true);
        mutfak_odasi_obje.SetActive(false);

        gym_kiz_paket.SetActive(true);
        muzik_kiz_paket.SetActive(false);
        mutfak_kiz_paket.SetActive(false);
        giyinme_odasi.SetActive(false);
        gym_kiz.transform.rotation = Quaternion.Euler(0, 7, 0);



        if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }

        gym_oda_button.SetActive(true);
        mutfak_oda_button.SetActive(true);
        muzik_button.SetActive(true);
        dolop_button.SetActive(true);
        yatakodasi_button.SetActive(true);
        world_map_button.SetActive(true);
        stram_event_button.SetActive(true);
        boyama_button.SetActive(true);
        settins_button.SetActive(true);
        level_button.SetActive(true);
        geri_sayim_gameobject.SetActive(true);



        gym_oda_button.GetComponent<Button>().interactable = false;
        mutfak_oda_button.GetComponent<Button>().interactable = true;
        muzik_button.GetComponent<Button>().interactable = true;
        dolop_button.GetComponent<Button>().interactable = true;
        yatakodasi_button.GetComponent<Button>().interactable = true;
        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(true);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);

        if (oda_durumu == 1)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.5f;
        }
        else if (oda_durumu == 2)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.65f;
        }
        else if (oda_durumu == 3)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.52f;
        }
        else if (oda_durumu == 4)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.33f;
        }
    }
    public void muzik_oda_button_fonk()
    {
        panel_ac(Oyun_Panel_UI);
        popup_cerceve.SetActive(true);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);



        if (oda_durumu != 3)
        {
            //GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }
        //exit_button_fonk();
        oda_durumu = 3;

        gym_kamera.SetActive(false);
        muzik_kamera.SetActive(true);
        mutfak_kamera.SetActive(false);
        giyinme_odasi.SetActive(false);
        bedroom_kameralar.SetActive(false);
        bedroom_kameralar.SetActive(false);
        gym_kameralar.SetActive(false);
        muzik_kameralar.SetActive(false);
        mutfak_kameralar.SetActive(false);


        muzik_odasi_obje.SetActive(true);
        gym_odasi_obje.SetActive(false);
        mutfak_odasi_obje.SetActive(false);

        gym_kiz_paket.SetActive(false);
        muzik_kiz_paket.SetActive(true);
        mutfak_kiz_paket.SetActive(false);

        muzik_kiz.transform.rotation = Quaternion.Euler(0,6, 0);

        if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }
        gym_oda_button.SetActive(true);
        mutfak_oda_button.SetActive(true);
        muzik_button.SetActive(true);
        dolop_button.SetActive(true);
        yatakodasi_button.SetActive(true);
        world_map_button.SetActive(true);
        stram_event_button.SetActive(true);
        boyama_button.SetActive(true);
        settins_button.SetActive(true);
        level_button.SetActive(true);
        geri_sayim_gameobject.SetActive(true);

        gym_oda_button.GetComponent<Button>().interactable = true;
        mutfak_oda_button.GetComponent<Button>().interactable = true;
        muzik_button.GetComponent<Button>().interactable = false;
        dolop_button.GetComponent<Button>().interactable = true;
        yatakodasi_button.GetComponent<Button>().interactable = true;

        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(true);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);

        if (oda_durumu == 1)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.5f;
        }
        else if (oda_durumu == 2)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.65f;
        }
        else if (oda_durumu == 3)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.52f;
        }
        else if (oda_durumu == 4)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.33f;
        }
    }
    public void mutfak_oda_button_fonk()
    {
        panel_ac(Oyun_Panel_UI);
        popup_cerceve.SetActive(true);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);


        if (oda_durumu != 4)
        {
            //GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        }
        
        // exit_button_fonk();
        oda_durumu = 4;
        gym_kamera.SetActive(false);
        muzik_kamera.SetActive(false);
        mutfak_kamera.SetActive(true);
        bedroom_kameralar.SetActive(false);
        bedroom_kameralar.SetActive(false);
        gym_kameralar.SetActive(false);
        muzik_kameralar.SetActive(false);
        mutfak_kameralar.SetActive(false);

        gym_kiz_paket.SetActive(false);
        muzik_kiz_paket.SetActive(false);
        mutfak_kiz_paket.SetActive(true);
        giyinme_odasi.SetActive(false);

        mutfak_kiz.transform.rotation = Quaternion.Euler (0, -12, 0);

        muzik_odasi_obje.SetActive(false);
        gym_odasi_obje.SetActive(false);
        mutfak_odasi_obje.SetActive(true);

        gym_oda_button.SetActive(true);
        mutfak_oda_button.SetActive(true);
        muzik_button.SetActive(true);
        dolop_button.SetActive(true);
        yatakodasi_button.SetActive(true);
        world_map_button.SetActive(true);
        stram_event_button.SetActive(true);
        boyama_button.SetActive(true);
        settins_button.SetActive(true);
        level_button.SetActive(true);
        geri_sayim_gameobject.SetActive(true);

        gym_oda_button.GetComponent<Button>().interactable=true;
        mutfak_oda_button.GetComponent<Button>().interactable = false;
        muzik_button.GetComponent<Button>().interactable = true;
        dolop_button.GetComponent<Button>().interactable = true;
        yatakodasi_button.GetComponent<Button>().interactable = true;

        mutfak_cerceve.SetActive(true);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);

        if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }
        if (oda_durumu == 1)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.5f;
        }
        else if (oda_durumu == 2)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.65f;
        }
        else if (oda_durumu == 3)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.52f;
        }
        else if (oda_durumu == 4)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.33f;
        }
    }
    public void level_odul_panel_fonk()
    {
        int level = (int)PlayerPrefs.GetFloat("level");
       
        level_odul_derece1_text.text = "" + (0 + (level / 5) * 5);
        level_odul_derece2_text.text = "" + (5 + (level / 5) * 5);
        float x = ((level % 5) / 5f);
        level_odul_bar.GetComponent<Image>().fillAmount = x;
        level_odul_3x_button.gameObject.SetActive(false);
        level_odul_button.gameObject.SetActive(false);
        level_rank.SetActive(false);
        level_bar.SetActive(true);
        level_image.sprite = level_sprite_duz;
        if (level % 5==0)
        {
            level_odul_3x_button.gameObject.SetActive(true);
            level_odul_button.gameObject.SetActive(true);
            level_rank.SetActive(true);
            level_bar.SetActive(false);
            level_image.sprite = level_sprite_odul;
        }


        //Debug.Log("/////////==="+ (int)PlayerPrefs.GetFloat("level"));
    }
    public void level_odul_alma()
    {
        Debug.Log("bastım");
        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + System.Int32.Parse(level_para_text.text));
        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + System.Int32.Parse(level_takipci_text.text));
        PlayerPrefs.SetInt("popiodul", PlayerPrefs.GetInt("popiodul") + System.Int32.Parse(level_popi_text.text));
        // level_odul_panel_fonk();
        level_odul_3x_button.gameObject.SetActive(false);
        level_odul_button.gameObject.SetActive(false);
        level_rank.SetActive(false);
        level_bar.SetActive(true);
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
    }
    public void level_3x_odul_alma()
    {
        Debug.Log("bastım");
        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + (System.Int32.Parse(level_para_text.text)*3));
        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + (System.Int32.Parse(level_takipci_text.text)*3));
        PlayerPrefs.SetInt("popiodul", PlayerPrefs.GetInt("popiodul") + (System.Int32.Parse(level_popi_text.text)*3));
        //level_odul_panel_fonk();
        level_odul_3x_button.gameObject.SetActive(false);
        level_odul_button.gameObject.SetActive(false);
        level_rank.SetActive(false);
        level_bar.SetActive(true);
    }
    public void level_3x_odul_button_fonk()
    {
        Reklam.odul_bak = 4;
        //GameObject.Find("Game_Manager").GetComponent<Reklam>().reklam_izlet();
    }
    public void panel_ac(GameObject panel_acilacak)
    {
        Oyun_Panel_UI.SetActive(true);
        Sponsor_Reklam_Panel_UI.SetActive(false);
        Settings_Panel_UI.SetActive(false);
        Disko_Panel_UI.SetActive(false);
        Bedroom_Panel_UI.SetActive(false);
        Wardrobe_Panel_UI.SetActive(false);
        Improvements_Panel_UI.SetActive(false);
        Information_Panel_UI.SetActive(false);
        Character_Panel_UI.SetActive(false);
        Ranking_Panel_UI.SetActive(false);
        Shop_Panel_UI.SetActive(false);
        Welcome_Back_Panel_UI.SetActive(false); 
        Stream_Event_Panel_UI.SetActive(false); 
        Word_Map_Panel_UI.SetActive(false);
        Followers_Panel_UI.SetActive(false);
        Video_Yorum_Panel_UI.SetActive(false);
        Sponsor_Panel_UI.SetActive(false);
        Video_kayit_Panel_UI.SetActive(false);
        Event_Panel_UI.SetActive(false);
        animation_panel_UI.SetActive(false);
        camera_foto.SetActive(false);
        boyama_panel_UI.SetActive(false);
        giyinme_dolabi_UI.SetActive(false);
        panel_acilacak.SetActive(true);
        giyinme_odasi.SetActive(false);
        disko_oda.SetActive(false);
        

        improvements_button.SetActive(true);
        //ranking_button.SetActive(true);
      
        popup_cerceve.SetActive(false);

       /* bedroom_kameralar.SetActive(false);
        gym_kameralar.SetActive(false);
        muzik_kameralar.SetActive(false);
        mutfak_kameralar.SetActive(false);*/

        
        if(oda_durumu==1)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.5f;
        }
        else if (oda_durumu == 2)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.65f;
        }
        else if (oda_durumu == 3)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.52f;
        }
        else if (oda_durumu == 4)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.33f;
        }
        else if (oda_durumu == 5)
        {
            Camera.main.gameObject.GetComponent<AlllGame>().scrollbar.value = 0.66f;
        }
    }
    public void exit_button_fonk()
    {
        if (exit_fonk_bak && mobilya_kontrol_bool)
        {
            panel_ac(Oyun_Panel_UI);
            popup_cerceve.SetActive(true);
            if (PlayerPrefs.GetInt("ses_effect") == 1)
                efekt_oynatici.PlayOneShot(button_ses, 1);
            
            /*gym_oda_button.SetActive(true);
            mutfak_oda_button.SetActive(true);
            muzik_button.SetActive(true);
            dolop_button.SetActive(true);
            yatakodasi_button.SetActive(true);
            world_map_button.SetActive(true);
            stram_event_button.SetActive(true);
            boyama_button.SetActive(true);
            settins_button.SetActive(true);
            level_button.SetActive(true);
            geri_sayim_gameobject.SetActive(true);*/
            if (oda_durumu == 1)
            {
                yatakodasi_button_fonk();
            }
            else if (oda_durumu == 2)
            {
                gym_oda_button_fonk();
            }
            else if (oda_durumu == 3)
            {
                muzik_oda_button_fonk();
            }
            else if (oda_durumu == 4)
            {
                mutfak_oda_button_fonk();
            }
            else if (oda_durumu == 5)
            {
                giyinme_dolabi_panel_fonk();
            }

        }
    }
    public void disko_panel_fonk()
    {
        panel_ac(Disko_Panel_UI);
        disko_oda.SetActive(true);
        bedroom_button.SetActive(false);
        wardrobe_button.SetActive(false);
        improvements_button.SetActive(false);
        // ranking_button.SetActive(false);
        gym_oda_button.SetActive(false);
        mutfak_oda_button.SetActive(false);
        muzik_button.SetActive(false);
        dolop_button.SetActive(false);
        yatakodasi_button.SetActive(false);

        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);
        

        world_map_button.SetActive(false);
        stram_event_button.SetActive(false);
        boyama_button.SetActive(false);
        settins_button.SetActive(false);
        level_button.SetActive(false);
        geri_sayim_gameobject.SetActive(false);
        //popup_temizle();
    }
    public void boyama_panel_fonk()
    {

        if(oda_durumu==1 )
        {
            gym_kamera.SetActive(false);
            muzik_kamera.SetActive(false);
            mutfak_kamera.SetActive(false);
            bedroom_kameralar.SetActive(false);
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if(oda_durumu==2)
        {
            gym_kamera.SetActive(true);
            muzik_kamera.SetActive(false);
            mutfak_kamera.SetActive(false);
            bedroom_kameralar.SetActive(false);
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if (oda_durumu == 3)
        {
            gym_kamera.SetActive(false);
            muzik_kamera.SetActive(true);
            mutfak_kamera.SetActive(false);
            bedroom_kameralar.SetActive(false);
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if (oda_durumu == 4)
        {
            gym_kamera.SetActive(false);
            muzik_kamera.SetActive(false);
            mutfak_kamera.SetActive(true);
            bedroom_kameralar.SetActive(false);
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        


        //popup_temizle();
        panel_ac(boyama_panel_UI);
        if (oda_durumu == 5)
        {
            giyinme_odasi.SetActive(true);
            gym_kamera.SetActive(false);
            muzik_kamera.SetActive(false);
            mutfak_kamera.SetActive(false);
            bedroom_kameralar.SetActive(false);
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        boyama_zemin();
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
        if(GameObject.Find("boyama_kirmizi_Image"))
        {
            GameObject.Find("boyama_kirmizi_Image").SetActive(false);
        }
        PlayerPrefs.SetInt("boyama_nokta", 1);
    }
    public void bedroom_panel_fonk()
    {
        panel_ac(Bedroom_Panel_UI);

        bedroom_button.SetActive(false);
        wardrobe_button.SetActive(false);
        improvements_button.SetActive(false);
        //ranking_button.SetActive(false);


        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);

        gym_oda_button.SetActive(false);
        mutfak_oda_button.SetActive(false);
        muzik_button.SetActive(false);
        dolop_button.SetActive(false);
        yatakodasi_button.SetActive(false);
        world_map_button.SetActive(false);
        stram_event_button.SetActive(false);
        boyama_button.SetActive(false);
        settins_button.SetActive(false);
        level_button.SetActive(false);
        geri_sayim_gameobject.SetActive(false);
        // popup_temizle();
        gym_kiz_paket.SetActive(false);
        muzik_kiz_paket.SetActive(false);
        mutfak_kiz_paket.SetActive(false);
        giyinme_odasi.SetActive(false);
        if (oda_durumu==1)
        {
            /*bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(false);
            bedroom_kamera_main.SetActive(true);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);*/
            mobilya_alma_kamera("main");
            donanim_secim.SetActive(false);
            mobilya_secim.SetActive(true);
            mobilya_secim_gym.SetActive(false); 
            mobilya_secim_muzik.SetActive(false);
            mobilya_secim_mutfak.SetActive(false);
            donanim_button.SetActive(true);
            mobilya_button.SetActive(true);
            mobilya_button.GetComponent<Button>().interactable=true;
            secim_mobilya();
        }
        else if (oda_durumu==2)
        {
            mobilya_alma_kamera("gym_main");
            donanim_secim.SetActive(false);
            mobilya_secim.SetActive(false);
            mobilya_secim_gym.SetActive(true);
            mobilya_secim_muzik.SetActive(false);
            mobilya_secim_mutfak.SetActive(false);
            donanim_button.SetActive(false);
            mobilya_button.SetActive(true);
            mobilya_button.GetComponent<Button>().interactable = false;
            bedrom_buy_image.sprite = buy_image_secildi;
            bedroom_panel_image.sprite = mobilya_yeni_odalar_sprite;
        }
        else if (oda_durumu == 3)
        {
            mobilya_alma_kamera("muzik_main");
            donanim_secim.SetActive(false);
            mobilya_secim.SetActive(false);
            mobilya_secim_gym.SetActive(false);
            mobilya_secim_muzik.SetActive(true);
            mobilya_secim_mutfak.SetActive(false);
            donanim_button.SetActive(false);
            mobilya_button.SetActive(true);
            mobilya_button.GetComponent<Button>().interactable = false;
            bedrom_buy_image.sprite = buy_image_secildi;
            bedroom_panel_image.sprite = mobilya_yeni_odalar_sprite;
        }
        else if (oda_durumu == 4)
        {
            mobilya_alma_kamera("mutfak_main");
            donanim_secim.SetActive(false);
            mobilya_secim.SetActive(false);
            mobilya_secim_gym.SetActive(false);
            mobilya_secim_muzik.SetActive(false);
            mobilya_secim_mutfak.SetActive(true);
            donanim_button.SetActive(false);
            mobilya_button.SetActive(true);
            mobilya_button.GetComponent<Button>().interactable = false;
            bedrom_buy_image.sprite = buy_image_secildi;
            bedroom_panel_image.sprite = mobilya_yeni_odalar_sprite;
        }
        else if (oda_durumu==5)
        {
            giyinme_odasi.SetActive(true);
        }
       
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void event_panel_fonk()
    {

        panel_ac(Event_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void wardrobe_panel_fonk()
    {
        panel_ac(Wardrobe_Panel_UI);
        bedroom_button.SetActive(false);
        wardrobe_button.SetActive(false);
        improvements_button.SetActive(false);
        //ranking_button.SetActive(false);
        gym_oda_button.SetActive(false);
        mutfak_oda_button.SetActive(false);
        muzik_button.SetActive(false);
        dolop_button.SetActive(false);
        yatakodasi_button.SetActive(false);
        world_map_button.SetActive(false);
        stram_event_button.SetActive(false);
        boyama_button.SetActive(false);
        settins_button.SetActive(false);
        level_button.SetActive(false);
        geri_sayim_gameobject.SetActive(false);
        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);

        kiyafet_govde();
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void improvements_panel_fonk()
    {
       
        panel_ac(Improvements_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void ranking_panel_fonk()
    {
       
        panel_ac(Ranking_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void shop_panel_fonk()
    {
       
        panel_ac(Shop_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void world_map_fonk()
    {
        panel_ac(Word_Map_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void stream_event_fonk()
    {
        panel_ac(Stream_Event_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
        Stream_Event_Panel_UI.GetComponent<Stream_Event>().baslangic();
    }
    public void character_fonk()
    {
        
        panel_ac(Character_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void settings_fonk()
    {
        panel_ac(Settings_Panel_UI);
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void exit_button_fonk_kiyafet_alma()
    {
        if (exit_fonk_bak && mobilya_kontrol_bool)
        {
            panel_ac(Oyun_Panel_UI);
            popup_cerceve.SetActive(true);
            if (PlayerPrefs.GetInt("ses_effect") == 1)
                efekt_oynatici.PlayOneShot(button_ses, 1);
            if (oda_durumu == 5)
            {
                wardrobe_button.SetActive(true);
                bedroom_button.SetActive(false);
            }
            else
            {
                wardrobe_button.SetActive(false);
                bedroom_button.SetActive(true);
            }
        }
        panel_ac(giyinme_dolabi_UI);
        giyinme_odasi.SetActive(true);
        GameObject.Find("giyinme_odasi").GetComponent<Kiyafetodasi>().geri_don();
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
        if (oda_durumu == 5)
        {
            wardrobe_button.SetActive(true);
            bedroom_button.SetActive(false);
        }
        else
        {
            wardrobe_button.SetActive(false);
            bedroom_button.SetActive(true);
        }
    }
    public void kiyafet_kafa()
    {
        
      
        
        kiyafet_kafa_go.SetActive(true);
        kiyafet_govde_go.SetActive(false);
        kiyafet_bacak_go.SetActive(false);
        kiyafet_ayak_go.SetActive(false);
        wardrobe_panel_image.sprite = wardrobe_gozluk_sprite;

        bedroom_kameralar.SetActive(true);
        bedroom_kamera1.SetActive(false);
        bedroom_kamera2.SetActive(false);
        bedroom_kamera3.SetActive(false);
        bedroom_kamera_main.SetActive(false);
        wardrobe_kamera_ayak.SetActive(false);
        wardrobe_kamera_bacak.SetActive(false);
        wardrobe_kamera_govde.SetActive(false);
        wardrobe_kamera_kafa.SetActive(true);
        wardrobe_kamera_vucut.SetActive(false);

        button_ses_fok();
    }
    public void hazirlik()
    {

        kiyafet_kafa_go.SetActive(false);
        kiyafet_govde_go.SetActive(true);
        kiyafet_bacak_go.SetActive(false);
        kiyafet_ayak_go.SetActive(false);
        wardrobe_panel_image.sprite = wardrobe_ust_sprite;

        bedroom_kameralar.SetActive(true);
        bedroom_kamera1.SetActive(false);
        bedroom_kamera2.SetActive(false);
        bedroom_kamera3.SetActive(false);
        bedroom_kamera_main.SetActive(false);
        wardrobe_kamera_ayak.SetActive(false);
        wardrobe_kamera_bacak.SetActive(false);
        wardrobe_kamera_govde.SetActive(true);
        wardrobe_kamera_kafa.SetActive(false);
        wardrobe_kamera_vucut.SetActive(false);
        if (mobilya_kontrol_bool)
        {
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(false);
            bedroom_kamera_main.SetActive(true);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);
            bedrom_buy_image.sprite = buy_image_secildi;
            bedrom_upgrade_image.sprite = upgrade_image_secilmedi;
            bedroom_panel_image.sprite = bedrom_panel_buy_sprite;
            donanim_secim.SetActive(false);
            mobilya_secim.SetActive(true);
            //button_ses_fok();
        }
    }
    public void kiyafet_govde()
    {
        
       
        kiyafet_kafa_go.SetActive(false);
        kiyafet_govde_go.SetActive(true);
        kiyafet_bacak_go.SetActive(false);
        kiyafet_ayak_go.SetActive(false);
        wardrobe_panel_image.sprite = wardrobe_ust_sprite;

        bedroom_kameralar.SetActive(true);
        bedroom_kamera1.SetActive(false);
        bedroom_kamera2.SetActive(false);
        bedroom_kamera3.SetActive(false);
        bedroom_kamera_main.SetActive(false);
        wardrobe_kamera_ayak.SetActive(false);
        wardrobe_kamera_bacak.SetActive(false);
        wardrobe_kamera_govde.SetActive(true);
        wardrobe_kamera_kafa.SetActive(false);
        wardrobe_kamera_vucut.SetActive(false);
        button_ses_fok();
    }
    public void kiyafet_bacak()
    {
        
        kiyafet_kafa_go.SetActive(false);
        kiyafet_govde_go.SetActive(false);
        kiyafet_bacak_go.SetActive(true);
        kiyafet_ayak_go.SetActive(false);
        wardrobe_panel_image.sprite = wardrobe_etec_sprite;

        bedroom_kameralar.SetActive(true);
        bedroom_kamera1.SetActive(false);
        bedroom_kamera2.SetActive(false);
        bedroom_kamera3.SetActive(false);
        bedroom_kamera_main.SetActive(false);
        wardrobe_kamera_ayak.SetActive(false);
        wardrobe_kamera_bacak.SetActive(true);
        wardrobe_kamera_govde.SetActive(false);
        wardrobe_kamera_kafa.SetActive(false);
        wardrobe_kamera_vucut.SetActive(false);
        button_ses_fok();
    }
    public void kiyafet_ayak()
    {
        
        kiyafet_kafa_go.SetActive(false);
        kiyafet_govde_go.SetActive(false);
        kiyafet_bacak_go.SetActive(false);
        kiyafet_ayak_go.SetActive(true);
        wardrobe_panel_image.sprite = wardrobe_ayakkabi_sprite;

        bedroom_kameralar.SetActive(true);
        bedroom_kamera1.SetActive(false);
        bedroom_kamera2.SetActive(false);
        bedroom_kamera3.SetActive(false);
        bedroom_kamera_main.SetActive(false);
        wardrobe_kamera_ayak.SetActive(true);
        wardrobe_kamera_bacak.SetActive(false);
        wardrobe_kamera_govde.SetActive(false);
        wardrobe_kamera_kafa.SetActive(false);
        wardrobe_kamera_vucut.SetActive(false);
        button_ses_fok();
    }
    public void secim_donanim()
    {
        if (mobilya_kontrol_bool)
        {
            bedroom_panel_image.sprite = bedrom_panel_upgrade_sprite;

            bedrom_buy_image.sprite = buy_image_secilmedi;
            bedrom_upgrade_image.sprite = upgrade_image_secildi;

            donanim_secim.SetActive(true);
            mobilya_secim.SetActive(false);
            // Debug.Log("girdiiiimmmmmmmmm");
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(true);
            bedroom_kamera_main.SetActive(false);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);
            button_ses_fok();
        }
        
    }
    public void secim_mobilya()
    {
        if (mobilya_kontrol_bool)
        {
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(false);
            bedroom_kamera_main.SetActive(true);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);
            bedrom_buy_image.sprite = buy_image_secildi;
            bedrom_upgrade_image.sprite = upgrade_image_secilmedi;
            bedroom_panel_image.sprite = bedrom_panel_buy_sprite;
            donanim_secim.SetActive(false);
            mobilya_secim.SetActive(true);
            button_ses_fok();
        }
       
    }
    public void deneme_olustur()
    {
        Instantiate(popuplar[sayac], new Vector3(0,0,0), Quaternion.identity, popup_cerceve.transform).transform.localPosition= new Vector3(0, 0, 0);
    }
    public void titresim_ac_kapa()
    {
        if (PlayerPrefs.GetInt("titresim")==0)
        {
            PlayerPrefs.SetInt("titresim",1);
            titresim_button.GetComponent<Image>().sprite = titresim_on_image;
        }
        else
        {
            PlayerPrefs.SetInt("titresim", 0);
            titresim_button.GetComponent<Image>().sprite = titresim_off_image;
        }
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void ses_ac_kapa()
    {
        if (PlayerPrefs.GetInt("ses") == 0)
        {
            PlayerPrefs.SetInt("ses", 1);
            ana_muzik_obje.SetActive(true);
            ses_button.GetComponent<Image>().sprite = ses_on_image;
        }
        else
        {
            PlayerPrefs.SetInt("ses", 0);
            ana_muzik_obje.SetActive(false);
            ses_button.GetComponent<Image>().sprite = ses_off_image;
        }
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void effect_ses_ac_kapa()
    {
        if (PlayerPrefs.GetInt("ses_effect") == 0)
        {
            PlayerPrefs.SetInt("ses_effect", 1);

            effect_button.GetComponent<Image>().sprite = effect_on_image;
        }
        else
        {
            PlayerPrefs.SetInt("ses_effect", 0);

            effect_button.GetComponent<Image>().sprite = effect_off_image;
        }
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void ses_reklam_kapa()
    {
        if (PlayerPrefs.GetInt("ses") == 1)
        {
            ana_muzik_obje.SetActive(false);
        }
    }
    public void ses_reklam_ac()
    {
        if (PlayerPrefs.GetInt("ses") == 1)
        {
            ana_muzik_obje.SetActive(true);
        }
    }
    public void x3kazanc()
    {
        
        Reklam.odul_bak = 1;
        //game_manager.GetComponent<Reklam>().reklam_izlet();
        
    }
    public void foto_ekran_ac()
    {
        Oyun_Panel_UI.SetActive(false);
        Word_Map_Panel_UI.SetActive(false);
        animation_panel_UI.SetActive(true);
        camera_foto.SetActive(true);

    }
    public void yetersiz_para_fonk()
    {
        if (PlayerPrefs.GetInt("ses_effect") == 1)
        {
            efekt_oynatici.PlayOneShot(yetersizpara_ses, 1);
        }
    }
    public void satinalma_fonk()
    {
        if (PlayerPrefs.GetInt("ses_effect") == 1)
        {
            efekt_oynatici.PlayOneShot(satinalma_ses, 1);
        }
    }
    public void button_ses_fok()
    {
       // GameObject.Find("Main Camera").GetComponent<AlllGame>().button_ses_fok();
        if (PlayerPrefs.GetInt("ses_effect") == 1)
            efekt_oynatici.PlayOneShot(button_ses, 1);
    }
    public void boyama_duvar()
    {

        if(oda_durumu==1 )
        {
            zemin_boya.GetComponent<example>().StopPaint();
            duvar_boya.GetComponent<example>().StopPaint();
            tavan_boya.GetComponent<example>().StopPaint();
            duvar_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu==2)
        {
            gym_zemin_boya.GetComponent<example>().StopPaint();
            gym_duvar_boya.GetComponent<example>().StopPaint();
            gym_tavan_boya.GetComponent<example>().StopPaint();
            gym_duvar_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 3)
        {
            muzik_zemin_boya.GetComponent<example>().StopPaint();
            muzik_duvar_boya.GetComponent<example>().StopPaint();
            muzik_tavan_boya.GetComponent<example>().StopPaint();
            muzik_duvar_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 4)
        {
            mutfak_zemin_boya.GetComponent<example>().StopPaint();
            mutfak_duvar_boya.GetComponent<example>().StopPaint();
            mutfak_tavan_boya.GetComponent<example>().StopPaint();
            mutfak_duvar_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 5)
        {
            giyinme_odasi_zemin_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_duvar_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_tavan_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_duvar_boya.GetComponent<example>().StartPaint();
        }


        /*duvar_boya_button.GetComponent<Image>().sprite = duvar_boya_button_on;
        zemin_boya_button.GetComponent<Image>().sprite = zemin_boya_button_off;
        tavan_boya_button.GetComponent<Image>().sprite = tavan_boya_button_off;*/
        duvar_boya_button.GetComponent<Image>().color = new Color(0.254902f, 0.7098039f, 1, 1);
        zemin_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        tavan_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
    }
    public void boyama_zemin()
    {
        if (oda_durumu == 1 )
        {
            zemin_boya.GetComponent<example>().StopPaint();
            duvar_boya.GetComponent<example>().StopPaint();
            tavan_boya.GetComponent<example>().StopPaint();
            zemin_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 2)
        {
            gym_zemin_boya.GetComponent<example>().StopPaint();
            gym_duvar_boya.GetComponent<example>().StopPaint();
            gym_tavan_boya.GetComponent<example>().StopPaint();
            gym_zemin_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 3)
        {
            muzik_zemin_boya.GetComponent<example>().StopPaint();
            muzik_duvar_boya.GetComponent<example>().StopPaint();
            muzik_tavan_boya.GetComponent<example>().StopPaint();
            muzik_zemin_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 4)
        {
            mutfak_zemin_boya.GetComponent<example>().StopPaint();
            mutfak_duvar_boya.GetComponent<example>().StopPaint();
            mutfak_tavan_boya.GetComponent<example>().StopPaint();
            mutfak_zemin_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 5)
        {
            giyinme_odasi_zemin_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_duvar_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_tavan_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_zemin_boya.GetComponent<example>().StartPaint();
        }



        /*duvar_boya_button.GetComponent<Image>().sprite = duvar_boya_button_off;
        tavan_boya_button.GetComponent<Image>().sprite = tavan_boya_button_off;
        zemin_boya_button.GetComponent<Image>().sprite = zemin_boya_button_on;*/
        duvar_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        zemin_boya_button.GetComponent<Image>().color = new Color(0.254902f, 0.7098039f, 1, 1);
        tavan_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);

    }
    public void boyama_tavan()
    {

        if (oda_durumu == 1)
        {
            zemin_boya.GetComponent<example>().StopPaint();
            duvar_boya.GetComponent<example>().StopPaint();
            tavan_boya.GetComponent<example>().StopPaint();
            tavan_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 2)
        {
            gym_zemin_boya.GetComponent<example>().StopPaint();
            gym_duvar_boya.GetComponent<example>().StopPaint();
            gym_tavan_boya.GetComponent<example>().StopPaint();
            gym_tavan_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 3)
        {
            muzik_zemin_boya.GetComponent<example>().StopPaint();
            muzik_duvar_boya.GetComponent<example>().StopPaint();
            muzik_tavan_boya.GetComponent<example>().StopPaint();
            muzik_tavan_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 4)
        {
            mutfak_zemin_boya.GetComponent<example>().StopPaint();
            mutfak_duvar_boya.GetComponent<example>().StopPaint();
            mutfak_tavan_boya.GetComponent<example>().StopPaint();
            mutfak_tavan_boya.GetComponent<example>().StartPaint();
        }
        else if (oda_durumu == 5)
        {
            giyinme_odasi_zemin_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_duvar_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_tavan_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_tavan_boya.GetComponent<example>().StartPaint();
        }


        /*zemin_boya.GetComponent<example>().StopPaint();
        duvar_boya.GetComponent<example>().StopPaint();
        tavan_boya.GetComponent<example>().StopPaint();
        tavan_boya.GetComponent<example>().StartPaint();*/
        /* duvar_boya_button.GetComponent<Image>().sprite = duvar_boya_button_off;
         zemin_boya_button.GetComponent<Image>().sprite = zemin_boya_button_off;
         tavan_boya_button.GetComponent<Image>().sprite = tavan_boya_button_on;*/
        duvar_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        zemin_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        tavan_boya_button.GetComponent<Image>().color = new Color(0.254902f, 0.7098039f, 1, 1);
        
        
    }
    public void boyama_kapa()
    {

        if (oda_durumu == 1)
        {
            zemin_boya.GetComponent<example>().StopPaint();
            duvar_boya.GetComponent<example>().StopPaint();
            tavan_boya.GetComponent<example>().StopPaint();
           
        }
        else if (oda_durumu == 2)
        {
            gym_zemin_boya.GetComponent<example>().StopPaint();
            gym_duvar_boya.GetComponent<example>().StopPaint();
            gym_tavan_boya.GetComponent<example>().StopPaint();
           
        }
        else if (oda_durumu == 3)
        {
            muzik_zemin_boya.GetComponent<example>().StopPaint();
            muzik_duvar_boya.GetComponent<example>().StopPaint();
            muzik_tavan_boya.GetComponent<example>().StopPaint();
           
        }
        else if (oda_durumu == 4)
        {
            mutfak_zemin_boya.GetComponent<example>().StopPaint();
            mutfak_duvar_boya.GetComponent<example>().StopPaint();
            mutfak_tavan_boya.GetComponent<example>().StopPaint();
          
        }
        else if (oda_durumu == 5)
        {
            giyinme_odasi_zemin_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_duvar_boya.GetComponent<example>().StopPaint();
            giyinme_odasi_tavan_boya.GetComponent<example>().StopPaint();
           
        }
        duvar_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        zemin_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        tavan_boya_button.GetComponent<Image>().color = new Color(0.8431373f, 0.8431373f, 0.8431373f, 1);
        /*zemin_boya_button.GetComponent<Image>().sprite = zemin_boya_button_off;
        duvar_boya_button.GetComponent<Image>().sprite = duvar_boya_button_off;
        tavan_boya_button.GetComponent<Image>().sprite = tavan_boya_button_off;*/
        exit_button_fonk();
    }
    public void foto_cekme_exit_button_fonk()
    {
            panel_ac(Oyun_Panel_UI);
        popup_cerceve.SetActive(true);
        world_map_fonk();
        GameObject obj = GameObject.Find("kiz_Final_etkinlik");
        obj.GetComponent<animasyon>().scrollbar.value = 0.5f;
        obj.GetComponent<animasyon>().timeline.value = 0.5f;
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();

    }
    public void popup_panel_hazirlik()
    {
        mutfak_cerceve.SetActive(false);
        gym_cerceve.SetActive(false);
        muzik_cerceve.SetActive(false);
        dolap_cerceve.SetActive(false);
        yatakodasi_cerceve.SetActive(false);
        

        bedroom_button.SetActive(false);
        wardrobe_button.SetActive(false);
        improvements_button.SetActive(false);
        //ranking_button.SetActive(false);
        gym_oda_button.SetActive(false);
        mutfak_oda_button.SetActive(false);
        muzik_button.SetActive(false);
        dolop_button.SetActive(false);
        yatakodasi_button.SetActive(false);
        world_map_button.SetActive(false);
        stram_event_button.SetActive(false);
        boyama_button.SetActive(false);
        settins_button.SetActive(false);
        level_button.SetActive(false);
        geri_sayim_gameobject.SetActive(false);
        popup_cerceve.SetActive(false);
        //popup_temizle();
    }
    public void para_anim_cagir()
    {
        StartCoroutine(para_anim_fonk());
    }
    public IEnumerator para_anim_fonk()
    {
        para_anim.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        para_anim.SetActive(false);
    }
    public void takipci_anim_cagir()
    {
        StartCoroutine(takipci_anim_fonk());
    }
    public IEnumerator takipci_anim_fonk()
    {
        takipci_anim.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        takipci_anim.SetActive(false);
    }
    public void popup_temizle()
    {
       
        for (int i = 0; i < popup_parent.transform.childCount; i++)
        {

            Destroy(popup_parent.transform.GetChild(i).gameObject);
        }
    }
    public void mobilya_alma_kamera(string kamera)
    {
        if(kamera=="1")
        {
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(true);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(false);
            bedroom_kamera_main.SetActive(false);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);

            
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if(kamera=="2")
        {
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(true);
            bedroom_kamera3.SetActive(false);
            bedroom_kamera_main.SetActive(false);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);

            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if (kamera == "3")
        {
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(true);
            bedroom_kamera_main.SetActive(false);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);

            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if (kamera=="main")
        {
            bedroom_kameralar.SetActive(true);
            bedroom_kamera1.SetActive(false);
            bedroom_kamera2.SetActive(false);
            bedroom_kamera3.SetActive(false);
            bedroom_kamera_main.SetActive(true);
            wardrobe_kamera_ayak.SetActive(false);
            wardrobe_kamera_bacak.SetActive(false);
            wardrobe_kamera_govde.SetActive(false);
            wardrobe_kamera_kafa.SetActive(false);
            wardrobe_kamera_vucut.SetActive(false);

            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
        }
        else if (kamera == "gym_main")
        {
            bedroom_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);

            gym_kameralar.SetActive(true);

            gym_kamera_main.SetActive(true);
            gym_kamera1.SetActive(false);
            gym_kamera2.SetActive(false);
            gym_kamera3.SetActive(false);
            gym_kamera4.SetActive(false);
            gym_kamera5.SetActive(false);
        }
        else if (kamera == "4")
        {
            bedroom_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);

            gym_kameralar.SetActive(true);

            gym_kamera_main.SetActive(false);
            gym_kamera1.SetActive(true);
            gym_kamera2.SetActive(false);
            gym_kamera3.SetActive(false);
            gym_kamera4.SetActive(false);
            gym_kamera5.SetActive(false);
        }
        else if (kamera == "5")
        {
            bedroom_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);

            gym_kameralar.SetActive(true);

            gym_kamera_main.SetActive(false);
            gym_kamera1.SetActive(false);
            gym_kamera2.SetActive(true);
            gym_kamera3.SetActive(false);
            gym_kamera4.SetActive(false);
            gym_kamera5.SetActive(false);
        }
        else if (kamera == "6")
        {
            bedroom_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);

            gym_kameralar.SetActive(true);

            gym_kamera_main.SetActive(false);
            gym_kamera1.SetActive(false);
            gym_kamera2.SetActive(false);
            gym_kamera3.SetActive(true);
            gym_kamera4.SetActive(false);
            gym_kamera5.SetActive(false);
        }
        else if (kamera == "7")
        {
            bedroom_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);

            gym_kameralar.SetActive(true);

            gym_kamera_main.SetActive(false);
            gym_kamera1.SetActive(false);
            gym_kamera2.SetActive(false);
            gym_kamera3.SetActive(false);
            gym_kamera4.SetActive(true);
            gym_kamera5.SetActive(false);
        }
        else if (kamera == "8")
        {
            bedroom_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);

            gym_kameralar.SetActive(true);

            gym_kamera_main.SetActive(false);
            gym_kamera1.SetActive(false);
            gym_kamera2.SetActive(false);
            gym_kamera3.SetActive(false);
            gym_kamera4.SetActive(false);
            gym_kamera5.SetActive(true);
        }
        else if (kamera == "muzik_main")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
            muzik_kameralar.SetActive(true);

            muzik_kamera_main.SetActive(true);
            muzik_kamera1.SetActive(false);
            muzik_kamera2.SetActive(false);
            muzik_kamera3.SetActive(false);
            muzik_kamera4.SetActive(false);
            
        }
        else if (kamera == "9")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
            muzik_kameralar.SetActive(true);

            muzik_kamera_main.SetActive(false);
            muzik_kamera1.SetActive(true);
            muzik_kamera2.SetActive(false);
            muzik_kamera3.SetActive(false);
            muzik_kamera4.SetActive(false);
        }
        else if (kamera == "10")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
            muzik_kameralar.SetActive(true);

            muzik_kamera_main.SetActive(false);
            muzik_kamera1.SetActive(false);
            muzik_kamera2.SetActive(true);
            muzik_kamera3.SetActive(false);
            muzik_kamera4.SetActive(false);
        }
        else if (kamera == "11")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
            muzik_kameralar.SetActive(true);

            muzik_kamera_main.SetActive(false);
            muzik_kamera1.SetActive(false);
            muzik_kamera2.SetActive(false);
            muzik_kamera3.SetActive(true);
            muzik_kamera4.SetActive(false);
        }
        else if (kamera == "12")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(false);
            muzik_kameralar.SetActive(true);

            muzik_kamera_main.SetActive(false);
            muzik_kamera1.SetActive(false);
            muzik_kamera2.SetActive(false);
            muzik_kamera3.SetActive(false);
            muzik_kamera4.SetActive(true);
        }
        else if (kamera == "mutfak_main")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(true);

            mutfak_kamera_main.SetActive(true);
            mutfak_kamera1.SetActive(false);
            mutfak_kamera2.SetActive(false);
            mutfak_kamera3.SetActive(false);

        }
        else if (kamera == "13")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(true);

            mutfak_kamera_main.SetActive(false);
            mutfak_kamera1.SetActive(true);
            mutfak_kamera2.SetActive(false);
            mutfak_kamera3.SetActive(false);

        }
        else if (kamera == "14")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(true);

            mutfak_kamera_main.SetActive(false);
            mutfak_kamera1.SetActive(false);
            mutfak_kamera2.SetActive(true);
            mutfak_kamera3.SetActive(false);

        }
        else if (kamera == "15")
        {
            bedroom_kameralar.SetActive(false);
            gym_kameralar.SetActive(false);
            muzik_kameralar.SetActive(false);
            mutfak_kameralar.SetActive(true);

            mutfak_kamera_main.SetActive(false);
            mutfak_kamera1.SetActive(false);
            mutfak_kamera2.SetActive(false);
            mutfak_kamera3.SetActive(true);
            
        }
    }
    public void reklam_ackapa()
    {
       /* if (PlayerPrefs.GetInt("reklam_kapa") == 0)
        {
            versiyon_text.color = Color.red;
            PlayerPrefs.SetInt("reklam_kapa", 1);
        }
        else
        {
            versiyon_text.color = Color.green;
            PlayerPrefs.SetInt("reklam_kapa", 0);
        }*/
    }
    public void reklam_sponsor_prefab()
    {
        Instantiate(popuplar[4], new Vector3(0, 0, 0), Quaternion.identity, popup_cerceve.transform).transform.localPosition = new Vector3(0, 0, 0);
    }     
    public void tbt_popup_ayarla()
    {
        tbt_popup_text.text = "+" + (1000 + ((PlayerPrefs.GetInt("takipci") / 100) * 10));
        int deger = PlayerPrefs.GetInt("tbt_sprite");
        if(deger> tbt_sprites.Length-1)
        {
            deger = 0;
        }
        tbt_image.sprite = tbt_sprites[deger];
        PlayerPrefs.SetInt("tbt_sprite", deger + 1);
    }
    public void tbt_popup_reklamizlet()
    {
        Reklam.odul_bak = 10;
        //game_manager.GetComponent<Reklam>().reklam_izlet();
    }
    public void sponsor_panel_resim_degistir()
    {
        sponsor_isim_text.text = sponsor_isim_list[Random.Range(0, sponsor_isim_list.Length)];
        sponsor_image.sprite = sponsor_sprites[Random.Range(0, sponsor_sprites.Length)];
    }
    public void sponsor_reklam_panel_resim_degistir()
    {
        sponsor_reklam_isim_text.text = sponsor_isim_list[Random.Range(0, sponsor_isim_list.Length)];
        sponsor_reklam_image.sprite = sponsor_sprites[Random.Range(0, sponsor_sprites.Length)];
    }

   
}
