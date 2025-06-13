using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000221 RID: 545
	public class PourOntoTargetTask : PourIntoPotTask
	{
		// Token: 0x06002CF4 RID: 11508 RVA: 0x00101C44 File Offset: 0x000FFE44
		// Note: this type is marked as 'beforefieldinit'.
		static PourOntoTargetTask()
		{
			Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourOntoTargetTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr);
			PourOntoTargetTask.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "Target");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_THRESHOLD");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_TIME");
			PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "timeOverTarget");
			PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668395);
			PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668396);
			PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668397);
			PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668398);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00101D14 File Offset: 0x000FFF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127136, XrefRangeEnd = 127141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourOntoTargetTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00101D84 File Offset: 0x000FFF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127141, XrefRangeEnd = 127145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00101DC0 File Offset: 0x000FFFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127145, XrefRangeEnd = 127148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00101DFC File Offset: 0x000FFFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127148, XrefRangeEnd = 127154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00018306 File Offset: 0x00016506
		public PourOntoTargetTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x00101E38 File Offset: 0x00100038
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x0001830F File Offset: 0x0001650F
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x00101E68 File Offset: 0x00100068
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x0001832E File Offset: 0x0001652E
		public unsafe float SUCCESS_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x00101E90 File Offset: 0x00100090
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x00018349 File Offset: 0x00016549
		public unsafe float SUCCESS_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME)) = value;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x00101EB8 File Offset: 0x001000B8
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x00018364 File Offset: 0x00016564
		public unsafe float timeOverTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget)) = value;
			}
		}

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_THRESHOLD;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_TIME;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeFieldInfoPtr_timeOverTarget;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0;
	}
}
