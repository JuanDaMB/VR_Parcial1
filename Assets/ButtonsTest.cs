using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsTest : MonoBehaviour
{
    public Material material1,material2;
    public void ChangeColor1()
    {
        material1.color = Random.ColorHSV();
    }

    public void ChangeColor2()
    {
        material2.color = Random.ColorHSV();
    }
}
