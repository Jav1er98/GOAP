using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveModelShow : GAction
{
    public delegate void ModelDestroyed();
    public static event ModelDestroyed OnModelDestroyed;
    
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        if (OnModelDestroyed != null)
        {
            OnModelDestroyed();
        }
        Destroy(gameObject);
        return true;
    }
}
