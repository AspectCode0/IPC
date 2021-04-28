using System.Collections;
using System.Collections.Generic;
using BreakInfinity;

public class Data
{
    public int UMultC;
    public int UMult;
    public int MenuClicks;
    public BigDouble matter;
    public BigDouble MPCUpgrade;
    public BigDouble MPCUCost;
    public BigDouble MPSUpgrade;
    public BigDouble MPSUCost; 
    public bool AutoMC;

    public Data()
    {
        matter = 0;
        MenuClicks = 0;
        MPCUpgrade = 1;
        MPCUCost = 10;
        MPSUpgrade = 0;
        MPSUCost = 100;
        AutoMC = false;
        UMultC = 1;
        UMult = 1;
    }
}
