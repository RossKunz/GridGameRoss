using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class GameManager : Singleton<GameManager> {

    public TextAsset carsexample;

    void Start()
    {

    }

    void update()
    {

    }

   
    

    /// Declaring Variables for Later Functions based on Matlab Code
    /// 
    private float dt = 0.25f;

    private float accNetIncome = 1e6f;

    private double[,] genData =
    {
        {0,10,01,0,0,0,0,115,0,1 },
        {0,20,2,0,0,0,0,105,0,1 },
        {0,1,10,0,0,0,0,95,0,1 },
        {0,10,25,0,0,90,0,35,0,1 },
        {0,5,50,0,0,35,0,80,0,1 },
        {0,10,50,5,1,80,50,10,0,0 },
        {0,5,20,20,10,0,10,75,0,0 },
        {0,5,30,10,2,60,30,25,0,0 }
    };

    private double[,] storageData =
    {
        {10,20,2,0.001,100,10,0,0 },
        {10,20,2,0.010,10,10,0,0 },
        {10,20,2,0,0,0,0,0 }
    };

    private double[,] loadData =
    {
        {1,25,10,120,360,1,0,1 },
        {1,25,25,110,330,2,0,1 },
        {0,10,50,105,315,2,0,1 },
        {0,10,10,100,300,3,0,1 },
        {0,100000,2e-3,95,285,3,0,1 },
        {0,1000,50e-3,95,285,3,0,1 },
        {0,1,250,0,0,0,0,1 }
    };

    private double[] lineData = {5,0.02,200};


}
