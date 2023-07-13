using UnityEngine;

public class Obstacle : MonoBehaviour
{

    void Update()
    {
        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
