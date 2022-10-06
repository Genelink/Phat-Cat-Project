using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    private int CurScore = 0;
    public GameObject Player;
    private string StrCurScore;
    // Start is called before the first frame update
    void Start()
    {
        CurScore = Player.GetComponent<Score>().CurrentScore;
    }

    // Update is called once per frame
    void Update()
    {
        StrCurScore = "Score [" + CurScore.ToString();
        GetComponent<TextMeshProUGUI>().text = StrCurScore;
    }
}
