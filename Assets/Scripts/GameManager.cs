using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject WinUI;

    //Show WinUI when collision determination occurs
    public void InGoal()
    {
        WinUI.SetActive(true);
    }

}
