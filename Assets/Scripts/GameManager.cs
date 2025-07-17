using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;

    public TextMeshProUGUI scoretext;
    public GameObject Play;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpwanObstacles()
    {
        while (true)
        {
            float waitTime = Random.Range(0.5f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    void ScoreUp()
    {
        score++;
        scoretext.text = score.ToString();
    }

    public void GameStart()
    {
        Player.SetActive(true);
        Play.SetActive(false);
        
        StartCoroutine("SpwanObstacles");
        InvokeRepeating("ScoreUp", 2f, 1f);
    }
}
