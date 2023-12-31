﻿

using System;
using System.Collections;
using bardak;
using UnityEngine;

public class Splash : MonoBehaviour
{
    private IEnumerator Start()
    {
        if (!AdsManager.HaveSetupConsent)
        {
            SharedUIManager.ConsentPanel.Show();
            yield return new WaitUntil(() => !SharedUIManager.ConsentPanel.Showing);
        }

        GameManager.LoadScene("MainMenu");
    }
}