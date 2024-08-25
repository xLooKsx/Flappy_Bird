using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject GameOverPannel;
    void Start()
    {
    }

    public void ShowGameOverPanel(){

        this.GameOverPannel.SetActive(true);
    }
}
