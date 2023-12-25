using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using GoogleMobileAds;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Collections;

public class Reklam : MonoBehaviour
{
    public GameObject main_camera;
    private RewardedAd rewardedAd;
    public static int odul_bak;
    public GameObject disko_panel;
    //banner
    private BannerView banner;
    private bool banner_bak;
    public static GameObject reklam_mobilya, reklam_kiyaket;
    bool isEarnedReward;
    // public string banner_idAndroid = "";
    // public string banner_idIOS = "";

//    public void Start()
//    {
//        banner_bak = true;
//        odul_bak = 0;
//        string adUnitId;
//#if UNITY_ANDROID
//        adUnitId = "ca-app-pub-9585813676258300/5380415420";

//#elif UNITY_IPHONE
//        adUnitId = "ca-app-pub-9585813676258300/3636761678";
            
//#else
//            adUnitId = "unexpected_platform";
            
//#endif
//        MobileAds.SetiOSAppPauseOnBackground(true);
//        MobileAds.Initialize(initStatus => { });
//        this.rewardedAd = new RewardedAd(adUnitId);

//        // Called when an ad request has successfully loaded.
//        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
//        // Called when an ad request failed to load.
//        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
//        // Called when an ad is shown.
//        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
//        // Called when an ad request failed to show.
//        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
//        // Called when the user should be rewarded for interacting with the ad.
//        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
//        // Called when the ad is closed.
//        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the rewarded ad with the request.

//        this.rewardedAd.LoadAd(request);
//        this.RequestBanner();

       


//    }
//    void Update()
//    {

//    }
//    private void RequestBanner()
//    {
//#if UNITY_ANDROID
//        string id = "ca-app-pub-9585813676258300/1433254259";
//#elif UNITY_IPHONE
//        string id = "ca-app-pub-9585813676258300/9311744276";
//#else
//            string id = "unexpected_platform";
//#endif
//        AdSize adsize = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);
//        banner = new BannerView(id, adsize, AdPosition.Bottom);
//        AdRequest request = new AdRequest.Builder().Build();
//         banner.LoadAd(request);//açılacak
//       // banner.Show();//açılmayacak
//        // banner.Hide();
//    }
//    public void HandleRewardedAdLoaded(object sender, EventArgs args)
//    {
//       // MonoBehaviour.print("HandleRewardedAdLoaded event received");
//    }
//    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs e)
//    {
//    }
///*public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
//    {
//        GameAnalytics.NewDesignEvent("Rewarded:FailedToLoad");
//        // MonoBehaviour.print(
//        //   "HandleRewardedAdFailedToLoad event received with message: "
//        //                    + args.Message);

//        //not showed
//    }*/
//    public void HandleRewardedAdOpening(object sender, EventArgs args)
//    {
//       // MonoBehaviour.print("HandleRewardedAdOpening event received");
//    }
//    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)//not showed
//    {
//    }
//    public void CreateAndLoadRewardedAd()
//    {
//#if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-9585813676258300/5380415420";
//#elif UNITY_IPHONE
//        string adUnitId = "ca-app-pub-9585813676258300/3636761678";
//#else
//            string adUnitId = "unexpected_platform";
//#endif

//        this.rewardedAd = new RewardedAd(adUnitId);

//        // Called when an ad request has successfully loaded.
//       // this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
//        // Called when an ad request failed to load.
//       // this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
//        // Called when an ad is shown.
//       // this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
//        // Called when an ad request failed to show.
//       // this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
//        // Called when the user should be rewarded for interacting with the ad.
//        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
//        // Called when the ad is closed.
//        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the rewarded ad with the request.
//        this.rewardedAd.LoadAd(request);
//    }
//    public void HandleRewardedAdClosed(object sender, EventArgs args)//ödül ver
//    {
//        //Debug.Log("_______ HandleRewardedAdClosed");
//        this.rewardedAd.OnAdClosed -= HandleRewardedAdClosed;
//        this.CreateAndLoadRewardedAd();
//        StartCoroutine(Delayer());
//    }
//    private IEnumerator Delayer()
//    {
//        yield return new WaitForSeconds(0f);

//        if (isEarnedReward)
//        {
//            if (odul_bak == 1)
//            {
//                x2_kazanama();

//            }
//            else if (odul_bak == 2)
//            {
//                sponsor_panel();
//            }
//            else if (odul_bak == 3)
//            {
//                follower_panel();
//            }
//            else if (odul_bak == 4)
//            {
//                x3_kazanama();
//            }
//            else if (odul_bak == 5)
//            {
//                disko_reklam();
//            }
//            else if (odul_bak == 6)
//            {
//                GameObject.Find("Game_Manager").GetComponent<AllPP>().welcome_back_reklam_odul_fonk();
//            }
//            else if (odul_bak == 7)
//            {
//                disko_x2_reklam();
//            }
//            else if (odul_bak == 8)
//            {
//                GameObject.Find("Game_Manager").GetComponent<AllPP>().welcome_back_reklam_odul_takipci_fonk();
//            }
//            else if (odul_bak == 9)
//            {
//                ParaFloatButton_fonk();
//            }
//            else if (odul_bak == 10)
//            {
//                Tbt_reklam_odul();
//            }
//            else if (odul_bak == 11)
//            {
                
//                reklam_mobilya.GetComponent<mobilya_alma>().Reklamla_al();
//            }
//            else if (odul_bak == 13)
//            {
                
//                reklam_kiyaket.GetComponent<Kiyafet_alma>().Reklamla_al();
//            }
//            else
//            {
//                main_camera.GetComponent<AlllGame>().exit_button_fonk();
//            }
//        }
//        else
//        {
//            if (odul_bak == 5)
//            {
//                disko_panel.GetComponent<Disko_Panel>().fail_oyuna_don_fonk();
//            }
//            else if (odul_bak == 11 || odul_bak == 13)
//            {
//                //reklam ile kıyafet ve mobilya alma kısmı
//            }
//            else
//            {
//                main_camera.GetComponent<AlllGame>().exit_button_fonk();
//            }
//        }
//        odul_bak = 0;
//        Camera.main.GetComponent<AlllGame>().ses_reklam_ac();
//        Time.timeScale = 1;
//    }
//    //public void HandleUserEarnedReward(object sender, Reward args)//ödül ver
//    //{
//    //    isEarnedReward = true;
//    //}
//    public void ParaFloatButton_fonk()
//    {
//        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + (500 + (250 * PlayerPrefs.GetInt("ParaFloatButton"))));
//        PlayerPrefs.SetInt("ParaFloatButton", PlayerPrefs.GetInt("ParaFloatButton") + 1);
//        main_camera.GetComponent<AlllGame>().para_anim_cagir();
//        main_camera.GetComponent<AlllGame>().exit_button_fonk();
//    }
//    public void Tbt_reklam_odul()
//    {
//        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + (1000 + ((PlayerPrefs.GetInt("takipci") / 100) * 10)));
//        main_camera.GetComponent<AlllGame>().exit_button_fonk();
//        main_camera.GetComponent<AlllGame>().takipci_anim_cagir();
//    }
//    public void reklam_izlet()
//    {
//        if(PlayerPrefs.GetInt("reklam_kapa") == 0)
//        {
//            if (this.rewardedAd.IsLoaded())
//            {
//                isEarnedReward = false;
//                this.rewardedAd.Show();
//            }
//            this.rewardedAd.OnAdLoaded -= HandleRewardedAdLoaded;
//            Camera.main.GetComponent<AlllGame>().ses_reklam_kapa();
//            Time.timeScale = 0;
//        }
//        else
//        {
//            if (odul_bak == 1)
//            {
//                odul_bak = 0;
//                //Debug.Log("girdim");
//                x2_kazanama();

//            }
//            else if (odul_bak == 2)
//            {
//                odul_bak = 0;
//                sponsor_panel();
//            }
//            else if (odul_bak == 3)
//            {
//                odul_bak = 0;
//                follower_panel();
//            }
//            else if (odul_bak == 4)
//            {
//                odul_bak = 0;
//                x3_kazanama();
//            }
//            else if (odul_bak == 5)
//            {
//                odul_bak = 0;
//                disko_reklam();
//            }
//            else if (odul_bak == 6)
//            {
//                odul_bak = 0;
//                GameObject.Find("Game_Manager").GetComponent<AllPP>().welcome_back_reklam_odul_fonk();
//            }
//            else if (odul_bak == 7)
//            {
//                odul_bak = 0;
//                disko_x2_reklam();
//            }
//            else if (odul_bak == 8)
//            {
//                odul_bak = 0;
//                GameObject.Find("Game_Manager").GetComponent<AllPP>().welcome_back_reklam_odul_takipci_fonk();
//            }
//            else if (odul_bak == 9)
//            {
//                odul_bak = 0;
//                ParaFloatButton_fonk();
//            }
//            else if (odul_bak == 10)
//            {
//                odul_bak = 0;
//                Tbt_reklam_odul();
//            }
//            else if (odul_bak == 11)
//            {
//                odul_bak = 0;
//                reklam_mobilya.GetComponent<mobilya_alma>().Reklamla_al();
//            }
//            else if (odul_bak == 13)
//            {
//                //odul_bak = 0;
//                //kiyafeti_ac();
//                reklam_kiyaket.GetComponent<Kiyafet_alma>().Reklamla_al();
//            }
//            //GameObject.Find("Main Camera").GetComponent<AlllGame>().ses_reklam_ac();
//            odul_bak = 0;
//            GameObject.Find("Main Camera").GetComponent<AlllGame>().ses_reklam_ac();
//            Time.timeScale = 1;
//        }
//    }
//    public void x2_kazanama()
//    {
//        //AllPP.x3 = 2;
//        AlllGame.gerisay = true;
//        main_camera.GetComponent<AlllGame>().x3_button.gameObject.SetActive(false);
//        // main_camera.GetComponent<AlllGame>().time_text.gameObject.SetActive(true);
//        main_camera.GetComponent<AlllGame>().geri_sayim_gameobject.SetActive(true);
//        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + (1000 + ((PlayerPrefs.GetInt("takipci") / 100) * 10)));
//        main_camera.GetComponent<AlllGame>().exit_button_fonk();
//        main_camera.GetComponent<AlllGame>().takipci_anim_cagir();
//    }
//    public void x3_kazanama()
//    {

//        main_camera.GetComponent<AlllGame>().level_3x_odul_alma();
//    }
//    public void sponsor_panel()
//    {
//        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + System.Int32.Parse(gameObject.GetComponent<AllPP>().sponsor_image.transform.GetChild(4).gameObject.GetComponent<Text>().text));
//        gameObject.GetComponent<AllPP>().sponsor_image.transform.parent.gameObject.SetActive(false);
//        PlayerPrefs.SetInt("sponsor_para", PlayerPrefs.GetInt("sponsor_para") + 500);
//        gameObject.GetComponent<AllPP>().sponsor_image.transform.GetChild(4).GetComponent<Text>().text = "" + PlayerPrefs.GetInt("sponsor_para");
//        GameObject.Find("Main Camera").GetComponent<AlllGame>().exit_button_fonk();
//        main_camera.GetComponent<AlllGame>().exit_button_fonk();
//    }
//    public void sponsor_reklam_panel()
//    {
//        PlayerPrefs.SetFloat("para", PlayerPrefs.GetFloat("para") + System.Int32.Parse(gameObject.GetComponent<AllPP>().sponsor_reklam_image.transform.GetChild(4).gameObject.GetComponent<Text>().text));
//        gameObject.GetComponent<AllPP>().sponsor_reklam_image.transform.parent.gameObject.SetActive(false);
//        main_camera.GetComponent<AlllGame>().exit_button_fonk();
//    }
//    public void follower_panel()
//    {
//        PlayerPrefs.SetInt("takipci", PlayerPrefs.GetInt("takipci") + System.Int32.Parse(gameObject.GetComponent<AllPP>().follower_image.transform.GetChild(4).gameObject.GetComponent<Text>().text));
//        gameObject.GetComponent<AllPP>().follower_image.transform.parent.gameObject.SetActive(false);
//        main_camera.GetComponent<AlllGame>().exit_button_fonk();
//    }
//    public void banner_ac_kapa()
//    {
//        if(banner_bak)
//        {
//            banner.Hide();
//        }

//        else
//        {
//            banner.Show();
//        }
//        banner_bak = !banner_bak;
//    }
//    public void disko_reklam()
//    {
//        disko_panel.GetComponent<Disko_Panel>().reklam_izlendi();
//    }
//    public void disko_x2_reklam()
//    {
//        disko_panel.GetComponent<Disko_Panel>().x2_win_oyuna_don_fon();
//    }
//    public void kiyafeti_ac()
//    {
//        reklam_kiyaket.GetComponent<Kiyafet_alma>().Reklamla_al();
//    }
}