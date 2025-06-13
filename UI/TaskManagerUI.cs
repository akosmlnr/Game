using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200068D RID: 1677
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x060094E0 RID: 38112 RVA: 0x0026886C File Offset: 0x00266A6C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManagerUI()
		{
			Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TaskManagerUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr);
			TaskManagerUI.NativeFieldInfoPtr_textShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "textShown");
			TaskManagerUI.NativeFieldInfoPtr_inputPromptUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "inputPromptUI");
			TaskManagerUI.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "canvas");
			TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "multiGrabIndicator");
			TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "PackagingStationMK2TutorialDone");
			TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681877);
			TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681878);
			TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681879);
			TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681880);
			TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681881);
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x00268964 File Offset: 0x00266B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268697, XrefRangeEnd = 268703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x002689A0 File Offset: 0x00266BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268703, XrefRangeEnd = 268728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x002689DC File Offset: 0x00266BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268728, XrefRangeEnd = 268744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInstructionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x00268A18 File Offset: 0x00266C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268744, XrefRangeEnd = 268769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskStarted(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x00268A5C File Offset: 0x00266C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268769, XrefRangeEnd = 268772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManagerUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x00047C62 File Offset: 0x00045E62
		public TaskManagerUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D6A RID: 11626
		// (get) Token: 0x060094E7 RID: 38119 RVA: 0x00268A98 File Offset: 0x00266C98
		// (set) Token: 0x060094E8 RID: 38120 RVA: 0x00047C6B File Offset: 0x00045E6B
		public unsafe bool textShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown)) = value;
			}
		}

		// Token: 0x17002D6B RID: 11627
		// (get) Token: 0x060094E9 RID: 38121 RVA: 0x00268AC0 File Offset: 0x00266CC0
		// (set) Token: 0x060094EA RID: 38122 RVA: 0x00047C86 File Offset: 0x00045E86
		public unsafe GenericUIScreen inputPromptUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6C RID: 11628
		// (get) Token: 0x060094EB RID: 38123 RVA: 0x00268AF0 File Offset: 0x00266CF0
		// (set) Token: 0x060094EC RID: 38124 RVA: 0x00047CA5 File Offset: 0x00045EA5
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6D RID: 11629
		// (get) Token: 0x060094ED RID: 38125 RVA: 0x00268B20 File Offset: 0x00266D20
		// (set) Token: 0x060094EE RID: 38126 RVA: 0x00047CC4 File Offset: 0x00045EC4
		public unsafe RectTransform multiGrabIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D6E RID: 11630
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x00268B50 File Offset: 0x00266D50
		// (set) Token: 0x060094F0 RID: 38128 RVA: 0x00047CE3 File Offset: 0x00045EE3
		public unsafe GenericUIScreen PackagingStationMK2TutorialDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400649C RID: 25756
		private static readonly IntPtr NativeFieldInfoPtr_textShown;

		// Token: 0x0400649D RID: 25757
		private static readonly IntPtr NativeFieldInfoPtr_inputPromptUI;

		// Token: 0x0400649E RID: 25758
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x0400649F RID: 25759
		private static readonly IntPtr NativeFieldInfoPtr_multiGrabIndicator;

		// Token: 0x040064A0 RID: 25760
		private static readonly IntPtr NativeFieldInfoPtr_PackagingStationMK2TutorialDone;

		// Token: 0x040064A1 RID: 25761
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040064A2 RID: 25762
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040064A3 RID: 25763
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0;

		// Token: 0x040064A4 RID: 25764
		private static readonly IntPtr NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0;

		// Token: 0x040064A5 RID: 25765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
