using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseScorePipe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            score.instance.updateCurrentScore();
        }
    }
}
