using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerspectivePersonController : MonoBehaviour
{
        public enum Controls{
        normal,
        inversed,
        twod,
        mirrored,
        mirroredInversed
    };
    public Controls actualMov;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    int actualCam = 1;
    public Animator anim;
    float speed = 5f;
    public Rigidbody rb;
    float oldX;
    float oldZ;
    // Start is called before the first frame update
    void Start()
    {
        switch(cam1.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
    }

    // Update is called once per frame
    void Update()
    {
        UserInput();
    }
    void UserInput(){
        Movement();
        ChangePerspective();
    }



    void Movement(){
        switch(actualMov){
            case Controls.normal:
            if(Input.GetKey("w")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
        } else if(Input.GetKey("s")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
        } else if(Input.GetKey("a")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
        }else if (Input.GetKey("d")){
            oldZ = transform.position.z;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
        }else{
            anim.SetBool("isWalking", false);
        }
            break;

            case Controls.inversed:
            if(Input.GetKey("w")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            } else if(Input.GetKey("s")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            } else if(Input.GetKey("a")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else if (Input.GetKey("d")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else{
            anim.SetBool("isWalking", false);
            }
            break;

            case Controls.mirrored:
            if(Input.GetKey("w")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            } else if(Input.GetKey("s")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            } else if(Input.GetKey("a")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else if (Input.GetKey("d")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else{
            anim.SetBool("isWalking", false);
            }
            break;
            case Controls.mirroredInversed:
            if(Input.GetKey("w")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            } else if(Input.GetKey("s")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            anim.SetBool("isWalking", true);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            } else if(Input.GetKey("a")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else if (Input.GetKey("d")){
            oldX = transform.position.x;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldX != transform.position.x){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else{
            anim.SetBool("isWalking", false);
            }
            break;

            case Controls.twod:
            if(Input.GetKey("a")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else if (Input.GetKey("d")){
            oldZ = transform.position.z;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if(oldZ != transform.position.z){
                anim.SetBool("isWalking", true);
            }else{
                anim.SetBool("isWalking", false);
            }
            }else{
            anim.SetBool("isWalking", false);
            }
            break;
        }
        
        
    }



    void ChangePerspective(){
        if(actualMov != Controls.twod){
        if(Input.GetKeyDown("space")){
            if(cam3 != null){
                switch(actualCam){
                    case 1:
                    cam1.SetActive(true);
                    switch(cam1.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    cam3.SetActive(false);
                    actualCam++;
                    break;

                    case 2:
                    cam1.SetActive(false);
                    cam2.SetActive(true);
                    switch(cam2.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam++;
                    break;

                    case 3:
                    cam2.SetActive(false);
                    cam3.SetActive(true);
                    switch(cam3.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam = 1;
                    break;
                }
            } else {
                if(actualCam == 1){
                    cam1.SetActive(true);
                    cam2.SetActive(false);
                    switch(cam2.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam = 2;
                }else{
                    switch(cam1.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam = 1;
                    cam2.SetActive(true);
                    cam1.SetActive(false);
                }
                }

            }
        }else{
            if(Input.GetKeyDown("w") || Input.GetKeyDown("s")){
            if(cam3 != null){
                switch(actualCam){
                    case 1:
                    cam1.SetActive(true);
                    switch(cam1.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    cam3.SetActive(false);
                    actualCam++;
                    break;

                    case 2:
                    cam1.SetActive(false);
                    cam2.SetActive(true);
                    switch(cam2.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam++;
                    break;

                    case 3:
                    cam2.SetActive(false);
                    cam3.SetActive(true);
                    switch(cam3.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam = 1;
                    break;
                }
            } else {
                if(actualCam == 1){
                    cam1.SetActive(true);
                    cam2.SetActive(false);
                    switch(cam2.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam = 2;
                }else{
                    switch(cam1.tag){
                        case "CameraNormal":
                        actualMov = Controls.normal;
                        break;
                        case "CameraInversed":
                        actualMov = Controls.inversed;
                        break; 
                        case "Camera2D":
                        actualMov = Controls.twod;
                        break; 
                        case "CameraMirrored":
                        actualMov = Controls.mirrored;
                        break;
                        case "CameraMirroredInversed":
                        actualMov = Controls.mirroredInversed;
                        break;
                        default:
                        actualMov = Controls.normal;
                        break;
                    }
                    actualCam = 1;
                    cam2.SetActive(true);
                    cam1.SetActive(false);
                }
                }

            }
        }
    }
}
