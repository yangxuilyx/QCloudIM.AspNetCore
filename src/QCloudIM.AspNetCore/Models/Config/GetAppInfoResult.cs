using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIM.AspNetCore.Models.Config
{ 

    public class GetAppInfoResult : QCloudIMResult
	{
		

	    [JsonProperty("Result")]
        public  IList<ResultItem> Result
		{
            get; set;
        }
       

    }
    public class ResultItem
    {

        [JsonProperty("APNSMsgNum")]
        public static long ApnsMsgNum
        {
            get; set;
        }

        [JsonProperty("ActiveUserNum")]
        public long ActiveUserNum
        {
            get; set;
        }

        [JsonProperty("AppId")]
        public string AppId
        {
            get; set;
        }

        [JsonProperty("AppName")]
        public string AppName
        {
            get; set;
        }

        [JsonProperty("C2CAPNSMsgNum")]
        public long C2CApnsMsgNum
        {
            get; set;
        }

        [JsonProperty("C2CDownMsgNum")]
        public long C2CDownMsgNum
        {
            get; set;
        }

        [JsonProperty("C2CSendMsgUserNum")]
        public long C2CSendMsgUserNum
        {
            get; set;
        }

        [JsonProperty("C2CUpMsgNum")]
        public long C2CUpMsgNum
        {
            get; set;
        }
        [JsonProperty("CallBackReq")]

        public long CallbackReq
        {
            get; set;
        }

        [JsonProperty("CallBackRsp")]
        public long CallbackRsp
        {
            get; set;
        }

        [JsonProperty("ChainDecrease")]
        public long ChainDecrease
        {
            get; set;
        }

        [JsonProperty("ChainIncrease")]
        public long ChainIncrease
        {
            get; set;
        }

        [JsonProperty("Company")]
        public string Company
        {
            get; set;
        }

        [JsonProperty("Date")]
        public string Date
        {
            get; set;
        }

        [JsonProperty("DownMsgNum")]
        public long DownMsgNum
        {
            get; set;
        }

        [JsonProperty("GroupAPNSMsgNum")]
        public long GroupApnsMsgNum
        {
            get; set;
        }

        [JsonProperty("GroupAllGroupNum")]
        public long GroupAllGroupNum
        {
            get; set;
        }

        [JsonProperty("GroupDestroyGroupNum")]
        public long GroupDestroyGroupNum
        {
            get; set;
        }

        [JsonProperty("GroupDownMsgNum")]
        public long GroupDownMsgNum
        {
            get; set;
        }

        [JsonProperty("GroupJoinGroupTimes")]
        public long GroupJoinGroupTimes
        {
            get; set;
        }

        [JsonProperty("GroupNewGroupNum")]
        public long GroupNewGroupNum
        {
            get; set;
        }

        [JsonProperty("GroupQuitGroupTimes")]
        public long GroupQuitGroupTimes
        {
            get; set;
        }

        [JsonProperty("GroupSendMsgGroupNum")]
        public long GroupSendMsgGroupNum
        {
            get; set;
        }

        [JsonProperty("GroupSendMsgUserNum")]
        public long GroupSendMsgUserNum
        {
            get; set;
        }

        [JsonProperty("GroupUpMsgNum")]
        public long GroupUpMsgNum
        {
            get; set;
        }

        [JsonProperty("LoginTimes")]
        public long LoginTimes
        {
            get; set;
        }

        [JsonProperty("LoginUserNum")]
        public long LoginUserNum
        {
            get; set;
        }

        [JsonProperty("MaxOnlineNum")]
        public long MaxOnlineNum
        {
            get; set;
        }

        [JsonProperty("QQ")]
        public string Qq
        {
            get; set;
        }

        [JsonProperty("RegistUserNumOneDay")]
        public long RegisterUserNumOneDay
        {
            get; set;
        }

        [JsonProperty("RegistUserNumTotal")]
        public long RegisterUserNumTotal
        {
            get; set;
        }

        [JsonProperty("SendMsgUserNum")]
        public long SendMsgUserNum
        {
            get; set;
        }

        [JsonProperty("TextMsgInNum")]
        public long TextMsgInNum
        {
            get; set;
        }

        [JsonProperty("TextMsgOutNum")]
        public long TxtMsgOutNum
        {
            get; set;
        }

        [JsonProperty("UpMsgNum")]
        public long UpMsgNum
        {
            get; set;
        }

        [JsonProperty("VoiceMsgInNum")]
        public long VoiceMsgInNum
        {
            get; set;
        }

        [JsonProperty("VoiceMsgOutNum")]
        public long VoiceMsgOutNum
        {
            get; set;
        }

    }

}