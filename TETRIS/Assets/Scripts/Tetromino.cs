/*
https://en.wikipedia.org/wiki/Tetromino
Enum is based on link

I : Staright tetromino [][][][]

O : Square tetromino [][]
                     [][]

T : T tetromino [][][]
                  []


L : L tetromino   []
                  []
                  [][]

J :  reversal L tetromino   []
                            []
                            [][]


S : skew tetromino    [][]
                    [][]

Z : reversal skew tetromino [][]
                              [][]

*/
using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
    I,
    O,
    T,
    L,
    J,
    S,
    Z
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set;}

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
    }
}