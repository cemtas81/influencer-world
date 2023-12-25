/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;
using System;


public class bildirim_android : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        bildirim();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bildirim()
    {
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification();
        notification.Title = "Influencer";
        notification.Text = "Takipcilerin senden yeni icerikler bekliyor";
        notification.SmallIcon = "icon_0";
        notification.LargeIcon = "icon_1";

        notification.FireTime = System.DateTime.Now.AddMinutes(2);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
}
*/