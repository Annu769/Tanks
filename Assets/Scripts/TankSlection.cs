using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankSlection : MonoBehaviour
{
    public TankSpwaner tankSpwaner;
    public void BlueTankSlected()
    {
        
        Debug.Log("blue Tank Slected");
        tankSpwaner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }
    
    public void GreenTankSlected()
    {
        tankSpwaner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }
    public void RedTankSlected()
    {
        tankSpwaner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }

}
