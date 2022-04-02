using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour
{
    public int rows;
    public int cols;
    public GameObject tilePrefab;
    private Tiles[,] allTiles;
    public GameObject[] dots;
    public Transform Pdots;
    public Transform Ptiles;

    // Start is called before the first frame update
    void Start()
    {
        allTiles = new Tiles[cols, rows];
        SetUp();
    }


    private void SetUp()
    {
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                GameObject backgroundTile = (GameObject)Instantiate(tilePrefab, new Vector3(i, j, 0), Quaternion.identity);
                backgroundTile.transform.SetParent(Ptiles);
                backgroundTile.name = "Tile (" + i + "," + j + ")";

                int dot2use = Random.Range(0, dots.Length);
                GameObject dot = (GameObject)Instantiate(dots[dot2use], new Vector3(i, j, 0), Quaternion.identity);
                dot.transform.SetParent(Pdots);
                dot.name = "Dot (" + i + "," + j + ")";
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
