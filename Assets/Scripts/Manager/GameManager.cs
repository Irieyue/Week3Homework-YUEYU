using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;

    [SerializeField]
    private GameObject ball = null;

    private Vector3 ballTransform;

    [SerializeField]
    private GameObject paddle = null;

    private Vector3 paddleTransform;
    private List<GameObject> list;
    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with
    public void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
        paddleTransform = paddle.transform.position;
        ballTransform = ball.transform.position;
        list = new List<GameObject>();
    }

    private void OnEnable()
    {
        RefreshBlock();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            gameRestart();
        }
    }
    private void RefreshBlock()
    {
        for (int i = 0; i < TOTAL_ROWS; i++)
        {
            for (int k = 0; k < PIECE_COUNT_PER_ROW; k++)
            {
                GameObject newPiece = Instantiate(instance.piecePrefab);
                list.Add(newPiece);
                Vector3 temp;
                temp = pieces.position;
                temp.x = temp.x + 0.96f * k;
                temp.y = temp.y - 0.48f * i;
                newPiece.transform.position = temp;
            }
        }
    }

    public void gameRestart()
    {
        foreach (GameObject obj in list) {
            Destroy(obj);
        }
        OnEnable();
        ball.transform.position = ballTransform;
        paddle.transform.position = paddleTransform;
        ball.GetComponent<Ball>().gameStart = false;
        ball.GetComponent<Ball>().speed = 0;
    }

}
