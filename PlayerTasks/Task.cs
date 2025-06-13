using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000211 RID: 529
	public class Task : Il2CppSystem.Object
	{
		// Token: 0x06002B56 RID: 11094 RVA: 0x000FC958 File Offset: 0x000FAB58
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Task");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task>.NativeClassPtr);
			Task.NativeFieldInfoPtr_ClickDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionRange");
			Task.NativeFieldInfoPtr_ClickDetectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionRadius");
			Task.NativeFieldInfoPtr_MultiGrabRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "MultiGrabRadius");
			Task.NativeFieldInfoPtr_MultiGrabForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "MultiGrabForceMultiplier");
			Task.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<TaskName>k__BackingField");
			Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<CurrentInstruction>k__BackingField");
			Task.NativeFieldInfoPtr__TaskActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<TaskActive>k__BackingField");
			Task.NativeFieldInfoPtr_ClickDetectionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionEnabled");
			Task.NativeFieldInfoPtr_Outcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "Outcome");
			Task.NativeFieldInfoPtr_onTaskSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskSuccess");
			Task.NativeFieldInfoPtr_onTaskFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskFail");
			Task.NativeFieldInfoPtr_onTaskStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskStop");
			Task.NativeFieldInfoPtr_clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "clickable");
			Task.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "draggable");
			Task.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "constraint");
			Task.NativeFieldInfoPtr_hitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "hitDistance");
			Task.NativeFieldInfoPtr_relativeHitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "relativeHitOffset");
			Task.NativeFieldInfoPtr_multiDraggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiDraggingEnabled");
			Task.NativeFieldInfoPtr_multiGrabProjectionPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiGrabProjectionPlane");
			Task.NativeFieldInfoPtr_multiDragTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiDragTargets");
			Task.NativeFieldInfoPtr_isMultiDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "isMultiDragging");
			Task.NativeFieldInfoPtr_forcedClickables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "forcedClickables");
			Task.NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668201);
			Task.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668202);
			Task.NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668203);
			Task.NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668204);
			Task.NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668205);
			Task.NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668206);
			Task.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668207);
			Task.NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668208);
			Task.NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668209);
			Task.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668210);
			Task.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668211);
			Task.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668212);
			Task.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668213);
			Task.NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668214);
			Task.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668215);
			Task.NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668216);
			Task.NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668217);
			Task.NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668218);
			Task.NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668219);
			Task.NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668220);
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000FCCD0 File Offset: 0x000FAED0
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x000FCD14 File Offset: 0x000FAF14
		public unsafe virtual string TaskName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000FCD64 File Offset: 0x000FAF64
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x000FCD9C File Offset: 0x000FAF9C
		public unsafe string CurrentInstruction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000FCDE0 File Offset: 0x000FAFE0
		// (set) Token: 0x06002B5C RID: 11100 RVA: 0x000FCE1C File Offset: 0x000FB01C
		public unsafe bool TaskActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000FCE5C File Offset: 0x000FB05C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 124298, RefRangeEnd = 124312, XrefRangeStart = 124262, XrefRangeEnd = 124298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000FCE98 File Offset: 0x000FB098
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 124336, RefRangeEnd = 124349, XrefRangeStart = 124312, XrefRangeEnd = 124336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000FCED4 File Offset: 0x000FB0D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 124353, RefRangeEnd = 124360, XrefRangeStart = 124349, XrefRangeEnd = 124353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000FCF10 File Offset: 0x000FB110
		[CallerCount(0)]
		public unsafe virtual void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000FCF4C File Offset: 0x000FB14C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 124388, RefRangeEnd = 124402, XrefRangeStart = 124360, XrefRangeEnd = 124388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000FCF88 File Offset: 0x000FB188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124413, RefRangeEnd = 124414, XrefRangeStart = 124402, XrefRangeEnd = 124413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000FCFC4 File Offset: 0x000FB1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124414, XrefRangeEnd = 124458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000FD000 File Offset: 0x000FB200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124482, RefRangeEnd = 124484, XrefRangeStart = 124458, XrefRangeEnd = 124482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMultiDragOrigin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x000FD03C File Offset: 0x000FB23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124484, XrefRangeEnd = 124564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000FD078 File Offset: 0x000FB278
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124572, RefRangeEnd = 124575, XrefRangeStart = 124564, XrefRangeEnd = 124572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceStartClick(Clickable _clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_clickable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000FD0BC File Offset: 0x000FB2BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 124582, RefRangeEnd = 124589, XrefRangeStart = 124575, XrefRangeEnd = 124582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceEndClick(Clickable _clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_clickable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000FD100 File Offset: 0x000FB300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124638, RefRangeEnd = 124639, XrefRangeStart = 124589, XrefRangeEnd = 124638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDraggablePhysics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000FD134 File Offset: 0x000FB334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124639, XrefRangeEnd = 124672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Clickable GetClickable(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &hit;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x000FD18C File Offset: 0x000FB38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124672, XrefRangeEnd = 124673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(projectionPlane);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref radius;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0001762B File Offset: 0x0001582B
		public Task(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000FD1DC File Offset: 0x000FB3DC
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x00017634 File Offset: 0x00015834
		public unsafe static float ClickDetectionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_ClickDetectionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_ClickDetectionRange, (void*)(&value));
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000FD1F8 File Offset: 0x000FB3F8
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x00017642 File Offset: 0x00015842
		public unsafe float ClickDetectionRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionRadius)) = value;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000FD220 File Offset: 0x000FB420
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x0001765D File Offset: 0x0001585D
		public unsafe float MultiGrabRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_MultiGrabRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_MultiGrabRadius)) = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000FD248 File Offset: 0x000FB448
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x00017678 File Offset: 0x00015878
		public unsafe static float MultiGrabForceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_MultiGrabForceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_MultiGrabForceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000FD264 File Offset: 0x000FB464
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x00017686 File Offset: 0x00015886
		public unsafe string _TaskName_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x000FD28C File Offset: 0x000FB48C
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x000176A5 File Offset: 0x000158A5
		public unsafe string _CurrentInstruction_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x000FD2B4 File Offset: 0x000FB4B4
		// (set) Token: 0x06002B79 RID: 11129 RVA: 0x000176C4 File Offset: 0x000158C4
		public unsafe bool _TaskActive_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x000FD2DC File Offset: 0x000FB4DC
		// (set) Token: 0x06002B7B RID: 11131 RVA: 0x000176DF File Offset: 0x000158DF
		public unsafe bool ClickDetectionEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionEnabled)) = value;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000FD304 File Offset: 0x000FB504
		// (set) Token: 0x06002B7D RID: 11133 RVA: 0x000176FA File Offset: 0x000158FA
		public unsafe Task.EOutcome Outcome
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_Outcome);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_Outcome)) = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000FD32C File Offset: 0x000FB52C
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x00017715 File Offset: 0x00015915
		public unsafe Il2CppSystem.Action onTaskSuccess
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskSuccess);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x000FD35C File Offset: 0x000FB55C
		// (set) Token: 0x06002B81 RID: 11137 RVA: 0x00017734 File Offset: 0x00015934
		public unsafe Il2CppSystem.Action onTaskFail
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskFail);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000FD38C File Offset: 0x000FB58C
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x00017753 File Offset: 0x00015953
		public unsafe Il2CppSystem.Action onTaskStop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskStop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000FD3BC File Offset: 0x000FB5BC
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00017772 File Offset: 0x00015972
		public unsafe Clickable clickable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000FD3EC File Offset: 0x000FB5EC
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x00017791 File Offset: 0x00015991
		public unsafe Draggable draggable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_draggable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000FD41C File Offset: 0x000FB61C
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x000177B0 File Offset: 0x000159B0
		public unsafe DraggableConstraint constraint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_constraint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000FD44C File Offset: 0x000FB64C
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x000177CF File Offset: 0x000159CF
		public unsafe float hitDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_hitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_hitDistance)) = value;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000FD474 File Offset: 0x000FB674
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x000177EA File Offset: 0x000159EA
		public unsafe Vector3 relativeHitOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_relativeHitOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_relativeHitOffset)) = value;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000FD49C File Offset: 0x000FB69C
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x00017805 File Offset: 0x00015A05
		public unsafe bool multiDraggingEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDraggingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDraggingEnabled)) = value;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x000FD4C4 File Offset: 0x000FB6C4
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x00017820 File Offset: 0x00015A20
		public unsafe Transform multiGrabProjectionPlane
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiGrabProjectionPlane);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiGrabProjectionPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000FD4F4 File Offset: 0x000FB6F4
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0001783F File Offset: 0x00015A3F
		public unsafe List<Draggable> multiDragTargets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDragTargets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDragTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000FD524 File Offset: 0x000FB724
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x0001785E File Offset: 0x00015A5E
		public unsafe bool isMultiDragging
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_isMultiDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_isMultiDragging)) = value;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000FD54C File Offset: 0x000FB74C
		// (set) Token: 0x06002B97 RID: 11159 RVA: 0x00017879 File Offset: 0x00015A79
		public unsafe List<Clickable> forcedClickables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_forcedClickables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Clickable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_forcedClickables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CBC RID: 7356
		private static readonly System.IntPtr NativeFieldInfoPtr_ClickDetectionRange;

		// Token: 0x04001CBD RID: 7357
		private static readonly System.IntPtr NativeFieldInfoPtr_ClickDetectionRadius;

		// Token: 0x04001CBE RID: 7358
		private static readonly System.IntPtr NativeFieldInfoPtr_MultiGrabRadius;

		// Token: 0x04001CBF RID: 7359
		private static readonly System.IntPtr NativeFieldInfoPtr_MultiGrabForceMultiplier;

		// Token: 0x04001CC0 RID: 7360
		private static readonly System.IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001CC1 RID: 7361
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentInstruction_k__BackingField;

		// Token: 0x04001CC2 RID: 7362
		private static readonly System.IntPtr NativeFieldInfoPtr__TaskActive_k__BackingField;

		// Token: 0x04001CC3 RID: 7363
		private static readonly System.IntPtr NativeFieldInfoPtr_ClickDetectionEnabled;

		// Token: 0x04001CC4 RID: 7364
		private static readonly System.IntPtr NativeFieldInfoPtr_Outcome;

		// Token: 0x04001CC5 RID: 7365
		private static readonly System.IntPtr NativeFieldInfoPtr_onTaskSuccess;

		// Token: 0x04001CC6 RID: 7366
		private static readonly System.IntPtr NativeFieldInfoPtr_onTaskFail;

		// Token: 0x04001CC7 RID: 7367
		private static readonly System.IntPtr NativeFieldInfoPtr_onTaskStop;

		// Token: 0x04001CC8 RID: 7368
		private static readonly System.IntPtr NativeFieldInfoPtr_clickable;

		// Token: 0x04001CC9 RID: 7369
		private static readonly System.IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04001CCA RID: 7370
		private static readonly System.IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x04001CCB RID: 7371
		private static readonly System.IntPtr NativeFieldInfoPtr_hitDistance;

		// Token: 0x04001CCC RID: 7372
		private static readonly System.IntPtr NativeFieldInfoPtr_relativeHitOffset;

		// Token: 0x04001CCD RID: 7373
		private static readonly System.IntPtr NativeFieldInfoPtr_multiDraggingEnabled;

		// Token: 0x04001CCE RID: 7374
		private static readonly System.IntPtr NativeFieldInfoPtr_multiGrabProjectionPlane;

		// Token: 0x04001CCF RID: 7375
		private static readonly System.IntPtr NativeFieldInfoPtr_multiDragTargets;

		// Token: 0x04001CD0 RID: 7376
		private static readonly System.IntPtr NativeFieldInfoPtr_isMultiDragging;

		// Token: 0x04001CD1 RID: 7377
		private static readonly System.IntPtr NativeFieldInfoPtr_forcedClickables;

		// Token: 0x04001CD2 RID: 7378
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0;

		// Token: 0x04001CD6 RID: 7382
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly System.IntPtr NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly System.IntPtr NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly System.IntPtr NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0;

		// Token: 0x02000913 RID: 2323
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x04008850 RID: 34896
			Cancelled,
			// Token: 0x04008851 RID: 34897
			Success,
			// Token: 0x04008852 RID: 34898
			Fail
		}
	}
}
