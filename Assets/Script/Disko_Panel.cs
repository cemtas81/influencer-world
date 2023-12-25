using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disko_Panel : MonoBehaviour
{

    public Scrollbar scrollbar;
    private float line_deger;
    private bool deger_degisim, fail_sayac_bool;
    public bool control_bool, control_bool2;
    public GameObject[] danslar;
    private int dans_deger;
    public Button tiklama_button;
    public Animator k_Animator;
    private string[] animler = { "macarena", "hiphop", "belly", "samba" };
    public AnimationClip[] animasyonlar;
    public GameObject emoji_prefab;
    public GameObject[] emoji_cikis;
    public static int durum;
    private float time;
    public Sprite[] basarili_emoji;
    public Sprite[] basarisiz_emoji;
    private float sayac, anim_nerede_float;
    public GameObject fail_panel, win_panel, geri_sayim_foto, complatet_image;
    private int tiklama_sayisi, rnd;
    private float fail_sayac_float;
    public GameObject kiz_disko, event_panel_script;
    public Sprite[] dans_barlar;
    private int dans_bar_int;
    public Image tiklama_yazi;
    public Sprite[] tiklama_yazi_sprites;
    public GameObject konfeti;
    public GameObject background;
    public GameObject reklam_bar;
    public GameObject Reklam_bar_go;
    void Start()
    {
        baslangic();
    }
    public void baslangic()
    {
        reklam_bar.SetActive(false);
        konfeti.SetActive(false);
        kiz_disko.transform.position = new Vector3(-8.517f, 85.3f, 89.5f);
        kiz_disko.transform.rotation = Quaternion.Euler(0, 180, 0);
        geri_sayim_foto.SetActive(false);
        fail_sayac_bool = false;
        fail_sayac_float = 3;
        k_Animator.Play("Base Layer.bekleme", 0, 0);
        anim_nerede_float = 0;
        tiklama_sayisi = 0;
        time = 0;
        win_panel.SetActive(false);
        complatet_image.SetActive(false);
        fail_panel.SetActive(false);
        control_bool2 = false;
        sayac = 0;
        durum = 0;
        dans_deger = 0;
        control_bool = true;
        deger_degisim = true;
        control_bool = true;
        background.SetActive(true);
        scrollbar.gameObject.SetActive(true);
        tiklama_button.interactable = true;
        tiklama_button.gameObject.SetActive(true);
        dans_bar_int = Random.Range(0, dans_barlar.Length);
        scrollbar.gameObject.GetComponent<Image>().sprite = dans_barlar[dans_bar_int];
        tiklama_yazi.gameObject.SetActive(false);
        /* int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
         tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];*/
    }
    // Update is called once per frame
    void Update()
    {
        if (control_bool)
        {
            if (line_deger > 1)
            {
                deger_degisim = false;
            }
            if (line_deger < 0)
            {
                deger_degisim = true;
            }
            if (deger_degisim)
            {
                line_deger += Time.deltaTime;
            }
            else
            {
                line_deger -= Time.deltaTime;
            }

            scrollbar.value = line_deger;
        }
        if (control_bool2)//emoji prefab için 
        {
            if (sayac > 0.5f)
            {
                prefab_yarat();
                sayac = 0;
            }
            sayac += Time.deltaTime;
        }
        if (fail_sayac_bool)
        {
            fail_sayac_float -= Time.deltaTime;
            geri_sayim_foto.SetActive(true);
            //fail_sayac_text.text = "" + fail_sayac_float;

        }
        if (fail_sayac_float < 0)
        {
            geri_sayim_foto.SetActive(false);
            fail_sayac_bool = false;
            StartCoroutine("anim_atla");
        }
    }
    public void tiklama()
    {

        control_bool = false;
        background.SetActive(false);
        scrollbar.gameObject.SetActive(false);
        tiklama_button.interactable = false;
        tiklama_button.gameObject.SetActive(false);

        if (dans_bar_int == 0)
        {
            if (0.388f < scrollbar.value && scrollbar.value < 0.619f && durum == 0)
            {
                tiklama_yazi.gameObject.SetActive(false);
                int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
                tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];
                tiklama_yazi.gameObject.SetActive(true);
                StartCoroutine("anim_oynat");
            }
            else if (0.388f < scrollbar.value && scrollbar.value < 0.619f && durum != 0)
            {
                tiklama_yazi.gameObject.SetActive(false);
                int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
                tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];
                tiklama_yazi.gameObject.SetActive(true);
                StartCoroutine(ara_tiklama());
            }
            else
            {
                StartCoroutine("anim_atla");
            }
        }
        else if (dans_bar_int == 1)
        {
            if (0.678f < scrollbar.value && scrollbar.value < 0.913f && durum == 0)
            {
                tiklama_yazi.gameObject.SetActive(false);
                int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
                tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];
                tiklama_yazi.gameObject.SetActive(true);
                StartCoroutine("anim_oynat");
            }
            else if (0.678f < scrollbar.value && scrollbar.value < 0.913f && durum != 0)
            {
                tiklama_yazi.gameObject.SetActive(false);
                int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
                tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];
                tiklama_yazi.gameObject.SetActive(true);
                StartCoroutine(ara_tiklama());
            }
            else
            {
                StartCoroutine("anim_atla");
            }
        }
        else if (dans_bar_int == 2)
        {
            if (0.153f < scrollbar.value && scrollbar.value < 0.379f && durum == 0)
            {
                tiklama_yazi.gameObject.SetActive(false);
                int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
                tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];
                tiklama_yazi.gameObject.SetActive(true);
                StartCoroutine("anim_oynat");
            }
            else if (0.153f < scrollbar.value && scrollbar.value < 0.379f && durum != 0)
            {
                tiklama_yazi.gameObject.SetActive(false);
                int rnd2 = Random.Range(0, tiklama_yazi_sprites.Length);
                tiklama_yazi.sprite = tiklama_yazi_sprites[rnd2];
                tiklama_yazi.gameObject.SetActive(true);
                StartCoroutine(ara_tiklama());
            }
            else
            {
                StartCoroutine("anim_atla");
            }
        }
    }
    public void prefab_yarat()
    {
        int rnd = Random.Range(0, emoji_cikis.Length);
        Instantiate(emoji_prefab, emoji_cikis[rnd].transform.position, Quaternion.Euler(0, 20, 0), emoji_cikis[rnd].transform);
    }
    public IEnumerator anim_oynat()
    {
        durum = 1;//emoji prefab için gerekli
        tiklama_sayisi++;
        Debug.Log("Tiklama_sayisi=" + tiklama_sayisi);
        rnd = Random.Range(0, animler.Length);
        k_Animator.Play("Base Layer." + animler[rnd], 0, 0);
        RuntimeAnimatorController ac = k_Animator.runtimeAnimatorController;
        for (int i = 0; i < ac.animationClips.Length; i++)
        {
            if (ac.animationClips[i].name == animasyonlar[rnd].name)
            {
                time = ac.animationClips[i].length;
            }
        }
        yield return new WaitForSeconds(3);
        control_bool2 = true;
        yield return new WaitForSeconds((time / 3) - 3);
        control_bool = true;
        background.SetActive(true);
        scrollbar.gameObject.SetActive(true);
        tiklama_button.interactable = true;
        tiklama_button.gameObject.SetActive(true);
        geri_sayim_foto.SetActive(true);
        fail_sayac_float = 3;
        fail_sayac_bool = true;
        dans_bar_int = Random.Range(0, dans_barlar.Length);
        scrollbar.gameObject.GetComponent<Image>().sprite = dans_barlar[dans_bar_int];
    }
    public IEnumerator anim_atla()
    {
        control_bool = false;
        background.SetActive(false);
        scrollbar.gameObject.SetActive(false);
        tiklama_button.interactable = false;
        tiklama_button.gameObject.SetActive(false);
        fail_sayac_bool = false;
        fail_sayac_float = 3;
        geri_sayim_foto.SetActive(false);
        anim_nerede_float = k_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        k_Animator.SetTrigger("fail");
        durum = 2;//emoji prefab için gerekli
        yield return new WaitForSeconds(3f);
        fail_panel.SetActive(true);
    }
    public IEnumerator ara_tiklama()
    {
        fail_sayac_bool = false;
        fail_sayac_float = 3;
        geri_sayim_foto.SetActive(false);
        durum = 1;//emoji prefab için gerekli
        tiklama_sayisi++;
        Debug.Log("Tiklama_sayisi=" + tiklama_sayisi);
        control_bool = false;
        background.SetActive(false);
        scrollbar.gameObject.SetActive(false);
        tiklama_button.interactable = false;
        tiklama_button.gameObject.SetActive(false);
        yield return new WaitForSeconds((time / 3) - 1.5f);
        if (tiklama_sayisi >= 3)
        {
            konfeti.SetActive(true);
            win_panel.SetActive(true);
            StartCoroutine(reklam_bar_ac());
            complatet_image.SetActive(true);
        }
        else
        {
            control_bool = true;
            background.SetActive(true);
            scrollbar.gameObject.SetActive(true);
            tiklama_button.interactable = true;
            tiklama_button.gameObject.SetActive(true);
            geri_sayim_foto.SetActive(true);
            fail_sayac_float = 3;
            fail_sayac_bool = true;
            dans_bar_int = Random.Range(0, dans_barlar.Length);
            scrollbar.gameObject.GetComponent<Image>().sprite = dans_barlar[dans_bar_int];
        }
    }
    public void reklam_izlendi()
    {
        Debug.Log("girdim***");
        fail_sayac_bool = false;
        fail_sayac_float = 3;
        geri_sayim_foto.SetActive(false);
        fail_panel.SetActive(false);
        
        if (tiklama_sayisi == 0)
        {
            StartCoroutine("anim_oynat");
        }
        else
        {
            k_Animator.Play("Base Layer." + animler[rnd], 0, anim_nerede_float);
            StartCoroutine(ara_tiklama());
        }
    }
    public void fail_oyuna_don_fonk()
    {
        baslangic();
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
        /* AlllGame.dans_gecen_zaman = 120;
         AlllGame.dans_image_baryuzde = 120;
         AlllGame.dans_gerisay = true;*/
    }
    public void win_oyuna_don_fon()
    {
        baslangic();
        GameObject.Find("Game_Manager").GetComponent<AllPP>().dans_artis_ayarla_cagir(10);
        GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
        GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
        AlllGame.dans_gecen_zaman = 120;
        AlllGame.dans_image_baryuzde = 120;
        AlllGame.dans_gerisay = true;
        GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
    }
    public void reklam_izlet()
    {
        Reklam.odul_bak = 5;
        //GameObject.Find("Game_Manager").GetComponent<Reklam>().reklam_izlet();
    }
    public void x2_odul_reklam_izlet()
    {
        Reklam.odul_bak = 7;
        //GameObject.Find("Game_Manager").GetComponent<Reklam>().reklam_izlet();
    }
    public void x2_win_oyuna_don_fon()
    {
        baslangic();
        GameObject.Find("Game_Manager").GetComponent<AllPP>().dans_artis_ayarla_cagir(Reklam_Bar_Script.bar_deger);
        GameObject.Find("Main Camera").GetComponent<AlllGame>().takipci_anim_cagir();
        GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
        Reklam_bar_go.GetComponent<Reklam_Bar_Script>().Start();
        AlllGame.dans_gecen_zaman = 120;
        AlllGame.dans_image_baryuzde = 120;
        AlllGame.dans_gerisay = true;

    }
    public IEnumerator reklam_bar_ac()
    {

        yield return new WaitForSeconds(1.1f);
        reklam_bar.SetActive(true);

    }
}
