using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonenable : MonoBehaviour
{
    public GameObject panel;
    public void enable ()
    {
        panel.SetActive(true); 
    }
}
