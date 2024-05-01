using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LionColl : MonoBehaviour
{

    [SerializeField] GameObject lion;
    [SerializeField] TextMeshProUGUI lionText;
    // Start is called before the first frame update
    void Start()
    {
        lionText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            lionText.gameObject.SetActive(true);
    
        }
    }
    public void OnTriggerExit(Collider collider){
        if(collider.CompareTag("Player")){
            lionText.gameObject.SetActive(false);
    
        }
    }
}
