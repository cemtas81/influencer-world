using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animasyon : MonoBehaviour
{
    private Animator anim;
    public Slider timeline;
    public Scrollbar scrollbar;
    private bool bak;
    public static bool anim_bak;
    float sayac;
    public Text geti_sayim_text;
    public GameObject foto_cekme_image;
    public GameObject gerisayim_image;
    public AudioClip foto_cekme_ses;
    public AudioSource efekt_oynatici;
    public float[] poz_konum = { 0f, 0.115f, 0.32f, 0.415f, 0.54f, 0.8f, 1f };
    public static int pozlar_konum_nokta;
    public GameObject foto_tutorial;
    public static string ulke_name;
    public static int ulke_artis;
    private int cekilen_foto;

    // Start is called before the first frame update
    void Start()
    {
        geti_sayim_text.gameObject.SetActive(false);
        cekilen_foto = 2;
        sayac = 3;
        anim_bak = false;
        bak = false;
        anim = GetComponent<Animator>();
        gerisayim_image.SetActive(false);
        foto_cekme_image.gameObject.SetActive(false);
        if (PlayerPrefs.GetInt("anim_foto") == 0)
        {
            foto_tutorial.SetActive(true);
            PlayerPrefs.SetInt("anim_foto", 1);
        }
        else
        {
            foto_tutorial.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!bak)
        {
            timeline.value = (1-scrollbar.value);
        }
        if (bak)
        {
            scrollbar.value = 1 - timeline.value;
        }

       // timeline.value = (1 - scrollbar.value);
        anim.Play("Base Layer.mixamo_com", 0, timeline.value);
        if(anim_bak)
        {
            
            //if(scrollbar.value<0.21&& scrollbar.value>0.18f)
            if (timeline.value < (poz_konum[pozlar_konum_nokta]+0.01) && timeline.value > (poz_konum[pozlar_konum_nokta] - 0.01))
            {
                sayac -= Time.deltaTime;
                geti_sayim_text.gameObject.SetActive(true);
                geti_sayim_text.text = "" + System.Math.Round(sayac, 1);
                gerisayim_image.SetActive(true);
            }
            else
            {
                geti_sayim_text.gameObject.SetActive(false);
                gerisayim_image.SetActive(false);
                sayac = 3;
            }
        }
        if(sayac<0)
        {
            if(cekilen_foto!=0)
            {

                anim_bak = false;
                sayac = 3;
                cekilen_foto--;
                StartCoroutine(foto_cek());
            }
            else
            {
                anim_bak = false;
                sayac = 3;
                StartCoroutine(geri_donme());
            }
           // anim_bak = false;
           // sayac = 3;
           // StartCoroutine(geri_donme());
        }
    }
    
    public void dokunma()
    {
        bak = true;
    }
    public void cekme()
    {
        bak = false;
    }

    public IEnumerator foto_cek()
    {


        foto_cekme_image.gameObject.SetActive(true);

        if (PlayerPrefs.GetInt("ses") == 1)
            efekt_oynatici.PlayOneShot(foto_cekme_ses, 1);
       
        yield return new WaitForSeconds(1);
        foto_cekme_image.gameObject.SetActive(false);
        anim_bak = true;
        GameObject.Find("kiz_Final_etkinlik(pozlar)").GetComponent<pozlar>().poz_sec();
    }
    public IEnumerator geri_donme()
    {
        
        
        foto_cekme_image.gameObject.SetActive(true);

        if (PlayerPrefs.GetInt("ses") == 1)
            efekt_oynatici.PlayOneShot(foto_cekme_ses, 1);
        yield return new WaitForSeconds(0.8f);
        GameObject.Find("ConfettiManager").GetComponent<ConfettiManager>().Explode();
        yield return new WaitForSeconds(2);
        scrollbar.value = 0.5f;
        cekilen_foto = 2;
        foto_cekme_image.gameObject.SetActive(false);
        PlayerPrefs.SetInt("" + ulke_name, ulke_artis);
        GameObject.Find("Game_Manager").GetComponent<AllPP>().map_artis_ayarla_cagır(ulke_name);
        GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        //AlllGame.gerisay2 = true;
    }
    public void tutoial_kapa()
    {
        PlayerPrefs.SetInt("anim_foto", 1);
        foto_tutorial.SetActive(false); 
    }
}
