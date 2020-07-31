using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createfield : MonoBehaviour
{
    public int rows = 5;
    public int cols = 8;
    public float tileSize = 1;
    public GameObject referencetile;
    public GameObject spawntile;
    public GameObject healthtile;

    public GameObject topborder;
    public GameObject rightsideborder;
    public GameObject bottomborder;

    public GameObject enemyspawner;
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
        Instantiate(enemyspawner, transform.position, Quaternion.identity);
    }

    private void GenerateGrid()
    {

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {

                if(row==0 && col >=1 && col<cols-1)
                {
                    GameObject tile = Instantiate(topborder, transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    tile.transform.position = new Vector2(posX, posY+.75f);
                }
                if (col == cols - 2)
                {
                    GameObject tile = Instantiate(spawntile, transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;

                    tile.transform.position = new Vector2(posX, posY);
                }

                if (col == cols - 1)
                {
                    GameObject tile = Instantiate(rightsideborder, transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;

                    tile.transform.position = new Vector2(posX-.50f, posY);
                }
                /*
                if (row == rows - 1 )
                {
                    GameObject tile = Instantiate(bottomborder, transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;

                    tile.transform.position = new Vector2(posX - .50f, posY);
                }
                */

                else if (col == 0)
                {
                    GameObject tile = Instantiate(healthtile, transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;

                    tile.transform.position = new Vector2(posX, posY);
                }
                else
                {
                    GameObject tile = Instantiate(referencetile, transform);


                    float posX = col * tileSize;
                    float posY = row * -tileSize;

                    tile.transform.position = new Vector2(posX, posY);
                }

            }
        }

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;

        transform.position = new Vector2(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
