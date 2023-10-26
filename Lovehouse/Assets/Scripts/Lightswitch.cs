using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
        public GameObject inttext, light;
        public bool toggle = true, interactable;
        public Renderer lightBulb;
        public Material offlight, onlight; public AudioSource lightswitchSound;
        public Animator switchAnim;

        void OnTriggerStay(Collider other){
            if (other.CompareTag ("MainCanera")){
                inttext.SetActive(true);
                interactable = true;
            }
        }

        void OntriggerExit(Collider other){
            if (other.CompareTag ("MainCanera")){
                inttext.SetActive(false);
                interactable = false;
            }
        }

        void Update(){
            if(interactable == true){
                if(Input.GetKeyDown(KeyCode.E)){
                    toggle = !toggle;
                    switchAnim.ResetTrigger("press"); 
                    switchAnim.SetTrigger( "press");
                }
            }
            if (toggle == false){
                light.SetActive(false); 
                lightBulb.material = offlight;
            }
            if (toggle == true){
                light.SetActive(true); 
                lightBulb.material = onlight;
            }
        }
}