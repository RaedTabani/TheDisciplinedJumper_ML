using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Action<Target> release;
    public void Init(Action<Target> action){
        release = action;
    }
    public void Reset(){
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Goal")){

            release.Invoke(this);
        }   
        else if(other.CompareTag("Player")){

            release.Invoke(this);
        }
    }
}
