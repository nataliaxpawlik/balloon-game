using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomMovement : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    private float speed = 1;

    public static int displayMenuGameOver = 0;


    void Start()
    {
        targetPosition = GetRandomPosition();
    }


    void Update()
    {
        

        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }       

        else 
        { 
            targetPosition = GetRandomPosition();
        }

        if (Timer.currentTime >= 5)
        {
            speed = 1.5f;
        }   
        
        if (Timer.currentTime >= 10)
        {
            speed = 2f;
        }

        if (Timer.currentTime >= 15)
        {
            speed = 2.5f;
        }

        if (Timer.currentTime >= 20)
        {
            speed = 3f;
        }

        if (Timer.currentTime >= 25)
        {
            speed = 3.5f;
        }

        if (Timer.currentTime >= 30)
        {
            speed = 4f;
        }

        if (Timer.currentTime >= 35)
        {
            speed = 4.5f;
        }

        if (Timer.currentTime >= 40)
        {
            speed = 5f;
        }

        if (Timer.currentTime >= 45)
        {
            speed = 5.5f;
        }

        if (Timer.currentTime >= 50)
        {
            speed = 6f;
        }

        if (Timer.currentTime >= 55)
        {
            speed = 6.5f;
        }

        if (Timer.currentTime >= 60)
        {
            speed = 7f;
        }

        if (Timer.currentTime >= 65)
        {
            speed = 7.5f;
        }

        if (Timer.currentTime >= 70)
        {
            speed = 8f;
        }

        if (Timer.currentTime >= 75)
        {
            speed = 8.5f;
        }

        if (Timer.currentTime >= 80)
        {
            speed = 9f;
        }

        if (Timer.currentTime >= 85)
        {
            speed = 9.5f;
        }

        if (Timer.currentTime >= 90)
        {
            speed = 10f;
        }

        if (Timer.currentTime >= 95)
        {
            speed = 10.5f;
        }

        if (Timer.currentTime >= 100)
        {
            speed = 11f;
        }

        if (Timer.currentTime >= 105)
        {
            speed = 11.5f;
        }

        if (Timer.currentTime >= 110)
        {
            speed = 12f;
        }

        if (Timer.currentTime >= 115)
        {
            speed = 12.5f;
        }

        if (Timer.currentTime >= 120)
        {
            speed = 13f;
        }
    }


    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Balloon")
        {
            displayMenuGameOver = 1; 

        }
    }
}
