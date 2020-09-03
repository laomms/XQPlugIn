using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static XQPlugIn.API;

namespace XQPlugIn
{
    public class XQMain
    {
        public static string sendPrivateMsg( string botQQ, int msgType,  string sendQQ,  string msg)
        {
            try
            {
                int res= API.Api_SendMsg(botQQ, msgType, null, sendQQ, msg, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
            return "";
        }

        public static string sendGroupMsg(string botQQ, int msgType, string groupid, string sendqq, string msg)
        {
            try
            {
                int res = API.Api_SendMsg(botQQ, msgType, groupid, sendqq, msg, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return "";
        }
    }
}