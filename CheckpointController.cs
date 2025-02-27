﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static CheckpointController instance;
    public Checkpoint[] checkpoints;
    public Vector3 spawnPoint;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        checkpoints = FindObjectsOfType<Checkpoint>();
        spawnPoint = Player.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactiveCheckpoints()
    {
        for(int i=0; i<checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }

    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }
}
