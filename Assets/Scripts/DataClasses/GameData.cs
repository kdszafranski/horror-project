using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Data/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public TaskListData taskList;

    public TaskListData GetTaskListData() {
        return taskList;
    }
}

