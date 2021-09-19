using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision
    public GameObject paddle;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            paddle.transform.Translate(-10 * Time.deltaTime, 0, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            paddle.transform.Translate(10 * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
