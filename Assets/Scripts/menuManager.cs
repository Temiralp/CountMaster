using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public GameObject blue;
    [SerializeField] private GameObject failPanel;
  [SerializeField] private GameObject startMenuObj;
    private bool isFailPanel;
    public static bool isNextLevel;
    [SerializeField] private GameObject nextLevelPanel;
    public Text level;
    public int currentLevel;
    public Text gold;
    public int currentGold;
    public void StartTheGame()
  {
    startMenuObj.SetActive(false);
    PlayerManager.PlayerManagerInstance.gameState = true;
    
    PlayerManager.PlayerManagerInstance.player.GetChild(1).GetComponent<Animator>().SetBool("run",true);

  }
    private void Awake()
    {
      //  SceneManager.LoadScene(1);
    }
    private void Start()
    {
      //  PlayerPrefs.DeleteAll();
        if (PlayerPrefs.GetInt("level") == 10)
        {
           
            SceneManager.LoadScene(0);
        }
      
        currentGold = 50;
        currentGold = PlayerPrefs.GetInt("gold");
        PlayerPrefs.SetInt("gold", currentGold);

        currentLevel = 1;
 
        currentLevel = PlayerPrefs.GetInt("level");
        PlayerPrefs.SetInt("level", currentLevel);
      

        Debug.Log(PlayerPrefs.GetInt("level"));
    }
    private void Update()
    {
        level.text = PlayerPrefs.GetInt("level").ToString();
             gold.text = PlayerPrefs.GetInt("gold").ToString();
        FailPanel();
        if (isFailPanel == true)
        {

        }
        //if (isFailPanel == false)
        //{
        //    Debug.Log("Fail panel kapatýldý");
        //    failPanel.SetActive(false);
        //}
    }
    private void FailPanel()  ///Fail paneli açar
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0 && GameObject.FindGameObjectsWithTag("blue").Length == 0)
        {
          
            Debug.Log("Fail panel açýldý");
            Debug.Log("Fail panel açýldý");

            failPanel.SetActive(true);
      
        }

    } 

    public void Retry()
    {
        Instantiate(blue); //gecici cozum 
        isFailPanel = false;
       failPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void NextLevel()
    {
        currentLevel = PlayerPrefs.GetInt("level");
        currentLevel++;
        PlayerPrefs.SetInt("level", currentLevel);
        level.text = PlayerPrefs.GetInt("level").ToString();

        currentGold = PlayerPrefs.GetInt("gold");
        currentGold =currentGold+200;
        //  gold.text = currentGold.ToString();
        PlayerPrefs.SetInt("gold", currentGold);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(PlayerPrefs.GetInt("level"));

    }
    public void NextLevelPanel()
    {
        nextLevelPanel.SetActive(true);
    }
}

