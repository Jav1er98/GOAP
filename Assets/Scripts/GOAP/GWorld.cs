using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;

    private static Queue<GameObject> scenario;
    private static Queue<GameObject> publicSpace;

    static GWorld()
    {
        world = new WorldStates();

        scenario = new Queue<GameObject>();
        publicSpace = new Queue<GameObject>();
        
        GameObject[] scenarioList = GameObject.FindGameObjectsWithTag("CatWalk");
        GameObject[] publicSpaceList = GameObject.FindGameObjectsWithTag("Seats");

        foreach (var sc in scenarioList)
        {
            scenario.Enqueue(sc);
        }

        if (scenarioList.Length > 0)
        {
            world.ModifyState("freeScenario", scenarioList.Length);
        }
        
        foreach (var ps in publicSpaceList)
        {
            publicSpace.Enqueue(ps);
        }

        if (publicSpaceList.Length > 0)
        {
            world.ModifyState("freePublicSpace", scenarioList.Length);
        }
    }
    
    public void AddScenario(GameObject sc)
    {
        scenario.Enqueue(sc);
    }

    public GameObject RemoveScenario()
    {
        if (scenario.Count == 0) return null;
        return scenario.Dequeue();
    }

    public void AddPublicSpace(GameObject ps)
    {
        publicSpace.Enqueue(ps);
    }
    
    public GameObject RemovePublicSpace()
    {
        if (publicSpace.Count == 0) return null;
        return publicSpace.Dequeue();
    }

    private GWorld()
    {
    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}
