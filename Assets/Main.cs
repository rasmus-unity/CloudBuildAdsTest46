using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class Main : MonoBehaviour
{
	void Start ()
	{
		Advertisement.Initialize("14851");
	}

	public void ShowAd()
	{
		if (!Advertisement.IsReady ())
		{
			Debug.Log("Ads not ready");
			return;
		}

		Advertisement.Show ();
	}
}
