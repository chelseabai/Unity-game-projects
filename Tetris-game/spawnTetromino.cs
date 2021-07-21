using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTetromino : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Tetrominoes;
    void Start()
    {
        NewTetromino();
    }


    public void NewTetromino()
    {
    	Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}
