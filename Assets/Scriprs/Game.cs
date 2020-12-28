using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Game : MonoBehaviour
{
    private List<Block> _blocks;

    public float speed = 1f;

    [SerializeField]
    public List<BlockDes> BlocksDesription;

    private static readonly string _blockTag = "Block";
    
    //private GameObject 
    
    private void Start()
    {
        var objs = GameObject.FindGameObjectsWithTag(_blockTag);
        _blocks = new List<Block>();
        
        foreach (var blockObj in objs)
        {
            var block = blockObj.AddComponent<Block>();
            //blockObj.
            
            _blocks.Add(block);
        }
        
        var typeCardCount =  _blocks.Count / BlocksDesription.Count;

        var blockDes = BlocksDesription.Select(x => x).ToList();
        var blockOfTypeCount = blockDes.ToDictionary(x => x, v => typeCardCount);

        for (int i = 0; i < _blocks.Count; i++)
        {
            var rndBlock = blockDes.Random();
            
            if (--blockOfTypeCount[rndBlock] == 0)
            { 
                blockDes.Remove(rndBlock);
            }
            
            _blocks[i].Init(speed, rndBlock);
        }
    }
    
    
}
