using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PotiSpawn : MonoBehaviour
{
    [SerializeField] GameObject potion;
    private GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            Debug.Log("Felvettem");
            Destroy(gameObject);
            gameManager.GetComponent<GameManager>().IncreaseHp();
            
        }
    }
    
}
