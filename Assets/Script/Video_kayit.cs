using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using MoreMountains.NiceVibrations;

public class Video_kayit : MonoBehaviour
{
    // Start is called before the first frame update
    public Image fill_bar;
    GameObject asd;
    public GameObject bar_image, nokta_image,dokunma_prefab;
    public Text video_text;
    public GameObject konum_dokunma;
    public GameObject isiklar, sandalyeler, kayit_sandalye;
    public static bool acilis_bak;
    public Slider sil_h, sil_v;
    public Scrollbar scrol_h, scrol_v;
    public GameObject kamera;
    public Tween ss,dd;
    public float sayac, sayac2;
    public Image kamera_kayma_image;
    public GameObject keep_frame;

    private void Awake()
    {
        acilis_bak = true;
    }
    void Start()
    {
        
        video_text.text = "" + PlayerPrefs.GetInt("video");
        keep_frame.SetActive(true);
        nokta_image.GetComponent<RectTransform>().localPosition =new Vector3(-bar_image.GetComponent<RectTransform>().sizeDelta.x/2,0,0);
        fill_bar.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        sayac2 += Time.deltaTime;
        acilis_hazirlik();
        video_text.text = "" + PlayerPrefs.GetInt("video");
        if (fill_bar.fillAmount>=1)
        {
            acilis_bak = false;
            nokta_image.GetComponent<RectTransform>().localPosition = new Vector3(-bar_image.GetComponent<RectTransform>().sizeDelta.x / 2, 0, 0);
            fill_bar.fillAmount = 0;
            PlayerPrefs.SetFloat("para", (PlayerPrefs.GetFloat("para") + (PlayerPrefs.GetInt("video") *100)));
            isiklar.SetActive(true);
            sandalyeler.SetActive(true);
            kayit_sandalye.SetActive(false);
            acilis_bak = true;
            GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
            GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
            GameObject.Find("Main Camera").GetComponent<AlllGame>().para_anim_cagir();
            gameObject.SetActive(false);
        }
        sil_h.value = scrol_h.value;
        sil_v.value = scrol_v.value;
     
        kamera.transform.DORotate(new Vector3(-30 + (60 * sil_v.value), 110 + (50 * (1-sil_h.value)), 0), 0.1f);
        if(sil_h.value>0.45f&& sil_h.value < 0.63f&& sil_v.value > 0.45f && sil_v.value < 0.63f)
        {
           // Debug.Log("girdim");
            sayac += Time.deltaTime;
            if(sayac>0.08f)
            {
                sayac = 0;
                video_dokunma();
            }
        }

        if(sayac2>3)
        {
            sayac2 = 0;
            kamera_kaydir();
        }

    }

    public void acilis_hazirlik()
    {
        if(acilis_bak)
        {
            for (int i = 0; i < kayit_sandalye.transform.childCount; i++)
            {
                kayit_sandalye.transform.GetChild(i).gameObject.SetActive(false);
            }
            int x = PlayerPrefs.GetInt("sandalye");
            if (x / 5 > kayit_sandalye.transform.childCount - 1)
            {
                x = (kayit_sandalye.transform.childCount - 1) * 5;
                kayit_sandalye.transform.GetChild((kayit_sandalye.transform.childCount - 1)).gameObject.SetActive(true);
            }
            else
            {
                kayit_sandalye.transform.GetChild((x / 5)).gameObject.SetActive(true);
            }
            isiklar.SetActive(false);
            sandalyeler.SetActive(false);
            kayit_sandalye.SetActive(true);
            acilis_bak = false;
            sayac = 0;
            sayac2 = 0;
            ss = null;
            dd = null;
            kamera_kayma_image.gameObject.SetActive(false);
            keep_frame.SetActive(true);
        }
    }
    public void video_dokunma()
    {
         float a = 1f;
        float b = 120f;//+ PlayerPrefs.GetInt("video")*30 ;
        // Debug.Log("pp=" + b);
         float deger = a / b;
        // Debug.Log("//" + deger);
        // Debug.Log("bbbbb" + b);
         fill_bar.fillAmount +=deger;
        // asd = Instantiate(dokunma_prefab, konum_dokunma.transform.position, Quaternion.identity, nokta_image.transform);
         // asd.transform.DOLocalMove(new Vector3(0, 0, 0), 0.15f).OnComplete(() =>Destroy(asd));
         nokta_image.GetComponent<RectTransform>().localPosition = new Vector3(nokta_image.GetComponent<RectTransform>().localPosition.x+(bar_image.GetComponent<RectTransform>().sizeDelta.x/b), 0, 0);
         if(nokta_image.GetComponent<RectTransform>().localPosition.x>= bar_image.GetComponent<RectTransform>().sizeDelta.x / 2)
         {
             nokta_image.GetComponent<RectTransform>().localPosition = new Vector3(bar_image.GetComponent<RectTransform>().sizeDelta.x / 2, 0, 0);
         }
         if (PlayerPrefs.GetInt("titresim") == 1)
         {
             MMVibrationManager.Haptic(HapticTypes.LightImpact);
         } 
    }
    
    public void kamera_kaydir()
    {
        int k = Random.Range(0, 4);
        float r1, r2;
        r1 = 0;
        r2 = 0;
        if(k==0)
        {
            r1 = Random.Range(0, 0.30f);
            r2 = Random.Range(0.7f, 1);
        }
        else if(k==1)
        {
            r1 = Random.Range(0, 0.30f);
            r2 = Random.Range(0, 0.30f);
        }
        else if (k == 2)
        {
            r2 = Random.Range(0, 0.30f);
            r1 = Random.Range(0.7f, 1);
        }
        else if (k == 3)
        {
            r1 = Random.Range(0.7f, 1);
            r2 = Random.Range(0.7f, 1);
        }
        ss = DOTween.To(x => scrol_h.value = x, scrol_h.value, r1, 2f).SetEase(Ease.Linear);
        dd= DOTween.To(x => scrol_v.value = x, scrol_v.value, r2, 2f).SetEase(Ease.Linear);
        kamera_kayma_image.gameObject.SetActive(true);
        kamera_kayma_image.DOFade(0.8f,3);
        keep_frame.SetActive(true);

    }
    public void kill()
    {
        ss.Kill();
        dd.Kill();
        Debug.Log("1=" + ss);
        Debug.Log("2=" + dd);
    }
    public void surukleme_fonk()
    {
        if(ss!=null)
        ss.Kill();
        if(dd!=null)
        dd.Kill();

        kamera_kayma_image.DOKill();
        kamera_kayma_image.gameObject.SetActive(false);
        kamera_kayma_image.DOFade(0, 0);
        // Debug.Log("deneme_girdim");
        keep_frame.SetActive(false);
    }
    public void cikis()
    {
        video_text.text = "" + PlayerPrefs.GetInt("video");
        nokta_image.GetComponent<RectTransform>().localPosition = new Vector3(-bar_image.GetComponent<RectTransform>().sizeDelta.x / 2, 0, 0);
        fill_bar.fillAmount = 0;
        acilis_bak = true;
        acilis_hazirlik();
        GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
    }
}
