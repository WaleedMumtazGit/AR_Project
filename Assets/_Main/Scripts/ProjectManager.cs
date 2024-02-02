using System.Collections;
using System.Collections.Generic;
using TriLibCore.Samples;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class ProjectManager : MonoBehaviour
{
    public static ProjectManager instance;

    public TMP_InputField inputField;

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

    public void LoadModel()
    {
        LoadModelFromURLSample.instance.LoadDownloadedModel();
    }

}
