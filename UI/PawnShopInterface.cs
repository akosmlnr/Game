using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000674 RID: 1652
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x060091B7 RID: 37303 RVA: 0x0025F0B0 File Offset: 0x0025D2B0
		// Note: this type is marked as 'beforefieldinit'.
		static PawnShopInterface()
		{
			Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PawnShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr);
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MIN");
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MAX");
			PawnShopInterface.NativeFieldInfoPtr_THINK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "THINK_TIME");
			PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MIN_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MAX_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAWN_SLOT_COUNT");
			PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentState");
			PawnShopInterface.NativeFieldInfoPtr_PlayerResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PlayerResponse");
			PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentNegotiationRound");
			PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "InitialShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastRefusedAmount");
			PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnShopNPC");
			PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<SelectedPayment>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<NPCAnger>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_RandomCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RandomCurve");
			PawnShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Canvas");
			PawnShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Container");
			PawnShopInterface.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Slots");
			PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ValueRangeLabels");
			PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "TotalValueLabel");
			PawnShopInterface.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "StartButton");
			PawnShopInterface.NativeFieldInfoPtr_Step1Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_Step2Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_FadeInAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeInAnim");
			PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeOutAnim");
			PawnShopInterface.NativeFieldInfoPtr_OfferInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferInputField");
			PawnShopInterface.NativeFieldInfoPtr_AngerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngerSlider");
			PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptCounterButtonLabel");
			PawnShopInterface.NativeFieldInfoPtr_OfferLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferLines");
			PawnShopInterface.NativeFieldInfoPtr_ThinkLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ThinkLines");
			PawnShopInterface.NativeFieldInfoPtr_AcceptLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptLines");
			PawnShopInterface.NativeFieldInfoPtr_CounterLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CounterLines");
			PawnShopInterface.NativeFieldInfoPtr_RefusalLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RefusalLines");
			PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "DealFinalizedLines");
			PawnShopInterface.NativeFieldInfoPtr_AngeredLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngeredLines");
			PawnShopInterface.NativeFieldInfoPtr_CrashOutLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CrashOutLines");
			PawnShopInterface.NativeFieldInfoPtr_PawnSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnSlots");
			PawnShopInterface.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "routine");
			PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681461);
			PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681462);
			PawnShopInterface.NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681463);
			PawnShopInterface.NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681464);
			PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681465);
			PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681466);
			PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681467);
			PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681468);
			PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681469);
			PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681470);
			PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681471);
			PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681472);
			PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681473);
			PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681474);
			PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681475);
			PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681476);
			PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681477);
			PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681478);
			PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681479);
			PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681480);
			PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681481);
			PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681482);
			PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681483);
			PawnShopInterface.NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681484);
			PawnShopInterface.NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681485);
			PawnShopInterface.NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681486);
			PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681487);
			PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681488);
			PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681489);
			PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681490);
			PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681491);
			PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681492);
			PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681493);
			PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681494);
			PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681495);
			PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681496);
			PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681497);
			PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681498);
			PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681499);
			PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681500);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681501);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681502);
		}

		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x0025F770 File Offset: 0x0025D970
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x0025F7AC File Offset: 0x0025D9AC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C87 RID: 11399
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x0025F7EC File Offset: 0x0025D9EC
		// (set) Token: 0x060091BB RID: 37307 RVA: 0x0025F828 File Offset: 0x0025DA28
		public unsafe float SelectedPayment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C88 RID: 11400
		// (get) Token: 0x060091BC RID: 37308 RVA: 0x0025F868 File Offset: 0x0025DA68
		// (set) Token: 0x060091BD RID: 37309 RVA: 0x0025F8A4 File Offset: 0x0025DAA4
		public unsafe float NPCAnger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86985, RefRangeEnd = 86987, XrefRangeStart = 86985, XrefRangeEnd = 86987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x0025F8E4 File Offset: 0x0025DAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264289, XrefRangeEnd = 264362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x0025F920 File Offset: 0x0025DB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264362, XrefRangeEnd = 264426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C0 RID: 37312 RVA: 0x0025F95C File Offset: 0x0025DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264426, XrefRangeEnd = 264460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C1 RID: 37313 RVA: 0x0025F998 File Offset: 0x0025DB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264460, XrefRangeEnd = 264521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C2 RID: 37314 RVA: 0x0025F9CC File Offset: 0x0025DBCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264572, RefRangeEnd = 264575, XrefRangeStart = 264521, XrefRangeEnd = 264572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool returnItemsToPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref returnItemsToPlayer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x0025FA0C File Offset: 0x0025DC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264575, XrefRangeEnd = 264577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x0025FA50 File Offset: 0x0025DC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264577, XrefRangeEnd = 264578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x0025FA84 File Offset: 0x0025DC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264578, XrefRangeEnd = 264579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x0025FAB8 File Offset: 0x0025DCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264579, XrefRangeEnd = 264604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x0025FAEC File Offset: 0x0025DCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264604, XrefRangeEnd = 264614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetPawnItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr2) : null;
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x0025FB2C File Offset: 0x0025DD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264614, XrefRangeEnd = 264615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PawnSlotChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x0025FB60 File Offset: 0x0025DD60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264637, RefRangeEnd = 264639, XrefRangeStart = 264615, XrefRangeEnd = 264637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueRangeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x0025FB94 File Offset: 0x0025DD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264639, XrefRangeEnd = 264646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x0025FBC8 File Offset: 0x0025DDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x0025FBFC File Offset: 0x0025DDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264646, XrefRangeEnd = 264652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref counter;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x0025FC48 File Offset: 0x0025DE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264652, XrefRangeEnd = 264682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lastShopOffer;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playerOffer;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &counterAmount;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &angerChange;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x0025FCBC File Offset: 0x0025DEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264682, XrefRangeEnd = 264686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x0025FCF0 File Offset: 0x0025DEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264686, XrefRangeEnd = 264688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PaymentSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x0025FD34 File Offset: 0x0025DF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264688, XrefRangeEnd = 264689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePayment(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x0025FD74 File Offset: 0x0025DF74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264709, RefRangeEnd = 264712, XrefRangeStart = 264689, XrefRangeEnd = 264709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedPayment(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x0025FDB4 File Offset: 0x0025DFB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264722, RefRangeEnd = 264725, XrefRangeStart = 264712, XrefRangeEnd = 264722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref response;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x0025FDF4 File Offset: 0x0025DFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264725, XrefRangeEnd = 264726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptOrCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x0025FE28 File Offset: 0x0025E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264726, XrefRangeEnd = 264727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x0025FE5C File Offset: 0x0025E05C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264760, RefRangeEnd = 264761, XrefRangeStart = 264727, XrefRangeEnd = 264760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAnger(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x0025FE9C File Offset: 0x0025E09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264772, RefRangeEnd = 264774, XrefRangeStart = 264761, XrefRangeEnd = 264772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngeredToday(bool angered)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref angered;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x0025FEDC File Offset: 0x0025E0DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264778, RefRangeEnd = 264779, XrefRangeStart = 264774, XrefRangeEnd = 264778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Think()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x0025FF10 File Offset: 0x0025E110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264793, RefRangeEnd = 264794, XrefRangeStart = 264779, XrefRangeEnd = 264793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffer(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x0025FF50 File Offset: 0x0025E150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264804, RefRangeEnd = 264805, XrefRangeStart = 264794, XrefRangeEnd = 264804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeDeal(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x0025FF90 File Offset: 0x0025E190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264805, XrefRangeEnd = 264807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x0025FFCC File Offset: 0x0025E1CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264808, RefRangeEnd = 264810, XrefRangeStart = 264807, XrefRangeEnd = 264808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundOffer(float offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref offer;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x00260018 File Offset: 0x0025E218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264839, RefRangeEnd = 264841, XrefRangeStart = 264810, XrefRangeEnd = 264839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetItemValue(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x00260068 File Offset: 0x0025E268
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264848, RefRangeEnd = 264851, XrefRangeStart = 264841, XrefRangeEnd = 264848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x0026009C File Offset: 0x0025E29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264851, XrefRangeEnd = 264854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x002600D8 File Offset: 0x0025E2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264854, XrefRangeEnd = 264859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x00260118 File Offset: 0x0025E318
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 264859, RefRangeEnd = 264868, XrefRangeStart = 264859, XrefRangeEnd = 264859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__67_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060091E1 RID: 37345 RVA: 0x00260154 File Offset: 0x0025E354
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 264859, RefRangeEnd = 264868, XrefRangeStart = 264859, XrefRangeEnd = 264868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__67_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060091E2 RID: 37346 RVA: 0x00045FAB File Offset: 0x000441AB
		public PawnShopInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x060091E3 RID: 37347 RVA: 0x00260190 File Offset: 0x0025E390
		// (set) Token: 0x060091E4 RID: 37348 RVA: 0x00045FB4 File Offset: 0x000441B4
		public unsafe static float PAYMENT_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x060091E5 RID: 37349 RVA: 0x002601AC File Offset: 0x0025E3AC
		// (set) Token: 0x060091E6 RID: 37350 RVA: 0x00045FC2 File Offset: 0x000441C2
		public unsafe static float PAYMENT_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x060091E7 RID: 37351 RVA: 0x002601C8 File Offset: 0x0025E3C8
		// (set) Token: 0x060091E8 RID: 37352 RVA: 0x00045FD0 File Offset: 0x000441D0
		public unsafe static float THINK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x002601E4 File Offset: 0x0025E3E4
		// (set) Token: 0x060091EA RID: 37354 RVA: 0x00045FDE File Offset: 0x000441DE
		public unsafe static float MIN_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x060091EB RID: 37355 RVA: 0x00260200 File Offset: 0x0025E400
		// (set) Token: 0x060091EC RID: 37356 RVA: 0x00045FEC File Offset: 0x000441EC
		public unsafe static float MAX_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x060091ED RID: 37357 RVA: 0x0026021C File Offset: 0x0025E41C
		// (set) Token: 0x060091EE RID: 37358 RVA: 0x00045FFA File Offset: 0x000441FA
		public unsafe static int PAWN_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x060091EF RID: 37359 RVA: 0x00260238 File Offset: 0x0025E438
		// (set) Token: 0x060091F0 RID: 37360 RVA: 0x00046008 File Offset: 0x00044208
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x060091F1 RID: 37361 RVA: 0x00260260 File Offset: 0x0025E460
		// (set) Token: 0x060091F2 RID: 37362 RVA: 0x00046023 File Offset: 0x00044223
		public unsafe PawnShopInterface.EState CurrentState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x060091F3 RID: 37363 RVA: 0x00260288 File Offset: 0x0025E488
		// (set) Token: 0x060091F4 RID: 37364 RVA: 0x0004603E File Offset: 0x0004423E
		public unsafe PawnShopInterface.EPlayerResponse PlayerResponse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse)) = value;
			}
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x060091F5 RID: 37365 RVA: 0x002602B0 File Offset: 0x0025E4B0
		// (set) Token: 0x060091F6 RID: 37366 RVA: 0x00046059 File Offset: 0x00044259
		public unsafe int CurrentNegotiationRound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound)) = value;
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x060091F7 RID: 37367 RVA: 0x002602D8 File Offset: 0x0025E4D8
		// (set) Token: 0x060091F8 RID: 37368 RVA: 0x00046074 File Offset: 0x00044274
		public unsafe float InitialShopOffer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer)) = value;
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x060091F9 RID: 37369 RVA: 0x00260300 File Offset: 0x0025E500
		// (set) Token: 0x060091FA RID: 37370 RVA: 0x0004608F File Offset: 0x0004428F
		public unsafe float LastShopOffer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer)) = value;
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x060091FB RID: 37371 RVA: 0x00260328 File Offset: 0x0025E528
		// (set) Token: 0x060091FC RID: 37372 RVA: 0x000460AA File Offset: 0x000442AA
		public unsafe float LastRefusedAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount)) = value;
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x060091FD RID: 37373 RVA: 0x00260350 File Offset: 0x0025E550
		// (set) Token: 0x060091FE RID: 37374 RVA: 0x000460C5 File Offset: 0x000442C5
		public unsafe NPC PawnShopNPC
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x060091FF RID: 37375 RVA: 0x00260380 File Offset: 0x0025E580
		// (set) Token: 0x06009200 RID: 37376 RVA: 0x000460E4 File Offset: 0x000442E4
		public unsafe float _SelectedPayment_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x06009201 RID: 37377 RVA: 0x002603A8 File Offset: 0x0025E5A8
		// (set) Token: 0x06009202 RID: 37378 RVA: 0x000460FF File Offset: 0x000442FF
		public unsafe float _NPCAnger_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06009203 RID: 37379 RVA: 0x002603D0 File Offset: 0x0025E5D0
		// (set) Token: 0x06009204 RID: 37380 RVA: 0x0004611A File Offset: 0x0004431A
		public unsafe AnimationCurve RandomCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06009205 RID: 37381 RVA: 0x00260400 File Offset: 0x0025E600
		// (set) Token: 0x06009206 RID: 37382 RVA: 0x00046139 File Offset: 0x00044339
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06009207 RID: 37383 RVA: 0x00260430 File Offset: 0x0025E630
		// (set) Token: 0x06009208 RID: 37384 RVA: 0x00046158 File Offset: 0x00044358
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06009209 RID: 37385 RVA: 0x00260460 File Offset: 0x0025E660
		// (set) Token: 0x0600920A RID: 37386 RVA: 0x00046177 File Offset: 0x00044377
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600920B RID: 37387 RVA: 0x00260490 File Offset: 0x0025E690
		// (set) Token: 0x0600920C RID: 37388 RVA: 0x00046196 File Offset: 0x00044396
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> ValueRangeLabels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600920D RID: 37389 RVA: 0x002604C0 File Offset: 0x0025E6C0
		// (set) Token: 0x0600920E RID: 37390 RVA: 0x000461B5 File Offset: 0x000443B5
		public unsafe TextMeshProUGUI TotalValueLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600920F RID: 37391 RVA: 0x002604F0 File Offset: 0x0025E6F0
		// (set) Token: 0x06009210 RID: 37392 RVA: 0x000461D4 File Offset: 0x000443D4
		public unsafe Button StartButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x06009211 RID: 37393 RVA: 0x00260520 File Offset: 0x0025E720
		// (set) Token: 0x06009212 RID: 37394 RVA: 0x000461F3 File Offset: 0x000443F3
		public unsafe Animation Step1Animation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06009213 RID: 37395 RVA: 0x00260550 File Offset: 0x0025E750
		// (set) Token: 0x06009214 RID: 37396 RVA: 0x00046212 File Offset: 0x00044412
		public unsafe CanvasGroup Step1CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06009215 RID: 37397 RVA: 0x00260580 File Offset: 0x0025E780
		// (set) Token: 0x06009216 RID: 37398 RVA: 0x00046231 File Offset: 0x00044431
		public unsafe Animation Step2Animation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06009217 RID: 37399 RVA: 0x002605B0 File Offset: 0x0025E7B0
		// (set) Token: 0x06009218 RID: 37400 RVA: 0x00046250 File Offset: 0x00044450
		public unsafe CanvasGroup Step2CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06009219 RID: 37401 RVA: 0x002605E0 File Offset: 0x0025E7E0
		// (set) Token: 0x0600921A RID: 37402 RVA: 0x0004626F File Offset: 0x0004446F
		public unsafe AnimationClip FadeInAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600921B RID: 37403 RVA: 0x00260610 File Offset: 0x0025E810
		// (set) Token: 0x0600921C RID: 37404 RVA: 0x0004628E File Offset: 0x0004448E
		public unsafe AnimationClip FadeOutAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600921D RID: 37405 RVA: 0x00260640 File Offset: 0x0025E840
		// (set) Token: 0x0600921E RID: 37406 RVA: 0x000462AD File Offset: 0x000444AD
		public unsafe TMP_InputField OfferInputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferInputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600921F RID: 37407 RVA: 0x00260670 File Offset: 0x0025E870
		// (set) Token: 0x06009220 RID: 37408 RVA: 0x000462CC File Offset: 0x000444CC
		public unsafe Slider AngerSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x06009221 RID: 37409 RVA: 0x002606A0 File Offset: 0x0025E8A0
		// (set) Token: 0x06009222 RID: 37410 RVA: 0x000462EB File Offset: 0x000444EB
		public unsafe TextMeshProUGUI AcceptCounterButtonLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x002606D0 File Offset: 0x0025E8D0
		// (set) Token: 0x06009224 RID: 37412 RVA: 0x0004630A File Offset: 0x0004450A
		public unsafe Il2CppStringArray OfferLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x00260700 File Offset: 0x0025E900
		// (set) Token: 0x06009226 RID: 37414 RVA: 0x00046329 File Offset: 0x00044529
		public unsafe Il2CppStringArray ThinkLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06009227 RID: 37415 RVA: 0x00260730 File Offset: 0x0025E930
		// (set) Token: 0x06009228 RID: 37416 RVA: 0x00046348 File Offset: 0x00044548
		public unsafe Il2CppStringArray AcceptLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06009229 RID: 37417 RVA: 0x00260760 File Offset: 0x0025E960
		// (set) Token: 0x0600922A RID: 37418 RVA: 0x00046367 File Offset: 0x00044567
		public unsafe Il2CppStringArray CounterLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600922B RID: 37419 RVA: 0x00260790 File Offset: 0x0025E990
		// (set) Token: 0x0600922C RID: 37420 RVA: 0x00046386 File Offset: 0x00044586
		public unsafe Il2CppStringArray RefusalLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0600922D RID: 37421 RVA: 0x002607C0 File Offset: 0x0025E9C0
		// (set) Token: 0x0600922E RID: 37422 RVA: 0x000463A5 File Offset: 0x000445A5
		public unsafe Il2CppStringArray DealFinalizedLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0600922F RID: 37423 RVA: 0x002607F0 File Offset: 0x0025E9F0
		// (set) Token: 0x06009230 RID: 37424 RVA: 0x000463C4 File Offset: 0x000445C4
		public unsafe Il2CppStringArray AngeredLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06009231 RID: 37425 RVA: 0x00260820 File Offset: 0x0025EA20
		// (set) Token: 0x06009232 RID: 37426 RVA: 0x000463E3 File Offset: 0x000445E3
		public unsafe Il2CppStringArray CrashOutLines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06009233 RID: 37427 RVA: 0x00260850 File Offset: 0x0025EA50
		// (set) Token: 0x06009234 RID: 37428 RVA: 0x00046402 File Offset: 0x00044602
		public unsafe Il2CppReferenceArray<ItemSlot> PawnSlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C85 RID: 11397
		// (get) Token: 0x06009235 RID: 37429 RVA: 0x00260880 File Offset: 0x0025EA80
		// (set) Token: 0x06009236 RID: 37430 RVA: 0x00046421 File Offset: 0x00044621
		public unsafe Coroutine routine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400629B RID: 25243
		private static readonly System.IntPtr NativeFieldInfoPtr_PAYMENT_MIN;

		// Token: 0x0400629C RID: 25244
		private static readonly System.IntPtr NativeFieldInfoPtr_PAYMENT_MAX;

		// Token: 0x0400629D RID: 25245
		private static readonly System.IntPtr NativeFieldInfoPtr_THINK_TIME;

		// Token: 0x0400629E RID: 25246
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER;

		// Token: 0x0400629F RID: 25247
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER;

		// Token: 0x040062A0 RID: 25248
		private static readonly System.IntPtr NativeFieldInfoPtr_PAWN_SLOT_COUNT;

		// Token: 0x040062A1 RID: 25249
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040062A2 RID: 25250
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x040062A3 RID: 25251
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerResponse;

		// Token: 0x040062A4 RID: 25252
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentNegotiationRound;

		// Token: 0x040062A5 RID: 25253
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialShopOffer;

		// Token: 0x040062A6 RID: 25254
		private static readonly System.IntPtr NativeFieldInfoPtr_LastShopOffer;

		// Token: 0x040062A7 RID: 25255
		private static readonly System.IntPtr NativeFieldInfoPtr_LastRefusedAmount;

		// Token: 0x040062A8 RID: 25256
		private static readonly System.IntPtr NativeFieldInfoPtr_PawnShopNPC;

		// Token: 0x040062A9 RID: 25257
		private static readonly System.IntPtr NativeFieldInfoPtr__SelectedPayment_k__BackingField;

		// Token: 0x040062AA RID: 25258
		private static readonly System.IntPtr NativeFieldInfoPtr__NPCAnger_k__BackingField;

		// Token: 0x040062AB RID: 25259
		private static readonly System.IntPtr NativeFieldInfoPtr_RandomCurve;

		// Token: 0x040062AC RID: 25260
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040062AD RID: 25261
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040062AE RID: 25262
		private static readonly System.IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x040062AF RID: 25263
		private static readonly System.IntPtr NativeFieldInfoPtr_ValueRangeLabels;

		// Token: 0x040062B0 RID: 25264
		private static readonly System.IntPtr NativeFieldInfoPtr_TotalValueLabel;

		// Token: 0x040062B1 RID: 25265
		private static readonly System.IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x040062B2 RID: 25266
		private static readonly System.IntPtr NativeFieldInfoPtr_Step1Animation;

		// Token: 0x040062B3 RID: 25267
		private static readonly System.IntPtr NativeFieldInfoPtr_Step1CanvasGroup;

		// Token: 0x040062B4 RID: 25268
		private static readonly System.IntPtr NativeFieldInfoPtr_Step2Animation;

		// Token: 0x040062B5 RID: 25269
		private static readonly System.IntPtr NativeFieldInfoPtr_Step2CanvasGroup;

		// Token: 0x040062B6 RID: 25270
		private static readonly System.IntPtr NativeFieldInfoPtr_FadeInAnim;

		// Token: 0x040062B7 RID: 25271
		private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutAnim;

		// Token: 0x040062B8 RID: 25272
		private static readonly System.IntPtr NativeFieldInfoPtr_OfferInputField;

		// Token: 0x040062B9 RID: 25273
		private static readonly System.IntPtr NativeFieldInfoPtr_AngerSlider;

		// Token: 0x040062BA RID: 25274
		private static readonly System.IntPtr NativeFieldInfoPtr_AcceptCounterButtonLabel;

		// Token: 0x040062BB RID: 25275
		private static readonly System.IntPtr NativeFieldInfoPtr_OfferLines;

		// Token: 0x040062BC RID: 25276
		private static readonly System.IntPtr NativeFieldInfoPtr_ThinkLines;

		// Token: 0x040062BD RID: 25277
		private static readonly System.IntPtr NativeFieldInfoPtr_AcceptLines;

		// Token: 0x040062BE RID: 25278
		private static readonly System.IntPtr NativeFieldInfoPtr_CounterLines;

		// Token: 0x040062BF RID: 25279
		private static readonly System.IntPtr NativeFieldInfoPtr_RefusalLines;

		// Token: 0x040062C0 RID: 25280
		private static readonly System.IntPtr NativeFieldInfoPtr_DealFinalizedLines;

		// Token: 0x040062C1 RID: 25281
		private static readonly System.IntPtr NativeFieldInfoPtr_AngeredLines;

		// Token: 0x040062C2 RID: 25282
		private static readonly System.IntPtr NativeFieldInfoPtr_CrashOutLines;

		// Token: 0x040062C3 RID: 25283
		private static readonly System.IntPtr NativeFieldInfoPtr_PawnSlots;

		// Token: 0x040062C4 RID: 25284
		private static readonly System.IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x040062C5 RID: 25285
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040062C6 RID: 25286
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040062C7 RID: 25287
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0;

		// Token: 0x040062C8 RID: 25288
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0;

		// Token: 0x040062C9 RID: 25289
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0;

		// Token: 0x040062CA RID: 25290
		private static readonly System.IntPtr NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0;

		// Token: 0x040062CB RID: 25291
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040062CC RID: 25292
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040062CD RID: 25293
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040062CE RID: 25294
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040062CF RID: 25295
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040062D0 RID: 25296
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040062D1 RID: 25297
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040062D2 RID: 25298
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDayPass_Private_Void_0;

		// Token: 0x040062D3 RID: 25299
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040062D4 RID: 25300
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0;

		// Token: 0x040062D5 RID: 25301
		private static readonly System.IntPtr NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0;

		// Token: 0x040062D6 RID: 25302
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0;

		// Token: 0x040062D7 RID: 25303
		private static readonly System.IntPtr NativeMethodInfoPtr_StartButtonPressed_Public_Void_0;

		// Token: 0x040062D8 RID: 25304
		private static readonly System.IntPtr NativeMethodInfoPtr_StartNegotiation_Private_Void_0;

		// Token: 0x040062D9 RID: 25305
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0;

		// Token: 0x040062DA RID: 25306
		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x040062DB RID: 25307
		private static readonly System.IntPtr NativeMethodInfoPtr_EndNegotiation_Private_Void_0;

		// Token: 0x040062DC RID: 25308
		private static readonly System.IntPtr NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0;

		// Token: 0x040062DD RID: 25309
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0;

		// Token: 0x040062DE RID: 25310
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0;

		// Token: 0x040062DF RID: 25311
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0;

		// Token: 0x040062E0 RID: 25312
		private static readonly System.IntPtr NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0;

		// Token: 0x040062E1 RID: 25313
		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x040062E2 RID: 25314
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0;

		// Token: 0x040062E3 RID: 25315
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0;

		// Token: 0x040062E4 RID: 25316
		private static readonly System.IntPtr NativeMethodInfoPtr_Think_Private_Void_0;

		// Token: 0x040062E5 RID: 25317
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOffer_Private_Void_Single_0;

		// Token: 0x040062E6 RID: 25318
		private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0;

		// Token: 0x040062E7 RID: 25319
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalValue_Private_Single_0;

		// Token: 0x040062E8 RID: 25320
		private static readonly System.IntPtr NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0;

		// Token: 0x040062E9 RID: 25321
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0;

		// Token: 0x040062EA RID: 25322
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetUI_Private_Void_0;

		// Token: 0x040062EB RID: 25323
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040062EC RID: 25324
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040062ED RID: 25325
		private static readonly System.IntPtr NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0;

		// Token: 0x040062EE RID: 25326
		private static readonly System.IntPtr NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0;

		// Token: 0x02000B82 RID: 2946
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x040094CA RID: 38090
			WaitingForOffer,
			// Token: 0x040094CB RID: 38091
			Negotiating
		}

		// Token: 0x02000B83 RID: 2947
		[OriginalName("Assembly-CSharp.dll", "", "EPlayerResponse")]
		public enum EPlayerResponse
		{
			// Token: 0x040094CD RID: 38093
			None,
			// Token: 0x040094CE RID: 38094
			Accept,
			// Token: 0x040094CF RID: 38095
			Counter,
			// Token: 0x040094D0 RID: 38096
			Cancel
		}

		// Token: 0x02000B84 RID: 2948
		[OriginalName("Assembly-CSharp.dll", "", "EShopResponse")]
		public enum EShopResponse
		{
			// Token: 0x040094D2 RID: 38098
			Accept,
			// Token: 0x040094D3 RID: 38099
			Counter,
			// Token: 0x040094D4 RID: 38100
			Refusal
		}

		// Token: 0x02000B85 RID: 2949
		[ObfuscatedName("ScheduleOne.UI.PawnShopInterface+<<StartNegotiation>g__NegotiationRoutine|67_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DD59 RID: 56665 RVA: 0x0034B7E8 File Offset: 0x003499E8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique()
			{
				Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<<StartNegotiation>g__NegotiationRoutine|67_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>1__state");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>2__current");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>4__this");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<shopResponse>5__2");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<counter>5__3");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681503);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681504);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681505);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681506);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681507);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681508);
			}

			// Token: 0x0600DD5A RID: 56666 RVA: 0x0034B8F0 File Offset: 0x00349AF0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD5B RID: 56667 RVA: 0x0034B938 File Offset: 0x00349B38
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD5C RID: 56668 RVA: 0x0034B96C File Offset: 0x00349B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264239, XrefRangeEnd = 264284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004453 RID: 17491
			// (get) Token: 0x0600DD5D RID: 56669 RVA: 0x0034B9A8 File Offset: 0x00349BA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD5E RID: 56670 RVA: 0x0034B9E8 File Offset: 0x00349BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264284, XrefRangeEnd = 264289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004454 RID: 17492
			// (get) Token: 0x0600DD5F RID: 56671 RVA: 0x0034BA1C File Offset: 0x00349C1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DD60 RID: 56672 RVA: 0x0006B79A File Offset: 0x0006999A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700444E RID: 17486
			// (get) Token: 0x0600DD61 RID: 56673 RVA: 0x0034BA5C File Offset: 0x00349C5C
			// (set) Token: 0x0600DD62 RID: 56674 RVA: 0x0006B7A3 File Offset: 0x000699A3
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700444F RID: 17487
			// (get) Token: 0x0600DD63 RID: 56675 RVA: 0x0034BA84 File Offset: 0x00349C84
			// (set) Token: 0x0600DD64 RID: 56676 RVA: 0x0006B7BE File Offset: 0x000699BE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004450 RID: 17488
			// (get) Token: 0x0600DD65 RID: 56677 RVA: 0x0034BAB4 File Offset: 0x00349CB4
			// (set) Token: 0x0600DD66 RID: 56678 RVA: 0x0006B7DD File Offset: 0x000699DD
			public unsafe PawnShopInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PawnShopInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004451 RID: 17489
			// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x0034BAE4 File Offset: 0x00349CE4
			// (set) Token: 0x0600DD68 RID: 56680 RVA: 0x0006B7FC File Offset: 0x000699FC
			public unsafe PawnShopInterface.EShopResponse _shopResponse_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2)) = value;
				}
			}

			// Token: 0x17004452 RID: 17490
			// (get) Token: 0x0600DD69 RID: 56681 RVA: 0x0034BB0C File Offset: 0x00349D0C
			// (set) Token: 0x0600DD6A RID: 56682 RVA: 0x0006B817 File Offset: 0x00069A17
			public unsafe float _counter_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3)) = value;
				}
			}

			// Token: 0x040094D5 RID: 38101
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094D6 RID: 38102
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094D7 RID: 38103
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094D8 RID: 38104
			private static readonly System.IntPtr NativeFieldInfoPtr__shopResponse_5__2;

			// Token: 0x040094D9 RID: 38105
			private static readonly System.IntPtr NativeFieldInfoPtr__counter_5__3;

			// Token: 0x040094DA RID: 38106
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094DB RID: 38107
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094DC RID: 38108
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094DD RID: 38109
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094DE RID: 38110
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094DF RID: 38111
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
