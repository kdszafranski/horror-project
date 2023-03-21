using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    // refs
    public GameController gameController;

   
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Objective")) {
            gameController.CheckTask(other.gameObject.GetComponent<Objective>());
        }    
    }

}
