using UnityEngine;
using UnityEngine.UI;
public class ScoreManagerIB : MonoBehaviour
{
    
    [SerializeField]
    private Text scoreText;

    public int score;

    //public int Score
    //{
        //get { return score; }
        //set
        //{
            //score = value;
            //scoreText.text = "Score: " + score.ToString();
        //}
    //}

    private void Awake()
    {
        score = 0;
    }
}
