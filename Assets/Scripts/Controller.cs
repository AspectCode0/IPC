using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;
    public TMP_Text matterCount;
    public TMP_Text MPCText;
    public TMP_Text MPSText;
    public TMP_Text MPSCounter;
    public TMP_Text UMultText;
    public GameObject UMultButton;
    public GameObject UpButton;
    public GameObject MenuBack;
    public GameObject MPCButton;
    public GameObject MPSButton;

    public void Start()
    {
        data = new Data();
        StartCoroutine(AutoClick());
    }
        private IEnumerator AutoClick()
     {
        WaitForSeconds waitTime = new WaitForSeconds(1);
        while (true)
        {
            yield return new WaitForSeconds(1);
            data.matter += data.MPSUpgrade;
        }
     }
    
    public void Update()
    {
        MPSCounter.text = "Matter Per Second: " + data.MPSUpgrade;
        MPCText.text = "Matter Per Click +" + data.UMult + " \n Cost: " + data.MPCUCost;
        MPSText.text = "Matter Per Second +" + data.UMult + " \n Cost: " + data.MPSUCost;
        matterCount.text = "Matter: " + data.matter;
        if (data.MenuClicks >= 3)
        {
            data.MenuClicks = 1;
        }

        if (data.MenuClicks == 1)
        {
            UpButton.SetActive(true);
            MenuBack.SetActive(true);
            MPCButton.SetActive(true);
            MPSButton.SetActive(true);
        }

        else
        {
            UpButton.SetActive(false);
            MenuBack.SetActive(false);
            MPCButton.SetActive(false);
            MPSButton.SetActive(false);
        }

        if (data.UMultC == 1)
        {
            data.UMult = 1;
            if (data.MPCUpgrade > 2)
            {
                data.MPCUCost = 10 + 7 * data.MPCUpgrade;
            }
            else
            {
                data.MPCUCost = 10;
            }
            if (data.MPSUpgrade > 2)
            {
                data.MPSUCost = 100 + 15 * data.MPSUpgrade;
            }
            else
            {
                data.MPSUCost = 100;
            }
            UMultText.text = "Upgrade Multiplier: " + data.UMult;
        }
        if (data.UMultC == 2)
        {
            data.UMult = 5;
            if (data.MPCUpgrade > 2)
            {
                data.MPCUCost = 50 + 7 * data.MPCUpgrade;
            }
            else
            {
                data.MPCUCost = 50;
            }
            if (data.MPSUpgrade > 2)
            {
                data.MPSUCost = 500 + 15 * data.MPSUpgrade;
            }
            else
            {
                data.MPSUCost = 500;
            }
            UMultText.text = "Upgrade Multiplier: " + data.UMult;
        }
        else if (data.UMultC == 3)
        {
            data.UMult = 25;
            if (data.MPCUpgrade > 2)
            {
                data.MPCUCost = 250 + 7 * data.MPCUpgrade;
            }
            else
            {
                data.MPCUCost = 250;
            }
            if (data.MPSUpgrade > 2)
            {
                data.MPSUCost = 2500 + 15 * data.MPSUpgrade;
            }
            else
            {
                data.MPSUCost = 2500;
            }
            UMultText.text = "Upgrade Multiplier: " + data.UMult;
        }
        else if (data.UMultC == 4)
        {
            data.UMult = 50;
            if (data.MPCUpgrade > 2)
            {
                data.MPCUCost = 500 + 7 * data.MPCUpgrade;
            }
            else
            {
                data.MPCUCost = 500;
            }
            if (data.MPSUpgrade > 2)
            {
                data.MPSUCost = 5000 + 15 * data.MPSUpgrade;
            }
            else
            {
                data.MPSUCost = 5000;
            }
            UMultText.text = "Upgrade Multiplier: " + data.UMult;
        }
        else if (data.UMultC == 5)
        {
            data.UMult = 100;
            if (data.MPCUpgrade > 2)
            {
                data.MPCUCost = 1000 + 7 * data.MPCUpgrade;
            }
            else
            {
                data.MPCUCost = 1000;
            }
            if (data.MPSUpgrade > 2)
            {
                data.MPSUCost = 10000 + 15 * data.MPSUpgrade;
            }
            else
            {
                data.MPSUCost = 10000;
            }
            UMultText.text = "Upgrade Multiplier: " + data.UMult;
        }
        else if (data.UMultC == 6)
        {
            data.UMultC = 1;
            UMultText.text = "Upgrade Multiplier: 1";
        }
    }

    public void PlanetClick()
    {
        data.matter += data.MPCUpgrade;
    }

    public void MenuClick()
    {
        data.MenuClicks += 1;
    }

    public void MPCUpgradeClick()
    {
        if (data.matter >= data.MPCUCost)
        {
            data.MPCUpgrade = data.MPCUpgrade + data.UMult;
            data.matter = data.matter - data.MPCUCost;
            data.MPCUCost += 7;
        }
        else
        {
            return;
        }
    }

    public void MPSUpgradeClick()
    {
        if(data.matter >= data.MPSUCost)
        {
            data.MPSUpgrade = data.MPSUpgrade + data.UMult;
            data.matter = data.matter - data.MPSUCost;
            data.MPSUCost += 15;
            data.AutoMC = true;
        }
        else
        {
            return;
        }
    }

    public void UpgradeMult()
    {
        data.UMultC++;
    }
}
