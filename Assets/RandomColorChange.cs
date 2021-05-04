using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorChange : MonoBehaviour
{
    Color[] colors = new Color[10];

    void Start()
    {
        colors[0] = new Color(237, 101, 85); //grapefruit
        colors[1] = new Color(252, 110, 81); //bittersweet
        colors[2] = new Color(255, 206, 84); //sunflower
        colors[3] = new Color(160, 212, 104); //grass
        colors[4] = new Color(72, 207, 173); //mint
        colors[5] = new Color(79, 193, 233); //aqua
        colors[6] = new Color(93, 156, 236); //blue jeans
        colors[7] = new Color(172, 146, 236); //lavender
        colors[8] = new Color(236, 135, 192); //pink rose
        colors[9] = new Color(204, 209, 217); //medium gray
        
    }

    
    void Update()
    {

        gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
}
