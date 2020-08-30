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

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] IntPtr lpFileName);

        [DllImport(DllName)]
        public static extern int Api_SendMsg(IntPtr botQQ, int msgType, IntPtr groupId, IntPtr QQ, IntPtr content, int bubbleId);
        [DllImport(DllName)]
        public static extern IntPtr Api_OutPutLog(IntPtr content);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetNick(IntPtr botQQ, IntPtr QQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupAdmin(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupCard(IntPtr botQQ, IntPtr groupId, IntPtr QQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupList(IntPtr botQQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupList_B(IntPtr botQQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupName(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetFriendList(IntPtr botQQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetFriendList_B(IntPtr botQQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetFriendsRemark(IntPtr botQQ, IntPtr QQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupMemberList(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupMemberList_B(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupMemberList_C(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern IntPtr Api_HandleGroupEvent(IntPtr botQQ, int reqType, IntPtr QQ, IntPtr groupId, IntPtr seq, int rspType, IntPtr msg);

        [DllImport(DllName)]
        public static extern IntPtr Api_HandleFriendEvent(IntPtr botQQ, IntPtr QQ, int rspType, IntPtr msg);

        [DllImport(DllName)]
        public static extern IntPtr Api_QuitGroup(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetGroupMemberNum(IntPtr botQQ, IntPtr groupId);

        [DllImport(DllName)]
        public static extern Boolean Api_SetAnon(IntPtr botQQ, IntPtr groupId, Boolean enable);
        [DllImport(DllName)]
        public static extern IntPtr Api_ShutUP(IntPtr botQQ, IntPtr groupId, IntPtr QQ, int duration);
        [DllImport(DllName)]
        public static extern Boolean Api_SetGroupCard(IntPtr botQQ, IntPtr groupId, IntPtr QQ, IntPtr card);

        [DllImport(DllName)]
        public static extern IntPtr Api_KickGroupMBR(IntPtr botQQ, IntPtr groupId, IntPtr QQ, bool refuseForever);
        [DllImport(DllName)]
        public static extern IntPtr Api_UpVote(IntPtr botQQ, IntPtr QQ);

        [DllImport(DllName)]
        public static extern Boolean Api_IsEnable();

        [DllImport(DllName)]
        public static extern string Api_GetOnLineList();

        [DllImport(DllName)]
        public static extern IntPtr Api_UpLoadPic(IntPtr botQQ, int uploadType, IntPtr targetId, IntPtr image);

        [DllImport(DllName)]
        public static extern Boolean Api_IfFriend(IntPtr botQQ, IntPtr QQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetCookies(IntPtr botQQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetBkn(IntPtr botQQ);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetVoiLink(IntPtr botQQ, IntPtr GUID);

        [DllImport(DllName)]
        public static extern IntPtr Api_WithdrawMsg(IntPtr botQQ, IntPtr groupId, IntPtr msgNum, IntPtr msgId);

        [DllImport(DllName)]
        public static extern IntPtr Api_GetPicLink(IntPtr botQQ, int picType, IntPtr sourceId, IntPtr GUID);

        [DllImport(DllName)]
        public static extern IntPtr Api_SendXML(IntPtr botQQ, int sendType, int msgType, IntPtr groupId, IntPtr QQ, IntPtr objectMsg, int subType);


    }
}
#endregion 
