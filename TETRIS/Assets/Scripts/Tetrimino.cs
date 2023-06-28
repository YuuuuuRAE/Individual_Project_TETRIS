/*
https://en.wikipedia.org/wiki/Tetromino
Enum is based on link

I : Staright tetrimino [][][][]

O : Square tetrimino [][]
                     [][]

T : T tetrimino [][][]
                  []


L : L tetrimino   []
                  []
                  [][]

J :  reversal L tetrimino   []
                            []
                            [][]


S : skew tetrimino    [][]
                    [][]

Z : reversal skew tetrimono [][]
                              [][]

*/
using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetrimino
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
public struct TetriminoData
{
    public Tetrimino tetrimino;
    public Tile tile;
    public Vector2Int[] cells;
}