using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200021D RID: 541
	public class StartLabOvenTask : Task
	{
		// Token: 0x06002C6F RID: 11375 RVA: 0x001000D0 File Offset: 0x000FE2D0
		// Note: this type is marked as 'beforefieldinit'.
		static StartLabOvenTask()
		{
			Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "StartLabOvenTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr);
			StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<Oven>k__BackingField");
			StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			StartLabOvenTask.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "ingredient");
			StartLabOvenTask.NativeFieldInfoPtr_pourRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourRoutine");
			StartLabOvenTask.NativeFieldInfoPtr_stationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "stationItem");
			StartLabOvenTask.NativeFieldInfoPtr_pourableModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourableModule");
			StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourAnimDone");
			StartLabOvenTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668320);
			StartLabOvenTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668321);
			StartLabOvenTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668322);
			StartLabOvenTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668323);
			StartLabOvenTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668324);
			StartLabOvenTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668325);
			StartLabOvenTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668326);
			StartLabOvenTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668327);
			StartLabOvenTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668328);
			StartLabOvenTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668329);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668330);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668331);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668332);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668333);
			StartLabOvenTask.NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668334);
			StartLabOvenTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668335);
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x001002CC File Offset: 0x000FE4CC
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x0010030C File Offset: 0x000FE50C
		public unsafe LabOven Oven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00100350 File Offset: 0x000FE550
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x0010038C File Offset: 0x000FE58C
		public unsafe StartLabOvenTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82758, RefRangeEnd = 82759, XrefRangeStart = 82758, XrefRangeEnd = 82759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 124741, RefRangeEnd = 124751, XrefRangeStart = 124741, XrefRangeEnd = 124751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x001003CC File Offset: 0x000FE5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126236, RefRangeEnd = 126237, XrefRangeStart = 126184, XrefRangeEnd = 126236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLabOvenTask(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00100418 File Offset: 0x000FE618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126237, XrefRangeEnd = 126263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00100454 File Offset: 0x000FE654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126263, XrefRangeEnd = 126280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00100490 File Offset: 0x000FE690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126280, XrefRangeEnd = 126307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x001004CC File Offset: 0x000FE6CC
		[CallerCount(0)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00100500 File Offset: 0x000FE700
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 126317, RefRangeEnd = 126324, XrefRangeStart = 126307, XrefRangeEnd = 126317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00100534 File Offset: 0x000FE734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126324, XrefRangeEnd = 126327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_OpenDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00100568 File Offset: 0x000FE768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126327, XrefRangeEnd = 126328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_Pour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0010059C File Offset: 0x000FE79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126328, XrefRangeEnd = 126331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CloseDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x001005D0 File Offset: 0x000FE7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126331, XrefRangeEnd = 126332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PressButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00100604 File Offset: 0x000FE804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126332, XrefRangeEnd = 126337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayPourAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00100644 File Offset: 0x000FE844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126337, XrefRangeEnd = 126343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepInstruction(StartLabOvenTask.EStep step)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref step;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x00017F1F File Offset: 0x0001611F
		public StartLabOvenTask(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0010067C File Offset: 0x000FE87C
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00017F28 File Offset: 0x00016128
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x001006AC File Offset: 0x000FE8AC
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x00017F47 File Offset: 0x00016147
		public unsafe StartLabOvenTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x001006D4 File Offset: 0x000FE8D4
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x00017F62 File Offset: 0x00016162
		public unsafe ItemInstance ingredient
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_ingredient);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x00100704 File Offset: 0x000FE904
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x00017F81 File Offset: 0x00016181
		public unsafe Coroutine pourRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x00100734 File Offset: 0x000FE934
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x00017FA0 File Offset: 0x000161A0
		public unsafe StationItem stationItem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_stationItem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_stationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x00100764 File Offset: 0x000FE964
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x00017FBF File Offset: 0x000161BF
		public unsafe PourableModule pourableModule
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourableModule);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourableModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x00100794 File Offset: 0x000FE994
		// (set) Token: 0x06002C8E RID: 11406 RVA: 0x00017FDE File Offset: 0x000161DE
		public unsafe bool pourAnimDone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone)) = value;
			}
		}

		// Token: 0x04001D72 RID: 7538
		private static readonly System.IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001D73 RID: 7539
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001D74 RID: 7540
		private static readonly System.IntPtr NativeFieldInfoPtr_ingredient;

		// Token: 0x04001D75 RID: 7541
		private static readonly System.IntPtr NativeFieldInfoPtr_pourRoutine;

		// Token: 0x04001D76 RID: 7542
		private static readonly System.IntPtr NativeFieldInfoPtr_stationItem;

		// Token: 0x04001D77 RID: 7543
		private static readonly System.IntPtr NativeFieldInfoPtr_pourableModule;

		// Token: 0x04001D78 RID: 7544
		private static readonly System.IntPtr NativeFieldInfoPtr_pourAnimDone;

		// Token: 0x04001D79 RID: 7545
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly System.IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly System.IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0;

		// Token: 0x02000918 RID: 2328
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x0400886E RID: 34926
			OpenDoor,
			// Token: 0x0400886F RID: 34927
			Pour,
			// Token: 0x04008870 RID: 34928
			CloseDoor,
			// Token: 0x04008871 RID: 34929
			PressButton
		}

		// Token: 0x02000919 RID: 2329
		[ObfuscatedName("ScheduleOne.PlayerTasks.StartLabOvenTask+<PlayPourAnimation>d__24")]
		public sealed class _PlayPourAnimation_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600C915 RID: 51477 RVA: 0x00311FAC File Offset: 0x003101AC
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayPourAnimation_d__24()
			{
				Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<PlayPourAnimation>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>1__state");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>2__current");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>4__this");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<pourTime>5__2");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<i>5__3");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668336);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668337);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668338);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668339);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668340);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668341);
			}

			// Token: 0x0600C916 RID: 51478 RVA: 0x003120B4 File Offset: 0x003102B4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayPourAnimation_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C917 RID: 51479 RVA: 0x003120FC File Offset: 0x003102FC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C918 RID: 51480 RVA: 0x00312130 File Offset: 0x00310330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126173, XrefRangeEnd = 126179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E80 RID: 16000
			// (get) Token: 0x0600C919 RID: 51481 RVA: 0x0031216C File Offset: 0x0031036C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C91A RID: 51482 RVA: 0x003121AC File Offset: 0x003103AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126179, XrefRangeEnd = 126184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E81 RID: 16001
			// (get) Token: 0x0600C91B RID: 51483 RVA: 0x003121E0 File Offset: 0x003103E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C91C RID: 51484 RVA: 0x0006184C File Offset: 0x0005FA4C
			public _PlayPourAnimation_d__24(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E7B RID: 15995
			// (get) Token: 0x0600C91D RID: 51485 RVA: 0x00312220 File Offset: 0x00310420
			// (set) Token: 0x0600C91E RID: 51486 RVA: 0x00061855 File Offset: 0x0005FA55
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E7C RID: 15996
			// (get) Token: 0x0600C91F RID: 51487 RVA: 0x00312248 File Offset: 0x00310448
			// (set) Token: 0x0600C920 RID: 51488 RVA: 0x00061870 File Offset: 0x0005FA70
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E7D RID: 15997
			// (get) Token: 0x0600C921 RID: 51489 RVA: 0x00312278 File Offset: 0x00310478
			// (set) Token: 0x0600C922 RID: 51490 RVA: 0x0006188F File Offset: 0x0005FA8F
			public unsafe StartLabOvenTask __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLabOvenTask>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E7E RID: 15998
			// (get) Token: 0x0600C923 RID: 51491 RVA: 0x003122A8 File Offset: 0x003104A8
			// (set) Token: 0x0600C924 RID: 51492 RVA: 0x000618AE File Offset: 0x0005FAAE
			public unsafe float _pourTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2)) = value;
				}
			}

			// Token: 0x17003E7F RID: 15999
			// (get) Token: 0x0600C925 RID: 51493 RVA: 0x003122D0 File Offset: 0x003104D0
			// (set) Token: 0x0600C926 RID: 51494 RVA: 0x000618C9 File Offset: 0x0005FAC9
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008872 RID: 34930
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008873 RID: 34931
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008874 RID: 34932
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008875 RID: 34933
			private static readonly System.IntPtr NativeFieldInfoPtr__pourTime_5__2;

			// Token: 0x04008876 RID: 34934
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008877 RID: 34935
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008878 RID: 34936
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008879 RID: 34937
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400887A RID: 34938
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400887B RID: 34939
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400887C RID: 34940
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
