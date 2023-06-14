using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colorswitching : MonoBehaviour
{
    public Image imagecolor;
    public Color color1,color2;
    public bool ischanged = false;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void colorchange()
    {
        if (ischanged == false)
        {
            imagecolor.color = color1;
            ischanged= true;
        }
        else if(ischanged== true)
        {
            imagecolor.color = color2;
            ischanged= false;
        }
        
    }
}
