using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    // refs
    public GameController gameController;

   
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Objective")) {
            gameController.CheckObjective(other.gameObject.GetComponent<Objective>());
        }    
    }

}
