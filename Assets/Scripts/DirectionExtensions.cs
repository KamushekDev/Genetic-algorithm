using System;
using Types;
using UnityEngine;

public static class DirectionExtensions
{
    public static Vector2 GetVector(this Direction direction)
    {
        switch (direction)
        {
            case Direction.North:
                return new Vector2(0, 1);
            case Direction.NorthWest:
                return new Vector2(-1, 1);
            case Direction.West:
                return new Vector2(-1, 0);
            case Direction.SouthWest:
                return new Vector2(-1, -1);
            case Direction.South:
                return new Vector2(0, -1);
            case Direction.SouthEast:
                return new Vector2(1, -1);
            case Direction.East:
                return new Vector2(1, 0);
            case Direction.NorthEast:
                return new Vector2(1, 1);
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }
    }
}