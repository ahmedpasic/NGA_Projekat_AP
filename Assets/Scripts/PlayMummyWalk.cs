using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayMummyWalk : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector playableDirector;
    void Start()
    {
        playableDirector.Stop();
    }

    void Update()
    {
        
    }
}
