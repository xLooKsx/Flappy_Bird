using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{

    public GameObject gameManager;

    private TopLevel TopLevel;

    private void Start() {
        
        TopLevel = gameManager.GetComponent<TopLevel>();
    }

    void OnTriggerEnter2D(Collider2D other) {        
        
        if(other.gameObject.CompareTag("Player")){
            TopLevel.AnnouncePlayerDeath(other.gameObject);
        }
        
    }
}
