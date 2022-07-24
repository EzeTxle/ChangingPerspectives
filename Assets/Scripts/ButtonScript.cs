using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioSource audio2;
    public AudioSource audio3;
    public bool disabled = false;
    public float tiempoDeHabla = 19f;
    public float tiempoDeBoton = 1.5f;
    public float tiempoDeFinal = 5f;
    public bool buttonPressed = false;
    public Animator animBoton;
    public Animator animDoor;
    public Transform fpsCamera;
    public GameObject mainCam;
    public GameObject playerCam;
    public GameObject fpsPlayer;
    public Transform capsule;
    public GameObject perspectivePlayer;
    bool changed = false;
    bool spacePressed = false;
    // Start is called before the first frame update
    void Start(){
        mainCam.SetActive(false);
        perspectivePlayer.SetActive(false);
        playerCam.SetActive(true);
        fpsPlayer.SetActive(true);
    }

    // Update is called once per frame
    void Update(){
        Temporizador();
        TouchingButton();
        if(Input.GetKeyDown("space") && !changed && disabled){
            mainCam.SetActive(true);
            playerCam.SetActive(false);
            perspectivePlayer.SetActive(true);
            perspectivePlayer.transform.position = capsule.position - new Vector3(0,1,0);
            perspectivePlayer.transform.rotation = capsule.rotation;
            fpsPlayer.SetActive(false);
            changed = true;
            spacePressed = true;
            audio3.Play();
            }
    }

    void TouchingButton(){
        RaycastHit ray;
        if(Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out ray, 5)){
        if (Input.GetMouseButton(0) && ray.transform.name == "Cylinder" && !disabled && !buttonPressed){
            animBoton.SetBool("buttonPressed", true);
            buttonPressed = true;
            audio2.Play();
            }}
        }

    private void Temporizador(){
        if(tiempoDeHabla > 0 && buttonPressed == true && !disabled ){
            tiempoDeHabla -= Time.deltaTime;
            tiempoDeBoton -= Time.deltaTime;
        } else if (buttonPressed && !disabled){
            disabled = true;            
        }
        
        if(tiempoDeBoton < 0 && !disabled){
        animBoton.SetBool("buttonPressed", false);
        }
        if(tiempoDeFinal >0 && spacePressed){
            tiempoDeFinal =- Time.deltaTime;
        }else if(spacePressed && tiempoDeFinal < 0){
            animDoor.SetBool("Opening", true);
        }
    }


}