using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMultiplayerUI : MonoBehaviour
{
    private void Start()
    {
        KitchenGameManager.Instance.OnMultiplayerGamePlayerPaused += KitchenGameManager_OnMultiplayerGamePlayerPaused;
        KitchenGameManager.Instance.OnMultiplayerGamePlayerUnpaused += KitchenGameManager_OnMultiplayerGamePlayerUnpaused;

        Hide();
    }

    private void KitchenGameManager_OnMultiplayerGamePlayerUnpaused(object sender, EventArgs e)
    {
        Hide();
    }

    private void KitchenGameManager_OnMultiplayerGamePlayerPaused(object sender, System.EventArgs e)
    {
        Show();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
