using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : GAgent
{
    new void Start()
    {
        base.Start();

        SubGoal s1 = new SubGoal("arriveCatwalk", 1, true);
        SubGoal s2 = new SubGoal("model", 1, true);
        SubGoal s3 = new SubGoal("leaveCatwalk", 1, true);
        goals.Add(s1, 5);
        goals.Add(s2, 10);
        goals.Add(s3, 10);
    }
}
