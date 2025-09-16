using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class kazanma : MonoBehaviour
{
    public GUISkin ustSkin1;
    public GUISkin ustSkin2;
    public GUISkin ortaSkin;
    public GUISkin altSkin;
    public GUISkin Logo;
    public Texture2D ZombiLogo;


    private void OnGUI()
    {
        GUI.Window(0, new Rect(0, 0, 1280, 350), UstPencere, "");
        GUI.Window(1, new Rect(0, 350, 1280, 300), OrtaPencere, "");
        GUI.Window(2, new Rect(0, 650, 1280, 70), AltPencere, "");
    }


    void UstPencere(int WindowID)
    {
        GUI.skin = Logo;
        GUI.Label(new Rect(0, 0, 1280, 150), ZombiLogo);
        GUI.skin = ustSkin1;
        GUI.Label(new Rect(0, 150, 1280, 90), "Skor: " + Coin.ToplamCoin);
        GUI.skin = ustSkin2;
        GUI.Label(new Rect(0, 240, 1280, 110), "KAZANDINIZ :)");
    }


    void OrtaPencere(int WindowID)
    {
        GUI.skin = ortaSkin;
        GUILayout.Space(100);
        if(GUILayout.Button("Tekrar Oyna"))
        {
            SceneManager.LoadScene("level1");
            Coin.ToplamCoin = 0;
        }
    }


    void AltPencere(int WindowID)
    {
        GUI.skin = altSkin;
        if(GUI.Button(new Rect(0, 0, 640, 70), "Ana Menü"))
        {
            SceneManager.LoadScene("giris");
        }
        if(GUI.Button(new Rect(640, 0, 640, 70), "Cikis"))
        {
            Application.Quit();
        }
    }

}
