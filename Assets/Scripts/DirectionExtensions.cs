using System;
using Types;
using UnityEngine;

public static class DirectionExtensions
{
    public static Vector2 GetVector(this Direction direction, Vector2 scale)
    {
        Vector2 result;

        switch (direction)
        {
            case Direction.North:
                result = new Vector2(0, 1);
                break;
            case Direction.NorthWest:
                result = new Vector2(-1, 1);
                break;
            case Direction.West:
                result = new Vector2(-1, 0);
                break;
            case Direction.SouthWest:
                result = new Vector2(-1, -1);
                break;
            case Direction.South:
                result = new Vector2(0, -1);
                break;
            case Direction.SouthEast:
                result = new Vector2(1, -1);
                break;
            case Direction.East:
                result = new Vector2(1, 0);
                break;
            case Direction.NorthEast:
                result = new Vector2(1, 1);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
        }

        return Vector2.Scale(result, scale);
    }
}