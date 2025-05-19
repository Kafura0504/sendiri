using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spawnlocation;
    public GameObject[] character;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = gettimer();
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
        timer -= Time.deltaTime;
    }

    void spawn()
    {
        if (timer < 0)
        {
        Instantiate(character[getcharacter()], spawnlocation[getindex()].transform);
            timer = gettimer();
        }
    }

    int getindex()
    {
        return UnityEngine.Random.Range(0, spawnlocation.Length);
    }

    int getcharacter()
    {
        return UnityEngine.Random.Range(0, character.Length);
    }
    float gettimer()
    {
        return UnityEngine.Random.Range(3, 7);
    }
}
