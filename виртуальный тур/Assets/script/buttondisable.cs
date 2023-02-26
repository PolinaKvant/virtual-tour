using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttondisable : MonoBehaviour
{
    public GameObject panel;
    public void disable ()
    {
        panel.SetActive(false); 
    }
}
