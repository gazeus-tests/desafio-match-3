using UnityEngine;

namespace Script.Score
{
    [CreateAssetMenu(fileName = "ScoreConfigRepository", menuName = "Gameplay/ScoreConfigRepository")]
    public class ScoreConfigRepository : ScriptableObject
    {
        //todo change to a curve
        [SerializeField] private ScoreConfig[] scoreConfigs;

        public ScoreConfig[] ScoreConfigs => scoreConfigs;
    }
}
