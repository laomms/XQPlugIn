using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls.Expressions;

namespace XQPlugIn
{
    class ExportAPI
    {
        public enum subType
        {
            XQ_StartupComplete = 10000,
            XQ_Exit = 10001,
            XQ_Load = 12000,
            XQ_Enable = 12001,
            XQ_Disable = 12002,
            XQ_FriendMsgEvent = 1,
            XQ_GroupMsgEvent = 2,
            XQ_DiscussMsgEvent = 2,
            XQ_GroupTmpMsgEvent = 4,
            XQ_DiscussTmpMsgEvent = 2,
            XQ_FriendAddReqEvent = 101,
            XQ_FriendAddedEvent = 100,
            XQ_GroupInviteReqEvent = 214,
            XQ_GroupAddReqEvent = 213,
            XQ_GroupInviteOtherReqEvent = 215,
            XQ_GroupMemberIncreaseByApply = 212,
            XQ_GroupMemberIncreaseByInvite = 219,
            XQ_GroupMemberDecreaseByExit = 201,
            XQ_GroupMemberDecreaseByKick = 202,
            XQ_GroupBanEvent = 203,
            XQ_GroupUnbanEvent = 204,
            XQ_GroupWholeBanEvent = 205,
            XQ_GroupWholeUnbanEvent = 206,
            XQ_GroupAdminSet = 210,
            XQ_GroupAdminUnset = 211,
            XQ_LogInComplete =1101,
            XQ_groupCardChange =217
        }

        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static int XQ_Event(string botQQ, int eventType, int extraType, string sourceId, string activeQQ, string passiveQQ, string msg, string msgNum, string msgId, IntPtr rawMsg, string timeStamp, string retText)

        {
            try
            {
                if (eventType == (int)subType.XQ_Load)
                {
                  
                }
                else if (eventType == (int)subType.XQ_Exit)
                {
                   
                }

                else if (eventType == (int)subType.XQ_Enable)
                {
                    string dllpath = System.Environment.CurrentDirectory + "\\bin\\xqapi.dll";
                    API.SetDllDirectory(dllpath);
                    string onlineList = API.Api_GetOnLineList();
                   
                }

                else if (eventType == (int)subType.XQ_Disable)
                {
                  
                }
                else if (eventType == (int)subType.XQ_GroupInviteReqEvent)
                {
                   
                }

                else if (eventType == (int)subType.XQ_GroupAddReqEvent)
                {
                   
                }
                else if (eventType == (int)subType.XQ_GroupInviteOtherReqEvent)
                {
                   
                }
                else if (eventType == (int)subType.XQ_FriendAddReqEvent)
                {

                }
                else if (eventType == (int)subType.XQ_GroupBanEvent)
                {

                }
                else if (eventType == (int)subType.XQ_GroupUnbanEvent)
                {

                }
                else if (eventType == (int)subType.XQ_GroupWholeBanEvent)
                {

                }
                else if (eventType == (int)subType.XQ_GroupWholeUnbanEvent)
                {

                }
                else if (eventType == (int)subType.XQ_GroupMemberIncreaseByApply)
                {

                }
                else if (eventType == (int)subType.XQ_GroupMemberIncreaseByInvite)
                {

                }
                else if (eventType == (int)subType.XQ_GroupMemberDecreaseByExit)
                {

                }
                else if (eventType == (int)subType.XQ_GroupMemberDecreaseByKick)
                {

                }
                else if (eventType == (int)subType.XQ_GroupAdminSet)
                {

                }
                else if (eventType == (int)subType.XQ_GroupAdminUnset)
                {

                }
                else if (eventType == (int)subType.XQ_FriendAddedEvent)
                {

                }
                else if (eventType == (int)subType.XQ_groupCardChange)
                {

                }
                else if (eventType == (int)subType.XQ_FriendMsgEvent)
                {
                    string szMsg = activeQQ + "发送了这样的消息:" + msg;
                    XQMain.sendPrivateMsg(botQQ, eventType, activeQQ, szMsg);

                }
                else if (eventType == (int)subType.XQ_GroupTmpMsgEvent)
                {

                }
                else if (eventType == (int)subType.XQ_GroupMsgEvent)
                {
                    string szMsg = activeQQ + "发送了这样的消息:" + msg;
                    if (activeQQ != botQQ) 
                        XQMain.sendGroupMsg(botQQ, eventType, sourceId, activeQQ, szMsg);
                }
                else if (eventType == (int)subType.XQ_DiscussTmpMsgEvent)
                {

                }
                else if (eventType == (int)subType.XQ_DiscussMsgEvent)
                {

                }
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }


        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static string XQ_Create(string frameworkVersion)
        {
            return "{\"name\":\"XQPlugIn\", \"pver\":\"1.0\", \"sver\":1, \"author\":\"XXX\", \"desc\":\"A simple plugin for XQ\"}";
        }
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static int XQ_DestroyPlugin()
        {          
            return 0;
        }
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static int XQ_SetUp()
        {           
            return 0;
        }
    }
}
