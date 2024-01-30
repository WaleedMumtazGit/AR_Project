using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectManager : MonoBehaviour
{
    public static ProjectManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        ShowAd();
    }

    void Update()
    {
       
    }

    public void ShowAd()
    {
        loadBanner.instance.showBannerAd();
    }

    public void ShowInterstitial()
    {
        loadInterstitial.instance.ShowAd();
    }

    public void ShowRewarded()
    {
        loadRewarded.instance.ShowAd();
    }

}
