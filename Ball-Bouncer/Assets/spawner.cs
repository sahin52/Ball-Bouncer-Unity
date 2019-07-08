using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class spawner : MonoBehaviour
{
    public GameObject block;
    public Transform player;
    public float y;
    public int seviye=0;
    int maxseviye=0;
    public bool gameEnded;
    // Start is called before the first frame update
    void Start()
    {
        y=player.position.y;
        Instantiate(block, new Vector3(0,-3,0),Quaternion.identity);
    }
    void Update(){
        
        if(seviye<=player.position.y+9 && !gameEnded){
            Instantiate(block, new Vector3(Random.Range(-7,7),seviye,0),Quaternion.identity);
            seviye += 3; 
            print(seviye/3);
            maxseviye=seviye;   
        }

        if(player.position.y<maxseviye-14){
            //GAME ENDS DO SOMETHING
            gameEnded=true;
            
        }
        if(gameEnded){
            if(Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Begin again;
            }
        }

    }
    // Update is called once per frame
    public IEnumerator spawn(){
        Instantiate(block, new Vector3(Random.Range(-5,5),y,0),Quaternion.identity);
        y=y+3f;
    
    yield return new WaitForSeconds(1f);
    StopCoroutine("spawn");
   // StartCoroutine("spawn");
    }

}
