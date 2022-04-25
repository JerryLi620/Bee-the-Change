using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomEvent : MonoBehaviour
{
    public TMP_Text Incident;
    public TMP_Text Policy1;
    public TMP_Text Policy2;
    public Button PolicyButton1;
    public Button PolicyButton2;
    public TMP_Text News;

    private int happinessChange1 = 0;
    private int lifeExpectancyChange1 = 0;
    private int honeyProductionChange1 = 0;
    private int beeRightsChange1 = 0;
    private int flowerDensityChange1 = 0;
    private int happinessChange2 = 0;
    private int lifeExpectancyChange2 = 0;
    private int honeyProductionChange2 = 0;
    private int beeRightsChange2 = 0;
    private int flowerDensityChange2 = 0;
    private string happiness1 = "";
    private string lifeExpectancy1 = "";
    private string honeyProduction1 = "";
    private string beeRights1 = "";
    private string flowerDensity1 = "";
    private string happiness2 = "";
    private string lifeExpectancy2 = "";
    private string honeyProduction2 = "";
    private string beeRights2 = "";
    private string flowerDensity2 = "";


    void Rainstorm(){
        Incident.text = "A rainstorm is expected to last for an unknown number of days, flooding the western side of the honeycomb.";
        Policy1.text = "Keep everything unchanged and hope it passes quickly";
        Policy2.text = "Shutdown honey factories and prepare relief materials and sufficient food for the honeycombs";


        happinessChange1 = -5;
        lifeExpectancyChange1 = -3;
        honeyProductionChange1 = 5;
        beeRightsChange1 = -3;
        flowerDensityChange1 = -3;
        happiness1 = "-5";
        lifeExpectancy1 = "-3";
        honeyProduction1 = "+5";
        beeRights1 = "-3";
        flowerDensity1 = "-3";

        happinessChange2 = 5;
        lifeExpectancyChange2 = 3;
        honeyProductionChange2 = -5;
        beeRightsChange2 = 3;
        flowerDensityChange2 = -3;
        happiness2 = "+5";
        lifeExpectancy2 = "+3";
        honeyProduction2 = "-5";
        beeRights2 = "+3";
        flowerDensity2 = "-3";
        }
    void ForestFire(){
        Incident.text = "A forest fire is spreading across the eastern (forest section) part of the honeycomb, destroying flowers and trees rapidly.";
        Policy1.text = "Focus fire department to rural areas of eastern honeycombs";
        Policy2.text = "Focus fire department to urban areas of eastern honeycombs";

        happinessChange1 = 2;
        lifeExpectancyChange1 = -5;
        honeyProductionChange1 = -1;
        beeRightsChange1 = 3;
        flowerDensityChange1 = -1;
        happiness1 = "+2";
        lifeExpectancy1 = "-5";
        honeyProduction1 = "-1";
        beeRights1 = "+3";
        flowerDensity1 = "-1";

        happinessChange2 = 3;
        lifeExpectancyChange2 = -3;
        honeyProductionChange2 = -5;
        beeRightsChange2 = 5;
        flowerDensityChange2 = -5;
        happiness2 = "+3";
        lifeExpectancy2 = "-3";
        honeyProduction2 = "-5";
        beeRights2 = "+5";
        flowerDensity2 = "-5";
        }
    void Hurricane(){
        Incident.text = "A hurricane is projected to hit the coast of the honeycomb within the next two days.";
        Policy1.text = "Require evacuation for everyone in the area and send emergency services after the fact.";
        Policy2.text = "Encourage evacuation for everyone in the area, continuing honey production through the hurricane.";

        happinessChange1 = 3;
        lifeExpectancyChange1 = 5;
        honeyProductionChange1 = -5;
        beeRightsChange1 = 3;
        flowerDensityChange1 = -2;
        happiness1 = "+3";
        lifeExpectancy1 = "+5";
        honeyProduction1 = "-5";
        beeRights1 = "+3";
        flowerDensity1 = "-2";

        happinessChange2 = 1;
        lifeExpectancyChange2 = 3;
        honeyProductionChange2 = 3;
        beeRightsChange2 = -3;
        flowerDensityChange2 = -2;
        happiness2 = "+1";
        lifeExpectancy2 = "+3";
        honeyProduction2 = "+3";
        beeRights2 = "-3";
        flowerDensity2 = "-2";
        }
    void Drought(){
        Incident.text = "There is a drought across the northern half of the island, leaving many bees struggling to continue honey production.";
        Policy1.text = "Evacuate everyone in the drought area and try to end the drought with artificial rainfall.";
        Policy2.text = "Prepare relief materials and sufficient food for the honeycombs.";

        happinessChange1 = 5;
        lifeExpectancyChange1 = 5;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 3;
        flowerDensityChange1 = -2;
        happiness1 = "+5";
        lifeExpectancy1 = "+5";
        honeyProduction1 = "-3";
        beeRights1 = "+3";
        flowerDensity1 = "-2";

        happinessChange2 = 0;
        lifeExpectancyChange2 = 3;
        honeyProductionChange2 = 3;
        beeRightsChange2 = 3;
        flowerDensityChange2 = -2;
        happiness2 = "0";
        lifeExpectancy2 = "+3";
        honeyProduction2 = "+3";
        beeRights2 = "+3";
        flowerDensity2 = "-2";
        }
    void Tornado(){
        Incident.text = "A tornado blasts through the center city, destroying buildings there and in all surrounding areas.";
        Policy1.text = "Force bee workers to work for longer hours and start rebuilding in the city first";
        Policy2.text = "Start rebuilding in surrounding areas first.";

        happinessChange1 = -3;
        lifeExpectancyChange1 = 0;
        honeyProductionChange1 = 5;
        beeRightsChange1 = -3;
        flowerDensityChange1 = 3;
        happiness1 = "-3";
        lifeExpectancy1 = "0";
        honeyProduction1 = "+5";
        beeRights1 = "-3";
        flowerDensity1 = "+3";

        happinessChange2 = 2;
        lifeExpectancyChange2 = 0;
        honeyProductionChange2 = -5;
        beeRightsChange2 = 2;
        flowerDensityChange2 = 1;
        happiness2 = "+2";
        lifeExpectancy2 = "0";
        honeyProduction2 = "+3";
        beeRights2 = "+3";
        flowerDensity2 = "-2";
        }
    void Hot(){
        Incident.text = "An extremely hot day strikes all the island.";
        Policy1.text = "Give the workers the day off.";
        Policy2.text = "Keep everything unchanged and make them work anyway";

        happinessChange1 = 5;
        lifeExpectancyChange1 = 1;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 3;
        flowerDensityChange1 = -2;
        happiness1 = "+5";
        lifeExpectancy1 = "+1";
        honeyProduction1 = "-3";
        beeRights1 = "+3";
        flowerDensity1 = "-2";

        happinessChange2 = -3;
        lifeExpectancyChange2 = -1;
        honeyProductionChange2 = 5;
        beeRightsChange2 = -2;
        flowerDensityChange2 = 2;
        happiness2 = "-3";
        lifeExpectancy2 = "-1";
        honeyProduction2 = "+5";
        beeRights2 = "-2";
        flowerDensity2 = "+2";
      }
    void Worker(){
        Incident.text = "A worker bee approaches you saying, 'we want lunch breaks and longer vacations!'";
        Policy1.text = "Give them the lunch breaks and vacations.";
        Policy2.text = "Ignore him and work away.";

        happinessChange1 = 5;
        lifeExpectancyChange1 = 1;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 3;
        flowerDensityChange1 = -2;
        happiness1 = "+5";
        lifeExpectancy1 = "+1";
        honeyProduction1 = "-3";
        beeRights1 = "+3";
        flowerDensity1 = "-2";


        happinessChange2 = -5;
        lifeExpectancyChange2 = -1;
        honeyProductionChange2 = +3;
        beeRightsChange2 = -3;
        flowerDensityChange2 = 2;
        happiness2 = "-5";
        lifeExpectancy2 = "-1";
        honeyProduction2 = "+3";
        beeRights2 = "-3";
        flowerDensity2 = "+2";
      }
    void Hire(){
        Incident.text = "Southern honeycombs are struggling to hire enough workers.";
        Policy1.text = "Increase the wage rate in sounthern main cities.";
        Policy2.text = "Try to invent better machines for honey factories.";

        happinessChange1 = 3;
        lifeExpectancyChange1 = 0;
        honeyProductionChange1 = 3;
        beeRightsChange1 = 1;
        flowerDensityChange1 = 1;
        happiness1 = "+3";
        lifeExpectancy1 = "0";
        honeyProduction1 = "3";
        beeRights1 = "1";
        flowerDensity1 = "1";

        happinessChange2 = 5;
        lifeExpectancyChange2 = 0;
        honeyProductionChange2 = -3;
        beeRightsChange2 = 1;
        flowerDensityChange2 = 3;
        happiness2 = "+5";
        lifeExpectancy2 = "0";
        honeyProduction2 = "-3";
        beeRights2 = "+1";
        flowerDensity2 = "+3";
      }
    void Influenza(){
        Incident.text = "Influenza is spreading across the entire island. The healthcare system is not well established to take care of all of the bees.";
        Policy1.text = "Increase spending on healthcare resources and sacrifice some spending on new honey factories";
        Policy2.text = "Keep same spending and risk further disease spreading";

        happinessChange1 = 2;
        lifeExpectancyChange1 = -3;
        honeyProductionChange1 = -5;
        beeRightsChange1 = 2;
        flowerDensityChange1 = -3;
        happiness1 = "+2";
        lifeExpectancy1 = "-3";
        honeyProduction1 = "-5";
        beeRights1 = "+2";
        flowerDensity1 = "-3";

        happinessChange2 = -2;
        lifeExpectancyChange2 = -3;
        honeyProductionChange2 = 3;
        beeRightsChange2 = -2;
        flowerDensityChange2 = 3;
        happiness2 = "-2";
        lifeExpectancy2 = "-3";
        honeyProduction2 = "+3";
        beeRights2 = "-2";
        flowerDensity2 = "+3";
      }
    void Poverty(){
        Incident.text = "Some honeycombs on the island are struggling to produce honey and many bees are dropping below the poverty line.";
        Policy1.text = "Provide food stamps and a housing stipend for the bees in poverty";
        Policy2.text = "Send flower seeds and fertilization supplies";

        happinessChange1 = 4;
        lifeExpectancyChange1 = 0;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 4;
        flowerDensityChange1 = -3;
        happiness1 = "+4";
        lifeExpectancy1 = "0";
        honeyProduction1 = "-3";
        beeRights1 = "+4";
        flowerDensity1 = "-3";

        happinessChange2 = 2;
        lifeExpectancyChange2 = 0;
        honeyProductionChange2 = -1;
        beeRightsChange2 = 2;
        flowerDensityChange2 = -1;
        happiness2 = "+2";
        lifeExpectancy2 = "0";
        honeyProduction2 = "-1";
        beeRights2 = "+2";
        flowerDensity2 = "-1";
      }
    void Skip(){
        Incident.text = "Inner city factories are struggling to keep workers from skipping work.";
        Policy1.text = "Fire workers who skipped work and hire new workers.";
        Policy2.text = "Decrese the salary of workers who skipped work.";

        happinessChange1 = -5;
        lifeExpectancyChange1 = 0;
        honeyProductionChange1 = -1;
        beeRightsChange1 = -3;
        flowerDensityChange1 = -1;
        happiness1 = "-5";
        lifeExpectancy1 = "0";
        honeyProduction1 = "-1";
        beeRights1 = "-3";
        flowerDensity1 = "-1";

        happinessChange2 = -2;
        lifeExpectancyChange2 = 0;
        honeyProductionChange2 = -3;
        beeRightsChange2 = -2;
        flowerDensityChange2 = -2;
        happiness2 = "-2";
        lifeExpectancy2 = "0";
        honeyProduction2 = "-3";
        beeRights2 = "-2";
        flowerDensity2 = "-2";
      }

    public void Policy1ChooseResult(){
        Map_Behavior.happiness += happinessChange1;
        Map_Behavior.lifeExpectancy += lifeExpectancyChange1;
        Map_Behavior.honeyProduction += honeyProductionChange1;
        Map_Behavior.beeRights += beeRightsChange1;
        Map_Behavior.flowerDensity += flowerDensityChange1;
        News.text = "Happiness: " + happiness1 + System.Environment.NewLine +
        "Life Expectancy: " + lifeExpectancy1 + System.Environment.NewLine +
        "Honey Production: " + honeyProduction1 + System.Environment.NewLine +
        "Bee Rights: " + beeRights1 + System.Environment.NewLine +
        "Flower Density: " + flowerDensity1;



        }
    public void Policy2ChooseResult(){
        Map_Behavior.happiness += happinessChange2;
        Map_Behavior.lifeExpectancy += lifeExpectancyChange2;
        Map_Behavior.honeyProduction += honeyProductionChange2;
        Map_Behavior.beeRights += beeRightsChange2;
        Map_Behavior.flowerDensity += flowerDensityChange2;
        News.text = "Happiness: " + happiness2 + System.Environment.NewLine +
        "Life Expectancy: " + lifeExpectancy2 + System.Environment.NewLine +
        "Honey Production: " + honeyProduction2 + System.Environment.NewLine +
        "Bee Rights: " + beeRights2 + System.Environment.NewLine +
        "Flower Density: " + flowerDensity2;
        }

    private delegate void RandomFunction();
    public void GenerateRandomEvent(){
        List<RandomFunction> FunctionList = new List<RandomFunction>();

        FunctionList.Add(Rainstorm);
        FunctionList.Add(ForestFire);
        FunctionList.Add(Hurricane);
        FunctionList.Add(Drought);
        FunctionList.Add(Tornado);
        FunctionList.Add(Hot);
        FunctionList.Add(Worker);
        FunctionList.Add(Hire);
        FunctionList.Add(Influenza);
        FunctionList.Add(Poverty);
        FunctionList.Add(Skip);

        FunctionList[Random.Range(0, FunctionList.Count)]();
    }
    }
