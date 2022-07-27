using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour

{
    private TankController tankController;
    private float moveMent;
    private float rotation;
    public Rigidbody rb;
   public MeshRenderer [] childs;

    // Start is called before the first frame update
    void Start()
    {
       GameObject cam = GameObject.Find("Main Camera");
       cam.transform.SetParent(transform);
       cam.transform.position = new Vector3(0f, 3f, -6f);
    }
  
    // Update is called once per frame
    void Update()
    {
         MoveMent();

       if(moveMent != 0)
              tankController.Move(moveMent,tankController.GetTankModel().movementSpeed);

       if(rotation != 0)
            tankController.Rotate( rotation, tankController.GetTankModel().rotationSpeed);
     }
        private void MoveMent()
        {
                 rotation = Input.GetAxis("Horizontal");
                 moveMent = Input.GetAxis("Vertical");
        }

    public void SetTankCotroller(TankController _tankController)
    {

        tankController = _tankController;
        
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    public void ChangeColor(Material color)
    {
        for(int i = 0; i<childs.Length; i++)
        {
            childs[i].material = color;
        }
    }
    



}
