/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.iOS;
using System;

public class bildirim_ios : MonoBehaviour
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
        var timeTrigger = new iOSNotificationTimeIntervalTrigger()
        {
            TimeInterval = new TimeSpan(0, 2, 0),
            Repeats = false
        };

        var notification = new iOSNotification()
        {
            // You can specify a custom identifier which can be used to manage the notification later.
            // If you don't provide one, a unique string will be generated automatically.
            Identifier = "_notification_01",
            Title = "Influencer",
            Body = "Takipcilerin seni bekliyor nerede kaldin",
            Subtitle = "Takipcilerin senden yeni icerikler bekliyor",
            ShowInForeground = true,
            ForegroundPresentationOption = (PresentationOption.Alert | PresentationOption.Sound),
            CategoryIdentifier = "category_a",
            ThreadIdentifier = "thread1",
            Trigger = timeTrigger,
        };

        iOSNotificationCenter.ScheduleNotification(notification);
    }
}*/
