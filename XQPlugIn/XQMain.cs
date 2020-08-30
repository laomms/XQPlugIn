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
        public static string sendPrivateMsg(string botQQ, int msgType, string sendQQ, string msg)
        {
            try
            {
                int res= API.Api_SendMsg(Marshal.StringToHGlobalAnsi(botQQ), msgType, IntPtr.Zero, Marshal.StringToHGlobalAnsi(sendQQ), Marshal.StringToHGlobalAnsi(msg), 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
            return "";
        }
    }
}