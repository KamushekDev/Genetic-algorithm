using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotSpawner : MonoBehaviour
{
    public Bot bot;

    private Grid _worldGrid;
    
    public void Awake()
    {
        _worldGrid = GetComponentInParent<Grid>();
        bot.grid = _worldGrid;
        Instantiate(bot, transform);
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
