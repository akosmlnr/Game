using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000180 RID: 384
	public class VisionCone : NetworkBehaviour
	{
		// Token: 0x06001E52 RID: 7762 RVA: 0x000D1A34 File Offset: 0x000CFC34
		// Note: this type is marked as 'beforefieldinit'.
		static VisionCone()
		{
			Il2CppClassPointerStore<VisionCone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionCone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone>.NativeClassPtr);
			VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VISION_UPDATE_INTERVAL");
			VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UniversalAttentivenessScale");
			VisionCone.NativeFieldInfoPtr_UniversalMemoryScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "UniversalMemoryScale");
			VisionCone.NativeFieldInfoPtr_DisableSightUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "DisableSightUpdates");
			VisionCone.NativeFieldInfoPtr_HorizontalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "HorizontalFOV");
			VisionCone.NativeFieldInfoPtr_VerticalFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VerticalFOV");
			VisionCone.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Range");
			VisionCone.NativeFieldInfoPtr_MinorWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinorWidth");
			VisionCone.NativeFieldInfoPtr_MinorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinorHeight");
			VisionCone.NativeFieldInfoPtr_VisionOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionOrigin");
			VisionCone.NativeFieldInfoPtr_DEBUG_FRUSTRUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "DEBUG_FRUSTRUM");
			VisionCone.NativeFieldInfoPtr_VisionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionEnabled");
			VisionCone.NativeFieldInfoPtr_VisionFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisionFalloff");
			VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "VisibilityBlockingLayers");
			VisionCone.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "RangeMultiplier");
			VisionCone.NativeFieldInfoPtr_StatesOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StatesOfInterest");
			VisionCone.NativeFieldInfoPtr_MinVisionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "MinVisionDelta");
			VisionCone.NativeFieldInfoPtr_Attentiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Attentiveness");
			VisionCone.NativeFieldInfoPtr_Memory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "Memory");
			VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "WorldspaceIconsEnabled");
			VisionCone.NativeFieldInfoPtr_QuestionMarkPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "QuestionMarkPopup");
			VisionCone.NativeFieldInfoPtr_ExclamationPointPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationPointPopup");
			VisionCone.NativeFieldInfoPtr_ExclamationSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "ExclamationSound");
			VisionCone.NativeFieldInfoPtr_onVisionEventStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventStarted");
			VisionCone.NativeFieldInfoPtr_onVisionEventHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventHalf");
			VisionCone.NativeFieldInfoPtr_onVisionEventFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventFull");
			VisionCone.NativeFieldInfoPtr_onVisionEventExpired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "onVisionEventExpired");
			VisionCone.NativeFieldInfoPtr_StateSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StateSettings");
			VisionCone.NativeFieldInfoPtr_activeVisionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "activeVisionEvents");
			VisionCone.NativeFieldInfoPtr_playerSightDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "playerSightDatas");
			VisionCone.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "npc");
			VisionCone.NativeFieldInfoPtr_generalCrimeResponseActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "generalCrimeResponseActive");
			VisionCone.NativeFieldInfoPtr_sightedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "sightedPlayers");
			VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted");
			VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted");
			VisionCone.NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666772);
			VisionCone.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666773);
			VisionCone.NativeMethodInfoPtr_PlayerSpawned_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666774);
			VisionCone.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666775);
			VisionCone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666776);
			VisionCone.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666777);
			VisionCone.NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666778);
			VisionCone.NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666779);
			VisionCone.NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666780);
			VisionCone.NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666781);
			VisionCone.NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666782);
			VisionCone.NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666783);
			VisionCone.NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666784);
			VisionCone.NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666785);
			VisionCone.NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666786);
			VisionCone.NativeMethodInfoPtr_GetEvent_Public_VisionEvent_Player_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666787);
			VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666788);
			VisionCone.NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666789);
			VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_PlayerSightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666790);
			VisionCone.NativeMethodInfoPtr_SetGeneralCrimeResponseActive_Public_Virtual_New_Void_Player_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666791);
			VisionCone.NativeMethodInfoPtr_OnDie_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666792);
			VisionCone.NativeMethodInfoPtr_ClearEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666793);
			VisionCone.NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666794);
			VisionCone.NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666795);
			VisionCone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666796);
			VisionCone.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666798);
			VisionCone.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666799);
			VisionCone.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666800);
			VisionCone.NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666801);
			VisionCone.NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666802);
			VisionCone.NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666803);
			VisionCone.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666804);
			VisionCone.NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666805);
			VisionCone.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666806);
			VisionCone.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, 100666807);
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x000D1FDC File Offset: 0x000D01DC
		public unsafe float effectiveRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000D2018 File Offset: 0x000D0218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110121, XrefRangeEnd = 110122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000D2054 File Offset: 0x000D0254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110122, XrefRangeEnd = 110142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned(Player plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_PlayerSpawned_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000D2098 File Offset: 0x000D0298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110142, XrefRangeEnd = 110147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000D20CC File Offset: 0x000D02CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110147, XrefRangeEnd = 110148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000D2108 File Offset: 0x000D0308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110148, XrefRangeEnd = 110163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x000D2144 File Offset: 0x000D0344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110163, XrefRangeEnd = 110164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void VisionUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x000D2180 File Offset: 0x000D0380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110164, XrefRangeEnd = 110310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEvents(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref tickTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000D21CC File Offset: 0x000D03CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110310, XrefRangeEnd = 110398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVision(float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref tickTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000D2218 File Offset: 0x000D0418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110398, XrefRangeEnd = 110407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventReachedZero(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000D2268 File Offset: 0x000D0468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110407, XrefRangeEnd = 110413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventHalfNoticed(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000D22B8 File Offset: 0x000D04B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110413, XrefRangeEnd = 110425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EventFullyNoticed(VisionEvent _event)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000D2308 File Offset: 0x000D0508
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110447, RefRangeEnd = 110450, XrefRangeStart = 110425, XrefRangeEnd = 110447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000D2358 File Offset: 0x000D0558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110450, XrefRangeEnd = 110473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000D23B4 File Offset: 0x000D05B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110473, XrefRangeEnd = 110511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = false, LandVehicle vehicleToIgnore = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ignoreLoS;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleToIgnore);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x000D2428 File Offset: 0x000D0628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110527, RefRangeEnd = 110528, XrefRangeStart = 110511, XrefRangeEnd = 110527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEvent GetEvent(Player target, PlayerVisualState.VisualState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetEvent_Public_VisionEvent_Player_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr2) : null;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000D248C File Offset: 0x000D068C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 110532, RefRangeEnd = 110543, XrefRangeStart = 110528, XrefRangeEnd = 110532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x000D24DC File Offset: 0x000D06DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110547, RefRangeEnd = 110549, XrefRangeStart = 110543, XrefRangeEnd = 110547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPlayerVisibility(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x000D252C File Offset: 0x000D072C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110554, RefRangeEnd = 110555, XrefRangeStart = 110549, XrefRangeEnd = 110554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible(Player player, out VisionCone.PlayerSightData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_PlayerSightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			data = ((intPtr2 == 0) ? null : new VisionCone.PlayerSightData(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x000D259C File Offset: 0x000D079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110555, XrefRangeEnd = 110561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGeneralCrimeResponseActive(Player player, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_SetGeneralCrimeResponseActive_Public_Virtual_New_Void_Player_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000D25F8 File Offset: 0x000D07F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110561, XrefRangeEnd = 110562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_OnDie_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x000D262C File Offset: 0x000D082C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110571, RefRangeEnd = 110574, XrefRangeStart = 110562, XrefRangeEnd = 110571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_ClearEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000D2660 File Offset: 0x000D0860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110596, RefRangeEnd = 110597, XrefRangeStart = 110574, XrefRangeEnd = 110596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetFrustumVertices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000D26A0 File Offset: 0x000D08A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110618, RefRangeEnd = 110619, XrefRangeStart = 110597, XrefRangeEnd = 110618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Plane> GetFrustumPlanes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr2) : null;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000D26E0 File Offset: 0x000D08E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110619, XrefRangeEnd = 110655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionCone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000D271C File Offset: 0x000D091C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110655, XrefRangeEnd = 110669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x000D2758 File Offset: 0x000D0958
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000D2794 File Offset: 0x000D0994
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000D27D0 File Offset: 0x000D09D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110669, XrefRangeEnd = 110680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000D2820 File Offset: 0x000D0A20
		[CallerCount(0)]
		public unsafe void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x000D2870 File Offset: 0x000D0A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110680, XrefRangeEnd = 110684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x000D28D4 File Offset: 0x000D0AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110684, XrefRangeEnd = 110695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x000D2924 File Offset: 0x000D0B24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110695, RefRangeEnd = 110697, XrefRangeStart = 110695, XrefRangeEnd = 110695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x000D2980 File Offset: 0x000D0B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110697, XrefRangeEnd = 110702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x000D29D0 File Offset: 0x000D0BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110779, RefRangeEnd = 110780, XrefRangeStart = 110702, XrefRangeEnd = 110779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisionCone.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0001101E File Offset: 0x0000F21E
		public VisionCone(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x000D2A0C File Offset: 0x000D0C0C
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x00011027 File Offset: 0x0000F227
		public unsafe static float VISION_UPDATE_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_VISION_UPDATE_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000D2A28 File Offset: 0x000D0C28
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x00011035 File Offset: 0x0000F235
		public unsafe static float UniversalAttentivenessScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_UniversalAttentivenessScale, (void*)(&value));
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x000D2A44 File Offset: 0x000D0C44
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x00011043 File Offset: 0x0000F243
		public unsafe static float UniversalMemoryScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionCone.NativeFieldInfoPtr_UniversalMemoryScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionCone.NativeFieldInfoPtr_UniversalMemoryScale, (void*)(&value));
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x000D2A60 File Offset: 0x000D0C60
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x00011051 File Offset: 0x0000F251
		public unsafe bool DisableSightUpdates
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DisableSightUpdates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DisableSightUpdates)) = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x000D2A88 File Offset: 0x000D0C88
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x0001106C File Offset: 0x0000F26C
		public unsafe float HorizontalFOV
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_HorizontalFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_HorizontalFOV)) = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x000D2AB0 File Offset: 0x000D0CB0
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x00011087 File Offset: 0x0000F287
		public unsafe float VerticalFOV
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VerticalFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VerticalFOV)) = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x000D2AD8 File Offset: 0x000D0CD8
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x000110A2 File Offset: 0x0000F2A2
		public unsafe float Range
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x000D2B00 File Offset: 0x000D0D00
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x000110BD File Offset: 0x0000F2BD
		public unsafe float MinorWidth
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorWidth)) = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000D2B28 File Offset: 0x000D0D28
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x000110D8 File Offset: 0x0000F2D8
		public unsafe float MinorHeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinorHeight)) = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x000D2B50 File Offset: 0x000D0D50
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x000110F3 File Offset: 0x0000F2F3
		public unsafe Transform VisionOrigin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionOrigin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x000D2B80 File Offset: 0x000D0D80
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x00011112 File Offset: 0x0000F312
		public unsafe bool DEBUG_FRUSTRUM
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DEBUG_FRUSTRUM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_DEBUG_FRUSTRUM)) = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x000D2BA8 File Offset: 0x000D0DA8
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x0001112D File Offset: 0x0000F32D
		public unsafe bool VisionEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionEnabled)) = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x000D2BD0 File Offset: 0x000D0DD0
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x00011148 File Offset: 0x0000F348
		public unsafe AnimationCurve VisionFalloff
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionFalloff);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisionFalloff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x000D2C00 File Offset: 0x000D0E00
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00011167 File Offset: 0x0000F367
		public unsafe LayerMask VisibilityBlockingLayers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_VisibilityBlockingLayers)) = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x000D2C28 File Offset: 0x000D0E28
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00011182 File Offset: 0x0000F382
		public unsafe float RangeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_RangeMultiplier)) = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x000D2C50 File Offset: 0x000D0E50
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x0001119D File Offset: 0x0000F39D
		public unsafe List<VisionCone.StateContainer> StatesOfInterest
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StatesOfInterest);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionCone.StateContainer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StatesOfInterest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x000D2C80 File Offset: 0x000D0E80
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x000111BC File Offset: 0x0000F3BC
		public unsafe float MinVisionDelta
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinVisionDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_MinVisionDelta)) = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001E99 RID: 7833 RVA: 0x000D2CA8 File Offset: 0x000D0EA8
		// (set) Token: 0x06001E9A RID: 7834 RVA: 0x000111D7 File Offset: 0x0000F3D7
		public unsafe float Attentiveness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Attentiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Attentiveness)) = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x000D2CD0 File Offset: 0x000D0ED0
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x000111F2 File Offset: 0x0000F3F2
		public unsafe float Memory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Memory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_Memory)) = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x000D2CF8 File Offset: 0x000D0EF8
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0001120D File Offset: 0x0000F40D
		public unsafe bool WorldspaceIconsEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_WorldspaceIconsEnabled)) = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x000D2D20 File Offset: 0x000D0F20
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x00011228 File Offset: 0x0000F428
		public unsafe WorldspacePopup QuestionMarkPopup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_QuestionMarkPopup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_QuestionMarkPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x000D2D50 File Offset: 0x000D0F50
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x00011247 File Offset: 0x0000F447
		public unsafe WorldspacePopup ExclamationPointPopup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationPointPopup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationPointPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x000D2D80 File Offset: 0x000D0F80
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x00011266 File Offset: 0x0000F466
		public unsafe AudioSourceController ExclamationSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_ExclamationSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x000D2DB0 File Offset: 0x000D0FB0
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x00011285 File Offset: 0x0000F485
		public unsafe VisionCone.EventStateChange onVisionEventStarted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventStarted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x000D2DE0 File Offset: 0x000D0FE0
		// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x000112A4 File Offset: 0x0000F4A4
		public unsafe VisionCone.EventStateChange onVisionEventHalf
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventHalf);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x000D2E10 File Offset: 0x000D1010
		// (set) Token: 0x06001EAA RID: 7850 RVA: 0x000112C3 File Offset: 0x0000F4C3
		public unsafe VisionCone.EventStateChange onVisionEventFull
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventFull);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventFull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x000D2E40 File Offset: 0x000D1040
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x000112E2 File Offset: 0x0000F4E2
		public unsafe VisionCone.EventStateChange onVisionEventExpired
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventExpired);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.EventStateChange>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_onVisionEventExpired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x000D2E70 File Offset: 0x000D1070
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x00011301 File Offset: 0x0000F501
		public unsafe Dictionary<Player, Dictionary<PlayerVisualState.EVisualState, VisionCone.StateContainer>> StateSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StateSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, Dictionary<PlayerVisualState.EVisualState, VisionCone.StateContainer>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_StateSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000D2EA0 File Offset: 0x000D10A0
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x00011320 File Offset: 0x0000F520
		public unsafe List<VisionEvent> activeVisionEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_activeVisionEvents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisionEvent>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_activeVisionEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000D2ED0 File Offset: 0x000D10D0
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x0001133F File Offset: 0x0000F53F
		public unsafe Dictionary<Player, VisionCone.PlayerSightData> playerSightDatas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_playerSightDatas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, VisionCone.PlayerSightData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_playerSightDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000D2F00 File Offset: 0x000D1100
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x0001135E File Offset: 0x0000F55E
		public unsafe NPC npc
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_npc);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000D2F30 File Offset: 0x000D1130
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x0001137D File Offset: 0x0000F57D
		public unsafe bool generalCrimeResponseActive
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_generalCrimeResponseActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_generalCrimeResponseActive)) = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x000D2F58 File Offset: 0x000D1158
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x00011398 File Offset: 0x0000F598
		public unsafe List<Player> sightedPlayers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightedPlayers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_sightedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x000D2F88 File Offset: 0x000D1188
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x000113B7 File Offset: 0x0000F5B7
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x000D2FB0 File Offset: 0x000D11B0
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x000113D2 File Offset: 0x0000F5D2
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001428 RID: 5160
		private static readonly System.IntPtr NativeFieldInfoPtr_VISION_UPDATE_INTERVAL;

		// Token: 0x04001429 RID: 5161
		private static readonly System.IntPtr NativeFieldInfoPtr_UniversalAttentivenessScale;

		// Token: 0x0400142A RID: 5162
		private static readonly System.IntPtr NativeFieldInfoPtr_UniversalMemoryScale;

		// Token: 0x0400142B RID: 5163
		private static readonly System.IntPtr NativeFieldInfoPtr_DisableSightUpdates;

		// Token: 0x0400142C RID: 5164
		private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalFOV;

		// Token: 0x0400142D RID: 5165
		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalFOV;

		// Token: 0x0400142E RID: 5166
		private static readonly System.IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x0400142F RID: 5167
		private static readonly System.IntPtr NativeFieldInfoPtr_MinorWidth;

		// Token: 0x04001430 RID: 5168
		private static readonly System.IntPtr NativeFieldInfoPtr_MinorHeight;

		// Token: 0x04001431 RID: 5169
		private static readonly System.IntPtr NativeFieldInfoPtr_VisionOrigin;

		// Token: 0x04001432 RID: 5170
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_FRUSTRUM;

		// Token: 0x04001433 RID: 5171
		private static readonly System.IntPtr NativeFieldInfoPtr_VisionEnabled;

		// Token: 0x04001434 RID: 5172
		private static readonly System.IntPtr NativeFieldInfoPtr_VisionFalloff;

		// Token: 0x04001435 RID: 5173
		private static readonly System.IntPtr NativeFieldInfoPtr_VisibilityBlockingLayers;

		// Token: 0x04001436 RID: 5174
		private static readonly System.IntPtr NativeFieldInfoPtr_RangeMultiplier;

		// Token: 0x04001437 RID: 5175
		private static readonly System.IntPtr NativeFieldInfoPtr_StatesOfInterest;

		// Token: 0x04001438 RID: 5176
		private static readonly System.IntPtr NativeFieldInfoPtr_MinVisionDelta;

		// Token: 0x04001439 RID: 5177
		private static readonly System.IntPtr NativeFieldInfoPtr_Attentiveness;

		// Token: 0x0400143A RID: 5178
		private static readonly System.IntPtr NativeFieldInfoPtr_Memory;

		// Token: 0x0400143B RID: 5179
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceIconsEnabled;

		// Token: 0x0400143C RID: 5180
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionMarkPopup;

		// Token: 0x0400143D RID: 5181
		private static readonly System.IntPtr NativeFieldInfoPtr_ExclamationPointPopup;

		// Token: 0x0400143E RID: 5182
		private static readonly System.IntPtr NativeFieldInfoPtr_ExclamationSound;

		// Token: 0x0400143F RID: 5183
		private static readonly System.IntPtr NativeFieldInfoPtr_onVisionEventStarted;

		// Token: 0x04001440 RID: 5184
		private static readonly System.IntPtr NativeFieldInfoPtr_onVisionEventHalf;

		// Token: 0x04001441 RID: 5185
		private static readonly System.IntPtr NativeFieldInfoPtr_onVisionEventFull;

		// Token: 0x04001442 RID: 5186
		private static readonly System.IntPtr NativeFieldInfoPtr_onVisionEventExpired;

		// Token: 0x04001443 RID: 5187
		private static readonly System.IntPtr NativeFieldInfoPtr_StateSettings;

		// Token: 0x04001444 RID: 5188
		private static readonly System.IntPtr NativeFieldInfoPtr_activeVisionEvents;

		// Token: 0x04001445 RID: 5189
		private static readonly System.IntPtr NativeFieldInfoPtr_playerSightDatas;

		// Token: 0x04001446 RID: 5190
		private static readonly System.IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04001447 RID: 5191
		private static readonly System.IntPtr NativeFieldInfoPtr_generalCrimeResponseActive;

		// Token: 0x04001448 RID: 5192
		private static readonly System.IntPtr NativeFieldInfoPtr_sightedPlayers;

		// Token: 0x04001449 RID: 5193
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400144A RID: 5194
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400144B RID: 5195
		private static readonly System.IntPtr NativeMethodInfoPtr_get_effectiveRange_Protected_get_Single_0;

		// Token: 0x0400144C RID: 5196
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400144D RID: 5197
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_Player_0;

		// Token: 0x0400144E RID: 5198
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400144F RID: 5199
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04001450 RID: 5200
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04001451 RID: 5201
		private static readonly System.IntPtr NativeMethodInfoPtr_VisionUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04001452 RID: 5202
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEvents_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001453 RID: 5203
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVision_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04001454 RID: 5204
		private static readonly System.IntPtr NativeMethodInfoPtr_EventReachedZero_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x04001455 RID: 5205
		private static readonly System.IntPtr NativeMethodInfoPtr_EventHalfNoticed_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x04001456 RID: 5206
		private static readonly System.IntPtr NativeMethodInfoPtr_EventFullyNoticed_Public_Virtual_New_Void_VisionEvent_0;

		// Token: 0x04001457 RID: 5207
		private static readonly System.IntPtr NativeMethodInfoPtr_SendEventReceipt_Public_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001458 RID: 5208
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveEventReceipt_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001459 RID: 5209
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPointWithinSight_Public_Virtual_New_Boolean_Vector3_Boolean_LandVehicle_0;

		// Token: 0x0400145A RID: 5210
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEvent_Public_VisionEvent_Player_VisualState_0;

		// Token: 0x0400145B RID: 5211
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_0;

		// Token: 0x0400145C RID: 5212
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerVisibility_Public_Single_Player_0;

		// Token: 0x0400145D RID: 5213
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerVisible_Public_Boolean_Player_byref_PlayerSightData_0;

		// Token: 0x0400145E RID: 5214
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGeneralCrimeResponseActive_Public_Virtual_New_Void_Player_Boolean_0;

		// Token: 0x0400145F RID: 5215
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDie_Private_Void_0;

		// Token: 0x04001460 RID: 5216
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearEvents_Public_Void_0;

		// Token: 0x04001461 RID: 5217
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFrustumVertices_Private_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04001462 RID: 5218
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFrustumPlanes_Private_Il2CppStructArray_1_Plane_0;

		// Token: 0x04001463 RID: 5219
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001464 RID: 5220
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001465 RID: 5221
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001466 RID: 5222
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001467 RID: 5223
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001468 RID: 5224
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEventReceipt_3486014028_Public_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x04001469 RID: 5225
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEventReceipt_3486014028_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400146A RID: 5226
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEventReceipt_3486014028_Private_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x0400146B RID: 5227
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEventReceipt_3486014028_Public_Virtual_New_Void_VisionEventReceipt_EEventLevel_0;

		// Token: 0x0400146C RID: 5228
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEventReceipt_3486014028_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400146D RID: 5229
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020008D9 RID: 2265
		[OriginalName("Assembly-CSharp.dll", "", "EEventLevel")]
		public enum EEventLevel
		{
			// Token: 0x0400872A RID: 34602
			Start,
			// Token: 0x0400872B RID: 34603
			Half,
			// Token: 0x0400872C RID: 34604
			Full,
			// Token: 0x0400872D RID: 34605
			Zero
		}

		// Token: 0x020008DA RID: 2266
		[System.Serializable]
		public class StateContainer : Il2CppSystem.Object
		{
			// Token: 0x0600C73F RID: 51007 RVA: 0x0030CC94 File Offset: 0x0030AE94
			// Note: this type is marked as 'beforefieldinit'.
			static StateContainer()
			{
				Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "StateContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr);
				VisionCone.StateContainer.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "state");
				VisionCone.StateContainer.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "Enabled");
				VisionCone.StateContainer.NativeFieldInfoPtr_RequiredNoticeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, "RequiredNoticeTime");
				VisionCone.StateContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr, 100666808);
			}

			// Token: 0x0600C740 RID: 51008 RVA: 0x0030CD10 File Offset: 0x0030AF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110007, XrefRangeEnd = 110008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.StateContainer>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.StateContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C741 RID: 51009 RVA: 0x00060966 File Offset: 0x0005EB66
			public StateContainer(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DEC RID: 15852
			// (get) Token: 0x0600C742 RID: 51010 RVA: 0x0030CD4C File Offset: 0x0030AF4C
			// (set) Token: 0x0600C743 RID: 51011 RVA: 0x0006096F File Offset: 0x0005EB6F
			public unsafe PlayerVisualState.EVisualState state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17003DED RID: 15853
			// (get) Token: 0x0600C744 RID: 51012 RVA: 0x0030CD74 File Offset: 0x0030AF74
			// (set) Token: 0x0600C745 RID: 51013 RVA: 0x0006098A File Offset: 0x0005EB8A
			public unsafe bool Enabled
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x17003DEE RID: 15854
			// (get) Token: 0x0600C746 RID: 51014 RVA: 0x0030CD9C File Offset: 0x0030AF9C
			// (set) Token: 0x0600C747 RID: 51015 RVA: 0x000609A5 File Offset: 0x0005EBA5
			public unsafe float RequiredNoticeTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_RequiredNoticeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.StateContainer.NativeFieldInfoPtr_RequiredNoticeTime)) = value;
				}
			}

			// Token: 0x0400872E RID: 34606
			private static readonly System.IntPtr NativeFieldInfoPtr_state;

			// Token: 0x0400872F RID: 34607
			private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04008730 RID: 34608
			private static readonly System.IntPtr NativeFieldInfoPtr_RequiredNoticeTime;

			// Token: 0x04008731 RID: 34609
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DB RID: 2267
		public class PlayerSightData : Il2CppSystem.Object
		{
			// Token: 0x0600C748 RID: 51016 RVA: 0x0030CDC4 File Offset: 0x0030AFC4
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerSightData()
			{
				Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "PlayerSightData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr);
				VisionCone.PlayerSightData.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, "Player");
				VisionCone.PlayerSightData.NativeFieldInfoPtr_VisionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, "VisionDelta");
				VisionCone.PlayerSightData.NativeFieldInfoPtr_TimeVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, "TimeVisible");
				VisionCone.PlayerSightData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr, 100666809);
			}

			// Token: 0x0600C749 RID: 51017 RVA: 0x0030CE40 File Offset: 0x0030B040
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSightData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.PlayerSightData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.PlayerSightData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C74A RID: 51018 RVA: 0x000609C0 File Offset: 0x0005EBC0
			public PlayerSightData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DEF RID: 15855
			// (get) Token: 0x0600C74B RID: 51019 RVA: 0x0030CE7C File Offset: 0x0030B07C
			// (set) Token: 0x0600C74C RID: 51020 RVA: 0x000609C9 File Offset: 0x0005EBC9
			public unsafe Player Player
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_Player);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF0 RID: 15856
			// (get) Token: 0x0600C74D RID: 51021 RVA: 0x0030CEAC File Offset: 0x0030B0AC
			// (set) Token: 0x0600C74E RID: 51022 RVA: 0x000609E8 File Offset: 0x0005EBE8
			public unsafe float VisionDelta
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_VisionDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_VisionDelta)) = value;
				}
			}

			// Token: 0x17003DF1 RID: 15857
			// (get) Token: 0x0600C74F RID: 51023 RVA: 0x0030CED4 File Offset: 0x0030B0D4
			// (set) Token: 0x0600C750 RID: 51024 RVA: 0x00060A03 File Offset: 0x0005EC03
			public unsafe float TimeVisible
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_TimeVisible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.PlayerSightData.NativeFieldInfoPtr_TimeVisible)) = value;
				}
			}

			// Token: 0x04008732 RID: 34610
			private static readonly System.IntPtr NativeFieldInfoPtr_Player;

			// Token: 0x04008733 RID: 34611
			private static readonly System.IntPtr NativeFieldInfoPtr_VisionDelta;

			// Token: 0x04008734 RID: 34612
			private static readonly System.IntPtr NativeFieldInfoPtr_TimeVisible;

			// Token: 0x04008735 RID: 34613
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DC RID: 2268
		public sealed class EventStateChange : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600C751 RID: 51025 RVA: 0x0030CEFC File Offset: 0x0030B0FC
			// Note: this type is marked as 'beforefieldinit'.
			static EventStateChange()
			{
				Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "EventStateChange");
				VisionCone.EventStateChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666810);
				VisionCone.EventStateChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666811);
				VisionCone.EventStateChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666812);
				VisionCone.EventStateChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr, 100666813);
			}

			// Token: 0x0600C752 RID: 51026 RVA: 0x0030CF70 File Offset: 0x0030B170
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 110018, RefRangeEnd = 110108, XrefRangeStart = 110008, XrefRangeEnd = 110018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventStateChange(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.EventStateChange>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C753 RID: 51027 RVA: 0x0030CFCC File Offset: 0x0030B1CC
			[CallerCount(0)]
			public unsafe void Invoke(VisionEventReceipt _event)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C754 RID: 51028 RVA: 0x0030D010 File Offset: 0x0030B210
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(VisionEventReceipt _event, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_event);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600C755 RID: 51029 RVA: 0x0030D084 File Offset: 0x0030B284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.EventStateChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C756 RID: 51030 RVA: 0x00060A1E File Offset: 0x0005EC1E
			public EventStateChange(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C757 RID: 51031 RVA: 0x00060A27 File Offset: 0x0005EC27
			public static implicit operator VisionCone.EventStateChange(System.Action<VisionEventReceipt> A_0)
			{
				return DelegateSupport.ConvertDelegate<VisionCone.EventStateChange>(A_0);
			}

			// Token: 0x0600C758 RID: 51032 RVA: 0x00060A2F File Offset: 0x0005EC2F
			public static VisionCone.EventStateChange operator +(VisionCone.EventStateChange A_0, VisionCone.EventStateChange A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<VisionCone.EventStateChange>();
			}

			// Token: 0x0600C759 RID: 51033 RVA: 0x00060A3D File Offset: 0x0005EC3D
			public static VisionCone.EventStateChange operator -(VisionCone.EventStateChange A_0, VisionCone.EventStateChange A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VisionCone.EventStateChange>();
				}
				return result;
			}

			// Token: 0x04008736 RID: 34614
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008737 RID: 34615
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VisionEventReceipt_0;

			// Token: 0x04008738 RID: 34616
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_VisionEventReceipt_AsyncCallback_Object_0;

			// Token: 0x04008739 RID: 34617
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008DD RID: 2269
		[ObfuscatedName("ScheduleOne.Vision.VisionCone+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C75A RID: 51034 RVA: 0x0030D0C8 File Offset: 0x0030B2C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr);
				VisionCone.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, "<>9");
				VisionCone.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, "<>9__45_0");
				VisionCone.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, 100666815);
				VisionCone.__c.NativeMethodInfoPtr__UpdateEvents_b__45_0_Internal_Boolean_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr, 100666816);
			}

			// Token: 0x0600C75B RID: 51035 RVA: 0x0030D144 File Offset: 0x0030B344
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C75C RID: 51036 RVA: 0x0030D180 File Offset: 0x0030B380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110108, XrefRangeEnd = 110117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateEvents_b__45_0(VisionEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c.NativeMethodInfoPtr__UpdateEvents_b__45_0_Internal_Boolean_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C75D RID: 51037 RVA: 0x00060A4E File Offset: 0x0005EC4E
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DF2 RID: 15858
			// (get) Token: 0x0600C75E RID: 51038 RVA: 0x0030D1D0 File Offset: 0x0030B3D0
			// (set) Token: 0x0600C75F RID: 51039 RVA: 0x00060A57 File Offset: 0x0005EC57
			public unsafe static VisionCone.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisionCone.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisionCone.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF3 RID: 15859
			// (get) Token: 0x0600C760 RID: 51040 RVA: 0x0030D1F8 File Offset: 0x0030B3F8
			// (set) Token: 0x0600C761 RID: 51041 RVA: 0x00060A69 File Offset: 0x0005EC69
			public unsafe static Il2CppSystem.Predicate<VisionEvent> __9__45_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisionCone.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<VisionEvent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisionCone.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400873A RID: 34618
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400873B RID: 34619
			private static readonly System.IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x0400873C RID: 34620
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400873D RID: 34621
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateEvents_b__45_0_Internal_Boolean_VisionEvent_0;
		}

		// Token: 0x020008DE RID: 2270
		[ObfuscatedName("ScheduleOne.Vision.VisionCone+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C762 RID: 51042 RVA: 0x0030D220 File Offset: 0x0030B420
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisionCone>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr);
				VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, "target");
				VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, "state");
				VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, 100666817);
				VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr, 100666818);
			}

			// Token: 0x0600C763 RID: 51043 RVA: 0x0030D29C File Offset: 0x0030B49C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionCone.__c__DisplayClass53_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C764 RID: 51044 RVA: 0x0030D2D8 File Offset: 0x0030B4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110117, XrefRangeEnd = 110121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEvent_b__0(VisionEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VisionCone.__c__DisplayClass53_0.NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C765 RID: 51045 RVA: 0x00060A7B File Offset: 0x0005EC7B
			public __c__DisplayClass53_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DF4 RID: 15860
			// (get) Token: 0x0600C766 RID: 51046 RVA: 0x0030D328 File Offset: 0x0030B528
			// (set) Token: 0x0600C767 RID: 51047 RVA: 0x00060A84 File Offset: 0x0005EC84
			public unsafe Player target
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_target);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DF5 RID: 15861
			// (get) Token: 0x0600C768 RID: 51048 RVA: 0x0030D358 File Offset: 0x0030B558
			// (set) Token: 0x0600C769 RID: 51049 RVA: 0x00060AA3 File Offset: 0x0005ECA3
			public unsafe PlayerVisualState.VisualState state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_state);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisionCone.__c__DisplayClass53_0.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400873E RID: 34622
			private static readonly System.IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400873F RID: 34623
			private static readonly System.IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04008740 RID: 34624
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008741 RID: 34625
			private static readonly System.IntPtr NativeMethodInfoPtr__GetEvent_b__0_Internal_Boolean_VisionEvent_0;
		}
	}
}
