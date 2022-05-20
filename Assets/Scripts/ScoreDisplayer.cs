using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    private TextMeshPro tmPro;
    private void Start()
    {
        tmPro = GetComponent<TextMeshPro>();
    }
    public void SetScore(int score)
    {
        
    }
}
