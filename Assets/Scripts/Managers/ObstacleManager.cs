using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject ObstaclePrefab;
    public GameObject GameManager;
    public float cooldown;

    private bool IsTimeToGenerateObstacle;
    private float CurrentTimeForNextGeneration;
    private void Start() {
        IsTimeToGenerateObstacle = true;
        CurrentTimeForNextGeneration = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsTimeToGenerateObstacle){
            CreateObstacle();            
        }
        CheckCooldownTime();
        
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

        Destroy(instantiatedObstacle, 12f);
        IsTimeToGenerateObstacle = false;
        CurrentTimeForNextGeneration = 0;
    }
}
