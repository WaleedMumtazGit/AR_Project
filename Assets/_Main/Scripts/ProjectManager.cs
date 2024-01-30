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

    IEnumerator Start()
    {
        MyAdsManager.instance.InitializeAds();
       


        yield return new WaitForSeconds(10f);
        MyAdsManager.instance.ShowInterstitialAds();
        MyAdsManager.instance.ShowAdmobBanner();
    }

    void Update()
    {
       
    }
}
