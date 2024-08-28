using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject GameOverPannel;
    public Text score;
    void Start()
    {
        score.text = "0";
    }

    public void ShowGameOverPanel(){

        this.GameOverPannel.SetActive(true);
    }

    public void UpdateScoreText(String newScore){
        score.text = newScore;
    }
}
