using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToSceneScript : MonoBehaviour
{
    public enum Scenes{
        tut,
        lvl1,
        lvl2,
        lvl3,
        lvl4,
        menu,
        end
    };
    public Scenes goTo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.gameObject.name == "Player"){
            switch(goTo){
                case Scenes.tut:
                SceneManager.LoadScene("TutorialRoom");
                break;
                case Scenes.lvl1:
                SceneManager.LoadScene("Level1");
                break;
                case Scenes.lvl2:
                SceneManager.LoadScene("Level2");
                break;
                case Scenes.lvl3:
                break;
                case Scenes.lvl4:
                break;
                case Scenes.menu:
                break;
                case Scenes.end:
                break;
            }
        }
    }
}
