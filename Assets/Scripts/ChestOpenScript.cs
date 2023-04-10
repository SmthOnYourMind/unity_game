using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpenScript : MonoBehaviour
{
    public static bool isPlayerNear;
    
    public static GameObject Panel;
    
    public static void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
