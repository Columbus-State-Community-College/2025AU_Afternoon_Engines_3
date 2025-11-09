using UnityEngine;
using UnityEngine.SceneManagement;
public class AreaExit : MonoBehaviour{
    [Header("This is the name of the SCENE you want to load.")]
    public string areaToLoad;
    //The Scene to Load on entering trigger zone.
    [Header("This is the name of the LOCATION IN SCENE you want to load.\nThis links to Target SCENE's AREA ENTRANCE script.\nMake sure to not double-up names in the same scene.")]

    public string targetAreaTransition;
    //The referenced location for the game to grab, must match another in order for there to be a connection
    public AreaEntrance theEntrance;
    public float waitToLoad;
    public bool delayLoad;
    void Start(){
        theEntrance.transitonName = targetAreaTransition;
    }
    void Update(){
        if(delayLoad)
        {
            waitToLoad -= Time.deltaTime;
            if(waitToLoad <= 0)
            {
                delayLoad = false;
                SceneManager.LoadScene(areaToLoad);
            }
        }

    }
    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player")
        {
            delayLoad = true;

            GameManager.instance.targetAreaTransition = targetAreaTransition;
        }
    }
}