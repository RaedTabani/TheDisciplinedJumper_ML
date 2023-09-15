using System;
using System.Collections;
using System.Collections.Generic;
using Config;
using UnityEngine;
using Movement;

[RequireComponent(typeof(Mover))]
public class Target : MonoBehaviour
{
    private IConfig config;
    private Mover mover;
    private Action<Target> release;
    private void Init(GameConfig config){
        this.config = config;
    }
    public void Init(Action<Target> action){
        release = action;
    }
    public void Reset(){
        
    }
    private void Update(){
        mover.Move(-Vector3.forward ,config.TargetSpeed);
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
