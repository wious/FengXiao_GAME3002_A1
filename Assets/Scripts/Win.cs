using UnityEngine;

public class Win: MonoBehaviour
{


    public GameManager gameManager;
    //Determine whether to hit the target
    void OnTriggerEnter()
    {
        gameManager.InGoal();
    }


}
