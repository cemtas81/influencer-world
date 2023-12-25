using UnityEngine.Events;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using GoogleMobileAds;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Reklam_InterstitialAd : MonoBehaviour
{
   
    private InterstitialAd interstitial;
    public float reklam_sayac,raklam_gosterme_sure;
    public GameObject popup_cerceve;
    public static bool popup_cikar;
    public GameObject main_camera;
    
    // Start is called before the first frame update
    void Start()
    {
        popup_cikar = true;
        raklam_gosterme_sure = 30f;
        reklam_sayac = 0f;
        gecis_reklami_yukle();
    }
    public void gecis_reklami_yukle()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-9585813676258300/3620433890";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-9585813676258300/4352923453";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is shown.
        this.interstitial.OnAdOpening += HandleOnAdOpened;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        //this.interstitial.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        // Create an empty ad request.
        //AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        //this.interstitial.LoadAd(request);
    }
    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        // MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        // MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
        //                  + args.Message);
       // GameAnalytics.NewDesignEvent("Interstitial:NotLoaded");

    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        // MonoBehaviour.print("HandleAdOpened event received");
        //Debug.Log("geçiş reklam açıldı");
        main_camera.GetComponent<AlllGame>().ses_reklam_ac();

    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        // MonoBehaviour.print("HandleAdClosed event received");
       // Debug.Log("geçiş reklam kapatıldı");
        reklam_sayac = 0;
        popup_cikar = true;
        main_camera.GetComponent<AlllGame>().ses_reklam_ac();
        Time.timeScale = 1;
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }
    // Update is called once per frame
    void Update()
    {
        reklam_sayac += Time.deltaTime;
        if (reklam_sayac >=30&& popup_cerceve.activeSelf && popup_cikar==true&& PlayerPrefs.GetInt("reklam_kapa") == 0&&popup_cerceve.transform.childCount == 0)
        {
            //reklam_sayac = 0;
            popup_cikar = false;
            main_camera.GetComponent<AlllGame>().reklam_sponsor_prefab();
        }
       // Debug.Log("reklam sayac=" + reklam_sayac);
    }
   
    public void gecis_reklami_izlet()
    {
        if (this.interstitial.IsLoaded()&&reklam_sayac>= raklam_gosterme_sure&& PlayerPrefs.GetInt("reklam_kapa")==0)
        {

            main_camera.GetComponent<AlllGame>().ses_reklam_kapa();
            if(this.interstitial.IsLoaded())
            {
                this.interstitial.Show();
                Time.timeScale = 0;
            }
            gecis_reklami_yukle();
        }
    }
}
