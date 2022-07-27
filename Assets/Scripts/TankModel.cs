
using UnityEngine;

public class TankModel 
{
   private TankController tankController;

  public float movementSpeed;

 public float rotationSpeed;
 public TankTypes tankType;
 public Material color;




   public TankModel(float _moveMent, float _rotation, TankTypes tank, Material _color)
   {
       movementSpeed = _moveMent;
       rotationSpeed = _rotation;
       tankType = tank;
       color = _color;
   }
   public void SetTankCotroller(TankController _tankController)
   {
      tankController = _tankController;
   }
}
