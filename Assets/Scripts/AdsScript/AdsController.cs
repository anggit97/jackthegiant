using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsController : MonoBehaviour {

	void Start ()
	{
		RequestBanner ();
	}

	private void RequestBanner()
	{
		
		string adUnitId = "ca-app-pub-9462227102377874/3825431383";
		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}

}
