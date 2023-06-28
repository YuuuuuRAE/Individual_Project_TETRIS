using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    public static readonly float cos = Mathf.Cos(Mathf.PI / 2f);
    public static readonly float sin = Mathf.Sin(Mathf.PI / 2f);
    public static readonly float[] RotationMatrix = new float[] {cos, sin, -sin, cos};

    /*
    <Tetriminoes>
    I,
    O,
    T,
    L,
    J,
    S,
    Z
     */
    public static readonly Dictionary<Tetrimino, Vector2Int[]> Cells = new Dictionary<Tetrimino, Vector2Int[]>()
    {   
        {Tetrimino.I, new Vector2Int[] {new Vector2Int(-1,1), new Vector2Int(0,1), new Vector2Int(1,1), new Vector2Int(2,1)}}, 
        {Tetrimino.O, new Vector2Int[] {new Vector2Int(0,0), new Vector2Int(1,0), new Vector2Int(1,1), new Vector2Int(0,1)}},
        {Tetrimino.O, new Vector2Int[] {new Vector2Int(0,0), new Vector2Int(1,0), new Vector2Int(1,1), new Vector2Int(0,1)}},
        {Tetrimino.O, new Vector2Int[] {new Vector2Int(0,0), new Vector2Int(1,0), new Vector2Int(1,1), new Vector2Int(0,1)}},
        {Tetrimino.O, new Vector2Int[] {new Vector2Int(0,0), new Vector2Int(1,0), new Vector2Int(1,1), new Vector2Int(0,1)}},
        {Tetrimino.O, new Vector2Int[] {new Vector2Int(0,0), new Vector2Int(1,0), new Vector2Int(1,1), new Vector2Int(0,1)}},
        {Tetrimino.O, new Vector2Int[] {new Vector2Int(0,0), new Vector2Int(1,0), new Vector2Int(1,1), new Vector2Int(0,1)}},
    };
}
