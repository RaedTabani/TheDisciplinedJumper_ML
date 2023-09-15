using UnityEngine;

namespace Config{
    public class GameConfig : IConfig
    {
        public float AgentSpeed => agentSpeed;

        public float SpawnMinDelay => spawnMinDelay;

        public float SpawnMaxDelay =>spawnMaxDelay;

        [SerializeField] private float agentSpeed;
        [SerializeField] private float spawnMinDelay;
        [SerializeField] private float spawnMaxDelay;

    }
}