using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }
    public TetrominoData[] tetriminoes;

    private void Awake()
    {
        this.tilemap = GetComponentInChildren<Tilemap>();

        for (int i = 0; i < this.tetriminoes.Length; i++)
        {
            this.tetriminoes[i].Initialize();
        }
    }

    private void Start()
    {
        SpawnPiece();
    }

    public void SpawnPiece()
    {
        int random = Random.Range(0, this.tetriminoes.Length);
        TetrominoData data = this.tetriminoes[random];
    }

    public void Set()
    {

    }
}
