using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using Types;
using UnityEngine;

public class GeneticController : MonoBehaviour
{
    private IBot _bot;
    private int _current;

    private void Awake()
    {
        GameEvents.Instance.Tick += Tick;
        _current = (int) Direction.North;
        _bot = GetComponent<IBot>();
    }

    private void Tick()
    {
        var result = _bot.Move((Direction) _current);
        _current += 2;
        _current %= 8;
        Debug.Log(result);
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