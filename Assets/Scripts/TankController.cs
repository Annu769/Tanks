
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    public Rigidbody rb;
    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();
        tankModel.SetTankCotroller(this);
        tankView.SetTankCotroller(this);
        tankView.ChangeColor(tankModel.color);
        
      
    }
    public void Move(float moveMent, float moveMentSpeed)
     {
        rb.velocity = tankView.transform.forward * moveMent * moveMentSpeed;
     }
     public void Rotate(float rotate, float rotationSpeed)
     {
        Vector3 vector = new Vector3(0f, rotate *rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

     }
     public TankModel GetTankModel()
     {
       return tankModel;
     }
}
