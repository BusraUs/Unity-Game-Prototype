
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class giris : MonoBehaviour
{
    public GUISkin giris1Skin;
    public GUISkin giris2Skin;
    public GUISkin baslik1Skin;
    public GUISkin baslik2Skin;
    public GUISkin baslik3Skin;
    public GUISkin buttonSkin;
    public GUISkin Logo;
    public Texture2D ZombiLogo;


    private void OnGUI()
    {
        GUI.Window(0, new Rect(0, 0, 1280, 400), UstPencere, "");
        GUI.Window(1, new Rect(0, 400, 1280, 200), OrtaPencere, "");
        GUI.Window(2, new Rect(0, 600, 1280, 120), AltPencere, "");
         
    }

    void UstPencere(int WindowID)
    {
        GUI.skin = Logo;
        GUI.Label(new Rect(0, 0, 1280, 120), ZombiLogo);
        GUI.skin = baslik1Skin;
        GUI.Label(new Rect(0, 120, 1280, 100), "ZOMBI OYUNU");
        GUI.skin = baslik2Skin;
        GUI.Label(new Rect(0, 220, 1280, 60), "HOS GELDINIZ!");
        GUI.skin = baslik3Skin;
        GUI.Label(new Rect(0, 280, 1280, 120), "Amac 3. bolum sonundaki eve sag salim yetisebilmektir. Bunu ancak gizli gecitler araciligiyla yapabilirsin.");
    }

    void OrtaPencere(int WindowID)
    {
        GUI.skin = giris1Skin;
        GUI.Label(new Rect(0, 0, 1280, 100), "150504009");
        GUI.skin = giris2Skin;
        GUI.Label(new Rect(0, 100, 1280, 100), "Busra USLU");
    }

    void AltPencere(int WindowID)
    {
        GUI.skin = buttonSkin;
        if(GUI.Button(new Rect(450, 10, 400, 100), "Oyuna Basla"))
        {
            SceneManager.LoadScene("level1");
        }
    }
}
