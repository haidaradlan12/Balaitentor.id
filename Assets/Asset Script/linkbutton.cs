using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkbutton : MonoBehaviour
{
    public string URL;

    public void Open()
    {
        Application.OpenURL(URL);
    }
}
