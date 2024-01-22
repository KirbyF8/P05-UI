using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    [SerializeField] float AutodestructionTime = 3f;
    public bool isGameOver = false;

    private GameManager_sc gameManager;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager_sc>();
        Autodestruction();
    }

    

    public void Autodestruction()
    {
        Destroy(gameObject, AutodestructionTime);
       
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);

    }

    private void OnDestroy()
    {
        gameManager.targetsPositionsInScene.Remove(transform.position);
    }
}
