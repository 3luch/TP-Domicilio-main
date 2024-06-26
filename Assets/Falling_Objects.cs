using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Falling_Objects : MonoBehaviour
{
   public GameObject martillo;  
   public GameObject sillon; 
   public GameObject mesa;
    public GameObject sillaAzul;
    public GameObject birman;
    public GameObject piña;
    public GameObject pasilloSilla;
    public GameObject martillo2;
    public GameObject semaforo; 
    public GameObject manzana;
    public GameObject batalla;
    public GameObject thor; 
    public GameObject cono;
    public GameObject jarron;
    public GameObject rama; 
    public GameObject rozichner;
    public GameObject sendyk;
    public GameObject cartelCalle; 
    public GameObject cerrucho;
    public GameObject alfajor;
    public GameObject cerrucho2;
    public GameObject pizza;
    public float minX = -3.5f; 
   public float maxX = 3.5f; 
   public float Y = 4f; 

   
    // Start is called before the first frame update
    void Start() 
    { 
        SpawnObjects();
    } 
    
    // Update is called once per frame 
    void SpawnObjects()

    { 
        int numberSpawned = Random.Range(1, 3);
        for (int i = 0; i < numberSpawned; i++)
        { 
            float randomX = Random.Range(minX, maxX); 
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo, newPosition, Quaternion.identity); 
        } 

        int numberSpawn = Random.Range(1, 3);
        for (int h = 0; h < numberSpawn; h++)
        { 
            float randomX = Random.Range(minX, maxX); 
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(sillon, newPosition, Quaternion.identity); 
        }
        int numberSpawnedd = Random.Range(1, 3);
        for (int h = 0; h < numberSpawnedd; h++)
        { 
            float randomX = Random.Range(minX, maxX); 
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(mesa, newPosition, Quaternion.identity); 
        }
        int number = Random.Range(1, 3);
        for (int i = 0; i < number; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(sillaAzul, newPosition, Quaternion.identity);
        }

        int nu = Random.Range(1, 3);
        for (int h = 0; h < nu; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(birman, newPosition, Quaternion.identity);
        }
        int num = Random.Range(1, 3);
        for (int h = 0; h < num; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(piña, newPosition, Quaternion.identity);
        }
        int numb = Random.Range(1, 3);
        for (int i = 0; i < numb; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(pasilloSilla, newPosition, Quaternion.identity);
        }

        int numbe = Random.Range(1, 3);
        for (int h = 0; h < numbe; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo2, newPosition, Quaternion.identity);
        }
        int numberSpawnedd = Random.Range(1, 3);
        for (int h = 0; h < numberSpawnedd; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(mesa, newPosition, Quaternion.identity);
        }
        int numberSpawned = Random.Range(1, 3);
        for (int i = 0; i < numberSpawned; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo, newPosition, Quaternion.identity);
        }

        int numberSpawn = Random.Range(1, 3);
        for (int h = 0; h < numberSpawn; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(sillon, newPosition, Quaternion.identity);
        }
        int numberSpawnedd = Random.Range(1, 3);
        for (int h = 0; h < numberSpawnedd; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(mesa, newPosition, Quaternion.identity);
        }
        int numberSpawned = Random.Range(1, 3);
        for (int i = 0; i < numberSpawned; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo, newPosition, Quaternion.identity);
        }

        int numberSpawn = Random.Range(1, 3);
        for (int h = 0; h < numberSpawn; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(sillon, newPosition, Quaternion.identity);
        }
        int numberSpawnedd = Random.Range(1, 3);
        for (int h = 0; h < numberSpawnedd; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(mesa, newPosition, Quaternion.identity);
        }
        int numberSpawned = Random.Range(1, 3);
        for (int i = 0; i < numberSpawned; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo, newPosition, Quaternion.identity);
        }

        int numberSpawn = Random.Range(1, 3);
        for (int h = 0; h < numberSpawn; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(sillon, newPosition, Quaternion.identity);
        }
        int numberSpawnedd = Random.Range(1, 3);
        for (int h = 0; h < numberSpawnedd; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(mesa, newPosition, Quaternion.identity);
        }
        int numberSpawned = Random.Range(1, 3);
        for (int i = 0; i < numberSpawned; i++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(martillo, newPosition, Quaternion.identity);
        }

        int numberSpawn = Random.Range(1, 3);
        for (int h = 0; h < numberSpawn; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(sillon, newPosition, Quaternion.identity);
        }
        int numberSpawnedd = Random.Range(1, 3);
        for (int h = 0; h < numberSpawnedd; h++)
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 newPosition = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(mesa, newPosition, Quaternion.identity);
        }
    } 
}