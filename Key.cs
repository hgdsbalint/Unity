using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject key;
    private GameObject kulcs;
    
    //private float elapsedTime = 0;
     // Start is called before the first frame update
    void Start()
    {
        //key.gameObject.SetActive(false);
        kulcs = GameObject.Find("Chest closed");
    }

    // Update is called once per frame
    void Update()
    {
        //elapsedTime += Time.deltaTime;
      
    }
    public void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            Destroy(gameObject);
            kulcs.GetComponent<ChestOpen>().getKey = true;

        }
    }
}
