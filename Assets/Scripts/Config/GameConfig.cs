using UnityEngine;

namespace Config{
    public class GameConfig : IConfig
    {
        public float AgentSpeed => agentSpeed;
        public float TargetSpeed => targetSpeed;

        public float SpawnMinDelay => spawnMinDelay;

        public float SpawnMaxDelay =>spawnMaxDelay;

        [SerializeField] private float agentSpeed = 8;
        [SerializeField] private float targetSpeed = 2;
        [SerializeField] private float spawnMinDelay = 2;
        [SerializeField] private float spawnMaxDelay = 5;

    }
}