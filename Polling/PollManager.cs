using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000203 RID: 515
	public class PollManager : MonoBehaviour
	{
		// Token: 0x0600292F RID: 10543 RVA: 0x000F5800 File Offset: 0x000F3A00
		// Note: this type is marked as 'beforefieldinit'.
		static PollManager()
		{
			Il2CppClassPointerStore<PollManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager>.NativeClassPtr);
			PollManager.NativeFieldInfoPtr_SERVER_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "SERVER_URL");
			PollManager.NativeFieldInfoPtr__ActivePoll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<ActivePoll>k__BackingField");
			PollManager.NativeFieldInfoPtr__ConfirmedPoll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<ConfirmedPoll>k__BackingField");
			PollManager.NativeFieldInfoPtr__SubmissionResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<SubmissionResult>k__BackingField");
			PollManager.NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<SubmisssionFailedMesssage>k__BackingField");
			PollManager.NativeFieldInfoPtr_appTicketCallbackResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "appTicketCallbackResponse");
			PollManager.NativeFieldInfoPtr_tokenCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "tokenCompletion");
			PollManager.NativeFieldInfoPtr_receivedPollResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "receivedPollResponse");
			PollManager.NativeFieldInfoPtr_sentResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "sentResponse");
			PollManager.NativeFieldInfoPtr_appTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "appTicket");
			PollManager.NativeFieldInfoPtr_onActivePollReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "onActivePollReceived");
			PollManager.NativeFieldInfoPtr_onConfirmedPollReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "onConfirmedPollReceived");
			PollManager.NativeFieldInfoPtr_appTicketRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "appTicketRequested");
			PollManager.NativeMethodInfoPtr_get_ActivePoll_Public_get_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667969);
			PollManager.NativeMethodInfoPtr_set_ActivePoll_Private_set_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667970);
			PollManager.NativeMethodInfoPtr_get_ConfirmedPoll_Public_get_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667971);
			PollManager.NativeMethodInfoPtr_set_ConfirmedPoll_Private_set_Void_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667972);
			PollManager.NativeMethodInfoPtr_get_SubmissionResult_Public_get_EPollSubmissionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667973);
			PollManager.NativeMethodInfoPtr_set_SubmissionResult_Private_set_Void_EPollSubmissionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667974);
			PollManager.NativeMethodInfoPtr_get_SubmisssionFailedMesssage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667975);
			PollManager.NativeMethodInfoPtr_set_SubmisssionFailedMesssage_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667976);
			PollManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667977);
			PollManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667978);
			PollManager.NativeMethodInfoPtr_GenerateAppTicket_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667979);
			PollManager.NativeMethodInfoPtr_SelectPollResponse_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667980);
			PollManager.NativeMethodInfoPtr_InitAppTicket_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667981);
			PollManager.NativeMethodInfoPtr_SubmitAnswerToServer_Private_IEnumerator_PollAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667982);
			PollManager.NativeMethodInfoPtr_RequestPoll_Private_IEnumerator_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667983);
			PollManager.NativeMethodInfoPtr_ResponseCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667984);
			PollManager.NativeMethodInfoPtr_OnEncryptedAppTicketResponse_Private_Void_EncryptedAppTicketResponse_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667985);
			PollManager.NativeMethodInfoPtr_GetAppTicket_Private_Task_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667986);
			PollManager.NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667987);
			PollManager.NativeMethodInfoPtr_TryGetExistingPollResponse_Public_Static_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667988);
			PollManager.NativeMethodInfoPtr_RecordSubmission_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667989);
			PollManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager>.NativeClassPtr, 100667990);
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000F5AEC File Offset: 0x000F3CEC
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x000F5B2C File Offset: 0x000F3D2C
		public unsafe PollData ActivePoll
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_ActivePoll_Public_get_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_ActivePoll_Private_set_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000F5B70 File Offset: 0x000F3D70
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x000F5BB0 File Offset: 0x000F3DB0
		public unsafe PollData ConfirmedPoll
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_ConfirmedPoll_Public_get_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_ConfirmedPoll_Private_set_Void_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000F5BF4 File Offset: 0x000F3DF4
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x000F5C30 File Offset: 0x000F3E30
		public unsafe PollManager.EPollSubmissionResult SubmissionResult
		{
			[CallerCount(147)]
			[CachedScanResults(RefRangeStart = 42514, RefRangeEnd = 42661, XrefRangeStart = 42514, XrefRangeEnd = 42661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_SubmissionResult_Public_get_EPollSubmissionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71921, RefRangeEnd = 71922, XrefRangeStart = 71921, XrefRangeEnd = 71922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_SubmissionResult_Private_set_Void_EPollSubmissionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x000F5C70 File Offset: 0x000F3E70
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x000F5CA8 File Offset: 0x000F3EA8
		public unsafe string SubmisssionFailedMesssage
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_get_SubmisssionFailedMesssage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_set_SubmisssionFailedMesssage_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000F5CEC File Offset: 0x000F3EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122209, XrefRangeEnd = 122225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000F5D20 File Offset: 0x000F3F20
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000F5D54 File Offset: 0x000F3F54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122238, RefRangeEnd = 122240, XrefRangeStart = 122225, XrefRangeEnd = 122238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateAppTicket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_GenerateAppTicket_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000F5D88 File Offset: 0x000F3F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122262, RefRangeEnd = 122263, XrefRangeStart = 122240, XrefRangeEnd = 122262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPollResponse(int responseIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref responseIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_SelectPollResponse_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000F5DC8 File Offset: 0x000F3FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122263, XrefRangeEnd = 122273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task InitAppTicket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_InitAppTicket_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000F5E08 File Offset: 0x000F4008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122273, XrefRangeEnd = 122279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SubmitAnswerToServer(PollAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(answer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_SubmitAnswerToServer_Private_IEnumerator_PollAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000F5E58 File Offset: 0x000F4058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122279, XrefRangeEnd = 122285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RequestPoll(string url, Il2CppSystem.Action<string> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_RequestPoll_Private_IEnumerator_String_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000F5EBC File Offset: 0x000F40BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122285, XrefRangeEnd = 122343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResponseCallback(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_ResponseCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x000F5F00 File Offset: 0x000F4100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122343, XrefRangeEnd = 122362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEncryptedAppTicketResponse(EncryptedAppTicketResponse_t response, bool ioFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ioFailure;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_OnEncryptedAppTicketResponse_Private_Void_EncryptedAppTicketResponse_t_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000F5F4C File Offset: 0x000F414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122362, XrefRangeEnd = 122377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> GetAppTicket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_GetAppTicket_Private_Task_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr2) : null;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000F5F8C File Offset: 0x000F418C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122377, XrefRangeEnd = 122383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanTicket(string ticket)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ticket);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x000F5FC8 File Offset: 0x000F41C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122397, RefRangeEnd = 122398, XrefRangeStart = 122383, XrefRangeEnd = 122397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetExistingPollResponse(int pollId, out int response)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pollId;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &response;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_TryGetExistingPollResponse_Public_Static_Boolean_Int32_byref_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000F6014 File Offset: 0x000F4214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122398, XrefRangeEnd = 122408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordSubmission(int pollId, int response)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pollId;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref response;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr_RecordSubmission_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000F6054 File Offset: 0x000F4254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122408, XrefRangeEnd = 122414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00016492 File Offset: 0x00014692
		public PollManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000F6090 File Offset: 0x000F4290
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x0001649B File Offset: 0x0001469B
		public unsafe static string SERVER_URL
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(PollManager.NativeFieldInfoPtr_SERVER_URL, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PollManager.NativeFieldInfoPtr_SERVER_URL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x000F60B0 File Offset: 0x000F42B0
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x000164AD File Offset: 0x000146AD
		public unsafe PollData _ActivePoll_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ActivePoll_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ActivePoll_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x000F60E0 File Offset: 0x000F42E0
		// (set) Token: 0x0600294C RID: 10572 RVA: 0x000164CC File Offset: 0x000146CC
		public unsafe PollData _ConfirmedPoll_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ConfirmedPoll_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__ConfirmedPoll_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x000F6110 File Offset: 0x000F4310
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x000164EB File Offset: 0x000146EB
		public unsafe PollManager.EPollSubmissionResult _SubmissionResult_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmissionResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmissionResult_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x000F6138 File Offset: 0x000F4338
		// (set) Token: 0x06002950 RID: 10576 RVA: 0x00016506 File Offset: 0x00014706
		public unsafe string _SubmisssionFailedMesssage_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x000F6160 File Offset: 0x000F4360
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x00016525 File Offset: 0x00014725
		public unsafe CallResult<EncryptedAppTicketResponse_t> appTicketCallbackResponse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_appTicketCallbackResponse);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallResult<EncryptedAppTicketResponse_t>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_appTicketCallbackResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x000F6190 File Offset: 0x000F4390
		// (set) Token: 0x06002954 RID: 10580 RVA: 0x00016544 File Offset: 0x00014744
		public unsafe TaskCompletionSource<string> tokenCompletion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_tokenCompletion);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskCompletionSource<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_tokenCompletion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x000F61C0 File Offset: 0x000F43C0
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x00016563 File Offset: 0x00014763
		public unsafe PollResponse receivedPollResponse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_receivedPollResponse);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollResponse>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_receivedPollResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x000F61F0 File Offset: 0x000F43F0
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x00016582 File Offset: 0x00014782
		public unsafe int sentResponse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_sentResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_sentResponse)) = value;
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x000F6218 File Offset: 0x000F4418
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x0001659D File Offset: 0x0001479D
		public unsafe string appTicket
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_appTicket);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_appTicket), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x000F6240 File Offset: 0x000F4440
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x000165BC File Offset: 0x000147BC
		public unsafe Il2CppSystem.Action<PollData> onActivePollReceived
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onActivePollReceived);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PollData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onActivePollReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x000F6270 File Offset: 0x000F4470
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x000165DB File Offset: 0x000147DB
		public unsafe Il2CppSystem.Action<PollData> onConfirmedPollReceived
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onConfirmedPollReceived);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PollData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_onConfirmedPollReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x000F62A0 File Offset: 0x000F44A0
		// (set) Token: 0x06002960 RID: 10592 RVA: 0x000165FA File Offset: 0x000147FA
		public unsafe bool appTicketRequested
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_appTicketRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager.NativeFieldInfoPtr_appTicketRequested)) = value;
			}
		}

		// Token: 0x04001B4E RID: 6990
		private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_URL;

		// Token: 0x04001B4F RID: 6991
		private static readonly System.IntPtr NativeFieldInfoPtr__ActivePoll_k__BackingField;

		// Token: 0x04001B50 RID: 6992
		private static readonly System.IntPtr NativeFieldInfoPtr__ConfirmedPoll_k__BackingField;

		// Token: 0x04001B51 RID: 6993
		private static readonly System.IntPtr NativeFieldInfoPtr__SubmissionResult_k__BackingField;

		// Token: 0x04001B52 RID: 6994
		private static readonly System.IntPtr NativeFieldInfoPtr__SubmisssionFailedMesssage_k__BackingField;

		// Token: 0x04001B53 RID: 6995
		private static readonly System.IntPtr NativeFieldInfoPtr_appTicketCallbackResponse;

		// Token: 0x04001B54 RID: 6996
		private static readonly System.IntPtr NativeFieldInfoPtr_tokenCompletion;

		// Token: 0x04001B55 RID: 6997
		private static readonly System.IntPtr NativeFieldInfoPtr_receivedPollResponse;

		// Token: 0x04001B56 RID: 6998
		private static readonly System.IntPtr NativeFieldInfoPtr_sentResponse;

		// Token: 0x04001B57 RID: 6999
		private static readonly System.IntPtr NativeFieldInfoPtr_appTicket;

		// Token: 0x04001B58 RID: 7000
		private static readonly System.IntPtr NativeFieldInfoPtr_onActivePollReceived;

		// Token: 0x04001B59 RID: 7001
		private static readonly System.IntPtr NativeFieldInfoPtr_onConfirmedPollReceived;

		// Token: 0x04001B5A RID: 7002
		private static readonly System.IntPtr NativeFieldInfoPtr_appTicketRequested;

		// Token: 0x04001B5B RID: 7003
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActivePoll_Public_get_PollData_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActivePoll_Private_set_Void_PollData_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfirmedPoll_Public_get_PollData_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ConfirmedPoll_Private_set_Void_PollData_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmissionResult_Public_get_EPollSubmissionResult_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmissionResult_Private_set_Void_EPollSubmissionResult_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SubmisssionFailedMesssage_Public_get_String_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SubmisssionFailedMesssage_Private_set_Void_String_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateAppTicket_Public_Void_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectPollResponse_Public_Void_Int32_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly System.IntPtr NativeMethodInfoPtr_InitAppTicket_Private_Task_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitAnswerToServer_Private_IEnumerator_PollAnswer_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestPoll_Private_IEnumerator_String_Action_1_String_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly System.IntPtr NativeMethodInfoPtr_ResponseCallback_Private_Void_String_0;

		// Token: 0x04001B6B RID: 7019
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEncryptedAppTicketResponse_Private_Void_EncryptedAppTicketResponse_t_Boolean_0;

		// Token: 0x04001B6C RID: 7020
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppTicket_Private_Task_1_String_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly System.IntPtr NativeMethodInfoPtr_CleanTicket_Private_Static_String_String_0;

		// Token: 0x04001B6E RID: 7022
		private static readonly System.IntPtr NativeMethodInfoPtr_TryGetExistingPollResponse_Public_Static_Boolean_Int32_byref_Int32_0;

		// Token: 0x04001B6F RID: 7023
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordSubmission_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04001B70 RID: 7024
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200090B RID: 2315
		[OriginalName("Assembly-CSharp.dll", "", "EPollSubmissionResult")]
		public enum EPollSubmissionResult
		{
			// Token: 0x0400881C RID: 34844
			InProgress,
			// Token: 0x0400881D RID: 34845
			Success,
			// Token: 0x0400881E RID: 34846
			Failed
		}

		// Token: 0x0200090C RID: 2316
		[ObfuscatedName("ScheduleOne.Polling.PollManager+<InitAppTicket>d__30")]
		public sealed class _InitAppTicket_d__30 : Il2CppSystem.ValueType
		{
			// Token: 0x0600C8B0 RID: 51376 RVA: 0x00310D00 File Offset: 0x0030EF00
			// Note: this type is marked as 'beforefieldinit'.
			static _InitAppTicket_d__30()
			{
				Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<InitAppTicket>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr);
				PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr, "<>1__state");
				PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr, "<>t__builder");
				PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr, "<>4__this");
				PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr, "<>u__1");
				PollManager._InitAppTicket_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr, 100667991);
				PollManager._InitAppTicket_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr, 100667992);
			}

			// Token: 0x0600C8B1 RID: 51377 RVA: 0x00310DA4 File Offset: 0x0030EFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122065, XrefRangeEnd = 122118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._InitAppTicket_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8B2 RID: 51378 RVA: 0x00310DDC File Offset: 0x0030EFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122118, XrefRangeEnd = 122122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._InitAppTicket_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8B3 RID: 51379 RVA: 0x000614D7 File Offset: 0x0005F6D7
			public _InitAppTicket_d__30(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C8B4 RID: 51380 RVA: 0x000614E0 File Offset: 0x0005F6E0
			public _InitAppTicket_d__30() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager._InitAppTicket_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x17003E57 RID: 15959
			// (get) Token: 0x0600C8B5 RID: 51381 RVA: 0x00310E24 File Offset: 0x0030F024
			// (set) Token: 0x0600C8B6 RID: 51382 RVA: 0x000614F2 File Offset: 0x0005F6F2
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E58 RID: 15960
			// (get) Token: 0x0600C8B7 RID: 51383 RVA: 0x00310E4C File Offset: 0x0030F04C
			// (set) Token: 0x0600C8B8 RID: 51384 RVA: 0x0006150D File Offset: 0x0005F70D
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (System.UIntPtr)0));
				}
			}

			// Token: 0x17003E59 RID: 15961
			// (get) Token: 0x0600C8B9 RID: 51385 RVA: 0x00310E7C File Offset: 0x0030F07C
			// (set) Token: 0x0600C8BA RID: 51386 RVA: 0x0006153B File Offset: 0x0005F73B
			public unsafe PollManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E5A RID: 15962
			// (get) Token: 0x0600C8BB RID: 51387 RVA: 0x00310EAC File Offset: 0x0030F0AC
			// (set) Token: 0x0600C8BC RID: 51388 RVA: 0x0006155A File Offset: 0x0005F75A
			public TaskAwaiter<string> __u__1
			{
				get
				{
					System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<string>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._InitAppTicket_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<string>>.NativeClassPtr, (System.UIntPtr)0));
				}
			}

			// Token: 0x0400881F RID: 34847
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008820 RID: 34848
			private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04008821 RID: 34849
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008822 RID: 34850
			private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04008823 RID: 34851
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008824 RID: 34852
			private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200090D RID: 2317
		[ObfuscatedName("ScheduleOne.Polling.PollManager+<RequestPoll>d__32")]
		public sealed class _RequestPoll_d__32 : Il2CppSystem.Object
		{
			// Token: 0x0600C8BD RID: 51389 RVA: 0x00310EDC File Offset: 0x0030F0DC
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestPoll_d__32()
			{
				Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<RequestPoll>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr);
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "<>1__state");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "<>2__current");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "url");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "callback");
				PollManager._RequestPoll_d__32.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, "<request>5__2");
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100667993);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100667994);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100667995);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100667996);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100667997);
				PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr, 100667998);
			}

			// Token: 0x0600C8BE RID: 51390 RVA: 0x00310FE4 File Offset: 0x0030F1E4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RequestPoll_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager._RequestPoll_d__32>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8BF RID: 51391 RVA: 0x0031102C File Offset: 0x0030F22C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8C0 RID: 51392 RVA: 0x00311060 File Offset: 0x0030F260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122122, XrefRangeEnd = 122126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E60 RID: 15968
			// (get) Token: 0x0600C8C1 RID: 51393 RVA: 0x0031109C File Offset: 0x0030F29C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8C2 RID: 51394 RVA: 0x003110DC File Offset: 0x0030F2DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122126, XrefRangeEnd = 122131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E61 RID: 15969
			// (get) Token: 0x0600C8C3 RID: 51395 RVA: 0x00311110 File Offset: 0x0030F310
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._RequestPoll_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8C4 RID: 51396 RVA: 0x00061588 File Offset: 0x0005F788
			public _RequestPoll_d__32(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E5B RID: 15963
			// (get) Token: 0x0600C8C5 RID: 51397 RVA: 0x00311150 File Offset: 0x0030F350
			// (set) Token: 0x0600C8C6 RID: 51398 RVA: 0x00061591 File Offset: 0x0005F791
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E5C RID: 15964
			// (get) Token: 0x0600C8C7 RID: 51399 RVA: 0x00311178 File Offset: 0x0030F378
			// (set) Token: 0x0600C8C8 RID: 51400 RVA: 0x000615AC File Offset: 0x0005F7AC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E5D RID: 15965
			// (get) Token: 0x0600C8C9 RID: 51401 RVA: 0x003111A8 File Offset: 0x0030F3A8
			// (set) Token: 0x0600C8CA RID: 51402 RVA: 0x000615CB File Offset: 0x0005F7CB
			public unsafe string url
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003E5E RID: 15966
			// (get) Token: 0x0600C8CB RID: 51403 RVA: 0x003111D0 File Offset: 0x0030F3D0
			// (set) Token: 0x0600C8CC RID: 51404 RVA: 0x000615EA File Offset: 0x0005F7EA
			public unsafe Il2CppSystem.Action<string> callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E5F RID: 15967
			// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x00311200 File Offset: 0x0030F400
			// (set) Token: 0x0600C8CE RID: 51406 RVA: 0x00061609 File Offset: 0x0005F809
			public unsafe UnityWebRequest _request_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr__request_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._RequestPoll_d__32.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008825 RID: 34853
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008826 RID: 34854
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008827 RID: 34855
			private static readonly System.IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04008828 RID: 34856
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008829 RID: 34857
			private static readonly System.IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x0400882A RID: 34858
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400882B RID: 34859
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400882C RID: 34860
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400882D RID: 34861
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400882E RID: 34862
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400882F RID: 34863
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200090E RID: 2318
		[ObfuscatedName("ScheduleOne.Polling.PollManager+<SubmitAnswerToServer>d__31")]
		public sealed class _SubmitAnswerToServer_d__31 : Il2CppSystem.Object
		{
			// Token: 0x0600C8CF RID: 51407 RVA: 0x00311230 File Offset: 0x0030F430
			// Note: this type is marked as 'beforefieldinit'.
			static _SubmitAnswerToServer_d__31()
			{
				Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PollManager>.NativeClassPtr, "<SubmitAnswerToServer>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr);
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<>1__state");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<>2__current");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr_answer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "answer");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<>4__this");
				PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr__req_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, "<req>5__2");
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100667999);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668000);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668001);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668002);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668003);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668004);
				PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr, 100668005);
			}

			// Token: 0x0600C8D0 RID: 51408 RVA: 0x0031134C File Offset: 0x0030F54C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SubmitAnswerToServer_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollManager._SubmitAnswerToServer_d__31>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8D1 RID: 51409 RVA: 0x00311394 File Offset: 0x0030F594
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122134, RefRangeEnd = 122135, XrefRangeStart = 122131, XrefRangeEnd = 122134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8D2 RID: 51410 RVA: 0x003113C8 File Offset: 0x0030F5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122135, XrefRangeEnd = 122197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C8D3 RID: 51411 RVA: 0x00311404 File Offset: 0x0030F604
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122200, RefRangeEnd = 122204, XrefRangeStart = 122197, XrefRangeEnd = 122200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E67 RID: 15975
			// (get) Token: 0x0600C8D4 RID: 51412 RVA: 0x00311438 File Offset: 0x0030F638
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8D5 RID: 51413 RVA: 0x00311478 File Offset: 0x0030F678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122204, XrefRangeEnd = 122209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E68 RID: 15976
			// (get) Token: 0x0600C8D6 RID: 51414 RVA: 0x003114AC File Offset: 0x0030F6AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollManager._SubmitAnswerToServer_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8D7 RID: 51415 RVA: 0x00061628 File Offset: 0x0005F828
			public _SubmitAnswerToServer_d__31(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E62 RID: 15970
			// (get) Token: 0x0600C8D8 RID: 51416 RVA: 0x003114EC File Offset: 0x0030F6EC
			// (set) Token: 0x0600C8D9 RID: 51417 RVA: 0x00061631 File Offset: 0x0005F831
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E63 RID: 15971
			// (get) Token: 0x0600C8DA RID: 51418 RVA: 0x00311514 File Offset: 0x0030F714
			// (set) Token: 0x0600C8DB RID: 51419 RVA: 0x0006164C File Offset: 0x0005F84C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E64 RID: 15972
			// (get) Token: 0x0600C8DC RID: 51420 RVA: 0x00311544 File Offset: 0x0030F744
			// (set) Token: 0x0600C8DD RID: 51421 RVA: 0x0006166B File Offset: 0x0005F86B
			public unsafe PollAnswer answer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr_answer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollAnswer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr_answer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E65 RID: 15973
			// (get) Token: 0x0600C8DE RID: 51422 RVA: 0x00311574 File Offset: 0x0030F774
			// (set) Token: 0x0600C8DF RID: 51423 RVA: 0x0006168A File Offset: 0x0005F88A
			public unsafe PollManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E66 RID: 15974
			// (get) Token: 0x0600C8E0 RID: 51424 RVA: 0x003115A4 File Offset: 0x0030F7A4
			// (set) Token: 0x0600C8E1 RID: 51425 RVA: 0x000616A9 File Offset: 0x0005F8A9
			public unsafe UnityWebRequest _req_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr__req_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollManager._SubmitAnswerToServer_d__31.NativeFieldInfoPtr__req_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008830 RID: 34864
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008831 RID: 34865
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008832 RID: 34866
			private static readonly System.IntPtr NativeFieldInfoPtr_answer;

			// Token: 0x04008833 RID: 34867
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008834 RID: 34868
			private static readonly System.IntPtr NativeFieldInfoPtr__req_5__2;

			// Token: 0x04008835 RID: 34869
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008836 RID: 34870
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008837 RID: 34871
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008838 RID: 34872
			private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04008839 RID: 34873
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400883A RID: 34874
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400883B RID: 34875
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
