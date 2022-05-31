using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Laser : MonoBehaviour
{
    private bool isWalking = false;
    [SerializeField]
    private GameObject mummy;
    [SerializeField]
    private PlayableDirector playableDirector;

    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.transform.CompareTag("mummy"))
            {
                if (!isWalking)
                {
                    playableDirector.Play();
                    isWalking = true;
                }
                else
                {
                    playableDirector.Stop();
                    isWalking = false;
                }
            }
        }
    }
}
