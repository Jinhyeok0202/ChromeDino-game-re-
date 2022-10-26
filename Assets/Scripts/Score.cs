using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private float Speed = 3f;
    [SerializeField]
    private TextMeshProUGUI ScoreText;

    private float score = 0;

    void Update()
    {
        score += Speed * Time.deltaTime;
        ScoreText.text = ((int)score).ToString();
    }
}
