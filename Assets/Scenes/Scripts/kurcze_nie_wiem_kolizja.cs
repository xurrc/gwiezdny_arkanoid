using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurcze_nie_wiem_kolizja : MonoBehaviour
{
    public ParticleSystem boom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision);
    {
            boom.Play();
    }
}
}
