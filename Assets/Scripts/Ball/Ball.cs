using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched

    // make sure game is not start  until you hit F
    public bool gameStart = false;
    public int speed = 0;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // press F to start the game 
        if (Input.GetKey(KeyCode.F) && gameStart == false)
        {
            rigidBody.velocity = new Vector3(5f, 5f, 0);
            gameStart = true;
            speed = 8;
        }
        rigidBody.velocity = rigidBody.velocity.normalized * speed;
    }
}
