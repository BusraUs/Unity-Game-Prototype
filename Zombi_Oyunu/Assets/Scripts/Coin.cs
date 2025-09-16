using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int ToplamCoin;


    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Coin")
            {
                ToplamCoin += 10;
                Destroy(collision.gameObject);
            }
    }
}
