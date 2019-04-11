using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerController PlayerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveGame() {
        Player player = new Player();
        player.position = PlayerController.gameObject.transform.position;
        string data = JsonUtility.ToJson(player);
        SaveAndLoad.Save(data);
    }

    public void LoadGame() {
        string content = SaveAndLoad.Load();
        Player player = JsonUtility.FromJson<Player>(content);
        PlayerController.gameObject.transform.position = player.position;
    }
}


public class Player {
    public Vector3 position;
}