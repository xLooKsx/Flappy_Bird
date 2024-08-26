using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Borders : MonoBehaviour
{

    public GameObject GameManager;

    void OnTriggerEnter2D(Collider2D other) {        
        
        if(other.gameObject.CompareTag("Player")){        
            this.GameManager.GetComponent<TopLevel>().AnnouncePlayerDeath(other.gameObject);
        }
        
    }

    public void SetGameManager(GameObject GameManager){
        this.GameManager = GameManager;
    }
}
