using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followroute : MonoBehaviour
{
    Node[] PathNode;
    GameObject [] player;
    public float MoveSpeed;

    Vector2 startposition;
    float timer;
    static Vector3 CurrentPositionHolder;

    int CurrentNode;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject p in player)
        {
            Debug.Log(p.gameObject.name);
        }

            PathNode = GetComponentsInChildren<Node>();
        CheckNode();


    }

    void CheckNode()
    {

        if(CurrentNode < PathNode.Length-1)
        timer = 0;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }
    void DrawLine()
    {
        for(int i=0;i<PathNode.Length;i++)
        {
            if (i < PathNode.Length - 1)
                Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.blue);
        }
    }

    // Update is called once per frame
    void Update()
    {
        DrawLine();
        timer += Time.deltaTime * MoveSpeed;

        foreach (GameObject p in player)
        {


            if (p.transform.position != CurrentPositionHolder)
            {
                p.transform.position = Vector3.Lerp(startposition, CurrentPositionHolder, timer);
            }
            else if (CurrentNode < PathNode.Length - 1)
            {
                CurrentNode++;
                CheckNode();
                startposition = p.transform.position;
            }
        }
    }
}
