using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public Action Tick = () => { };

    private static GameEvents _instance;
    private float _lastTickTime;

    [Tooltip("Delay between ticks in seconds")]
    public float tickDelay;

    public static GameEvents Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType<GameEvents>();
                if (_instance)
                    _instance.Initialize();
            }

            return _instance;
        }
    }

    private void Initialize()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - _lastTickTime > tickDelay)
        {
            _lastTickTime = Time.time;
            Tick.Invoke();
        }
    }
}