using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WorldScript : MonoBehaviour
{
    public int maxFoodAmount;
    public int maxPoisonAmount;
    public Vector2 leftCorner;
    public Vector2 rightCorner;
    public GameObject foodObject;
    public GameObject poisonObject;

    private GameObject _foodListObject;
    private GameObject _poisonListObject;
    private Grid _worldGrid;

    private List<GameObject> _foodList;
    private List<GameObject> _poisonList;

    readonly Collider2D[] _colliders = new Collider2D[10];

    private void Awake()
    {
        _foodList = new List<GameObject>();
        _poisonList = new List<GameObject>();

        var foods = new GameObject("Foods");
        var poisons = new GameObject("Poisons");
        _foodListObject = Instantiate(foods, transform);
        _poisonListObject = Instantiate(poisons, transform);
        Destroy(foods);
        Destroy(poisons);

        _worldGrid = GetComponent<Grid>();

        for (int i = 0; i < maxFoodAmount; i++)
            SpawnFood();
        for (int i = 0; i < maxPoisonAmount; i++)
            SpawnPoison();


        GameEvents.Instance.Tick += OnTick;
    }

    private void OnTick()
    {
        if (_foodList.Count < maxFoodAmount)
            SpawnFood();

        if (_poisonList.Count < maxPoisonAmount)
            SpawnPoison();
    }

    private void SpawnPoison()
    {
        var poison = Instantiate(poisonObject, _poisonListObject.transform);
        poison.transform.position = GetRandomEmptyCellCenter();
        _poisonList.Add(poison);
    }

    private void SpawnFood()
    {
        var food = Instantiate(foodObject, _foodListObject.transform);
        food.transform.position = GetRandomEmptyCellCenter();
        _foodList.Add(food);
    }

    Vector3 GetRandomEmptyCellCenter()
    {
        Vector3 result;
        int colliders;
        var scale = transform.localScale;
        do
        {
            result = Random.insideUnitCircle;

            result.x = Mathf.Lerp(leftCorner.x * scale.x, rightCorner.x * scale.x, Mathf.InverseLerp(-1, 1, result.x));
            result.y = Mathf.Lerp(leftCorner.y * scale.y, rightCorner.y * scale.y, Mathf.InverseLerp(-1, 1, result.y));
            result = _worldGrid.GetCellCenterWorld(_worldGrid.WorldToCell(result));
            colliders = Physics2D.OverlapCircleNonAlloc(result, .3f, _colliders);
        } while (colliders > 0);

        return result;
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}