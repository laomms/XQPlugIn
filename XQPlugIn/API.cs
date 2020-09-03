using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XQPlugIn
{
    public static class API
    {
        #region 动态引用API接口
        public const string DllName = "xqapi.dll";

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool SetDllDirectory(string lpPathName);



        [DllImport(DllName)]
        public static extern int Api_SendMsg([MarshalAs(UnmanagedType.LPStr)]  string botQQ, int msgType, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string QQ, [MarshalAs(UnmanagedType.LPStr)]  string content, int bubbleId);
        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_OutPutLog([MarshalAs(UnmanagedType.LPStr)]  string content);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetNick([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string QQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetGroupAdmin([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetGroupCard([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string QQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetGroupList([MarshalAs(UnmanagedType.LPStr)]  string botQQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetGroupList_B([MarshalAs(UnmanagedType.LPStr)]  string botQQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetGroupName([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetFriendList([MarshalAs(UnmanagedType.LPStr)]  string botQQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetFriendList_B([MarshalAs(UnmanagedType.LPStr)]  string botQQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetFriendsRemark([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string QQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetGroupMemberList([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetGroupMemberList_B([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetGroupMemberList_C([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_HandleGroupEvent([MarshalAs(UnmanagedType.LPStr)]  string botQQ, int reqType, [MarshalAs(UnmanagedType.LPStr)]  string QQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string seq, int rspType, [MarshalAs(UnmanagedType.LPStr)]  string msg);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_HandleFriendEvent([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string QQ, int rspType, [MarshalAs(UnmanagedType.LPStr)]  string msg);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_QuitGroup([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetGroupMemberNum([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId);

        [DllImport(DllName)]
        public static extern Boolean Api_SetAnon([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, Boolean enable);
        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_ShutUP([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string QQ, int duration);
        [DllImport(DllName)]
        public static extern Boolean Api_SetGroupCard([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string QQ, [MarshalAs(UnmanagedType.LPStr)]  string card);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_KickGroupMBR([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string QQ, bool refuseForever);
        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_UpVote([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string QQ);

        [DllImport(DllName)]
        public static extern Boolean Api_IsEnable();

        [DllImport(DllName)]
        public static extern string Api_GetOnLineList();

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_UpLoadPic([MarshalAs(UnmanagedType.LPStr)]  string botQQ, int uploadType, [MarshalAs(UnmanagedType.LPStr)]  string targetId, [MarshalAs(UnmanagedType.LPStr)]  string image);

        [DllImport(DllName)]
        public static extern Boolean Api_IfFriend([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string QQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetCookies([MarshalAs(UnmanagedType.LPStr)]  string botQQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetBkn([MarshalAs(UnmanagedType.LPStr)]  string botQQ);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_GetVoiLink([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string GUID);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern   string Api_WithdrawMsg([MarshalAs(UnmanagedType.LPStr)]  string botQQ, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string msgNum, [MarshalAs(UnmanagedType.LPStr)]  string msgId);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_GetPicLink([MarshalAs(UnmanagedType.LPStr)]  string botQQ, int picType, [MarshalAs(UnmanagedType.LPStr)]  string sourceId, [MarshalAs(UnmanagedType.LPStr)]  string GUID);

        [DllImport(DllName)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static extern  string Api_SendXML([MarshalAs(UnmanagedType.LPStr)]  string botQQ, int sendType, int msgType, [MarshalAs(UnmanagedType.LPStr)]  string groupId, [MarshalAs(UnmanagedType.LPStr)]  string QQ, [MarshalAs(UnmanagedType.LPStr)]  string objectMsg, int subType);
    }
}
#endregion 
