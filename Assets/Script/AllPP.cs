using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using MoreMountains.NiceVibrations;

public class AllPP : MonoBehaviour
{
    public Text para_text,takipci_text,popi_text;
    public static int[] ekipman_ilk_fiyat= { 5000, 10000,15000,20000,25000};
    //public static int[] gelistirme_fiyat = { 400, 800, 1300, 2300, 3700, 5900, 9200, 13900, 20500, 29200, 40300, 54300, 71300, 91900, 116300, 114800, 17700, 215700, 258700, 307200, 361600, 422000, 489200, 563100, 644300, 744300, 944300, 1044300, 1544300, 3000000, 5000000, 9000000, 15000000 };
    public static int[] gelistirme_fiyat = { 1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 50000, 50000, 50000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    public static int[] isik_ek_para = { };
    private  float zaman,zaman2;
    private int default_para = 20;
    private int default_takipci = 20;
    private float level_atis = 24;
    public static int ekenecek_para;
    public static int ekenecek_takipci;
    public static int x3;
    public Image level_bar_Fa;
    public GameObject levelup_button;
    public Text level_text, welcome_back_para_Text, welcome_back_takipci_Text;
    private float x;
    public GameObject welcome_back_UI;
    public GameObject para_cikis_konum,para_prefab,takipci_prefab, takipci_giden_prefab;
    int tiklama_sayac;
    public GameObject follower_image,sponsor_image, sponsor_reklam_image;
    public GameObject Ga;
    
   // public static bool kk_trigger;
    public static int mobilya_para_ek = 0;
    public static int mobilya_takipci_ek = 0;
    public static int  ektakipci, ektakipci_giden, dans_bust;
    public static float ekpara;
    public int takipci_map_artis;
    private int tiklama_sayac1, tiklama_sayac2;
    public GameObject tiklama_el;
    public GameObject gym_paracikis, muzik_paracikis, mutfak_paracikis;
    // Start is called before the first frame update
    public void Awake()
    {
        // PlayerPrefs.DeleteAll();
        
       
        /*foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
        {
            obje.baslangic_kontrol();
        }*/
       /* foreach (Ekipman_Gelistirme obje in Resources.FindObjectsOfTypeAll<Ekipman_Gelistirme>())
        {
            obje.baslangic_kontrol();
        }*/
       


        if (PlayerPrefs.HasKey("boyama_nokta"))
        {
            /////GameObject.Find("boyama_kirmizi_Image").SetActive(false);
        }
        else
        {

        }

        if (PlayerPrefs.HasKey("oyun_tutorial"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("oyun_tutorial", 0);
        }
        if (PlayerPrefs.HasKey("anim_foto"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("anim_foto", 0);
        }

        //PlayerPrefs.SetInt("para", 1000000);
        ////duvar
        if (PlayerPrefs.HasKey("drenk_h"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("drenk_h", 0.9163581f);
        }

        if (PlayerPrefs.HasKey("drenk_s"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("drenk_s", 0.6157596f);
        }

        if (PlayerPrefs.HasKey("drenk_v"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("drenk_v", 0.9852591f);
        }
        /////

        ////// zemin
        if (PlayerPrefs.HasKey("zrenk_h"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("zrenk_h", 0.5787126f);
        }

        if (PlayerPrefs.HasKey("zrenk_s"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("zrenk_s", 0.8389464f);
        }

        if (PlayerPrefs.HasKey("zrenk_v"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("zrenk_v", 0.5163566f);
        }
        ///////

        ///tavan
        if (PlayerPrefs.HasKey("trenk_h"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("trenk_h", 0.06453484f);
        }

        if (PlayerPrefs.HasKey("trenk_s"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("trenk_s", 0.9435722f);
        }

        if (PlayerPrefs.HasKey("trenk_v"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("trenk_v", 0.06882209f);
        }
        ////



        if (PlayerPrefs.HasKey("toplam_tiklama_sayisi"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("toplam_tiklama_sayisi", 1);
        }

        if (PlayerPrefs.HasKey("event"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("event", 1);
        }
        if (PlayerPrefs.HasKey("titresim"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("titresim", 1);
        }
        if (PlayerPrefs.HasKey("ses"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ses", 1);
        }
        if (PlayerPrefs.HasKey("ses_effect"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ses_effect", 1);
        }
        if (PlayerPrefs.HasKey("video"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("video", 1);
        }
       
        if (PlayerPrefs.HasKey("popi"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("popi", 0);
        }
        if (PlayerPrefs.HasKey("level"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("level", 1f);
        }
        if (PlayerPrefs.HasKey("level_artis"))
        {
            if (PlayerPrefs.GetFloat("level") > 1f)
            {
                PlayerPrefs.SetFloat("level_artis", (((PlayerPrefs.GetFloat("level") - 1) * 4) * level_atis));
            }
            else
            {
                PlayerPrefs.SetFloat("level_artis", level_atis);
            }

        }
        else
        {
            PlayerPrefs.SetFloat("level_artis", 24f);
        }
        if (PlayerPrefs.HasKey("tiklama_sayisi"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("tiklama_sayisi", 1f);
        }
        if (PlayerPrefs.HasKey("kafa_pa"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("kafa_pa", 0);
        }
        if (PlayerPrefs.HasKey("govde_pa"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("govde_pa", 0);
        }
        if (PlayerPrefs.HasKey("bacak_pa"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("bacak_pa", 0);
        }
        if (PlayerPrefs.HasKey("ayak_pa"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ayak_pa", 0);
        }

        //takipçi
        
        if (PlayerPrefs.HasKey("kafa_ta"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("kafa_ta", 0);
        }
        if (PlayerPrefs.HasKey("govde_ta"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("govde_ta", 0);
        }
        if (PlayerPrefs.HasKey("bacak_ta"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("bacak_ta", 0);
        }
        if (PlayerPrefs.HasKey("ayak_ta"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ayak_ta", 0);
        }

        //popilarite
        if (PlayerPrefs.HasKey("popikafa"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("popikafa", 0);
        }
        if (PlayerPrefs.HasKey("popigovde"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("popigovde", 0);
        }
        if (PlayerPrefs.HasKey("popibacak"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("popibacak", 0);
        }
        if (PlayerPrefs.HasKey("popiayak"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("popiayak", 0);
        }
        if (PlayerPrefs.HasKey("popiodul"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("popiodul", 0);
        }
        //map
        if (PlayerPrefs.HasKey("ucak_pa"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ucak_pa", 0);
        }
        if (PlayerPrefs.HasKey("ucak_ta"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ucak_ta", 0);
        }
        yeni_pp();
    }
    public void yeni_pp()
    {

        if (PlayerPrefs.HasKey("tbt_sprite"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("tbt_sprite", 0);
        }
        if (PlayerPrefs.HasKey("ParaFloatButton"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("ParaFloatButton", 0);
        }
        if (PlayerPrefs.HasKey("sponsor_para"))
        {
           
        }
        else
        {
            PlayerPrefs.SetInt("sponsor_para", 1750);
        }

        if (!PlayerPrefs.HasKey("gatakipci1start"))
        {
            PlayerPrefs.SetInt("gatakipci1start", 0);
        }
        
        
        if (PlayerPrefs.HasKey("reklam_kapa"))
        {
            PlayerPrefs.SetInt("reklam_kapa", 0);
        }
        else
        {
            PlayerPrefs.SetInt("reklam_kapa", 0);
        }
        if (PlayerPrefs.HasKey("rnd_y"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("rnd_y", 11);
        }

        if (PlayerPrefs.HasKey("rnd_x"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("rnd_x", 5);
        }

        if (PlayerPrefs.HasKey("rnd_k"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("rnd_k", 5);
        }
        if (PlayerPrefs.HasKey("rnd_z"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("rnd_z", 1);
        }

        if (PlayerPrefs.HasKey("para"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("para", 0);
        }
        if (PlayerPrefs.HasKey("takipci"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("takipci", 0);
        }
        if (PlayerPrefs.HasKey("t_zaman"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("t_zaman", 3);
        }
        if (PlayerPrefs.HasKey("p_artis"))
        {

        }
        else
        {
            PlayerPrefs.SetFloat("p_artis", 0.01f);
        }
        if (PlayerPrefs.HasKey("sponsorcikar"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("sponsorcikar", 2500);
        }




        //////duvar
        if (!PlayerPrefs.HasKey("gym_drenk_h"))
        {
            PlayerPrefs.SetFloat("gym_drenk_h", 0.9163581f);
        }
        

        if (!PlayerPrefs.HasKey("gym_drenk_s"))
        {
            PlayerPrefs.SetFloat("gym_drenk_s", 0.6157596f);
        }
        

        if (!PlayerPrefs.HasKey("gym_drenk_v"))
        {
            PlayerPrefs.SetFloat("gym_drenk_v", 0.9852591f);
        }
       
        /////

        ////// zemin
        if (!PlayerPrefs.HasKey("gym_zrenk_h"))
        {
            PlayerPrefs.SetFloat("gym_zrenk_h", 0.5787126f);
        }
        

        if (!PlayerPrefs.HasKey("gym_zrenk_s"))
        {
            PlayerPrefs.SetFloat("gym_zrenk_s", 0.8389464f);
        }
        

        if (!PlayerPrefs.HasKey("gym_zrenk_v"))
        {
            PlayerPrefs.SetFloat("gym_zrenk_v", 0.5163566f);
        }
       
        ///////

        ///tavan
        if (!PlayerPrefs.HasKey("gym_trenk_h"))
        {
            PlayerPrefs.SetFloat("gym_trenk_h", 0.06453484f);
        }
        

        if (!PlayerPrefs.HasKey("gym_trenk_s"))
        {
            PlayerPrefs.SetFloat("gym_trenk_s", 0.9435722f);
        }
        

        if (!PlayerPrefs.HasKey("gym_trenk_v"))
        {
            PlayerPrefs.SetFloat("gym_trenk_v", 0.06882209f);
        }
        ///////

        //////duvar
        if (!PlayerPrefs.HasKey("muzik_drenk_h"))
        {
            PlayerPrefs.SetFloat("muzik_drenk_h", 0.9163581f);
        }


        if (!PlayerPrefs.HasKey("muzik_drenk_s"))
        {
            PlayerPrefs.SetFloat("muzik_drenk_s", 0.6157596f);
        }


        if (!PlayerPrefs.HasKey("muzik_drenk_v"))
        {
            PlayerPrefs.SetFloat("muzik_drenk_v", 0.9852591f);
        }

        /////

        ////// zemin
        if (!PlayerPrefs.HasKey("muzik_zrenk_h"))
        {
            PlayerPrefs.SetFloat("muzik_zrenk_h", 0.5787126f);
        }


        if (!PlayerPrefs.HasKey("muzik_zrenk_s"))
        {
            PlayerPrefs.SetFloat("muzik_zrenk_s", 0.8389464f);
        }


        if (!PlayerPrefs.HasKey("muzik_zrenk_v"))
        {
            PlayerPrefs.SetFloat("muzik_zrenk_v", 0.5163566f);
        }

        ///////

        ///tavan
        if (!PlayerPrefs.HasKey("muzik_trenk_h"))
        {
            PlayerPrefs.SetFloat("muzik_trenk_h", 0.06453484f);
        }


        if (!PlayerPrefs.HasKey("muzik_trenk_s"))
        {
            PlayerPrefs.SetFloat("muzik_trenk_s", 0.9435722f);
        }


        if (!PlayerPrefs.HasKey("muzik_trenk_v"))
        {
            PlayerPrefs.SetFloat("muzik_trenk_v", 0.06882209f);
        }
        ///////
        //////duvar
        if (!PlayerPrefs.HasKey("mutfak_drenk_h"))
        {
            PlayerPrefs.SetFloat("mutfak_drenk_h", 0.9163581f);
        }


        if (!PlayerPrefs.HasKey("mutfak_drenk_s"))
        {
            PlayerPrefs.SetFloat("mutfak_drenk_s", 0.6157596f);
        }


        if (!PlayerPrefs.HasKey("mutfak_drenk_v"))
        {
            PlayerPrefs.SetFloat("mutfak_drenk_v", 0.9852591f);
        }

        /////

        ////// zemin
        if (!PlayerPrefs.HasKey("mutfak_zrenk_h"))
        {
            PlayerPrefs.SetFloat("mutfak_zrenk_h", 0.5787126f);
        }


        if (!PlayerPrefs.HasKey("mutfak_zrenk_s"))
        {
            PlayerPrefs.SetFloat("mutfak_zrenk_s", 0.8389464f);
        }


        if (!PlayerPrefs.HasKey("mutfak_zrenk_v"))
        {
            PlayerPrefs.SetFloat("mutfak_zrenk_v", 0.5163566f);
        }

        ///////

        ///tavan
        if (!PlayerPrefs.HasKey("mutfak_trenk_h"))
        {
            PlayerPrefs.SetFloat("mutfak_trenk_h", 0.06453484f);
        }


        if (!PlayerPrefs.HasKey("mutfak_trenk_s"))
        {
            PlayerPrefs.SetFloat("mutfak_trenk_s", 0.9435722f);
        }


        if (!PlayerPrefs.HasKey("mutfak_trenk_v"))
        {
            PlayerPrefs.SetFloat("mutfak_trenk_v", 0.06882209f);
        }
        ///////
        //////duvar
        if (!PlayerPrefs.HasKey("giyinme_drenk_h"))
        {
            PlayerPrefs.SetFloat("giyinme_drenk_h", 0.9163581f);
        }


        if (!PlayerPrefs.HasKey("giyinme_drenk_s"))
        {
            PlayerPrefs.SetFloat("giyinme_drenk_s", 0.6157596f);
        }


        if (!PlayerPrefs.HasKey("giyinme_drenk_v"))
        {
            PlayerPrefs.SetFloat("giyinme_drenk_v", 0.9852591f);
        }

        /////

        ////// zemin
        if (!PlayerPrefs.HasKey("giyinme_zrenk_h"))
        {
            PlayerPrefs.SetFloat("giyinme_zrenk_h", 0.5787126f);
        }


        if (!PlayerPrefs.HasKey("giyinme_zrenk_s"))
        {
            PlayerPrefs.SetFloat("giyinme_zrenk_s", 0.8389464f);
        }


        if (!PlayerPrefs.HasKey("giyinme_zrenk_v"))
        {
            PlayerPrefs.SetFloat("giyinme_zrenk_v", 0.5163566f);
        }

        ///////

        ///tavan
        if (!PlayerPrefs.HasKey("giyinme_trenk_h"))
        {
            PlayerPrefs.SetFloat("giyinme_trenk_h", 0.06453484f);
        }


        if (!PlayerPrefs.HasKey("giyinme_trenk_s"))
        {
            PlayerPrefs.SetFloat("giyinme_trenk_s", 0.9435722f);
        }


        if (!PlayerPrefs.HasKey("giyinme_trenk_v"))
        {
            PlayerPrefs.SetFloat("giyinme_trenk_v", 0.06882209f);
        }
        ///////

    }
    void Start()
    {
        sponsor_image.transform.GetChild(4).GetComponent<Text>().text= ""+PlayerPrefs.GetInt("sponsor_para");
        takipci_map_artis = 0;
        dans_bust = 0;
        tiklama_sayac1 = 0;
        tiklama_sayac2 = 0;
       // tiklama_el.SetActive(false);


        foreach (Kiyafet_alma obje in Resources.FindObjectsOfTypeAll<Kiyafet_alma>())
        {
            obje.baslangic_kontrol();
        }
        foreach (mobilya_alma obje in Resources.FindObjectsOfTypeAll<mobilya_alma>())
        {
            obje.baslangic_kontrol();
        }
        ektakipci = 0;
        ektakipci_giden = 0;
        x3 = 1;
        tiklama_sayac = 0;
        levelup_button.SetActive(false);
      
        zaman = 0;
        zaman2 = 0;
       
        x = PlayerPrefs.GetFloat("tiklama_sayisi") / PlayerPrefs.GetFloat("level_artis");
       level_bar_Fa.fillAmount = x;
        level_text.text = "Level " + PlayerPrefs.GetFloat("level");
        takipci_text.text = "" + PlayerPrefs.GetInt("takipci");
        PlayerPrefs.SetInt("popi",( PlayerPrefs.GetInt("popikafa") + PlayerPrefs.GetInt("popigovde") + PlayerPrefs.GetInt("popibacak") + PlayerPrefs.GetInt("popiayak")+ PlayerPrefs.GetInt("popiodul")));
        popi_text.text=""+ PlayerPrefs.GetInt("popi");
        // hariya_konum_ac(); düzenlenecek
       // int tkp_carpi_partis = PlayerPrefs.GetFloat("p_artis") * PlayerPrefs.GetInt("takipci");
        welcome_back_para_Text.text = "+" +((int)(PlayerPrefs.GetFloat("p_artis")* (1000 + ((int)(PlayerPrefs.GetInt("takipci") / 100)) * 20))*20); 
        welcome_back_takipci_Text.text = "+" + (1000+((int)(PlayerPrefs.GetInt("takipci") / 100)) * 20);
    }
    public void asd()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("takipci_map_artis=" + takipci_map_artis);
       
       
        zaman += Time.deltaTime;
        zaman2 += Time.deltaTime;
        if ( zaman > PlayerPrefs.GetInt("t_zaman"))
        {
            zaman = 0;

             ektakipci = Random.Range(PlayerPrefs.GetInt("rnd_y"), PlayerPrefs.GetInt("rnd_x"));

            ektakipci = x3 * (ektakipci + ((ektakipci * dans_bust) / 100) + ((ektakipci * takipci_map_artis) / 100)+
           ((ektakipci * PlayerPrefs.GetInt("kafa_ta")) / 100) + ((ektakipci * PlayerPrefs.GetInt("govde_ta")) / 100) +
           ((ektakipci * PlayerPrefs.GetInt("bacak_ta")) / 100) + ((ektakipci * PlayerPrefs.GetInt("ayak_ta")) / 100) + ((ektakipci * PlayerPrefs.GetInt("ucak_ta")) / 100));


            ektakipci_giden =Random.Range(PlayerPrefs.GetInt("rnd_k"), PlayerPrefs.GetInt("rnd_z"));
            PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + (ektakipci- ektakipci_giden));
             

            ekpara = PlayerPrefs.GetFloat("p_artis") * PlayerPrefs.GetInt("takipci");
            PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + ekpara);

            if(tiklama_sayac1%5==0|| tiklama_sayac1 % 5 == 2)
            {
                if(AlllGame.oda_durumu==1)
                {
                    Instantiate(takipci_prefab, para_cikis_konum.transform.position, Quaternion.Euler(0, 20, 0), para_cikis_konum.transform);
                }
                else if (AlllGame.oda_durumu==2)
                {
                    Instantiate(takipci_prefab, gym_paracikis.transform.position, Quaternion.Euler(0, 20, 0), gym_paracikis.transform);
                }
                else if (AlllGame.oda_durumu ==3)
                {
                    Instantiate(takipci_prefab, muzik_paracikis.transform.position, Quaternion.Euler(0, 20, 0), muzik_paracikis.transform);
                }
                else if (AlllGame.oda_durumu == 4)
                {
                    Instantiate(takipci_prefab, mutfak_paracikis.transform.position, Quaternion.Euler(0, 20, 0), mutfak_paracikis.transform);
                }
                
            }
            else if (tiklama_sayac1 % 5 == 4)
            {
                if (AlllGame.oda_durumu == 1)
                {
                    Instantiate(takipci_giden_prefab, para_cikis_konum.transform.position, Quaternion.Euler(0, 20, 0), para_cikis_konum.transform);
                }
                else if (AlllGame.oda_durumu == 2)
                {
                    Instantiate(takipci_giden_prefab, gym_paracikis.transform.position, Quaternion.Euler(0, 20, 0), gym_paracikis.transform);
                }
                else if (AlllGame.oda_durumu == 3)
                {
                    Instantiate(takipci_giden_prefab, muzik_paracikis.transform.position, Quaternion.Euler(0, 20, 0), muzik_paracikis.transform);
                }
                else if (AlllGame.oda_durumu == 4)
                {
                    Instantiate(takipci_giden_prefab, mutfak_paracikis.transform.position, Quaternion.Euler(0, 20, 0), mutfak_paracikis.transform);
                }
                
            }
            else if (tiklama_sayac1 % 5 == 1 || tiklama_sayac1 % 5 == 3)
            {
                if (AlllGame.oda_durumu == 1)
                {
                    Instantiate(para_prefab, para_cikis_konum.transform.position, Quaternion.Euler(0, 20, 0), para_cikis_konum.transform);
                }
                else if (AlllGame.oda_durumu == 2)
                {
                    Instantiate(para_prefab, gym_paracikis.transform.position, Quaternion.Euler(0, 20, 0), gym_paracikis.transform);
                }
                else if (AlllGame.oda_durumu == 3)
                {
                    Instantiate(para_prefab, muzik_paracikis.transform.position, Quaternion.Euler(0, 20, 0), muzik_paracikis.transform);
                }
                else if (AlllGame.oda_durumu == 4)
                {
                    Instantiate(para_prefab, mutfak_paracikis.transform.position, Quaternion.Euler(0, 20, 0), mutfak_paracikis.transform);
                }
                
            }
            

            tiklama_sayac1++;

            PlayerPrefs.SetFloat("tiklama_sayisi", PlayerPrefs.GetFloat("tiklama_sayisi") + 1f);

            if (PlayerPrefs.GetInt("titresim")==1)
             {
            MMVibrationManager.Haptic(HapticTypes.LightImpact);
             }
        }

        
        para_text.text = System.Convert.ToString(PlayerPrefs.GetFloat("para").ToString("N0")); //  ""+ String.Format("{0:0.00}", Math.Round(PlayerPrefs.GetFloat("para"), 2).ToString());// "" + PlayerPrefs.GetFloat("para");
        takipci_text.text = "" + PlayerPrefs.GetInt("takipci");
        PlayerPrefs.SetInt("popi", (PlayerPrefs.GetInt("popikafa") + PlayerPrefs.GetInt("popigovde") + PlayerPrefs.GetInt("popibacak") + PlayerPrefs.GetInt("popiayak")+ PlayerPrefs.GetInt("popiodul")));
        popi_text.text = "" + PlayerPrefs.GetInt("popi");
        x = PlayerPrefs.GetFloat("tiklama_sayisi") / PlayerPrefs.GetFloat("level_artis");
        level_bar_Fa.fillAmount = x;
        if(level_bar_Fa.fillAmount>=1)
        {
            levelup_button.SetActive(true);
        }
    }
    public void ekle()
    {
      
        tiklama_sayac += 1;

        ektakipci = Random.Range(PlayerPrefs.GetInt("rnd_y"), PlayerPrefs.GetInt("rnd_x"));

        ektakipci = x3 * (ektakipci + ((ektakipci * dans_bust) / 100)+ ((ektakipci * takipci_map_artis) / 100) +
          ((ektakipci * PlayerPrefs.GetInt("kafa_ta")) / 100) + ((ektakipci * PlayerPrefs.GetInt("govde_ta")) / 100) +
          ((ektakipci * PlayerPrefs.GetInt("bacak_ta")) / 100) + ((ektakipci * PlayerPrefs.GetInt("ayak_ta")) / 100) + ((ektakipci * PlayerPrefs.GetInt("ucak_ta")) / 100));


        ektakipci_giden = Random.Range(PlayerPrefs.GetInt("rnd_k"), PlayerPrefs.GetInt("rnd_z"));
        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + (ektakipci - ektakipci_giden));

        if (tiklama_sayac2 % 8 == 7)
        {
            if (AlllGame.oda_durumu == 1)
            {
                Instantiate(takipci_giden_prefab, para_cikis_konum.transform.position, Quaternion.Euler(0, 20, 0), para_cikis_konum.transform);
            }
            else if (AlllGame.oda_durumu == 2)
            {
                Instantiate(takipci_giden_prefab, gym_paracikis.transform.position, Quaternion.Euler(0, 20, 0), gym_paracikis.transform);
            }
            else if (AlllGame.oda_durumu == 3)
            {
                Instantiate(takipci_giden_prefab, muzik_paracikis.transform.position, Quaternion.Euler(0, 20, 0), muzik_paracikis.transform);
            }
            else if (AlllGame.oda_durumu == 4)
            {
                Instantiate(takipci_giden_prefab, mutfak_paracikis.transform.position, Quaternion.Euler(0, 20, 0), mutfak_paracikis.transform);
            }
            
        }
        else
        {
            if (AlllGame.oda_durumu == 1)
            {
                Instantiate(takipci_prefab, para_cikis_konum.transform.position, Quaternion.Euler(0, 20, 0), para_cikis_konum.transform);
            }
            else if (AlllGame.oda_durumu == 2)
            {
                Instantiate(takipci_prefab, gym_paracikis.transform.position, Quaternion.Euler(0, 20, 0), gym_paracikis.transform);
            }
            else if (AlllGame.oda_durumu == 3)
            {
                Instantiate(takipci_prefab, muzik_paracikis.transform.position, Quaternion.Euler(0, 20, 0), muzik_paracikis.transform);
            }
            else if (AlllGame.oda_durumu == 4)
            {
                Instantiate(takipci_prefab, mutfak_paracikis.transform.position, Quaternion.Euler(0, 20, 0), mutfak_paracikis.transform);
            }
            
        }
        tiklama_sayac2++;
        if (PlayerPrefs.GetInt("titresim")==1)
        {
            MMVibrationManager.Haptic(HapticTypes.LightImpact);
        }
        PlayerPrefs.SetInt("toplam_tiklama_sayisi", PlayerPrefs.GetInt("toplam_tiklama_sayisi") + 1);
        PlayerPrefs.SetFloat("tiklama_sayisi", PlayerPrefs.GetFloat("tiklama_sayisi") + 1f);
    }
    public IEnumerator tiklama_anim()
    {
        yield return new WaitForSeconds(0.5f);
        tiklama_el.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        ekle();
        yield return new WaitForSeconds(0.2f);
        ekle();
        yield return new WaitForSeconds(0.2f);
        ekle();
        yield return new WaitForSeconds(0.2f);
        ekle();
        yield return new WaitForSeconds(0.2f);
        ekle();
        yield return new WaitForSeconds(0.5f);
        tiklama_el.SetActive(false);
    }
    public void level_atla()
    {
       
        //hariya_konum_ac(); düzenlenecek
        PlayerPrefs.SetFloat("level", PlayerPrefs.GetFloat("level")+1f);
        PlayerPrefs.SetFloat("level_artis", (((PlayerPrefs.GetFloat("level") - 1) * 4) * level_atis));
        PlayerPrefs.SetFloat("tiklama_sayisi", 1f);
        level_text.text = "Level " + PlayerPrefs.GetFloat("level");
        levelup_button.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<AlllGame>().level_odul_panel_fonk();
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
    }
    public void gelistirme_fonk()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Ekipman_Gelistirme>().Al_gelistir();
    }
    public void kiyafet_fonk()
    {
        EventSystem.current.currentSelectedGameObject.GetComponent<Kiyafet_alma>().kiyafet_al();
    }
    public void welcome_back_fonk()
    {
        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para")+ System.Int32.Parse(welcome_back_para_Text.text.Substring(1, welcome_back_para_Text.text.Length-1)));
        //Debug.Log("///" + System.Int32.Parse(welcome_back_para_Text.text.Substring(1, welcome_back_para_Text.text.Length-1)));
        GameObject.Find("Main Camera").GetComponent<AlllGame>().para_anim_cagir();
        welcome_back_UI.SetActive(false);
        
    }
    public void welcome_back_reklam_odul_fonk()//para veren
    {
        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + (System.Int32.Parse(welcome_back_para_Text.text.Substring(1, welcome_back_para_Text.text.Length - 1))));
        //Debug.Log("///" + System.Int32.Parse(welcome_back_para_Text.text.Substring(1, welcome_back_para_Text.text.Length-1)));
        GameObject.Find("Main Camera").GetComponent<AlllGame>().para_anim_cagir();
        welcome_back_UI.SetActive(false);
    }
    public void welcome_back_reklam_odul_takipci_fonk()//takipçi veren
    {
        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + (System.Int32.Parse(welcome_back_takipci_Text.text.Substring(1, welcome_back_takipci_Text.text.Length - 1))));
        //Debug.Log("///" + System.Int32.Parse(welcome_back_para_Text.text.Substring(1, welcome_back_para_Text.text.Length-1)));
        GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
        welcome_back_UI.SetActive(false);
    }
    public void welcome_back_reklam_fonk()//para veren
    {
        Reklam.odul_bak = 6;
        //gameObject.GetComponent<Reklam>().reklam_izlet();
        welcome_back_UI.SetActive(false);
    }
    public void welcome_back_reklam_takipci_fonk()//takipçi veren
    {
        Reklam.odul_bak = 8;
        //gameObject.GetComponent<Reklam>().reklam_izlet();
        welcome_back_UI.SetActive(false);
    }
    public void followers_panel()
    {
        Reklam.odul_bak = 10;
        //gameObject.GetComponent<Reklam>().reklam_izlet();

    }
    public void sponsor_panel()
    {
        Reklam.odul_bak = 2;
        //gameObject.GetComponent<Reklam>().reklam_izlet();
    }
    public void sponsor_reklam_panel()
    {
        //GameObject.Find("Game_Manager").GetComponent<Reklam>().sponsor_reklam_panel();
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
    }
    public void map_artis_ayarla_cagır(string ad)
    {
        StartCoroutine(map_artis_ayarla(ad));
    }
    public IEnumerator map_artis_ayarla(string ad)
    {
        
        Debug.Log("" + ad + "=" + PlayerPrefs.GetInt("" + ad));
        takipci_map_artis = takipci_map_artis + PlayerPrefs.GetInt("" + ad);
        Debug.Log("takipci_map_artis="+ takipci_map_artis);
        yield return new WaitForSeconds(105f);
        takipci_map_artis = takipci_map_artis - PlayerPrefs.GetInt("" + ad);
        PlayerPrefs.SetInt("" + ad, 0);
        Debug.Log("takipci_map_artis=" + takipci_map_artis);
        Debug.Log("" + ad + "=" + PlayerPrefs.GetInt("" + ad));
    }
    public void dans_artis_ayarla_cagir(int ad)
    {
        StartCoroutine(dans_artis_ayarla(ad));
    }
    public IEnumerator dans_artis_ayarla(int ad)
    {

        dans_bust = ad;
         yield return new WaitForSeconds(120f);
        dans_bust = 0;
    }
}
