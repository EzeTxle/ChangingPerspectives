using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour{
    //Player Movement
    public float velocidadMovimiento = 3f;



    //Player Look Rotation
    float sensibilidadMouse = 250f;
    public float xRotacion;
    public float yRotacion;
    public Transform cam;
    public Transform capsule;
    
    //Temporizador
    float tiempoEncerrado = 47f;
    bool tiempoEnSilla = false;
    
    //Rigidbody
    public Rigidbody rb;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rb.isKinematic = true;

    }

   
    void Update(){
      Move();  
      MouseLook();
      Temporizador();
    }


    void Move(){
        if(tiempoEnSilla == true){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 inputPlayer = new Vector3(hor,0,ver);
        capsule.Translate(inputPlayer * velocidadMovimiento * Time.deltaTime);
        
        }
        transform.position = capsule.position;
    }

    void MouseLook(){
        float mouseX = Input.GetAxis("Mouse X") *sensibilidadMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") *sensibilidadMouse * Time.deltaTime;

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -70,70);
        if(tiempoEnSilla == false){
        yRotacion = Mathf.Clamp(yRotacion, -180,0);
        }
        yRotacion += mouseX;
        cam.localRotation= Quaternion.Euler(xRotacion,yRotacion,0);
        capsule.localRotation= Quaternion.Euler(0,yRotacion,0);

    }
    void Temporizador(){
        if(tiempoEncerrado > 0 && tiempoEnSilla == false){
            tiempoEncerrado -= Time.deltaTime;
            } else if (tiempoEnSilla == false){
                for (int i = 0; i<23; i++){
                    capsule.position += new Vector3(1, 0, 0) * Time.deltaTime;
                    transform.position = capsule.position;
                }
                rb.isKinematic = false;
                tiempoEnSilla = true;
            } else if(tiempoEncerrado > 0){
                
            }
    }
    
    }