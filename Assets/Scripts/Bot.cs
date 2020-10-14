using Interfaces;
using Types;
using UnityEngine;

public class Bot : MonoBehaviour, IBot
{
    public LayerMask wallsLayer;
    public Grid grid;

    private void Awake()
    {
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

    #region IBot

    public int Health { get; private set; }

    public CellResult Move(Direction moveDirection)
    {
        Vector3 directionVector = moveDirection.GetVector();

        var cell = grid.WorldToCell(transform.position + directionVector);
        var center = grid.GetCellCenterWorld(cell);
        var result = CellResult.Empty;
        if (Physics2D.OverlapCircle(center, .3f, wallsLayer.value))
            return CellResult.Wall;

        //todo: rest results
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