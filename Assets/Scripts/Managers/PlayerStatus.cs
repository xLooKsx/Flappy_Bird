using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    private int PlayerScore;
    private bool PlayerAlive;


    public int GetPlayerScore(){
        return this.PlayerScore;
    }

      public void AddPlayerScore(){
        this.PlayerScore++;
    }    

    public bool IsPlayerAlive(){
        return this.PlayerAlive;
    }

    public void SetPlayerAlive(bool isPlayerAlive){
        this.PlayerAlive = isPlayerAlive;
    }
}
