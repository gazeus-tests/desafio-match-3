using UnityEngine;

namespace Script.Score
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private ScoreView view;
        [SerializeField] private ScoreConfigRepository scoreConfigRepository;

        private int score;

        private int GetScore(int strike)
        {
            foreach (var scoreConfig in scoreConfigRepository.ScoreConfigs)
            {
                //todo cache the values using a hash
                if (scoreConfig.strike == strike)
                {
                    return scoreConfig.score;
                }
            }

            return 0;
        }
            
        public void HandleScore(int strike)
        {
            score += GetScore(strike);
            Debug.Log($"strike: {strike}");

            view.UpdateView(score);
        }
    }
}
