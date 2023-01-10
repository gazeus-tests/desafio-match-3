using TMPro;
using UnityEngine;

namespace Script.Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        public void UpdateView(int score)
        {
            //todo add 'increasing animation'
            scoreText.text = score.ToString();
        }
    }
}
