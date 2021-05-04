using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverImage;
    public GameObject playAgainText;
    public GameObject exitText;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (RandomMovement.displayMenuGameOver == 1)
        {
            gameOverImage.SetActive(true);
            playAgainText.SetActive(true);
            //exitText.SetActive(true);

            Time.timeScale = 0f;
            
            
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Timer.currentTime = 0;
        Time.timeScale = 1f;
        RandomMovement.displayMenuGameOver = 0;

    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
