using System;
using System.Collections.Generic;
using System.Linq;

namespace EA.WorkspaceManager.p4library
{
    public class WorkpacesDetails
    {
        public static List<Workspace> getWorkpacesDetails(string p4instancename)
        {
            //Accept p4instancename as argument 

            var workspacelist = new List<Workspace>
            {
                new Workspace { Instancename = "gdas.p4one.ea.com:1666", Wsname = "abetz_ORL2-ABETZ-R_7915", Owner = "abetz", Time = "2021/05/26 15:51:57",Filelock = "N" }


             };

            //return Mock data for workspace
            return workspacelist;
        }
    }
}
