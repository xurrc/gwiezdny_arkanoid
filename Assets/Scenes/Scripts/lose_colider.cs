using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose_colider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Application.LoadLevel("Game_over");
    }

  
}
