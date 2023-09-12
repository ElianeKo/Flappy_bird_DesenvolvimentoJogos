using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public GameObject GameOverObj;
    public GameObject StartObj;
    Player player;



    void Start()
    {
        player = FindObjectOfType<Player>();
        player.enabled = false;
        
       Time.timeScale = 0; 
       StartObj.SetActive(true);
    }

   public void StartButton()
    {
      Time.timeScale = 1; 
      player.enabled = true;

      GameOverObj.SetActive(false);
      StartObj.SetActive(false);  
    }
    
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void GameOver()
    {
        GameOverObj.SetActive(true);
        Time.timeScale = 0;
        player.enabled = false;
        
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Scoring()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
