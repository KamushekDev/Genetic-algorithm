using System;
using Interfaces;
using Types;
using UnityEngine;

public class Bot : MonoBehaviour, IBot
{
    public LayerMask wallsLayer;
    public Grid grid;


    private void Awake()
    {
        Health = 20;
    }

    private void OnDestroy()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPositionAlignedToCellCenter(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Move(Vector2 direction)
    {
        var newPos = transform.position + (Vector3) direction;
        SetPositionAlignedToCellCenter(newPos);
    }

    void SetPositionAlignedToCellCenter(Vector3 position)
    {
        var cell = grid.WorldToCell(position);
        var center = grid.GetCellCenterWorld(cell);
        transform.position = center;
    }

    void Die()
    {
    }

    #region IBot

    private int _health;

    private const int MaxHealth = 90;

    public int Health
    {
        get => _health;
        private set
        {
            if (value <= 0)
                Die();
            _health = Math.Min(value, MaxHealth);
        }
    }

    private readonly Collider2D[] _colliders = new Collider2D[5];

    public CellResult Move(Direction moveDirection)
    {
        Vector3 directionVector = moveDirection.GetVector(transform.lossyScale);

        var cell = grid.WorldToCell(transform.position + directionVector);
        var center = grid.GetCellCenterWorld(cell);
        var result = CellResult.Empty;
        var colliders = Physics2D.OverlapCircleNonAlloc(center, .3f, _colliders);
        if (colliders > 0)
        {
            var firstCollider = _colliders[0];

            switch (firstCollider)
            {
                case var c when c.CompareTag("Collectable"):
                    var collectable = c.GetComponent<CollectableScript>();
                    switch (collectable.type)
                    {
                        case CollectableType.Food:
                            result = CellResult.Food;
                            break;
                        case CollectableType.Poison:
                            result = CellResult.Poison;
                            break;
                        case CollectableType.Corpse:
                            result = CellResult.Corpse;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    Health += collectable.healthChange;
                    collectable.Collect();
                    break;
                case var c when c.CompareTag("Walls"):
                    return CellResult.Wall;
                case var c when c.CompareTag("Bot") || c.CompareTag("Player"):
                    return CellResult.Bot;
            }
        }

        Move(directionVector);
        return result;
    }

    public CellResult Interact(Direction interactDirection)
    {
        throw new System.NotImplementedException();
    }

    public CellResult Look(Direction lookDirection)
    {
        throw new System.NotImplementedException();
    }

    #endregion
}