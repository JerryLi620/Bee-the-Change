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
    private string News1 = "";
    private string News2 = "";



    void Rainstorm(){
        Incident.text = "A rainstorm is expected to last for an unknown number of days, flooding the western side of the honeycomb.";

        Policy1.text = "Keep everything unchanged and hope it passes quickly";
        happinessChange1 = -5;
        lifeExpectancyChange1 = -3;
        honeyProductionChange1 = 3;
        flowerDensityChange1 = 3;
        News1 = "The rainstorm lasted for four days, devastating the lives of affected bees. Flowers in the surrounding area are thriving after the heavy rains.";

        Policy2.text = "Shutdown honey factories and prepare relief materials and sufficient food for the honeycombs";
        happinessChange2 = 5;
        lifeExpectancyChange2 = 3;
        honeyProductionChange2 = -5;
        flowerDensityChange2 = 3;
        News2 = "The rainstorm lasted for four days. Because of good planning, most of the damage was mitigated. Flowers in the surrounding area are thriving after the heavy rains.";
        }
    void ForestFire(){
        Incident.text = "A forest fire is spreading across the honeycomb, destroying flowers and trees rapidly.";


        Policy1.text = "Focus fire department on mitigating damage to urban areas";
        happinessChange1 = 5;
        lifeExpectancyChange1 = 5;
        honeyProductionChange1 = -3;
        flowerDensityChange1 = -5;
        News1 = "Many lives were saved by deploying the fire department to urban areas. However, the surrounding population of flowers has been ravaged";

        Policy2.text = "Focus fire department on mitigating damage to forest";
        happinessChange2 = -5;
        lifeExpectancyChange2 = -5;
        honeyProductionChange2 = 3;
        flowerDensityChange2 = 5;
        News2 = "The fire departments protection saved the flower forest! The fire ravaged through the center of the hive, destroying many homes. Local bees are not happy.";
        }
    void Hurricane(){
        Incident.text = "A hurricane is projected to hit the coast of the honeycomb within the next two days.";
        Policy1.text = "Require evacuation for everyone in the area and send emergency services after the fact.";
        lifeExpectancyChange1 = 5;
        beeRightsChange1 = -3;
        honeyProductionChange2 = -3;
        flowerDensityChange1 = -2;
        News1 = "Bee activists are protesting the forced evacuation.";

        Policy2.text = "Encourage evacuation for everyone in the area, continuing honey production through the hurricane.";
        lifeExpectancyChange2 = -3;
        honeyProductionChange2 = 3;
        flowerDensityChange2 = -2;
        News2 = "The devastating hurricane caused many bees lives to be lost.";

        }
    void Drought(){
        Incident.text = "There is a drought across the northern half of the island, leaving many bees struggling to continue honey production.";
        Policy1.text = "Try to end the drought with artificial rainfall.";
        honeyProductionChange1 = 3;
        flowerDensityChange1 = 5;
        lifeExpectancyChange1 = -3;
        News1 = "Untested chemicals in the artifical rainfall have caused a mysterious illness among the bees.";

        Policy2.text = "Prepare relief materials and sufficient food for the honeycombs.";
        lifeExpectancyChange2 = 5;
        happinessChange2 = 3;
        flowerDensityChange2 = -3;
        News2 = "It took only five days for the rain to come. However, flowers everywhere are feeling the effects of the drought still.";
        }
    void Tornado(){
        Incident.text = "A tornado blasts through the center city, destroying buildings there and in all surrounding areas.";


        Policy1.text = "Force bee workers to work for longer hours and start rebuilding in the city first.";
        happinessChange1 = -3;
        honeyProductionChange1 = 5;
        beeRightsChange1 = -5;
        flowerDensityChange1 = 3;
        News1 = "Bees are unhappy with unfit working conditions. Rumors of a bee worker union can be heard all across the hive.";

        Policy2.text = "Start rebuilding in surrounding areas first.";
        happinessChange2 = 2;
        honeyProductionChange2 = -5;
        beeRightsChange2 = 2;
        News2 = "The worker bees are happy with their working conditions. Honey production has taken a big hit.";
        }
    void Hot(){
        Incident.text = "An extremely hot day strikes all the island.";

        Policy2.text = "Keep everything unchanged and make them work anyway";

        Policy1.text = "Give the workers the day off.";
        happinessChange1 = 5;
        lifeExpectancyChange1 = 1;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 3;
        News1 = "A fiesta across the island is held in your name.";

        Policy2.text = "Keep everything unchanged and make them work anyway";
        happinessChange2 = -3;
        lifeExpectancyChange2 = -1;
        honeyProductionChange2 = 5;
        beeRightsChange2 = -2;
        News2 = "Bees are very unhappy.";

      }
    void Worker(){
        Incident.text = "A worker bee approaches you saying, 'we want lunch breaks and longer vacations!'";
        Policy1.text = "Give them the lunch breaks and vacations.";
        Policy2.text = "Ignore him and walk away.";

        happinessChange1 = 5;
        lifeExpectancyChange1 = 1;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 3;
        News1 = "Bees everywhere rejoice their new workers rights";

        happinessChange2 = -3;
        lifeExpectancyChange2 = -1;
        honeyProductionChange2 = 5;
        beeRightsChange2 = -2;
        News2 = "Worker bees are very sad with their working condtitions";

      }
    void Hire(){
        Incident.text = "Southern honeycombs are struggling to hire enough workers.";
        Policy1.text = "Increase the wage rate in southern main cities.";
        Policy2.text = "Try to invent better machines for honey factories.";

        happinessChange1 = 5;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 1;
        News1 = "Workers flock to the honey pumps!";

        lifeExpectancyChange2 = -3;
        honeyProductionChange2 = -5;
        News2 = "The new untested machines malfunction injure the workers.";


      }
    void Influenza(){
        Incident.text = "Influenza is spreading across the entire island. The healthcare system is not well established to take care of all of the bees.";
        Policy1.text = "Increase spending on healthcare resources and sacrifice some spending on new honey factories";
        Policy2.text = "Keep same spending and risk further disease spreading";

        happinessChange1 = 2;
        lifeExpectancyChange1 = 3;
        honeyProductionChange1 = -5;
        beeRightsChange1 = 2;
        News1 = "The hive quickly overcomes the Influenza crisis";
        happinessChange2 = -2;
        lifeExpectancyChange2 = -3;
        honeyProductionChange2 = -3;
        beeRightsChange2 = -2;
        News2 = "Many bees die and hospitals are overwhelmed";


      }
    void Poverty(){
        Incident.text = "Some honeycombs on the island are struggling to produce honey and many bees are dropping below the poverty line.";
        Policy1.text = "Provide honey stamps and a housing stipend for the bees in poverty";
        Policy2.text = "Send flower seeds and fertilization supplies";

        happinessChange1 = 4;
        honeyProductionChange1 = -3;
        beeRightsChange1 = 4;
        flowerDensityChange1 = -3;
        News1="Poverty is halved through your generosity";


        happinessChange2 = -3;
        lifeExpectancyChange2 = -1;
        honeyProductionChange2 = 3;
        flowerDensityChange2 = 5;
        News2="More and more bees find themselves experiencing poverty. Honey production is back up though!";

      }
    void Skip(){
        Incident.text = "Inner city factories are struggling to keep workers from skipping work.";
        Policy1.text = "Fire workers who skipped work and hire new workers.";
        Policy2.text = "Decrese the salary of workers who skipped work.";

        happinessChange1 = -5;
        honeyProductionChange1 = -1;
        beeRightsChange1 = -3;
        flowerDensityChange1 = -1;
        News1 = "There is a shortage of workers at the factories. Bees are unhappy with working conditions.";



        happinessChange2 = -2;
        lifeExpectancyChange2 = 0;
        honeyProductionChange2 = 3;
        flowerDensityChange2 = 2;
        News2 = "Less workers are skipping work and honey production is up!";

      }

    public void Policy1ChooseResult(){
        Map_Behavior.happiness += happinessChange1;
        Map_Behavior.lifeExpectancy += lifeExpectancyChange1;
        Map_Behavior.honeyProduction += honeyProductionChange1;
        Map_Behavior.beeRights += beeRightsChange1;
        Map_Behavior.flowerDensity += flowerDensityChange1;
        News.text = ""+News1;



        }
    public void Policy2ChooseResult(){
        Map_Behavior.happiness += happinessChange2;
        Map_Behavior.lifeExpectancy += lifeExpectancyChange2;
        Map_Behavior.honeyProduction += honeyProductionChange2;
        Map_Behavior.beeRights += beeRightsChange2;
        Map_Behavior.flowerDensity += flowerDensityChange2;
        News.text = ""+ News2;
        }

    public delegate void RandomFunction();
    public List<RandomFunction> FunctionList = new List<RandomFunction>();
    private static List<int> UsedNumbers = new List<int>();

    public void SetUpEvents()
    {
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
    }

    public void GenerateRandomEvent(){

        int number = Random.Range(0, FunctionList.Count);

        while(UsedNumbers.Contains(number))
        {
            number = Random.Range(0, FunctionList.Count);
        }
        UsedNumbers.Add(number);
        print(FunctionList.Count);
        FunctionList[number]();
    }
    }
