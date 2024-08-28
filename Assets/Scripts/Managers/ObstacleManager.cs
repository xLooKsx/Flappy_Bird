using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject ObstaclePrefab;
    public GameObject GameManager;
    public float cooldown;

    private int ScoreCheckCooldown;
    private bool IsTimeToGenerateObstacle;
    private float CurrentTimeForNextGeneration;
    private PlayerStatus PlayerStatus;
    private void Start() {
        
        ScoreCheckCooldown = 10;
        IsTimeToGenerateObstacle = true;
        CurrentTimeForNextGeneration = 0f;    
        PlayerStatus = this.GameManager.GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        if(IsTimeToGenerateObstacle){
            CreateObstacle();            
        }
        CheckCooldownTime();
        UpdateCoolDownTime();        
    }

    private void UpdateCoolDownTime()
    {
        if(PlayerStatus.Getscore() == ScoreCheckCooldown){
            cooldown -= cooldown / 10 ;
            ScoreCheckCooldown += 10;
        }
        
    }

    private void CheckCooldownTime(){

        if(CurrentTimeForNextGeneration >= cooldown && !IsTimeToGenerateObstacle){
            
             IsTimeToGenerateObstacle = true;
        }else{
           CurrentTimeForNextGeneration += Time.deltaTime;            
        }

    }

    private void CreateObstacle(){

        GameObject instantiatedObstacle = Instantiate(ObstaclePrefab, this.transform.position, Quaternion.identity);
        instantiatedObstacle.transform.GetChild(0).GetComponent<Borders>().SetGameManager(this.GameManager);
        instantiatedObstacle.transform.GetChild(1).GetComponent<Borders>().SetGameManager(this.GameManager);
        instantiatedObstacle.GetComponentInChildren<Score>().setGameManager(this.GameManager);
        instantiatedObstacle.transform.position = Vector2.up * Random.Range(2, -4);
        

        Destroy(instantiatedObstacle, 12f);
        IsTimeToGenerateObstacle = false;
        CurrentTimeForNextGeneration = 0;
    }
}
