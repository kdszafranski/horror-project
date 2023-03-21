using System;

[Serializable]
public struct Task 
{
    public string details;
    public bool completed;
    public int id;
    public int nextTaskId;
}
