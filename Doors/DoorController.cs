using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000445 RID: 1093
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x06005EE8 RID: 24296 RVA: 0x001B82C4 File Offset: 0x001B64C4
		// Note: this type is marked as 'beforefieldinit'.
		static DoorController()
		{
			Il2CppClassPointerStore<DoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorController>.NativeClassPtr);
			DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "DISTANT_PLAYER_THRESHOLD");
			DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<IsOpen>k__BackingField");
			DoorController.NativeFieldInfoPtr_PlayerAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerAccess");
			DoorController.NativeFieldInfoPtr_AutoOpenForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoOpenForPlayer");
			DoorController.NativeFieldInfoPtr_InteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorIntObjs");
			DoorController.NativeFieldInfoPtr_ExteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorIntObjs");
			DoorController.NativeFieldInfoPtr_PlayerBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerBlocker");
			DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_AutoCloseOnSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnSleep");
			DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnDistantPlayer");
			DoorController.NativeFieldInfoPtr_OpenableByNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "OpenableByNPCs");
			DoorController.NativeFieldInfoPtr_ReturnToOriginalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ReturnToOriginalTime");
			DoorController.NativeFieldInfoPtr_onDoorOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorOpened");
			DoorController.NativeFieldInfoPtr_onDoorClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorClosed");
			DoorController.NativeFieldInfoPtr_lastOpenSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "lastOpenSide");
			DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<openedByNPC>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSinceNPCSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr_autoOpenedForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "autoOpenedForPlayer");
			DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<playerDetectedSinceOpened>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSincePlayerSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeInCurrentState>k__BackingField");
			DoorController.NativeFieldInfoPtr_noAccessErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "noAccessErrorMessage");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675485);
			DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675486);
			DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675487);
			DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675488);
			DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675489);
			DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675490);
			DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675491);
			DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675492);
			DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675493);
			DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675494);
			DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675495);
			DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675496);
			DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675497);
			DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675498);
			DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675499);
			DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675500);
			DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675501);
			DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675502);
			DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675503);
			DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675504);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675505);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675506);
			DoorController.NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675507);
			DoorController.NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675508);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675509);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675510);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675511);
			DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675512);
			DoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675513);
			DoorController.NativeMethodInfoPtr__Start_b__42_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675514);
			DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675515);
			DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675516);
			DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675517);
			DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675518);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675519);
			DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675520);
			DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675521);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675522);
			DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675523);
			DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675524);
			DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675525);
			DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100675526);
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x06005EE9 RID: 24297 RVA: 0x001B8830 File Offset: 0x001B6A30
		// (set) Token: 0x06005EEA RID: 24298 RVA: 0x001B886C File Offset: 0x001B6A6C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06005EEB RID: 24299 RVA: 0x001B88AC File Offset: 0x001B6AAC
		// (set) Token: 0x06005EEC RID: 24300 RVA: 0x001B88E8 File Offset: 0x001B6AE8
		public unsafe bool openedByNPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x001B8928 File Offset: 0x001B6B28
		// (set) Token: 0x06005EEE RID: 24302 RVA: 0x001B8964 File Offset: 0x001B6B64
		public unsafe float timeSinceNPCSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x001B89A4 File Offset: 0x001B6BA4
		// (set) Token: 0x06005EF0 RID: 24304 RVA: 0x001B89E0 File Offset: 0x001B6BE0
		public unsafe bool playerDetectedSinceOpened
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x001B8A20 File Offset: 0x001B6C20
		// (set) Token: 0x06005EF2 RID: 24306 RVA: 0x001B8A5C File Offset: 0x001B6C5C
		public unsafe float timeSincePlayerSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x001B8A9C File Offset: 0x001B6C9C
		// (set) Token: 0x06005EF4 RID: 24308 RVA: 0x001B8AD8 File Offset: 0x001B6CD8
		public unsafe float timeInCurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x001B8B18 File Offset: 0x001B6D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200095, RefRangeEnd = 200097, XrefRangeStart = 200094, XrefRangeEnd = 200095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x001B8B54 File Offset: 0x001B6D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200097, XrefRangeEnd = 200113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x001B8B90 File Offset: 0x001B6D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200113, XrefRangeEnd = 200119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x001B8BCC File Offset: 0x001B6DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200119, XrefRangeEnd = 200121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x001B8C1C File Offset: 0x001B6E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200121, XrefRangeEnd = 200133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x001B8C58 File Offset: 0x001B6E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200133, XrefRangeEnd = 200139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x001B8C94 File Offset: 0x001B6E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200139, XrefRangeEnd = 200151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x001B8CD0 File Offset: 0x001B6ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200151, XrefRangeEnd = 200157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x001B8D0C File Offset: 0x001B6F0C
		[CallerCount(0)]
		public unsafe bool CanPlayerAccess(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x001B8D58 File Offset: 0x001B6F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200158, RefRangeEnd = 200159, XrefRangeStart = 200157, XrefRangeEnd = 200158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x001B8DC8 File Offset: 0x001B6FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200159, XrefRangeEnd = 200162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCVicinityDetected(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x001B8E14 File Offset: 0x001B7014
		[CallerCount(0)]
		public unsafe virtual void PlayerVicinityDetected(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x001B8E60 File Offset: 0x001B7060
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 200186, RefRangeEnd = 200192, XrefRangeStart = 200162, XrefRangeEnd = 200186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x001B8EBC File Offset: 0x001B70BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 200235, RefRangeEnd = 200240, XrefRangeStart = 200192, XrefRangeEnd = 200235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x001B8F1C File Offset: 0x001B711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200240, XrefRangeEnd = 200245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x001B8F74 File Offset: 0x001B7174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200245, XrefRangeEnd = 200253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckAutoCloseForDistantPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x001B8FB0 File Offset: 0x001B71B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200257, RefRangeEnd = 200258, XrefRangeStart = 200253, XrefRangeEnd = 200257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x001B8FEC File Offset: 0x001B71EC
		[CallerCount(0)]
		public unsafe void _Start_b__42_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__Start_b__42_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x001B9020 File Offset: 0x001B7220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200278, RefRangeEnd = 200279, XrefRangeStart = 200258, XrefRangeEnd = 200278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x001B905C File Offset: 0x001B725C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116274, RefRangeEnd = 116275, XrefRangeStart = 116274, XrefRangeEnd = 116275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x001B9098 File Offset: 0x001B7298
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x001B90D4 File Offset: 0x001B72D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200279, XrefRangeEnd = 200291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x001B9130 File Offset: 0x001B7330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200291, XrefRangeEnd = 200292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x001B918C File Offset: 0x001B738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200292, XrefRangeEnd = 200296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x001B91F0 File Offset: 0x001B73F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200296, XrefRangeEnd = 200307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x001B9250 File Offset: 0x001B7450
		[CallerCount(0)]
		public unsafe void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x001B92B0 File Offset: 0x001B74B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200307, XrefRangeEnd = 200310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x001B9300 File Offset: 0x001B7500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200310, XrefRangeEnd = 200321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x001B9360 File Offset: 0x001B7560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200321, XrefRangeEnd = 200324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x001B93B0 File Offset: 0x001B75B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200364, RefRangeEnd = 200365, XrefRangeStart = 200324, XrefRangeEnd = 200364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x0002C813 File Offset: 0x0002AA13
		public DoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06005F14 RID: 24340 RVA: 0x001B93EC File Offset: 0x001B75EC
		// (set) Token: 0x06005F15 RID: 24341 RVA: 0x0002C81C File Offset: 0x0002AA1C
		public unsafe static float DISTANT_PLAYER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06005F16 RID: 24342 RVA: 0x001B9408 File Offset: 0x001B7608
		// (set) Token: 0x06005F17 RID: 24343 RVA: 0x0002C82A File Offset: 0x0002AA2A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06005F18 RID: 24344 RVA: 0x001B9430 File Offset: 0x001B7630
		// (set) Token: 0x06005F19 RID: 24345 RVA: 0x0002C845 File Offset: 0x0002AA45
		public unsafe EDoorAccess PlayerAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess)) = value;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06005F1A RID: 24346 RVA: 0x001B9458 File Offset: 0x001B7658
		// (set) Token: 0x06005F1B RID: 24347 RVA: 0x0002C860 File Offset: 0x0002AA60
		public unsafe bool AutoOpenForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer)) = value;
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06005F1C RID: 24348 RVA: 0x001B9480 File Offset: 0x001B7680
		// (set) Token: 0x06005F1D RID: 24349 RVA: 0x0002C87B File Offset: 0x0002AA7B
		public unsafe Il2CppReferenceArray<InteractableObject> InteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06005F1E RID: 24350 RVA: 0x001B94B0 File Offset: 0x001B76B0
		// (set) Token: 0x06005F1F RID: 24351 RVA: 0x0002C89A File Offset: 0x0002AA9A
		public unsafe Il2CppReferenceArray<InteractableObject> ExteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x001B94E0 File Offset: 0x001B76E0
		// (set) Token: 0x06005F21 RID: 24353 RVA: 0x0002C8B9 File Offset: 0x0002AAB9
		public unsafe BoxCollider PlayerBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x001B9510 File Offset: 0x001B7710
		// (set) Token: 0x06005F23 RID: 24355 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
		public unsafe Animation InteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06005F24 RID: 24356 RVA: 0x001B9540 File Offset: 0x001B7740
		// (set) Token: 0x06005F25 RID: 24357 RVA: 0x0002C8F7 File Offset: 0x0002AAF7
		public unsafe Animation ExteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x001B9570 File Offset: 0x001B7770
		// (set) Token: 0x06005F27 RID: 24359 RVA: 0x0002C916 File Offset: 0x0002AB16
		public unsafe bool AutoCloseOnSleep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep)) = value;
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x001B9598 File Offset: 0x001B7798
		// (set) Token: 0x06005F29 RID: 24361 RVA: 0x0002C931 File Offset: 0x0002AB31
		public unsafe bool AutoCloseOnDistantPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer)) = value;
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x001B95C0 File Offset: 0x001B77C0
		// (set) Token: 0x06005F2B RID: 24363 RVA: 0x0002C94C File Offset: 0x0002AB4C
		public unsafe bool OpenableByNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs)) = value;
			}
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x001B95E8 File Offset: 0x001B77E8
		// (set) Token: 0x06005F2D RID: 24365 RVA: 0x0002C967 File Offset: 0x0002AB67
		public unsafe float ReturnToOriginalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime)) = value;
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06005F2E RID: 24366 RVA: 0x001B9610 File Offset: 0x001B7810
		// (set) Token: 0x06005F2F RID: 24367 RVA: 0x0002C982 File Offset: 0x0002AB82
		public unsafe UnityEvent<EDoorSide> onDoorOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDoorSide>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06005F30 RID: 24368 RVA: 0x001B9640 File Offset: 0x001B7840
		// (set) Token: 0x06005F31 RID: 24369 RVA: 0x0002C9A1 File Offset: 0x0002ABA1
		public unsafe UnityEvent onDoorClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06005F32 RID: 24370 RVA: 0x001B9670 File Offset: 0x001B7870
		// (set) Token: 0x06005F33 RID: 24371 RVA: 0x0002C9C0 File Offset: 0x0002ABC0
		public unsafe EDoorSide lastOpenSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide)) = value;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06005F34 RID: 24372 RVA: 0x001B9698 File Offset: 0x001B7898
		// (set) Token: 0x06005F35 RID: 24373 RVA: 0x0002C9DB File Offset: 0x0002ABDB
		public unsafe bool _openedByNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06005F36 RID: 24374 RVA: 0x001B96C0 File Offset: 0x001B78C0
		// (set) Token: 0x06005F37 RID: 24375 RVA: 0x0002C9F6 File Offset: 0x0002ABF6
		public unsafe float _timeSinceNPCSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x001B96E8 File Offset: 0x001B78E8
		// (set) Token: 0x06005F39 RID: 24377 RVA: 0x0002CA11 File Offset: 0x0002AC11
		public unsafe bool autoOpenedForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer)) = value;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06005F3A RID: 24378 RVA: 0x001B9710 File Offset: 0x001B7910
		// (set) Token: 0x06005F3B RID: 24379 RVA: 0x0002CA2C File Offset: 0x0002AC2C
		public unsafe bool _playerDetectedSinceOpened_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x001B9738 File Offset: 0x001B7938
		// (set) Token: 0x06005F3D RID: 24381 RVA: 0x0002CA47 File Offset: 0x0002AC47
		public unsafe float _timeSincePlayerSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x001B9760 File Offset: 0x001B7960
		// (set) Token: 0x06005F3F RID: 24383 RVA: 0x0002CA62 File Offset: 0x0002AC62
		public unsafe float _timeInCurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06005F40 RID: 24384 RVA: 0x001B9788 File Offset: 0x001B7988
		// (set) Token: 0x06005F41 RID: 24385 RVA: 0x0002CA7D File Offset: 0x0002AC7D
		public unsafe string noAccessErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06005F42 RID: 24386 RVA: 0x001B97B0 File Offset: 0x001B79B0
		// (set) Token: 0x06005F43 RID: 24387 RVA: 0x0002CA9C File Offset: 0x0002AC9C
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06005F44 RID: 24388 RVA: 0x001B97D8 File Offset: 0x001B79D8
		// (set) Token: 0x06005F45 RID: 24389 RVA: 0x0002CAB7 File Offset: 0x0002ACB7
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040040F6 RID: 16630
		private static readonly IntPtr NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD;

		// Token: 0x040040F7 RID: 16631
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040040F8 RID: 16632
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccess;

		// Token: 0x040040F9 RID: 16633
		private static readonly IntPtr NativeFieldInfoPtr_AutoOpenForPlayer;

		// Token: 0x040040FA RID: 16634
		private static readonly IntPtr NativeFieldInfoPtr_InteriorIntObjs;

		// Token: 0x040040FB RID: 16635
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorIntObjs;

		// Token: 0x040040FC RID: 16636
		private static readonly IntPtr NativeFieldInfoPtr_PlayerBlocker;

		// Token: 0x040040FD RID: 16637
		private static readonly IntPtr NativeFieldInfoPtr_InteriorDoorHandleAnimation;

		// Token: 0x040040FE RID: 16638
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorDoorHandleAnimation;

		// Token: 0x040040FF RID: 16639
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnSleep;

		// Token: 0x04004100 RID: 16640
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnDistantPlayer;

		// Token: 0x04004101 RID: 16641
		private static readonly IntPtr NativeFieldInfoPtr_OpenableByNPCs;

		// Token: 0x04004102 RID: 16642
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToOriginalTime;

		// Token: 0x04004103 RID: 16643
		private static readonly IntPtr NativeFieldInfoPtr_onDoorOpened;

		// Token: 0x04004104 RID: 16644
		private static readonly IntPtr NativeFieldInfoPtr_onDoorClosed;

		// Token: 0x04004105 RID: 16645
		private static readonly IntPtr NativeFieldInfoPtr_lastOpenSide;

		// Token: 0x04004106 RID: 16646
		private static readonly IntPtr NativeFieldInfoPtr__openedByNPC_k__BackingField;

		// Token: 0x04004107 RID: 16647
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField;

		// Token: 0x04004108 RID: 16648
		private static readonly IntPtr NativeFieldInfoPtr_autoOpenedForPlayer;

		// Token: 0x04004109 RID: 16649
		private static readonly IntPtr NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField;

		// Token: 0x0400410A RID: 16650
		private static readonly IntPtr NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField;

		// Token: 0x0400410B RID: 16651
		private static readonly IntPtr NativeFieldInfoPtr__timeInCurrentState_k__BackingField;

		// Token: 0x0400410C RID: 16652
		private static readonly IntPtr NativeFieldInfoPtr_noAccessErrorMessage;

		// Token: 0x0400410D RID: 16653
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400410E RID: 16654
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400410F RID: 16655
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004110 RID: 16656
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04004111 RID: 16657
		private static readonly IntPtr NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0;

		// Token: 0x04004112 RID: 16658
		private static readonly IntPtr NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0;

		// Token: 0x04004113 RID: 16659
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0;

		// Token: 0x04004114 RID: 16660
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0;

		// Token: 0x04004115 RID: 16661
		private static readonly IntPtr NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0;

		// Token: 0x04004116 RID: 16662
		private static readonly IntPtr NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0;

		// Token: 0x04004117 RID: 16663
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0;

		// Token: 0x04004118 RID: 16664
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0;

		// Token: 0x04004119 RID: 16665
		private static readonly IntPtr NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0;

		// Token: 0x0400411A RID: 16666
		private static readonly IntPtr NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0;

		// Token: 0x0400411B RID: 16667
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400411C RID: 16668
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x0400411D RID: 16669
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400411E RID: 16670
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400411F RID: 16671
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04004120 RID: 16672
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04004121 RID: 16673
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04004122 RID: 16674
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04004123 RID: 16675
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0;

		// Token: 0x04004124 RID: 16676
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04004125 RID: 16677
		private static readonly IntPtr NativeMethodInfoPtr_NPCVicinityDetected_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04004126 RID: 16678
		private static readonly IntPtr NativeMethodInfoPtr_PlayerVicinityDetected_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04004127 RID: 16679
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04004128 RID: 16680
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04004129 RID: 16681
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0;

		// Token: 0x0400412A RID: 16682
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1;

		// Token: 0x0400412B RID: 16683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400412C RID: 16684
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__42_0_Private_Void_0;

		// Token: 0x0400412D RID: 16685
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400412E RID: 16686
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400412F RID: 16687
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004130 RID: 16688
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04004131 RID: 16689
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04004132 RID: 16690
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004133 RID: 16691
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04004134 RID: 16692
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04004135 RID: 16693
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004136 RID: 16694
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04004137 RID: 16695
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004138 RID: 16696
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
