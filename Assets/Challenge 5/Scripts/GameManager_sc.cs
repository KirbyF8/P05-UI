using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager_sc : MonoBehaviour
{

    [SerializeField] private GameObject[] targetPrefabs;

    private float rangeInBetween = 2.5f;
    private float minX = -3.75f;
    private float minY = -3.75f;

    private bool isGameOver = false;

    [SerializeField] private float spawnRate = 2f;

    public int lives;

    private Vector3 randomPos;
    public List<Vector3> targetsPositionsInScene;

    

    void Start()
    {
        targetsPositionsInScene = new List<Vector3>();
        isGameOver = false;
        StartCoroutine(SpawnRandomTarget());
    }

    private Vector3 RandomPosition()
    {
        
        float spawnPosX = minX + (Random.Range(0, 4) * rangeInBetween);
        float spawnPosY = minY + (Random.Range(0, 4) * rangeInBetween);

        
        return new Vector3(spawnPosX, spawnPosY, 0);

    }
    private IEnumerator SpawnRandomTarget()
    {
        while (!isGameOver) 
        { 
            yield return new WaitForSeconds(spawnRate);
        
            int randomPrefab = Random.Range(0, targetPrefabs.Length);
            randomPos = RandomPosition();
            while (targetsPositionsInScene.Contains(randomPos))
            {
                randomPos = RandomPosition();
            }

            Instantiate(targetPrefabs[randomPrefab], randomPos, targetPrefabs[randomPrefab].transform.rotation);
            

            targetsPositionsInScene.Add(randomPos);
        }
    }

   
}
