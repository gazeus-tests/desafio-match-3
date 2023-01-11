using TMPro;
using UnityEngine;

namespace Script.Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        private void Awake()
        {
            scoreText.text = string.Empty;
        }

        public void UpdateView(int score)
        {
            //todo add 'increasing animation'
            scoreText.text = score.ToString();
        }
    }
}
