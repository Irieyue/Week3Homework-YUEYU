using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    [SerializeField]
    private GameObject gameManager = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle

    // hit the wall game will restart
        gameManager.GetComponent<GameManager>().gameRestart();

    }
}
