using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text, gameOverText;
    [SerializeField] GameObject potion, key;
    private GameObject Poti, player;
    private float elapsedTime = 0;
    private float keyElapsedTime = 0;
    private int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        Poti = GameObject.Find("bottle_009");
        text.SetText("HP:10/{0}", hp);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= 2){
            hp -= 1;
            text.SetText("HP:10/{0}", hp);
            elapsedTime = 0;
        }

        if(hp <= 0){
            text.SetText("");
            gameOverText.SetText("Game Over!");
            //player.GetComponent<PlayerController>().enabled=false;
            Time.timeScale = 0;
        }
        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("AAA");
            key.gameObject.SetActive(true);
            keyElapsedTime = 0;
        }
        keyElapsedTime += Time.deltaTime;
        if(keyElapsedTime > 3)
        {
            key.gameObject.SetActive(false);
        }
    }
    public void generateNewPotion(){
        Instantiate(potion,new Vector3(Random.Range(-2f,12f),0,Random.Range(1f,9f)),Quaternion.identity);
    }
    public void IncreaseHp()
    {
        hp += 5;
        text.SetText("HP:10/{0}", hp);
        generateNewPotion();
    }    
    
}
