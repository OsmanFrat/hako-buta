using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;
    public bool gameStarted = false;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;
    public int score;

    void FixedUpdate()
    {
       if(Input.GetMouseButton(0) && !gameStarted)
       {
            InvokeRepeating("SpawnObstacle", 0.5f, spawnRate);
            
            gameStarted = true;
            tapText.SetActive(false);
       }
    }

    public void SpawnObstacle()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);
        Instantiate(obstacle, spawnPos, Quaternion.identity);

        score++;
        scoreText.text = score.ToString();
    }
}
