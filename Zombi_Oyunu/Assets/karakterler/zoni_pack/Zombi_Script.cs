using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombi_Script : MonoBehaviour
{
    Animator ZombiAnim;
    
    public Transform Hedef;
    NavMeshAgent Ajan;
    public float Mesafe;
    public float MinMenzil = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        ZombiAnim = GetComponent<Animator>();
        Ajan = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        ZombiAnim.SetFloat("speed", Ajan.velocity.magnitude);
        Mesafe = Vector3.Distance(transform.position, Hedef.position);
        Ajan.destination = Hedef.position;
        if (Mesafe <= MinMenzil)
            Ajan.enabled = true;
        else
            Ajan.enabled = false;
    }
}
