using System.Collections;
using System.Collections.Generic;
using Config;
using Movement;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Integrations.Match3;
using Unity.MLAgents.Sensors;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Zenject;

namespace AI{
    [RequireComponent(typeof(Mover))]
    public class Jumper : Agent
    {
        private IConfig config;
        private Mover mover;

        [Inject]
        private void Init(IConfig config){
            this.config = config;
            Debug.Log("SETTING UP AGENT");
        }
        public override void Initialize()
        {
            mover = GetComponent<Mover>();
        }

        public override void OnEpisodeBegin()
        {
            base.OnEpisodeBegin();
        }

        public override void CollectObservations(VectorSensor sensor)
        {
            base.CollectObservations(sensor);
        }
        public override void OnActionReceived(ActionBuffers actions)
        {
            base.OnActionReceived(actions);
        }
        public override void Heuristic(in ActionBuffers actionsOut)
        {
            int jump = (int)Input.GetAxis("Fire1");
            Debug.Log(jump);
            if(jump == 1)
                mover.Jump(Vector3.up,config.AgentSpeed);
        }

    }
}