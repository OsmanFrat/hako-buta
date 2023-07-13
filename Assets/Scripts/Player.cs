using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float movementHorizontal;


    void FixedUpdate()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
            
        transform.position += Vector3.right * movementHorizontal * moveSpeed * Time.fixedDeltaTime;
    }


    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(0);
        }
    }



}
