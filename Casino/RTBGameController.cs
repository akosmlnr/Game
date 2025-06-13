using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C9 RID: 1225
	public class RTBGameController : CasinoGameController
	{
		// Token: 0x060069DE RID: 27102 RVA: 0x001DD9D4 File Offset: 0x001DBBD4
		// Note: this type is marked as 'beforefieldinit'.
		static RTBGameController()
		{
			Il2CppClassPointerStore<RTBGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "RTBGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr);
			RTBGameController.NativeFieldInfoPtr_BET_MINIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "BET_MINIMUM");
			RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "BET_MAXIMUM");
			RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ANSWER_MAX_TIME");
			RTBGameController.NativeFieldInfoPtr_PlayCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "PlayCameraTransform");
			RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "FocusedCameraTransform");
			RTBGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "Cards");
			RTBGameController.NativeFieldInfoPtr_CardDefaultPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "CardDefaultPositions");
			RTBGameController.NativeFieldInfoPtr_ActiveCardPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "ActiveCardPosition");
			RTBGameController.NativeFieldInfoPtr_DockedCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "DockedCardPositions");
			RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_onStageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onStageChange");
			RTBGameController.NativeFieldInfoPtr_onQuestionReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionReady");
			RTBGameController.NativeFieldInfoPtr_onQuestionDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onQuestionDone");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerCorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerIncorrect");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<IsQuestionActive>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<LocalPlayerBetMultiplier>k__BackingField");
			RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<RemainingAnswerTime>k__BackingField");
			RTBGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "playersInCurrentRound");
			RTBGameController.NativeFieldInfoPtr_cardsInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "cardsInDeck");
			RTBGameController.NativeFieldInfoPtr_drawnCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "drawnCards");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.RTBGameControllerAssembly-CSharp.dll_Excuted");
			RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676838);
			RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676839);
			RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676840);
			RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676841);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676842);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676843);
			RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676844);
			RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676845);
			RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676846);
			RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676847);
			RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676848);
			RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676849);
			RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676850);
			RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676851);
			RTBGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676852);
			RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676853);
			RTBGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676854);
			RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676855);
			RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676856);
			RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676857);
			RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676858);
			RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676859);
			RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676860);
			RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676861);
			RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676862);
			RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676863);
			RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676864);
			RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676865);
			RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676866);
			RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676867);
			RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676868);
			RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676869);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676870);
			RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676871);
			RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676872);
			RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676873);
			RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676874);
			RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676875);
			RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676876);
			RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676877);
			RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676878);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676879);
			RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676880);
			RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676881);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676882);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676883);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676884);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676885);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676886);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676887);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676888);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676889);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676890);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676891);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676892);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676893);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676894);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676895);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676896);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676897);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676898);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676899);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676900);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676901);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676902);
			RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676903);
			RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676904);
			RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676905);
			RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, 100676906);
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x001DE170 File Offset: 0x001DC370
		// (set) Token: 0x060069E0 RID: 27104 RVA: 0x001DE1AC File Offset: 0x001DC3AC
		public unsafe RTBGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FB4 RID: 8116
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x001DE1EC File Offset: 0x001DC3EC
		// (set) Token: 0x060069E2 RID: 27106 RVA: 0x001DE228 File Offset: 0x001DC428
		public unsafe bool IsQuestionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x001DE268 File Offset: 0x001DC468
		// (set) Token: 0x060069E4 RID: 27108 RVA: 0x001DE2A4 File Offset: 0x001DC4A4
		public unsafe float LocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x001DE2E4 File Offset: 0x001DC4E4
		// (set) Token: 0x060069E6 RID: 27110 RVA: 0x001DE320 File Offset: 0x001DC520
		public unsafe float LocalPlayerBetMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x001DE360 File Offset: 0x001DC560
		public unsafe float MultipliedLocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x060069E8 RID: 27112 RVA: 0x001DE39C File Offset: 0x001DC59C
		// (set) Token: 0x060069E9 RID: 27113 RVA: 0x001DE3D8 File Offset: 0x001DC5D8
		public unsafe float RemainingAnswerTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x060069EA RID: 27114 RVA: 0x001DE418 File Offset: 0x001DC618
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 214949, RefRangeEnd = 214961, XrefRangeStart = 214941, XrefRangeEnd = 214949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x001DE454 File Offset: 0x001DC654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214961, XrefRangeEnd = 214963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x001DE490 File Offset: 0x001DC690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214963, XrefRangeEnd = 214970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x001DE4CC File Offset: 0x001DC6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214970, XrefRangeEnd = 214979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x001DE508 File Offset: 0x001DC708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214979, XrefRangeEnd = 214983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x001DE558 File Offset: 0x001DC758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214983, XrefRangeEnd = 215013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x001DE594 File Offset: 0x001DC794
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 215035, RefRangeEnd = 215040, XrefRangeStart = 215013, XrefRangeEnd = 215035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStage(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetStage_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x001DE5D4 File Offset: 0x001DC7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215057, RefRangeEnd = 215058, XrefRangeStart = 215040, XrefRangeEnd = 215057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunRound(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RunRound_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x001DE614 File Offset: 0x001DC814
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215078, RefRangeEnd = 215081, XrefRangeStart = 215058, XrefRangeEnd = 215078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref multiplier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x001DE654 File Offset: 0x001DC854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215081, XrefRangeEnd = 215105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x001DE688 File Offset: 0x001DC888
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 215149, RefRangeEnd = 215155, XrefRangeStart = 215105, XrefRangeEnd = 215149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(bool payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref cameraDelay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x001DE6D4 File Offset: 0x001DC8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215156, RefRangeEnd = 215157, XrefRangeStart = 215155, XrefRangeEnd = 215156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x001DE710 File Offset: 0x001DC910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215169, RefRangeEnd = 215170, XrefRangeStart = 215157, XrefRangeEnd = 215169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAnswerIndex(RTBGameController.EStage stage, PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref card;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x001DE768 File Offset: 0x001DC968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215170, XrefRangeEnd = 215192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAnswer(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref answerIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x001DE7A8 File Offset: 0x001DC9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215192, XrefRangeEnd = 215213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x001DE7DC File Offset: 0x001DC9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215276, RefRangeEnd = 215277, XrefRangeStart = 215213, XrefRangeEnd = 215276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetQuestionsAndAnswers(RTBGameController.EStage stage, out string question, out Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr3 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			question = IL2CPP.Il2CppStringToManaged(il2CppString);
			System.IntPtr intPtr3 = intPtr;
			answers = ((intPtr3 == 0) ? null : new Il2CppStringArray(intPtr3));
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x001DE858 File Offset: 0x001DCA58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 215299, RefRangeEnd = 215304, XrefRangeStart = 215277, XrefRangeEnd = 215299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x001DE88C File Offset: 0x001DCA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215304, XrefRangeEnd = 215326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x001DE8D0 File Offset: 0x001DCAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215326, XrefRangeEnd = 215348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x001DE914 File Offset: 0x001DCB14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215370, RefRangeEnd = 215373, XrefRangeStart = 215348, XrefRangeEnd = 215370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x001DE958 File Offset: 0x001DCB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215373, XrefRangeEnd = 215384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardData PullCardFromDeck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x001DE994 File Offset: 0x001DCB94
		[CallerCount(0)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref bet;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x001DE9D4 File Offset: 0x001DCBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215384, XrefRangeEnd = 215387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x001DEA10 File Offset: 0x001DCC10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215400, RefRangeEnd = 215402, XrefRangeStart = 215387, XrefRangeEnd = 215400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x001DEA4C File Offset: 0x001DCC4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215408, RefRangeEnd = 215411, XrefRangeStart = 215402, XrefRangeEnd = 215408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerAnswer(float answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref answer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x001DEA8C File Offset: 0x001DCC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215411, XrefRangeEnd = 215428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAnsweredPlayersCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x001DEAC8 File Offset: 0x001DCCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215428, XrefRangeEnd = 215439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x001DEAFC File Offset: 0x001DCCFC
		[CallerCount(0)]
		public unsafe int GetCardNumberValue(PlayingCard.CardData card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref card;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x001DEB48 File Offset: 0x001DCD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215439, RefRangeEnd = 215440, XrefRangeStart = 215439, XrefRangeEnd = 215439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetNetBetMultiplier(RTBGameController.EStage stage)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x001DEB88 File Offset: 0x001DCD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215440, XrefRangeEnd = 215460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x001DEBC4 File Offset: 0x001DCDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215460, XrefRangeEnd = 215511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x001DEC00 File Offset: 0x001DCE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215511, XrefRangeEnd = 215512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x001DEC3C File Offset: 0x001DCE3C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x001DEC78 File Offset: 0x001DCE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215512, XrefRangeEnd = 215522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x001DECB8 File Offset: 0x001DCEB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215538, RefRangeEnd = 215540, XrefRangeStart = 215522, XrefRangeEnd = 215538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStage_2502303021(RTBGameController.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stage;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x001DECF8 File Offset: 0x001DCEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215540, XrefRangeEnd = 215544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStage_2502303021(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x001DED48 File Offset: 0x001DCF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215544, XrefRangeEnd = 215554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref multiplier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x001DED88 File Offset: 0x001DCF88
		[CallerCount(0)]
		public unsafe void RpcLogic___SetBetMultiplier_431000436(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref multiplier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x001DEDC8 File Offset: 0x001DCFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215554, XrefRangeEnd = 215557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetMultiplier_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x001DEE18 File Offset: 0x001DD018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215557, XrefRangeEnd = 215566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x001DEE4C File Offset: 0x001DD04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215566, XrefRangeEnd = 215570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x001DEE80 File Offset: 0x001DD080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215570, XrefRangeEnd = 215576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x001DEED0 File Offset: 0x001DD0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215576, XrefRangeEnd = 215586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref answerIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x001DEF10 File Offset: 0x001DD110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215606, RefRangeEnd = 215609, XrefRangeStart = 215586, XrefRangeEnd = 215606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyAnswer_431000436(float answerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref answerIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x001DEF50 File Offset: 0x001DD150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215609, XrefRangeEnd = 215613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyAnswer_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x001DEFA0 File Offset: 0x001DD1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215613, XrefRangeEnd = 215622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x001DEFD4 File Offset: 0x001DD1D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 215630, RefRangeEnd = 215635, XrefRangeStart = 215622, XrefRangeEnd = 215630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___QuestionDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x001DF008 File Offset: 0x001DD208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215635, XrefRangeEnd = 215638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_QuestionDone_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x001DF058 File Offset: 0x001DD258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215638, XrefRangeEnd = 215648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x001DF09C File Offset: 0x001DD29C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215661, RefRangeEnd = 215664, XrefRangeStart = 215648, XrefRangeEnd = 215661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x001DF0E0 File Offset: 0x001DD2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215664, XrefRangeEnd = 215668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x001DF130 File Offset: 0x001DD330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215668, XrefRangeEnd = 215678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x001DF174 File Offset: 0x001DD374
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215370, RefRangeEnd = 215373, XrefRangeStart = 215370, XrefRangeEnd = 215373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x001DF1B8 File Offset: 0x001DD3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215678, XrefRangeEnd = 215682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x001DF21C File Offset: 0x001DD41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215682, XrefRangeEnd = 215692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x001DF260 File Offset: 0x001DD460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215708, RefRangeEnd = 215711, XrefRangeStart = 215692, XrefRangeEnd = 215708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x001DF2A4 File Offset: 0x001DD4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215711, XrefRangeEnd = 215715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x001DF2F4 File Offset: 0x001DD4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215715, XrefRangeEnd = 215717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x00031B4F File Offset: 0x0002FD4F
		public RTBGameController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06006A25 RID: 27173 RVA: 0x001DF330 File Offset: 0x001DD530
		// (set) Token: 0x06006A26 RID: 27174 RVA: 0x00031B58 File Offset: 0x0002FD58
		public unsafe static int BET_MINIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06006A27 RID: 27175 RVA: 0x001DF34C File Offset: 0x001DD54C
		// (set) Token: 0x06006A28 RID: 27176 RVA: 0x00031B66 File Offset: 0x0002FD66
		public unsafe static int BET_MAXIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06006A29 RID: 27177 RVA: 0x001DF368 File Offset: 0x001DD568
		// (set) Token: 0x06006A2A RID: 27178 RVA: 0x00031B74 File Offset: 0x0002FD74
		public unsafe static float ANSWER_MAX_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTBGameController.NativeFieldInfoPtr_ANSWER_MAX_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06006A2B RID: 27179 RVA: 0x001DF384 File Offset: 0x001DD584
		// (set) Token: 0x06006A2C RID: 27180 RVA: 0x00031B82 File Offset: 0x0002FD82
		public unsafe Transform PlayCameraTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_PlayCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006A2D RID: 27181 RVA: 0x001DF3B4 File Offset: 0x001DD5B4
		// (set) Token: 0x06006A2E RID: 27182 RVA: 0x00031BA1 File Offset: 0x0002FDA1
		public unsafe Transform FocusedCameraTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_FocusedCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06006A2F RID: 27183 RVA: 0x001DF3E4 File Offset: 0x001DD5E4
		// (set) Token: 0x06006A30 RID: 27184 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06006A31 RID: 27185 RVA: 0x001DF414 File Offset: 0x001DD614
		// (set) Token: 0x06006A32 RID: 27186 RVA: 0x00031BDF File Offset: 0x0002FDDF
		public unsafe Il2CppReferenceArray<Transform> CardDefaultPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_CardDefaultPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06006A33 RID: 27187 RVA: 0x001DF444 File Offset: 0x001DD644
		// (set) Token: 0x06006A34 RID: 27188 RVA: 0x00031BFE File Offset: 0x0002FDFE
		public unsafe Transform ActiveCardPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_ActiveCardPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06006A35 RID: 27189 RVA: 0x001DF474 File Offset: 0x001DD674
		// (set) Token: 0x06006A36 RID: 27190 RVA: 0x00031C1D File Offset: 0x0002FE1D
		public unsafe Il2CppReferenceArray<Transform> DockedCardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_DockedCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x001DF4A4 File Offset: 0x001DD6A4
		// (set) Token: 0x06006A38 RID: 27192 RVA: 0x00031C3C File Offset: 0x0002FE3C
		public unsafe RTBGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06006A39 RID: 27193 RVA: 0x001DF4CC File Offset: 0x001DD6CC
		// (set) Token: 0x06006A3A RID: 27194 RVA: 0x00031C57 File Offset: 0x0002FE57
		public unsafe Il2CppSystem.Action<RTBGameController.EStage> onStageChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RTBGameController.EStage>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onStageChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06006A3B RID: 27195 RVA: 0x001DF4FC File Offset: 0x001DD6FC
		// (set) Token: 0x06006A3C RID: 27196 RVA: 0x00031C76 File Offset: 0x0002FE76
		public unsafe Il2CppSystem.Action<string, Il2CppStringArray> onQuestionReady
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06006A3D RID: 27197 RVA: 0x001DF52C File Offset: 0x001DD72C
		// (set) Token: 0x06006A3E RID: 27198 RVA: 0x00031C95 File Offset: 0x0002FE95
		public unsafe Il2CppSystem.Action onQuestionDone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onQuestionDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06006A3F RID: 27199 RVA: 0x001DF55C File Offset: 0x001DD75C
		// (set) Token: 0x06006A40 RID: 27200 RVA: 0x00031CB4 File Offset: 0x0002FEB4
		public unsafe Il2CppSystem.Action onLocalPlayerCorrect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x001DF58C File Offset: 0x001DD78C
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x00031CD3 File Offset: 0x0002FED3
		public unsafe Il2CppSystem.Action onLocalPlayerIncorrect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06006A43 RID: 27203 RVA: 0x001DF5BC File Offset: 0x001DD7BC
		// (set) Token: 0x06006A44 RID: 27204 RVA: 0x00031CF2 File Offset: 0x0002FEF2
		public unsafe Il2CppSystem.Action onLocalPlayerBetChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x001DF5EC File Offset: 0x001DD7EC
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x00031D11 File Offset: 0x0002FF11
		public unsafe Il2CppSystem.Action onLocalPlayerExitRound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x001DF61C File Offset: 0x001DD81C
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x00031D30 File Offset: 0x0002FF30
		public unsafe bool _IsQuestionActive_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__IsQuestionActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x001DF644 File Offset: 0x001DD844
		// (set) Token: 0x06006A4A RID: 27210 RVA: 0x00031D4B File Offset: 0x0002FF4B
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06006A4B RID: 27211 RVA: 0x001DF66C File Offset: 0x001DD86C
		// (set) Token: 0x06006A4C RID: 27212 RVA: 0x00031D66 File Offset: 0x0002FF66
		public unsafe float _LocalPlayerBetMultiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06006A4D RID: 27213 RVA: 0x001DF694 File Offset: 0x001DD894
		// (set) Token: 0x06006A4E RID: 27214 RVA: 0x00031D81 File Offset: 0x0002FF81
		public unsafe float _RemainingAnswerTime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06006A4F RID: 27215 RVA: 0x001DF6BC File Offset: 0x001DD8BC
		// (set) Token: 0x06006A50 RID: 27216 RVA: 0x00031D9C File Offset: 0x0002FF9C
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x001DF6EC File Offset: 0x001DD8EC
		// (set) Token: 0x06006A52 RID: 27218 RVA: 0x00031DBB File Offset: 0x0002FFBB
		public unsafe List<PlayingCard.CardData> cardsInDeck
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_cardsInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x001DF71C File Offset: 0x001DD91C
		// (set) Token: 0x06006A54 RID: 27220 RVA: 0x00031DDA File Offset: 0x0002FFDA
		public unsafe List<PlayingCard.CardData> drawnCards
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_drawnCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x001DF74C File Offset: 0x001DD94C
		// (set) Token: 0x06006A56 RID: 27222 RVA: 0x00031DF9 File Offset: 0x0002FFF9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x001DF774 File Offset: 0x001DD974
		// (set) Token: 0x06006A58 RID: 27224 RVA: 0x00031E14 File Offset: 0x00030014
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004887 RID: 18567
		private static readonly System.IntPtr NativeFieldInfoPtr_BET_MINIMUM;

		// Token: 0x04004888 RID: 18568
		private static readonly System.IntPtr NativeFieldInfoPtr_BET_MAXIMUM;

		// Token: 0x04004889 RID: 18569
		private static readonly System.IntPtr NativeFieldInfoPtr_ANSWER_MAX_TIME;

		// Token: 0x0400488A RID: 18570
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayCameraTransform;

		// Token: 0x0400488B RID: 18571
		private static readonly System.IntPtr NativeFieldInfoPtr_FocusedCameraTransform;

		// Token: 0x0400488C RID: 18572
		private static readonly System.IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x0400488D RID: 18573
		private static readonly System.IntPtr NativeFieldInfoPtr_CardDefaultPositions;

		// Token: 0x0400488E RID: 18574
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveCardPosition;

		// Token: 0x0400488F RID: 18575
		private static readonly System.IntPtr NativeFieldInfoPtr_DockedCardPositions;

		// Token: 0x04004890 RID: 18576
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x04004891 RID: 18577
		private static readonly System.IntPtr NativeFieldInfoPtr_onStageChange;

		// Token: 0x04004892 RID: 18578
		private static readonly System.IntPtr NativeFieldInfoPtr_onQuestionReady;

		// Token: 0x04004893 RID: 18579
		private static readonly System.IntPtr NativeFieldInfoPtr_onQuestionDone;

		// Token: 0x04004894 RID: 18580
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerCorrect;

		// Token: 0x04004895 RID: 18581
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerIncorrect;

		// Token: 0x04004896 RID: 18582
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x04004897 RID: 18583
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x04004898 RID: 18584
		private static readonly System.IntPtr NativeFieldInfoPtr__IsQuestionActive_k__BackingField;

		// Token: 0x04004899 RID: 18585
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x0400489A RID: 18586
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerBetMultiplier_k__BackingField;

		// Token: 0x0400489B RID: 18587
		private static readonly System.IntPtr NativeFieldInfoPtr__RemainingAnswerTime_k__BackingField;

		// Token: 0x0400489C RID: 18588
		private static readonly System.IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x0400489D RID: 18589
		private static readonly System.IntPtr NativeFieldInfoPtr_cardsInDeck;

		// Token: 0x0400489E RID: 18590
		private static readonly System.IntPtr NativeFieldInfoPtr_drawnCards;

		// Token: 0x0400489F RID: 18591
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040048A0 RID: 18592
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040048A1 RID: 18593
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x040048A2 RID: 18594
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x040048A3 RID: 18595
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsQuestionActive_Public_get_Boolean_0;

		// Token: 0x040048A4 RID: 18596
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsQuestionActive_Private_set_Void_Boolean_0;

		// Token: 0x040048A5 RID: 18597
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x040048A6 RID: 18598
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0;

		// Token: 0x040048A7 RID: 18599
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPlayerBetMultiplier_Public_get_Single_0;

		// Token: 0x040048A8 RID: 18600
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalPlayerBetMultiplier_Private_set_Void_Single_0;

		// Token: 0x040048A9 RID: 18601
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MultipliedLocalPlayerBet_Public_get_Single_0;

		// Token: 0x040048AA RID: 18602
		private static readonly System.IntPtr NativeMethodInfoPtr_get_RemainingAnswerTime_Public_get_Single_0;

		// Token: 0x040048AB RID: 18603
		private static readonly System.IntPtr NativeMethodInfoPtr_set_RemainingAnswerTime_Private_set_Void_Single_0;

		// Token: 0x040048AC RID: 18604
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x040048AD RID: 18605
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040048AE RID: 18606
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x040048AF RID: 18607
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_1;

		// Token: 0x040048B0 RID: 18608
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x040048B1 RID: 18609
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x040048B2 RID: 18610
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStage_Private_Void_EStage_0;

		// Token: 0x040048B3 RID: 18611
		private static readonly System.IntPtr NativeMethodInfoPtr_RunRound_Private_Void_EStage_0;

		// Token: 0x040048B4 RID: 18612
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBetMultiplier_Private_Void_Single_0;

		// Token: 0x040048B5 RID: 18613
		private static readonly System.IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x040048B6 RID: 18614
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_Boolean_Single_0;

		// Token: 0x040048B7 RID: 18615
		private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x040048B8 RID: 18616
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAnswerIndex_Private_Single_EStage_CardData_0;

		// Token: 0x040048B9 RID: 18617
		private static readonly System.IntPtr NativeMethodInfoPtr_NotifyAnswer_Private_Void_Single_0;

		// Token: 0x040048BA RID: 18618
		private static readonly System.IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x040048BB RID: 18619
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQuestionsAndAnswers_Private_Void_EStage_byref_String_byref_Il2CppStringArray_0;

		// Token: 0x040048BC RID: 18620
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x040048BD RID: 18621
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040048BE RID: 18622
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040048BF RID: 18623
		private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040048C0 RID: 18624
		private static readonly System.IntPtr NativeMethodInfoPtr_PullCardFromDeck_Private_CardData_0;

		// Token: 0x040048C1 RID: 18625
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x040048C2 RID: 18626
		private static readonly System.IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x040048C3 RID: 18627
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x040048C4 RID: 18628
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPlayerAnswer_Public_Void_Single_0;

		// Token: 0x040048C5 RID: 18629
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAnsweredPlayersCount_Public_Int32_0;

		// Token: 0x040048C6 RID: 18630
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0;

		// Token: 0x040048C7 RID: 18631
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCardNumberValue_Private_Int32_CardData_0;

		// Token: 0x040048C8 RID: 18632
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetBetMultiplier_Public_Static_Single_EStage_0;

		// Token: 0x040048C9 RID: 18633
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040048CA RID: 18634
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040048CB RID: 18635
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040048CC RID: 18636
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040048CD RID: 18637
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x040048CE RID: 18638
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetStage_2502303021_Private_Void_EStage_0;

		// Token: 0x040048CF RID: 18639
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStage_2502303021_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048D0 RID: 18640
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x040048D1 RID: 18641
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetBetMultiplier_431000436_Private_Void_Single_0;

		// Token: 0x040048D2 RID: 18642
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetMultiplier_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048D3 RID: 18643
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x040048D4 RID: 18644
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x040048D5 RID: 18645
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048D6 RID: 18646
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x040048D7 RID: 18647
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___NotifyAnswer_431000436_Private_Void_Single_0;

		// Token: 0x040048D8 RID: 18648
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyAnswer_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048D9 RID: 18649
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_QuestionDone_2166136261_Private_Void_0;

		// Token: 0x040048DA RID: 18650
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___QuestionDone_2166136261_Private_Void_0;

		// Token: 0x040048DB RID: 18651
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_QuestionDone_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048DC RID: 18652
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040048DD RID: 18653
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040048DE RID: 18654
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048DF RID: 18655
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040048E0 RID: 18656
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040048E1 RID: 18657
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040048E2 RID: 18658
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040048E3 RID: 18659
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040048E4 RID: 18660
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x040048E5 RID: 18661
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A95 RID: 2709
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04008FE3 RID: 36835
			WaitingForPlayers,
			// Token: 0x04008FE4 RID: 36836
			RedOrBlack,
			// Token: 0x04008FE5 RID: 36837
			HigherOrLower,
			// Token: 0x04008FE6 RID: 36838
			InsideOrOutside,
			// Token: 0x04008FE7 RID: 36839
			Suit
		}

		// Token: 0x02000A96 RID: 2710
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D531 RID: 54577 RVA: 0x00334A50 File Offset: 0x00332C50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "stage");
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676907);
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676908);
				RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, 100676909);
			}

			// Token: 0x0600D532 RID: 54578 RVA: 0x00334AE0 File Offset: 0x00332CE0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D533 RID: 54579 RVA: 0x00334B1C File Offset: 0x00332D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214913, XrefRangeEnd = 214918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D534 RID: 54580 RVA: 0x00334B5C File Offset: 0x00332D5C
			[CallerCount(0)]
			public unsafe bool _RunRound_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D535 RID: 54581 RVA: 0x000676AA File Offset: 0x000658AA
			public __c__DisplayClass50_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E9 RID: 16873
			// (get) Token: 0x0600D536 RID: 54582 RVA: 0x00334B98 File Offset: 0x00332D98
			// (set) Token: 0x0600D537 RID: 54583 RVA: 0x000676B3 File Offset: 0x000658B3
			public unsafe RTBGameController __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EA RID: 16874
			// (get) Token: 0x0600D538 RID: 54584 RVA: 0x00334BC8 File Offset: 0x00332DC8
			// (set) Token: 0x0600D539 RID: 54585 RVA: 0x000676D2 File Offset: 0x000658D2
			public unsafe RTBGameController.EStage stage
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.NativeFieldInfoPtr_stage)) = value;
				}
			}

			// Token: 0x04008FE8 RID: 36840
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FE9 RID: 36841
			private static readonly System.IntPtr NativeFieldInfoPtr_stage;

			// Token: 0x04008FEA RID: 36842
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FEB RID: 36843
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008FEC RID: 36844
			private static readonly System.IntPtr NativeMethodInfoPtr__RunRound_b__1_Internal_Boolean_0;

			// Token: 0x02000CB6 RID: 3254
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass50_0+<<RunRound>g__RunRound|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E958 RID: 59736 RVA: 0x0036E00C File Offset: 0x0036C20C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0>.NativeClassPtr, "<<RunRound>g__RunRound|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<activeCard>5__2");
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676910);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676911);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676912);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676913);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676914);
					RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100676915);
				}

				// Token: 0x0600E959 RID: 59737 RVA: 0x0036E100 File Offset: 0x0036C300
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E95A RID: 59738 RVA: 0x0036E148 File Offset: 0x0036C348
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E95B RID: 59739 RVA: 0x0036E17C File Offset: 0x0036C37C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214732, XrefRangeEnd = 214908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700481E RID: 18462
				// (get) Token: 0x0600E95C RID: 59740 RVA: 0x0036E1B8 File Offset: 0x0036C3B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E95D RID: 59741 RVA: 0x0036E1F8 File Offset: 0x0036C3F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214908, XrefRangeEnd = 214913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700481F RID: 18463
				// (get) Token: 0x0600E95E RID: 59742 RVA: 0x0036E22C File Offset: 0x0036C42C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E95F RID: 59743 RVA: 0x000716F9 File Offset: 0x0006F8F9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700481A RID: 18458
				// (get) Token: 0x0600E960 RID: 59744 RVA: 0x0036E26C File Offset: 0x0036C46C
				// (set) Token: 0x0600E961 RID: 59745 RVA: 0x00071702 File Offset: 0x0006F902
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700481B RID: 18459
				// (get) Token: 0x0600E962 RID: 59746 RVA: 0x0036E294 File Offset: 0x0036C494
				// (set) Token: 0x0600E963 RID: 59747 RVA: 0x0007171D File Offset: 0x0006F91D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700481C RID: 18460
				// (get) Token: 0x0600E964 RID: 59748 RVA: 0x0036E2C4 File Offset: 0x0036C4C4
				// (set) Token: 0x0600E965 RID: 59749 RVA: 0x0007173C File Offset: 0x0006F93C
				public unsafe RTBGameController.__c__DisplayClass50_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass50_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700481D RID: 18461
				// (get) Token: 0x0600E966 RID: 59750 RVA: 0x0036E2F4 File Offset: 0x0036C4F4
				// (set) Token: 0x0600E967 RID: 59751 RVA: 0x0007175B File Offset: 0x0006F95B
				public unsafe PlayingCard _activeCard_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr__activeCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C2C RID: 39980
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C2D RID: 39981
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C2E RID: 39982
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C2F RID: 39983
				private static readonly System.IntPtr NativeFieldInfoPtr__activeCard_5__2;

				// Token: 0x04009C30 RID: 39984
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C31 RID: 39985
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C32 RID: 39986
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C33 RID: 39987
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C34 RID: 39988
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C35 RID: 39989
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A97 RID: 2711
		[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D53A RID: 54586 RVA: 0x00334BF0 File Offset: 0x00332DF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr);
				RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "cameraDelay");
				RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, 100676916);
				RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, 100676917);
			}

			// Token: 0x0600D53B RID: 54587 RVA: 0x00334C6C File Offset: 0x00332E6C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D53C RID: 54588 RVA: 0x00334CA8 File Offset: 0x00332EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214936, XrefRangeEnd = 214941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D53D RID: 54589 RVA: 0x000676ED File Offset: 0x000658ED
			public __c__DisplayClass53_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EB RID: 16875
			// (get) Token: 0x0600D53E RID: 54590 RVA: 0x00334CE8 File Offset: 0x00332EE8
			// (set) Token: 0x0600D53F RID: 54591 RVA: 0x000676F6 File Offset: 0x000658F6
			public unsafe float cameraDelay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x170041EC RID: 16876
			// (get) Token: 0x0600D540 RID: 54592 RVA: 0x00334D10 File Offset: 0x00332F10
			// (set) Token: 0x0600D541 RID: 54593 RVA: 0x00067711 File Offset: 0x00065911
			public unsafe RTBGameController __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FED RID: 36845
			private static readonly System.IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04008FEE RID: 36846
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FEF RID: 36847
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FF0 RID: 36848
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CB7 RID: 3255
			[ObfuscatedName("ScheduleOne.Casino.RTBGameController+<>c__DisplayClass53_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E968 RID: 59752 RVA: 0x0036E324 File Offset: 0x0036C524
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676918);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676919);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676920);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676921);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676922);
					RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676923);
				}

				// Token: 0x0600E969 RID: 59753 RVA: 0x0036E404 File Offset: 0x0036C604
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E96A RID: 59754 RVA: 0x0036E44C File Offset: 0x0036C64C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E96B RID: 59755 RVA: 0x0036E480 File Offset: 0x0036C680
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214918, XrefRangeEnd = 214931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004823 RID: 18467
				// (get) Token: 0x0600E96C RID: 59756 RVA: 0x0036E4BC File Offset: 0x0036C6BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E96D RID: 59757 RVA: 0x0036E4FC File Offset: 0x0036C6FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214931, XrefRangeEnd = 214936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004824 RID: 18468
				// (get) Token: 0x0600E96E RID: 59758 RVA: 0x0036E530 File Offset: 0x0036C730
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E96F RID: 59759 RVA: 0x0007177A File Offset: 0x0006F97A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004820 RID: 18464
				// (get) Token: 0x0600E970 RID: 59760 RVA: 0x0036E570 File Offset: 0x0036C770
				// (set) Token: 0x0600E971 RID: 59761 RVA: 0x00071783 File Offset: 0x0006F983
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004821 RID: 18465
				// (get) Token: 0x0600E972 RID: 59762 RVA: 0x0036E598 File Offset: 0x0036C798
				// (set) Token: 0x0600E973 RID: 59763 RVA: 0x0007179E File Offset: 0x0006F99E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004822 RID: 18466
				// (get) Token: 0x0600E974 RID: 59764 RVA: 0x0036E5C8 File Offset: 0x0036C7C8
				// (set) Token: 0x0600E975 RID: 59765 RVA: 0x000717BD File Offset: 0x0006F9BD
				public unsafe RTBGameController.__c__DisplayClass53_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController.__c__DisplayClass53_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBGameController.__c__DisplayClass53_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C36 RID: 39990
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C37 RID: 39991
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C38 RID: 39992
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C39 RID: 39993
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C3A RID: 39994
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C3B RID: 39995
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C3C RID: 39996
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C3D RID: 39997
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C3E RID: 39998
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
