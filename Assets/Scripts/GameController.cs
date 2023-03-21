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
        UpdateTaskUI();
    }

    void LoadTask(Task task) {
        _currentTask = task;
        UpdateTaskUI();
    }

    void UpdateTaskUI() {
        ui_currentTaskText.text = _currentTask.details;
    }

    void LoadNextTask(int idToLoad) {
        foreach(Task task in _taskData.tasks) {
            if(task.id == idToLoad) {
                LoadTask(task);
            }
        }
    }

    public void CheckTask(Objective objective) {
        Debug.Log("objective met: " + objective.id);
        if(_currentTask.id == objective.id) {
            CompleteObjective(_currentTask);
        }
    }

    void CompleteObjective(Task task) {
        // objective met!
        // ui_currentTaskText.color = Color.yellow;

        if(task.nextTaskId > 0) {
            // load the next task
            LoadNextTask(task.nextTaskId);
        }
    }



}
