 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{ [System.Serializable]
    public class Tank
    {
        public float moveMentSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }
    public List<Tank> tankList;
    public TankView tankView;
    void Start()
    {
        
    }
  public void CreateTank(TankTypes tankTypes)
    {
         if(tankTypes == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tankList[0].moveMentSpeed, tankList[0].rotationSpeed, tankList[0].tankType,tankList[0].color);
        TankController tankController = new TankController(tankModel, tankView);
        }
        if(tankTypes == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tankList[1].moveMentSpeed, tankList[1].rotationSpeed, tankList[1].tankType,tankList[1].color);
        TankController tankController = new TankController(tankModel, tankView);
        }
       
        if(tankTypes == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tankList[2].moveMentSpeed, tankList[2].rotationSpeed, tankList[2].tankType,tankList[2].color);
        TankController tankController = new TankController(tankModel, tankView);
        }
       

    }
  
}