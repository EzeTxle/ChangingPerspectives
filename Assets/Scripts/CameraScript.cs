using UnityEngine;

public class CameraScript : MonoBehaviour
{
   public Transform transjug;
    private int speedToLook = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Observar();
    }
    void Observar(){
        Quaternion newRotation = Quaternion.LookRotation(transjug.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }
}