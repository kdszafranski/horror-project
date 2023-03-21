using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameData tasks;
    private TaskListData _taskData;
    private Task _currentTask;

    // UI
    public TextMeshProUGUI ui_currentTaskText;

    void Start()
    {
        Cursor.visible = false;
        // the game task data
        LoadGameData();
        
        // let's go!
        Init();
    }

    void Init() {
        LoadTask(0);
    }

    void LoadGameData() {
        _taskData = tasks.GetTaskListData();
    }

    void LoadTask(int index = 0) {
        _currentTask = _taskData.tasks[index];

        ui_currentTaskText.text = _currentTask.details;
    }



}
