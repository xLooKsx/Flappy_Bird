using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{

    private int score;
    private bool PlayerAlive;


    public int Getscore(){
        return this.score;
    }

      public void Addscore(){
        this.score++;
    }    

    public bool IsPlayerAlive(){
        return this.PlayerAlive;
    }

    public void SetPlayerAlive(bool isPlayerAlive){
        this.PlayerAlive = isPlayerAlive;
    }
}
