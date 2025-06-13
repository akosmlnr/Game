using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Product.Packaging;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000362 RID: 866
	public class BodySearchBehaviour : Behaviour
	{
		// Token: 0x06003F19 RID: 16153 RVA: 0x00141C34 File Offset: 0x0013FE34
		// Note: this type is marked as 'beforefieldinit'.
		static BodySearchBehaviour()
		{
			Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "BodySearchBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr);
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_STEALTH_LEVEL");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_SEARCH_TIME");
			BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MAX_TIME_OUTSIDE_RANGE");
			BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "RANGE_TO_ESCALATE");
			BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MOVE_SPEED");
			BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "BODY_SEARCH_COOLDOWN");
			BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "ShowPostSearchDialogue");
			BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "MaxStealthLevel");
			BodySearchBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "officer");
			BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "targetDistanceOnStart");
			BodySearchBehaviour.NativeFieldInfoPtr_searchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "searchTime");
			BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "hasBeenInRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeOutsideRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeWithinSearchRange");
			BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "timeSinceCantReach");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_Clear");
			BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "onSearchComplete_ItemsFound");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted");
			BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670771);
			BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670772);
			BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670773);
			BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670774);
			BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670775);
			BodySearchBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670776);
			BodySearchBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670777);
			BodySearchBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670778);
			BodySearchBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670779);
			BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670780);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670781);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670782);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670783);
			BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670784);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670785);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670786);
			BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670787);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670788);
			BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670789);
			BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670790);
			BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670791);
			BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670792);
			BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670793);
			BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670794);
			BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670795);
			BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670796);
			BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670797);
			BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670798);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670799);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670800);
			BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670801);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670802);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670803);
			BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670804);
			BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr, 100670805);
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06003F1A RID: 16154 RVA: 0x001420EC File Offset: 0x001402EC
		public unsafe static float BODY_SEARCH_TIME
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150364, XrefRangeEnd = 150369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003F1B RID: 16155 RVA: 0x0014211C File Offset: 0x0014031C
		// (set) Token: 0x06003F1C RID: 16156 RVA: 0x0014215C File Offset: 0x0014035C
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06003F1D RID: 16157 RVA: 0x001421A0 File Offset: 0x001403A0
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x001421E0 File Offset: 0x001403E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150369, XrefRangeEnd = 150376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x0014221C File Offset: 0x0014041C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150376, XrefRangeEnd = 150404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x00142258 File Offset: 0x00140458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150404, XrefRangeEnd = 150418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x00142294 File Offset: 0x00140494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150418, XrefRangeEnd = 150429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x001422D0 File Offset: 0x001404D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150429, XrefRangeEnd = 150436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0014230C File Offset: 0x0014050C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150436, XrefRangeEnd = 150447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x00142348 File Offset: 0x00140548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150493, RefRangeEnd = 150494, XrefRangeStart = 150447, XrefRangeEnd = 150493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x0014237C File Offset: 0x0014057C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150494, XrefRangeEnd = 150513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x001423B8 File Offset: 0x001405B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150513, XrefRangeEnd = 150534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchClean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchClean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x001423EC File Offset: 0x001405EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150534, XrefRangeEnd = 150555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchFail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SearchFail_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x00142420 File Offset: 0x00140620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150577, RefRangeEnd = 150578, XrefRangeStart = 150555, XrefRangeEnd = 150577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00142454 File Offset: 0x00140654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150578, XrefRangeEnd = 150584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00142490 File Offset: 0x00140690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150584, XrefRangeEnd = 150608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x001424CC File Offset: 0x001406CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150608, XrefRangeEnd = 150610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0014250C File Offset: 0x0014070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150610, XrefRangeEnd = 150611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0014254C File Offset: 0x0014074C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150623, RefRangeEnd = 150624, XrefRangeStart = 150611, XrefRangeEnd = 150623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00142588 File Offset: 0x00140788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150629, RefRangeEnd = 150631, XrefRangeStart = 150624, XrefRangeEnd = 150629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x001425BC File Offset: 0x001407BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150631, XrefRangeEnd = 150636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0014260C File Offset: 0x0014080C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150636, XrefRangeEnd = 150638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x0014266C File Offset: 0x0014086C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150638, XrefRangeEnd = 150664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesPlayerContainItemsOfInterest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x001426B4 File Offset: 0x001408B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150664, XrefRangeEnd = 150732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConcludeSearch(bool clear)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clear;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00142700 File Offset: 0x00140900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150732, XrefRangeEnd = 150749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0014273C File Offset: 0x0014093C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150749, XrefRangeEnd = 150752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoItemsOfInterestFound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x00142778 File Offset: 0x00140978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150752, XrefRangeEnd = 150753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BodySearchBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BodySearchBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x001427B4 File Offset: 0x001409B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150753, XrefRangeEnd = 150761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x001427F0 File Offset: 0x001409F0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x0014282C File Offset: 0x00140A2C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00142868 File Offset: 0x00140A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150780, RefRangeEnd = 150781, XrefRangeStart = 150761, XrefRangeEnd = 150780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x001428BC File Offset: 0x00140ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150793, RefRangeEnd = 150795, XrefRangeStart = 150781, XrefRangeEnd = 150793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x0014291C File Offset: 0x00140B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150795, XrefRangeEnd = 150800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BodySearchBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x0014296C File Offset: 0x00140B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150800, XrefRangeEnd = 150807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BodySearchBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x0001F925 File Offset: 0x0001DB25
		public BodySearchBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06003F3E RID: 16190 RVA: 0x001429A8 File Offset: 0x00140BA8
		// (set) Token: 0x06003F3F RID: 16191 RVA: 0x0001F92E File Offset: 0x0001DB2E
		public unsafe static EStealthLevel MAX_STEALTH_LEVEL
		{
			get
			{
				EStealthLevel result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_STEALTH_LEVEL, (void*)(&value));
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003F40 RID: 16192 RVA: 0x001429C4 File Offset: 0x00140BC4
		// (set) Token: 0x06003F41 RID: 16193 RVA: 0x0001F93C File Offset: 0x0001DB3C
		public unsafe static float BODY_SEARCH_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x001429E0 File Offset: 0x00140BE0
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x0001F94A File Offset: 0x0001DB4A
		public unsafe static float MAX_SEARCH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_SEARCH_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x001429FC File Offset: 0x00140BFC
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x0001F958 File Offset: 0x0001DB58
		public unsafe static float MAX_TIME_OUTSIDE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x00142A18 File Offset: 0x00140C18
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x0001F966 File Offset: 0x0001DB66
		public unsafe static float RANGE_TO_ESCALATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_RANGE_TO_ESCALATE, (void*)(&value));
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x00142A34 File Offset: 0x00140C34
		// (set) Token: 0x06003F49 RID: 16201 RVA: 0x0001F974 File Offset: 0x0001DB74
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x00142A50 File Offset: 0x00140C50
		// (set) Token: 0x06003F4B RID: 16203 RVA: 0x0001F982 File Offset: 0x0001DB82
		public unsafe static float BODY_SEARCH_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BodySearchBehaviour.NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06003F4C RID: 16204 RVA: 0x00142A6C File Offset: 0x00140C6C
		// (set) Token: 0x06003F4D RID: 16205 RVA: 0x0001F990 File Offset: 0x0001DB90
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003F4E RID: 16206 RVA: 0x00142A9C File Offset: 0x00140C9C
		// (set) Token: 0x06003F4F RID: 16207 RVA: 0x0001F9AF File Offset: 0x0001DBAF
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x00142AC4 File Offset: 0x00140CC4
		// (set) Token: 0x06003F51 RID: 16209 RVA: 0x0001F9CA File Offset: 0x0001DBCA
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x00142AEC File Offset: 0x00140CEC
		// (set) Token: 0x06003F53 RID: 16211 RVA: 0x0001F9E5 File Offset: 0x0001DBE5
		public unsafe bool ShowPostSearchDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_ShowPostSearchDialogue)) = value;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06003F54 RID: 16212 RVA: 0x00142B14 File Offset: 0x00140D14
		// (set) Token: 0x06003F55 RID: 16213 RVA: 0x0001FA00 File Offset: 0x0001DC00
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06003F56 RID: 16214 RVA: 0x00142B3C File Offset: 0x00140D3C
		// (set) Token: 0x06003F57 RID: 16215 RVA: 0x0001FA1B File Offset: 0x0001DC1B
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06003F58 RID: 16216 RVA: 0x00142B6C File Offset: 0x00140D6C
		// (set) Token: 0x06003F59 RID: 16217 RVA: 0x0001FA3A File Offset: 0x0001DC3A
		public unsafe float targetDistanceOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_targetDistanceOnStart)) = value;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06003F5A RID: 16218 RVA: 0x00142B94 File Offset: 0x00140D94
		// (set) Token: 0x06003F5B RID: 16219 RVA: 0x0001FA55 File Offset: 0x0001DC55
		public unsafe float searchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_searchTime)) = value;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06003F5C RID: 16220 RVA: 0x00142BBC File Offset: 0x00140DBC
		// (set) Token: 0x06003F5D RID: 16221 RVA: 0x0001FA70 File Offset: 0x0001DC70
		public unsafe bool hasBeenInRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_hasBeenInRange)) = value;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06003F5E RID: 16222 RVA: 0x00142BE4 File Offset: 0x00140DE4
		// (set) Token: 0x06003F5F RID: 16223 RVA: 0x0001FA8B File Offset: 0x0001DC8B
		public unsafe float timeOutsideRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeOutsideRange)) = value;
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06003F60 RID: 16224 RVA: 0x00142C0C File Offset: 0x00140E0C
		// (set) Token: 0x06003F61 RID: 16225 RVA: 0x0001FAA6 File Offset: 0x0001DCA6
		public unsafe float timeWithinSearchRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeWithinSearchRange)) = value;
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06003F62 RID: 16226 RVA: 0x00142C34 File Offset: 0x00140E34
		// (set) Token: 0x06003F63 RID: 16227 RVA: 0x0001FAC1 File Offset: 0x0001DCC1
		public unsafe float timeSinceCantReach
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_timeSinceCantReach)) = value;
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06003F64 RID: 16228 RVA: 0x00142C5C File Offset: 0x00140E5C
		// (set) Token: 0x06003F65 RID: 16229 RVA: 0x0001FADC File Offset: 0x0001DCDC
		public unsafe UnityEvent onSearchComplete_Clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_Clear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06003F66 RID: 16230 RVA: 0x00142C8C File Offset: 0x00140E8C
		// (set) Token: 0x06003F67 RID: 16231 RVA: 0x0001FAFB File Offset: 0x0001DCFB
		public unsafe UnityEvent onSearchComplete_ItemsFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_onSearchComplete_ItemsFound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00142CBC File Offset: 0x00140EBC
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x0001FB1A File Offset: 0x0001DD1A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x00142CE4 File Offset: 0x00140EE4
		// (set) Token: 0x06003F6B RID: 16235 RVA: 0x0001FB35 File Offset: 0x0001DD35
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BodySearchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040029B1 RID: 10673
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEALTH_LEVEL;

		// Token: 0x040029B2 RID: 10674
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_RANGE;

		// Token: 0x040029B3 RID: 10675
		private static readonly IntPtr NativeFieldInfoPtr_MAX_SEARCH_TIME;

		// Token: 0x040029B4 RID: 10676
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TIME_OUTSIDE_RANGE;

		// Token: 0x040029B5 RID: 10677
		private static readonly IntPtr NativeFieldInfoPtr_RANGE_TO_ESCALATE;

		// Token: 0x040029B6 RID: 10678
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x040029B7 RID: 10679
		private static readonly IntPtr NativeFieldInfoPtr_BODY_SEARCH_COOLDOWN;

		// Token: 0x040029B8 RID: 10680
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x040029B9 RID: 10681
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x040029BA RID: 10682
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x040029BB RID: 10683
		private static readonly IntPtr NativeFieldInfoPtr_ShowPostSearchDialogue;

		// Token: 0x040029BC RID: 10684
		private static readonly IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x040029BD RID: 10685
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeFieldInfoPtr_targetDistanceOnStart;

		// Token: 0x040029BF RID: 10687
		private static readonly IntPtr NativeFieldInfoPtr_searchTime;

		// Token: 0x040029C0 RID: 10688
		private static readonly IntPtr NativeFieldInfoPtr_hasBeenInRange;

		// Token: 0x040029C1 RID: 10689
		private static readonly IntPtr NativeFieldInfoPtr_timeOutsideRange;

		// Token: 0x040029C2 RID: 10690
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinSearchRange;

		// Token: 0x040029C3 RID: 10691
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCantReach;

		// Token: 0x040029C4 RID: 10692
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_Clear;

		// Token: 0x040029C5 RID: 10693
		private static readonly IntPtr NativeFieldInfoPtr_onSearchComplete_ItemsFound;

		// Token: 0x040029C6 RID: 10694
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040029C7 RID: 10695
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040029C8 RID: 10696
		private static readonly IntPtr NativeMethodInfoPtr_get_BODY_SEARCH_TIME_Public_Static_get_Single_0;

		// Token: 0x040029C9 RID: 10697
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x040029CA RID: 10698
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSearch_Private_Void_0;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovement_Protected_Virtual_New_Void_0;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeMethodInfoPtr_SearchClean_Private_Void_0;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeMethodInfoPtr_SearchFail_Private_Void_0;

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_0;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCircle_Protected_Virtual_New_Void_0;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Vector3_0;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_Player_0;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerContainItemsOfInterest_Public_Virtual_New_Boolean_0;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Virtual_New_Void_0;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeMethodInfoPtr_NoItemsOfInterestFound_Public_Virtual_New_Void_0;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040029E5 RID: 10725
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040029E6 RID: 10726
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040029E7 RID: 10727
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040029E8 RID: 10728
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040029E9 RID: 10729
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029EA RID: 10730
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
