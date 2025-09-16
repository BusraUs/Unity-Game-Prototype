using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ajScript : MonoBehaviour
{
    public Animator anim;
    public float hiz;   
    public Transform Model;

    Vector3 StickDirection;
    Camera mainCam;
    float inputX = 0;
    float inputY = 0;
    public float dump;

    [Range(1, 20)]
    public float rotspeed;

    public KeyCode kosma = KeyCode.LeftShift;
    public KeyCode ziplama = KeyCode.Space;

    void Start()
    {
        anim = GetComponent<Animator>();
        mainCam = Camera.main;
    }

    private void LateUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        StickDirection = new Vector3(inputX, 0, inputY);
        InputMove();
        InputRotation();
    }
   

    void InputMove()
    {
        anim.SetFloat("speed",Vector3.ClampMagnitude(StickDirection,1).magnitude,dump, Time.deltaTime*10);
    }


    void InputRotation()
    {
        Vector3 rotOfset = mainCam.transform.TransformDirection(StickDirection);
        rotOfset.y = 0;
        Model.forward = Vector3.Slerp(Model.forward,rotOfset, Time.deltaTime*rotspeed);
    }


    private void OnCollisionEnter(Collision collision)
    {
        int sahneNo = SceneManager.GetActiveScene().buildIndex;

        if (collision.gameObject.tag == "Portal")
        {
            SceneManager.LoadScene("sahneNo + 1");
        }
    }

}
