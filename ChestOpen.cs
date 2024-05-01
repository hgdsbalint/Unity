using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    [SerializeField] GameObject[] chest;
    [SerializeField] TextMeshProUGUI winText;
    private GameObject key;
    public bool getKey = false;

     // Start is called before the first frame update
    void Start()
    {
        //gameManager = GetComponent<>();
        chest[1].gameObject.SetActive(false);
        key = GameObject.Find("key_gold");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player") && getKey){
            Destroy(chest[0]);
            chest[1].gameObject.SetActive(true);
            winText.SetText("You win!");
            Time.timeScale = 0;
            //player.GetComponent<PlayerController>().enabled = false;
        }
    }
}
