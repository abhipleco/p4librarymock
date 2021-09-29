using System;
using System.Collections.Generic;

namespace EA.WorkspaceManager.p4library
{
    public class getworkspacedetail
    {
        public static void Main(string[] args)
        {
            string p4instancename = args[0];
            //var workspacedetail = new List<(string instancename, string wsname, string owner, string time, string filelock)>;
       
            var workspacelist = new List<(string instancename,string wsname,string owner,string time,string filelock )>
            {
                ("gdas.p4one.ea.com:1666","abetz_ORL2-ABETZ-R_7915","abetz","2021/05/26 15:51:57","N"),
                ("gdas.p4one.ea.com:1666", "abetz_ORL2-ABETZ-R_8325","abetz","2021 /05/06 13:50:57","Y"),
                ("gdas.p4one.ea.com:1666", "abetz_ORL2-ABETZ-R_MODIv2_dev","abetz", "2020 /09/22 13:34:40","N"),
                ("gdas.p4one.ea.com:1666", "abetz_ORL2-ABETZ-R_Service911","abetz", "2021 /09/07 20:34:09","N"),
                ("gdas.p4one.ea.com:1666", "abetz_ORL2-ABETZ-R_Webapps","abetz", "2021 /07/28 19:49:59","N"),
                ("gdas.p4one.ea.com:1666", "AdobeRequests","afrangulea", "2020 /10/15 10:15:43","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_AFJAASVm_4086","afrangulea", "2021 /01/22 13:04:53","Y"),
                ("gdas.p4one.ea.com:1666", "afrangulea_AFJAASVm_4966","afrangulea", "2021 /01/19 08:40:26","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_AFJAASVm_6589","afrangulea", "2021 /01/19 08:40:20","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_AFJAASVm_6879","afrangulea", "2021 /04/06 08:03:23","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_AFJAASVm_newdev","afrangulea", "2020 /04/28 09:30:26","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_1014","afrangulea", "2021 /06/03 12:25:44","Y"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_1309","afrangulea", "2021 /06/03 12:36:02","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_1423","afrangulea", "2021 /05/05 09:52:44","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_1935","afrangulea", "2021 /04/06 07:56:30","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_2003","afrangulea", "2021 /06/30 10:54:06","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_7354","afrangulea", "2021 /09/23 08:13:44","Y"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_8833","afrangulea", "2020 /10/13 10:05:02","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_9147","afrangulea", "2020 /08/14 12:11:45","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_Jukb7d1e81Vm_9179","afrangulea", "2021 /02/19 12:00:32","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_PerfOne","afrangulea", "2021 /09/07 08:04:44","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_RO-3046820-W8_HAL35_Dev_2927","afrangulea", "2020 /08/05 07:57:45","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_RO-36505551_5247","afrangulea", "2020 /08/05 08:21:46","N"),
                ("gdas.p4one.ea.com:1666", "afrangulea_RO-36505551_5771","afrangulea", "2020 /08/05 07:59:25","N"),
                ("gdas.p4one.ea.com:1666", "ahung_P4One","ahung", "2020 /08/21 00:46:43","N"),
                ("gdas.p4one.ea.com:1666", "avichare_Per774ce48Vm_p4one_pleco_6314","avichare", "2021 /09/23 15:32:52","N")
             };





        }



    }
}
