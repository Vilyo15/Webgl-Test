using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Spin[] wheels;
    [SerializeField] private GameObject winGraphic;
    [SerializeField] private GameObject loseSound;

    public void DisplayWin()
    {
        wheels[0].Count ++ ;
        Debug.Log(wheels[0].Count);
        if (wheels[0].Result == wheels[1].Result && wheels[0].Result == wheels[2].Result )
        {
            winGraphic.SetActive(true) ;
        }
        else if (wheels[0].Count == 3)
        {
            loseSound.SetActive(true) ;
            wheels[0].Count = 0;
        }
    }
}
