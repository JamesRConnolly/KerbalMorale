using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KerbalMorale
{
    public class KerbalMoraleModule : PartModule
    {
        [KSPField(guiActive = true)]
        int totalCrewCapacity = 0;
        [KSPField(guiActive = true)]
        int simpleCrewCapacity = 0;
        [KSPField(guiActive = true)]
        int partNumber = 0;
        public override void OnAwake()
        {

        }

        public override void OnLoad(ConfigNode configNode)
        {
        }
        
        public override void OnSave(ConfigNode configNode)
        {
        }
        
        public override void OnStart(PartModule.StartState startState)
        {

            base.OnStart(startState);
        }
        
        public override void OnUpdate()
        {
            partNumber = 0;
            foreach (Part cap in part.vessel.Parts)
            {
                totalCrewCapacity = totalCrewCapacity + GetCrewCapacity(cap);
                partNumber++;
            }
            simpleCrewCapacity = part.vessel.GetCrewCapacity();
        }
        
        public override void OnActive()
        {
        }

        int GetCrewCapacity(Part thisPart)
        {
            return thisPart.CrewCapacity;
        }
    }
}
