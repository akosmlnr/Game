using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x02000304 RID: 772
	[System.Serializable]
	public class NPCAction : NetworkBehaviour
	{
		// Token: 0x060038C6 RID: 14534 RVA: 0x0012BA6C File Offset: 0x00129C6C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAction()
		{
			Il2CppClassPointerStore<NPCAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAction>.NativeClassPtr);
			NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			NPCAction.NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "<IsActive>k__BackingField");
			NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "<HasStarted>k__BackingField");
			NPCAction.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "priority");
			NPCAction.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "StartTime");
			NPCAction.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "npc");
			NPCAction.NativeFieldInfoPtr_schedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "schedule");
			NPCAction.NativeFieldInfoPtr_onEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "onEnded");
			NPCAction.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "consecutivePathingFailures");
			NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted");
			NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted");
			NPCAction.NativeMethodInfoPtr_get_ActionName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669904);
			NPCAction.NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669905);
			NPCAction.NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669906);
			NPCAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669907);
			NPCAction.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669908);
			NPCAction.NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669909);
			NPCAction.NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669910);
			NPCAction.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669911);
			NPCAction.NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669912);
			NPCAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669913);
			NPCAction.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669914);
			NPCAction.NativeMethodInfoPtr_GetReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669915);
			NPCAction.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669916);
			NPCAction.NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669917);
			NPCAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669918);
			NPCAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669919);
			NPCAction.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669920);
			NPCAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669921);
			NPCAction.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669922);
			NPCAction.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669923);
			NPCAction.NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669924);
			NPCAction.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669925);
			NPCAction.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669926);
			NPCAction.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669927);
			NPCAction.NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669928);
			NPCAction.NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669929);
			NPCAction.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669930);
			NPCAction.NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669931);
			NPCAction.NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669932);
			NPCAction.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669933);
			NPCAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669934);
			NPCAction.NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669935);
			NPCAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669936);
			NPCAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669937);
			NPCAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669938);
			NPCAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669939);
			NPCAction.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100669940);
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x0012BE5C File Offset: 0x0012A05C
		public unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145866, XrefRangeEnd = 145868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_ActionName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x0012BE94 File Offset: 0x0012A094
		public unsafe bool IsEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145868, XrefRangeEnd = 145870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x0012BED0 File Offset: 0x0012A0D0
		public unsafe bool IsSignal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145872, RefRangeEnd = 145873, XrefRangeStart = 145870, XrefRangeEnd = 145872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060038CA RID: 14538 RVA: 0x0012BF0C File Offset: 0x0012A10C
		// (set) Token: 0x060038CB RID: 14539 RVA: 0x0012BF48 File Offset: 0x0012A148
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060038CC RID: 14540 RVA: 0x0012BF88 File Offset: 0x0012A188
		// (set) Token: 0x060038CD RID: 14541 RVA: 0x0012BFC4 File Offset: 0x0012A1C4
		public unsafe bool HasStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x0012C004 File Offset: 0x0012A204
		public unsafe virtual int Priority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x0012C04C File Offset: 0x0012A24C
		public unsafe NPCMovement movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0012C08C File Offset: 0x0012A28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x0012C0C8 File Offset: 0x0012A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145873, XrefRangeEnd = 145875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x0012C104 File Offset: 0x0012A304
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 145890, RefRangeEnd = 145918, XrefRangeStart = 145875, XrefRangeEnd = 145890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_GetReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0012C138 File Offset: 0x0012A338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145934, RefRangeEnd = 145935, XrefRangeStart = 145918, XrefRangeEnd = 145934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x0012C174 File Offset: 0x0012A374
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 145944, RefRangeEnd = 145956, XrefRangeStart = 145935, XrefRangeEnd = 145944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x0012C1B0 File Offset: 0x0012A3B0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 145965, RefRangeEnd = 145977, XrefRangeStart = 145956, XrefRangeEnd = 145965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0012C1EC File Offset: 0x0012A3EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 145986, RefRangeEnd = 145994, XrefRangeStart = 145977, XrefRangeEnd = 145986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0012C228 File Offset: 0x0012A428
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 146003, RefRangeEnd = 146011, XrefRangeStart = 145994, XrefRangeEnd = 146003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x0012C264 File Offset: 0x0012A464
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 146026, RefRangeEnd = 146038, XrefRangeStart = 146011, XrefRangeEnd = 146026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x0012C2A0 File Offset: 0x0012A4A0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146053, RefRangeEnd = 146063, XrefRangeStart = 146038, XrefRangeEnd = 146053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0012C2DC File Offset: 0x0012A4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146063, XrefRangeEnd = 146077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResumeFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0012C318 File Offset: 0x0012A518
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146087, RefRangeEnd = 146097, XrefRangeStart = 146077, XrefRangeEnd = 146087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0012C354 File Offset: 0x0012A554
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x0012C390 File Offset: 0x0012A590
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x0012C3CC File Offset: 0x0012A5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146097, XrefRangeEnd = 146101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PendingMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x0012C408 File Offset: 0x0012A608
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038E0 RID: 14560 RVA: 0x0012C444 File Offset: 0x0012A644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146101, XrefRangeEnd = 146103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0012C48C File Offset: 0x0012A68C
		[CallerCount(0)]
		public unsafe virtual string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0012C4D0 File Offset: 0x0012A6D0
		[CallerCount(0)]
		public unsafe virtual string GetTimeDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0012C514 File Offset: 0x0012A714
		[CallerCount(0)]
		public unsafe virtual int GetEndTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x0012C55C File Offset: 0x0012A75C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 146116, RefRangeEnd = 146147, XrefRangeStart = 146103, XrefRangeEnd = 146116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref teleportIfFail;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0012C5A8 File Offset: 0x0012A7A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 146158, RefRangeEnd = 146169, XrefRangeStart = 146147, XrefRangeEnd = 146158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0012C5F4 File Offset: 0x0012A7F4
		[CallerCount(0)]
		public unsafe virtual void SetStartTime(int startTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0012C640 File Offset: 0x0012A840
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAction>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0012C67C File Offset: 0x0012A87C
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0012C6B8 File Offset: 0x0012A8B8
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0012C6F4 File Offset: 0x0012A8F4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x0012C730 File Offset: 0x0012A930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146169, XrefRangeEnd = 146170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x0001D553 File Offset: 0x0001B753
		public NPCAction(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x0012C76C File Offset: 0x0012A96C
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x0001D55C File Offset: 0x0001B75C
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x0012C788 File Offset: 0x0012A988
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x0001D56A File Offset: 0x0001B76A
		public unsafe bool _IsActive_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__IsActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__IsActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x0012C7B0 File Offset: 0x0012A9B0
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x0001D585 File Offset: 0x0001B785
		public unsafe bool _HasStarted_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField)) = value;
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x0012C7D8 File Offset: 0x0012A9D8
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		public unsafe int priority
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x0012C800 File Offset: 0x0012AA00
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x0001D5BB File Offset: 0x0001B7BB
		public unsafe int StartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x0012C828 File Offset: 0x0012AA28
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x0001D5D6 File Offset: 0x0001B7D6
		public unsafe NPC npc
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_npc);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x0012C858 File Offset: 0x0012AA58
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x0001D5F5 File Offset: 0x0001B7F5
		public unsafe NPCScheduleManager schedule
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_schedule);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_schedule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x0012C888 File Offset: 0x0012AA88
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x0001D614 File Offset: 0x0001B814
		public unsafe Il2CppSystem.Action onEnded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_onEnded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_onEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x0012C8B8 File Offset: 0x0012AAB8
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0001D633 File Offset: 0x0001B833
		public unsafe int consecutivePathingFailures
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x0012C8E0 File Offset: 0x0012AAE0
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x0001D64E File Offset: 0x0001B84E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x0012C908 File Offset: 0x0012AB08
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x0001D669 File Offset: 0x0001B869
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002546 RID: 9542
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002547 RID: 9543
		private static readonly System.IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

		// Token: 0x04002548 RID: 9544
		private static readonly System.IntPtr NativeFieldInfoPtr__HasStarted_k__BackingField;

		// Token: 0x04002549 RID: 9545
		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400254A RID: 9546
		private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400254B RID: 9547
		private static readonly System.IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400254C RID: 9548
		private static readonly System.IntPtr NativeFieldInfoPtr_schedule;

		// Token: 0x0400254D RID: 9549
		private static readonly System.IntPtr NativeFieldInfoPtr_onEnded;

		// Token: 0x0400254E RID: 9550
		private static readonly System.IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x0400254F RID: 9551
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002550 RID: 9552
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002551 RID: 9553
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionName_Protected_get_String_0;

		// Token: 0x04002552 RID: 9554
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0;

		// Token: 0x04002553 RID: 9555
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0;

		// Token: 0x04002554 RID: 9556
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x04002555 RID: 9557
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsActive_Protected_set_Void_Boolean_0;

		// Token: 0x04002556 RID: 9558
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0;

		// Token: 0x04002557 RID: 9559
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0;

		// Token: 0x04002558 RID: 9560
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002559 RID: 9561
		private static readonly System.IntPtr NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0;

		// Token: 0x0400255A RID: 9562
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400255B RID: 9563
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x0400255C RID: 9564
		private static readonly System.IntPtr NativeMethodInfoPtr_GetReferences_Private_Void_0;

		// Token: 0x0400255D RID: 9565
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x0400255E RID: 9566
		private static readonly System.IntPtr NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0;

		// Token: 0x0400255F RID: 9567
		private static readonly System.IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0;

		// Token: 0x04002560 RID: 9568
		private static readonly System.IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0;

		// Token: 0x04002561 RID: 9569
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x04002562 RID: 9570
		private static readonly System.IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0;

		// Token: 0x04002563 RID: 9571
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0;

		// Token: 0x04002564 RID: 9572
		private static readonly System.IntPtr NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0;

		// Token: 0x04002565 RID: 9573
		private static readonly System.IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0;

		// Token: 0x04002566 RID: 9574
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002567 RID: 9575
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_New_Void_0;

		// Token: 0x04002568 RID: 9576
		private static readonly System.IntPtr NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0;

		// Token: 0x04002569 RID: 9577
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0;

		// Token: 0x0400256A RID: 9578
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0;

		// Token: 0x0400256B RID: 9579
		private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x0400256C RID: 9580
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0;

		// Token: 0x0400256D RID: 9581
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x0400256E RID: 9582
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x0400256F RID: 9583
		private static readonly System.IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x04002570 RID: 9584
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04002571 RID: 9585
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002572 RID: 9586
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002573 RID: 9587
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002574 RID: 9588
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002575 RID: 9589
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
