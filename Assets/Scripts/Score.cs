using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private GameObject GameManager;

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            GameManager.GetComponent<TopLevel>().addPlayerSocore();
        }
    }

    public void setGameManager(GameObject GameManager){
        this.GameManager = GameManager;
    }
}
