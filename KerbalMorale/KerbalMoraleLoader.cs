using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace KerbalMorale
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    class KerbalMoraleLoader : MonoBehaviour
    {
        [KSPField(guiActive = true)]
        int totalCrewCapacity = 0;
        [KSPField(guiActive = true)]
        int simpleCrewCapacity = 0;
        [KSPField(guiActive = true)]
        int partNumber = 0;
        void Awake()
        {
            partNumber = 0;
            foreach (Part cap in ActiveVessel{get;}.Parts)
            {
                totalCrewCapacity = totalCrewCapacity + GetCrewCapacity(cap);
                partNumber++;
            }
            simpleCrewCapacity = ActiveVessel{get;}.GetCrewCapacity();
        }

        void OnGui()
        {
            GUI.Window(GetInstanceID(), new Rect(5f, 40f, 500f, 400f), DrawGUI, "Window");
        }
        void DrawGui(int WindowsID)
        {
            String stringToLoad = "ayup";
            int numberToLoad = 6;
            GUILayout.BeginVertical();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("stringToLoad: ");
            stringToLoad = GUILayout.TextField(stringToLoad);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("numberToLoad: " + numberToLoad.ToString());
            numberToLoad = (int)GUILayout.HorizontalSlider((float)numberToLoad, 0f, 100f);
            GUILayout.EndHorizontal();

            GUILayout.EndVertical();

        }

    }

}
