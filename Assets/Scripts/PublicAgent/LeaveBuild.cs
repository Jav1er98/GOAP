using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveBuild : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        Destroy(gameObject);
        return true;
    }
}
