using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level3 : MonoBehaviour
{
    public GUISkin level3Skin;

    private void OnGUI()
    {
        GUI.skin = level3Skin;
        GUI.Window(0, new Rect(0, 0, 1280, 100), UserLogged, "");
    }

    void UserLogged(int WindowID)
    {
        GUI.Label(new Rect(600, 30, 300, 100), "Skor: " + Coin.ToplamCoin);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("kazanma");
        }
    }
}
