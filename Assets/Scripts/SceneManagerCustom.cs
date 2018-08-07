using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerCustom : MonoBehaviour {
    public GameObject AreaGearCarrierOutObject;
    public GameObject AreaGearCarrierInObject;
    public GameObject AreaHandleObject;
    public GameObject AreaHandleEndObject;
    public GameObject AreaLidObject;
    public GameObject AreaPlanetObject;
    public GameObject AreaRingObject;
    public GameObject AreaShaftOutObject;

    public GameObject AreaCarrierObject;
    public GameObject AreaCarrierShaftObject;
    public GameObject AreaCarrierOutObject;

    public GameObject Build1Object;
    public GameObject Build2Object;
    public GameObject Build3Object;
    public GameObject Build4Object;
    public GameObject Build5Object;
    public GameObject Build6Object;
    public GameObject Build7Object;
    public GameObject Build8Object;

    public GameObject BuildText;

    public Text txt;

    public Color red;
    public Color green;
    public Color blue;
    public Color transparent;

    public int stepNumber;

    // Use this for initialization
    void Start () {

        // asign objects
        AreaGearCarrierOutObject = GameObject.Find("AreaGearCarrierOut");
        AreaGearCarrierInObject = GameObject.Find("AreaGearCarrierIn");
        AreaHandleObject = GameObject.Find("AreaHandle");
        AreaHandleEndObject = GameObject.Find("AreaHandleEnd");
        AreaLidObject = GameObject.Find("AreaLid");
        AreaPlanetObject = GameObject.Find("AreaPlanet");
        AreaRingObject = GameObject.Find("AreaRing");
        AreaShaftOutObject = GameObject.Find("AreaShaftOut");
        AreaCarrierObject = GameObject.Find("AreaCarrier");
        AreaCarrierShaftObject = GameObject.Find("AreaCarrierShaft");
        AreaCarrierOutObject = GameObject.Find("AreaCarrierOut");

        Build1Object = GameObject.Find("Build1");
        Build2Object = GameObject.Find("Build2");
        Build3Object = GameObject.Find("Build3");
        Build4Object = GameObject.Find("Build4");
        Build5Object = GameObject.Find("Build5");
        Build6Object = GameObject.Find("Build6");
        Build7Object = GameObject.Find("Build7");
        Build8Object = GameObject.Find("Build8");

        BuildText = GameObject.Find("Instructions");
        txt = BuildText.GetComponent<Text>();

        transparent = AreaGearCarrierOutObject.GetComponent<Renderer>().material.color;
        transparent.a = 0.0f;
 
        red = Color.red;
        red.a = 0.35f;

        green = Color.green;
        green.a = 0.35f;

        blue = Color.blue;
        blue.a = 0.35f;

        //Make Areas transparent
        //AreaGearCarrierOutObject.GetComponent<Renderer>().material.color = transparent;
        // AreaGearCarrierInObject.GetComponent<Renderer>().material.color = transparent;
        // AreaHandleObject.GetComponent<Renderer>().material.color = transparent;
        //AreaHandleEndObject.GetComponent<Renderer>().material.color = transparent;
        //AreaLidObject.GetComponent<Renderer>().material.color = transparent;
        // AreaPlanetObject.GetComponent<Renderer>().material.color = transparent;
        //AreaRingObject.GetComponent<Renderer>().material.color = transparent;
        //AreaShaftOutObject.GetComponent<Renderer>().material.color = transparent;

        // AreaCarrierObject.GetComponent<Renderer>().material.color = transparent;
        //AreaCarrierShaftObject.GetComponent<Renderer>().material.color = transparent;
        //AreaCarrierOutObject.GetComponent<Renderer>().material.color = transparent;

        Build1Object.SetActive(false);
        Build2Object.SetActive(false);
        Build3Object.SetActive(false);
        Build4Object.SetActive(false);
        Build5Object.SetActive(false);
        Build6Object.SetActive(false);
        Build7Object.SetActive(false);
        Build8Object.SetActive(false);

        txt.text = "";

        stepNumber = -1;

    }

    // Update is called once per frame

    public void restart()
    {
        stepNumber = -1;
        AreaGearCarrierOutObject.GetComponent<Renderer>().material.color = transparent;
        AreaGearCarrierInObject.GetComponent<Renderer>().material.color = transparent;
        AreaHandleObject.GetComponent<Renderer>().material.color = transparent;
        AreaHandleEndObject.GetComponent<Renderer>().material.color = transparent;
        AreaLidObject.GetComponent<Renderer>().material.color = transparent;
        AreaPlanetObject.GetComponent<Renderer>().material.color = transparent;
        AreaRingObject.GetComponent<Renderer>().material.color = transparent;
        AreaShaftOutObject.GetComponent<Renderer>().material.color = transparent;

        AreaCarrierObject.GetComponent<Renderer>().material.color = transparent;
        AreaCarrierShaftObject.GetComponent<Renderer>().material.color = transparent;
        AreaCarrierOutObject.GetComponent<Renderer>().material.color = transparent;

        Build1Object.SetActive(false);
        Build2Object.SetActive(false);
        Build3Object.SetActive(false);
        Build4Object.SetActive(false);
        Build5Object.SetActive(false);
        Build6Object.SetActive(false);
        Build7Object.SetActive(false);
        Build8Object.SetActive(false);

        txt.text = "";

    }

    public void nextStep()
    {
        stepNumber++;
        AreaGearCarrierOutObject.GetComponent<Renderer>().material.color = transparent;
        AreaGearCarrierInObject.GetComponent<Renderer>().material.color = transparent;
        AreaHandleObject.GetComponent<Renderer>().material.color = transparent;
        AreaHandleEndObject.GetComponent<Renderer>().material.color = transparent;
        AreaLidObject.GetComponent<Renderer>().material.color = transparent;
        AreaPlanetObject.GetComponent<Renderer>().material.color = transparent;
        AreaRingObject.GetComponent<Renderer>().material.color = transparent;
        AreaShaftOutObject.GetComponent<Renderer>().material.color = transparent;

        AreaCarrierObject.GetComponent<Renderer>().material.color = transparent;
        AreaCarrierShaftObject.GetComponent<Renderer>().material.color = transparent;
        AreaCarrierOutObject.GetComponent<Renderer>().material.color = transparent;

        Build1Object.SetActive(false);
        Build2Object.SetActive(false);
        Build3Object.SetActive(false);
        Build4Object.SetActive(false);
        Build5Object.SetActive(false);
        Build6Object.SetActive(false);
        Build7Object.SetActive(false);
        Build8Object.SetActive(false);

        txt.text = "";
    }

    public void previousStep()
    {
        stepNumber--;
        AreaGearCarrierOutObject.GetComponent<Renderer>().material.color = transparent;
        AreaGearCarrierInObject.GetComponent<Renderer>().material.color = transparent;
        AreaHandleObject.GetComponent<Renderer>().material.color = transparent;
        AreaHandleEndObject.GetComponent<Renderer>().material.color = transparent;
        AreaLidObject.GetComponent<Renderer>().material.color = transparent;
        AreaPlanetObject.GetComponent<Renderer>().material.color = transparent;
        AreaRingObject.GetComponent<Renderer>().material.color = transparent;
        AreaShaftOutObject.GetComponent<Renderer>().material.color = transparent;

        AreaCarrierObject.GetComponent<Renderer>().material.color = transparent;
        AreaCarrierShaftObject.GetComponent<Renderer>().material.color = transparent;
        AreaCarrierOutObject.GetComponent<Renderer>().material.color = transparent;

        Build1Object.SetActive(false);
        Build2Object.SetActive(false);
        Build3Object.SetActive(false);
        Build4Object.SetActive(false);
        Build5Object.SetActive(false);
        Build6Object.SetActive(false);
        Build7Object.SetActive(false);
        Build8Object.SetActive(false);

        txt.text = "";
    }

    void Update () {

        switch(stepNumber)
        {
            //restart
            case -1:
                txt.text = "Please assemble the gearbox based on the instruction provided. Green areas below indicate components necessary to complete the assembly step. Blue areas indicate areas were a component is placed after an assembly step.";
                break;

            //Planets on Carriers 3x
            case 0:
                AreaPlanetObject.GetComponent<Renderer>().material.color = green;
                AreaGearCarrierInObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierObject.GetComponent<Renderer>().material.color = blue;

                Build1Object.SetActive(true);

                txt.text = "Planets on carrier 1/3";

                break;

            case 1:
                AreaPlanetObject.GetComponent<Renderer>().material.color = green;
                AreaGearCarrierInObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierObject.GetComponent<Renderer>().material.color = blue;

                Build1Object.SetActive(true);

                txt.text = "Planets on carrier 2/3";
                break;

            case 2:
                AreaPlanetObject.GetComponent<Renderer>().material.color = green;
                AreaGearCarrierInObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierObject.GetComponent<Renderer>().material.color = blue;

                Build1Object.SetActive(true);

                txt.text = "Planets on carrier 3/3";
                break;

            //Carrier out on planets with carriers 2x
            case 3:
                AreaGearCarrierOutObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierOutObject.GetComponent<Renderer>().material.color = blue;

                Build2Object.SetActive(true);

                txt.text = "Axle on carrier 1/2";
                break;

            case 4:
                AreaGearCarrierOutObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierOutObject.GetComponent<Renderer>().material.color = blue;

                Build2Object.SetActive(true);

                txt.text = "Axle on carrier 2/2";
                break;

            //Shaft out on planets with carrier 1x
            case 5:
                AreaCarrierObject.GetComponent<Renderer>().material.color = green;
                AreaShaftOutObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierShaftObject.GetComponent<Renderer>().material.color = blue;

                Build3Object.SetActive(true);

                txt.text = "Axle out on carrier";
                break;

            // shaft out into ring
            case 6:
                AreaRingObject.GetComponent<Renderer>().material.color = green;
                AreaCarrierShaftObject.GetComponent<Renderer>().material.color = green;

                Build4Object.SetActive(true);

                txt.text = "Transmission stage out into ring gear. Align one planet gear with the slit in the ring gear so it can slide in easily.";
                break;

            // gear 2 and 3 into ring 2x
            case 7:
                AreaCarrierOutObject.GetComponent<Renderer>().material.color = green;

                Build5Object.SetActive(true);

                txt.text = "Transmission stage into ring gear 1/2. Align one planet gear with the slit in the ring gear so it can slide in easily.";
                break;

            case 8:
                AreaCarrierOutObject.GetComponent<Renderer>().material.color = green;

                Build5Object.SetActive(true);

                txt.text = "Transmission stage into ring gear 2/2. Align one planet gear with the slit in the ring gear so it can slide in easily.";
                break;

            //handle end shaft into ring
            case 9:
                AreaHandleEndObject.GetComponent<Renderer>().material.color = green;

                Build6Object.SetActive(true);

                txt.text = "Axle in into assembly";
                break;
            
            //lid onto ring
            case 10:
                AreaLidObject.GetComponent<Renderer>().material.color = green;

                Build7Object.SetActive(true);

                txt.text = "Lid on ring gear";
                break;

            // handle on handle end shaft
            case 11:
                AreaHandleObject.GetComponent<Renderer>().material.color = green;

                Build8Object.SetActive(true);

                txt.text = "Handle onto in axle";
                break;

            case 12:

                txt.text = "Thank you for participating. The assembly process is finished.";
                break;

        }

        // Find out whether current second is odd or even
        //bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;

        // Enable renderer accordingly
        // rendSphere.enabled = oddeven;
    }
}
