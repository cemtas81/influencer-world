using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MoreMountains.NiceVibrations;

public class YorumlarPopUp : MonoBehaviour
{
    public Text yorum_text, isim_text,sayac_text,video_text;
    public Image karakter_image,bar;
    public Sprite[] karakterler_sprite;
    private string[] iyi_yorumlar = { "nice content", "nice clothes", "if you stop broadcast video i will cry", "Top class is here", "UK here! #AWESOME", "Spain is here! #BEST", "what is the this brand of lipstick?", "I came to watch with great excitement", "we always want to see you in videos", "Here are the answers to all the questions we didn't wonder", "She is asking the perfect questions. Love this", "Finally you came back.", "I admire your strong stance", "You are the perfect therapy method after school", "16:36 I died laughing at this part:D", };
    private string[] kotu_yorumlar = { "you gained a lot of weight", "your hair is so bad", "You are giving wrong information", "your makeup is so bad", "Nothing is understood from their speech", "you are soo bad.", "you should quit this job", "you always produce the same content", "the video could be better", "waste of time", "It's a pity for the time I spent on the video", "The worst video I've watched.", "It's good for you to take a break.", "You are a disrespectful person.", "Its style was very unattractive." };
    private string[] isimler = { "Polloso", "Mia Sanchez", "EcroDeron", "Mash Art", "Lizeth", "Dani", "Mr.P", "Arianator", "Anônima", "Hasini Pulavarthi", "Mak Carolin", "Yuce Bugra", "Kucuk Namik", "Kral Volkan", "Danna", "Dorian", "Victor", "Serir Nabil", "Nikola Eddy", "Milk & Cookies" };
    private int durum,sayac_iyi,sayac_kotu,sayac_isim,sayac_resim,sayac;
    float sayi;
    int sayi2;
    // Start is called before the first frame update
    void Start()
    {
        video_text.text = "" + PlayerPrefs.GetInt("video");
        sayac = 1;
        sayac_text.text = "" + sayac + "/20";
        sayac_resim = 0;
        bar.fillAmount = 0;
        durum = 0;
        sayac_iyi = 0;
        sayac_kotu = 0;
        sayac_isim = 0;
        yorum_getir();
        
    }
    private void yorum_getir()
    {
        
        durum = Random.Range(0, 2);
        if (durum == 1)//iyi yorum
        {
            if(sayac_resim>=5)
            {
                sayac_resim = 0;
            }
            if (sayac_iyi >= 15)
            {
                sayac_iyi = 0;
            }
            if (sayac_isim >= 20)
            {
                sayac_isim = 0;
            }
            karakter_image.sprite = karakterler_sprite[sayac_resim];
            isim_text.text = "" + isimler[sayac_isim];
            yorum_text.text = "<color=green>"+"" + iyi_yorumlar[sayac_iyi] + "</color>";
            sayac_iyi++;
            sayac_isim++;
            sayac_resim++;
        }
        else if (durum == 0)//kötü yorum
        {
            if (sayac_resim >= 5)
            {
                sayac_resim = 0;
            }
            if (sayac_kotu >= 15)
            {
                sayac_kotu = 0;
            }
            if (sayac_isim >= 20)
            {
                sayac_isim = 0;
            }
            karakter_image.sprite = karakterler_sprite[sayac_resim];
            isim_text.text = "" + isimler[sayac_isim];
            yorum_text.text = "<color=red>" +""+ kotu_yorumlar[sayac_kotu] + "</color>";
            sayac_kotu++;
            sayac_resim++;
            sayac_isim++;
        }
        sayac_text.text = "" + sayac + "/20";
    }
    // Update is called once per frame
    void Update()
    {
        if(sayac==21)
        {
          
            sayi = bar.fillAmount;
            sayi = sayi * 100;
            sayi2 = (int)(sayi);
            Debug.Log("sayi=" + sayi);
            Debug.Log("sayi2=" + sayi2);
            Debug.Log("///////////" +  (PlayerPrefs.GetInt("video")  * sayi2));

            PlayerPrefs.SetFloat("para", (PlayerPrefs.GetFloat("para")+(PlayerPrefs.GetInt("video")*sayi2)));
            PlayerPrefs.SetInt("video",PlayerPrefs.GetInt("video")+1);
            
            
            Start();
            GameObject.Find("Game_Manager").GetComponent<Reklam_InterstitialAd>().gecis_reklami_izlet();
            GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
            GameObject.Find("Main Camera").GetComponent<AlllGame>().para_anim_cagir();
            //gameObject.transform.parent.gameObject.SetActive(false);
        }
    }
    public void iyi_button()
    {
        if(durum==1)
        {
            if (PlayerPrefs.GetInt("titresim") == 1)
            {
                MMVibrationManager.Haptic(HapticTypes.LightImpact);
            }
            bar.fillAmount += 0.05f;
        }
        else
        {
            if(bar.fillAmount==0)
            {

            }
            else
            {
                if (PlayerPrefs.GetInt("titresim") == 1)
                {
                    MMVibrationManager.Haptic(HapticTypes.MediumImpact);
                }
                bar.fillAmount -= 0.05f;
            }
            
        }
        sayac++;
        yorum_getir();
        
    }

    public void kotu_button()
    {
        if (durum == 0)
        {
            if (PlayerPrefs.GetInt("titresim") == 1)
            {
                MMVibrationManager.Haptic(HapticTypes.LightImpact);
            }
            bar.fillAmount += 0.05f;
        }
        else
        {
            if (bar.fillAmount == 0)
            {

            }
            else
            {
                if (PlayerPrefs.GetInt("titresim") == 1)
                {
                    MMVibrationManager.Haptic(HapticTypes.MediumImpact);
                }
                bar.fillAmount -= 0.05f;
            }

        }
        sayac++;
        yorum_getir();
    }
}
