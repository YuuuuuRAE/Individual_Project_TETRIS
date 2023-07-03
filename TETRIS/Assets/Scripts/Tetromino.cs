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
    I, J, L, O, S, T, Z
}

[System.Serializable]
public struct TetrominoData
{
    public Tile tile;
    public Tetromino tetromino;

    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        cells = Data.Cells[tetromino];
        wallKicks = Data.WallKicks[tetromino];
    }

}