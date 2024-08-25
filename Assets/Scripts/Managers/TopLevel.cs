using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLevel : MonoBehaviour
{
    private UiManager UiManager;
    private PlayerStatus PlayerStatus;

    void Start()
    {
        UiManager = this.gameObject.GetComponent<UiManager>();    
        PlayerStatus = this.gameObject.GetComponent<PlayerStatus>();    
    }

    public void AnnouncePlayerDeath(GameObject gameObject){

        Destroy(gameObject);
        this.PlayerStatus.SetPlayerAlive(false);
        this.UiManager.ShowGameOverPanel();
    }
}
