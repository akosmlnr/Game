using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000224 RID: 548
	public class UseMixingStationTask : Task
	{
		// Token: 0x06002D1A RID: 11546 RVA: 0x00102470 File Offset: 0x00100670
		// Note: this type is marked as 'beforefieldinit'.
		static UseMixingStationTask()
		{
			Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "UseMixingStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr);
			UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "items");
			UseMixingStationTask.NativeFieldInfoPtr_mixerItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "mixerItems");
			UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "ingredientPieces");
			UseMixingStationTask.NativeFieldInfoPtr_removedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "removedIngredients");
			UseMixingStationTask.NativeFieldInfoPtr_Jug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "Jug");
			UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668411);
			UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668412);
			UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668413);
			UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668414);
			UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668415);
			UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668416);
			UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668417);
			UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668418);
			UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668419);
			UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668420);
			UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668421);
			UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668422);
			UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668423);
			UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668424);
			UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668425);
			UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668426);
			UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668427);
			UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668428);
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x00102694 File Offset: 0x00100894
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x001026D4 File Offset: 0x001008D4
		public unsafe MixingStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x00102718 File Offset: 0x00100918
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00102754 File Offset: 0x00100954
		public unsafe UseMixingStationTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82758, RefRangeEnd = 82759, XrefRangeStart = 82758, XrefRangeEnd = 82759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00102794 File Offset: 0x00100994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127295, XrefRangeEnd = 127299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(UseMixingStationTask.EStep step)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref step;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x001027CC File Offset: 0x001009CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127380, RefRangeEnd = 127381, XrefRangeStart = 127299, XrefRangeEnd = 127380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseMixingStationTask(MixingStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00102818 File Offset: 0x00100A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127381, XrefRangeEnd = 127403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker CreateJug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00102858 File Offset: 0x00100A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127403, XrefRangeEnd = 127413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00102894 File Offset: 0x00100A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127446, RefRangeEnd = 127447, XrefRangeStart = 127413, XrefRangeEnd = 127446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x001028C8 File Offset: 0x00100AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127447, XrefRangeEnd = 127454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x001028FC File Offset: 0x00100AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127454, XrefRangeEnd = 127461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00102930 File Offset: 0x00100B30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 127493, RefRangeEnd = 127497, XrefRangeStart = 127461, XrefRangeEnd = 127493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCombinedIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0010296C File Offset: 0x00100B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127497, XrefRangeEnd = 127498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x001029A0 File Offset: 0x00100BA0
		[CallerCount(0)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x001029D4 File Offset: 0x00100BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127498, XrefRangeEnd = 127516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00102A10 File Offset: 0x00100C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127552, RefRangeEnd = 127553, XrefRangeStart = 127516, XrefRangeEnd = 127552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00102A44 File Offset: 0x00100C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127553, XrefRangeEnd = 127598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00102A80 File Offset: 0x00100C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127664, RefRangeEnd = 127666, XrefRangeStart = 127598, XrefRangeEnd = 127664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.__c__DisplayClass15_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mixer;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000183EB File Offset: 0x000165EB
		public UseMixingStationTask(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x00102AF4 File Offset: 0x00100CF4
		// (set) Token: 0x06002D2F RID: 11567 RVA: 0x000183F4 File Offset: 0x000165F4
		public unsafe MixingStation _Station_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x00102B24 File Offset: 0x00100D24
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x00018413 File Offset: 0x00016613
		public unsafe UseMixingStationTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x00102B4C File Offset: 0x00100D4C
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x0001842E File Offset: 0x0001662E
		public unsafe List<StationItem> items
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x00102B7C File Offset: 0x00100D7C
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x0001844D File Offset: 0x0001664D
		public unsafe List<StationItem> mixerItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x00102BAC File Offset: 0x00100DAC
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x0001846C File Offset: 0x0001666C
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00102BDC File Offset: 0x00100DDC
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x0001848B File Offset: 0x0001668B
		public unsafe Il2CppReferenceArray<ItemInstance> removedIngredients
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x00102C0C File Offset: 0x00100E0C
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x000184AA File Offset: 0x000166AA
		public unsafe Beaker Jug
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DE5 RID: 7653
		private static readonly System.IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001DE6 RID: 7654
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001DE7 RID: 7655
		private static readonly System.IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001DE8 RID: 7656
		private static readonly System.IntPtr NativeFieldInfoPtr_mixerItems;

		// Token: 0x04001DE9 RID: 7657
		private static readonly System.IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001DEA RID: 7658
		private static readonly System.IntPtr NativeFieldInfoPtr_removedIngredients;

		// Token: 0x04001DEB RID: 7659
		private static readonly System.IntPtr NativeFieldInfoPtr_Jug;

		// Token: 0x04001DEC RID: 7660
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0;

		// Token: 0x04001DED RID: 7661
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateJug_Private_Beaker_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly System.IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly System.IntPtr NativeMethodInfoPtr_StartButtonPressed_Private_Void_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly System.IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateTrash_Private_Void_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0;

		// Token: 0x0200091D RID: 2333
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x04008894 RID: 34964
			CombineIngredients,
			// Token: 0x04008895 RID: 34965
			StartMixing
		}

		// Token: 0x0200091E RID: 2334
		[ObfuscatedName("ScheduleOne.PlayerTasks.Tasks.UseMixingStationTask+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.ValueType
		{
			// Token: 0x0600C943 RID: 51523 RVA: 0x003128A0 File Offset: 0x00310AA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr);
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "station");
			}

			// Token: 0x0600C944 RID: 51524 RVA: 0x000619A8 File Offset: 0x0005FBA8
			public __c__DisplayClass15_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C945 RID: 51525 RVA: 0x000619B1 File Offset: 0x0005FBB1
			public __c__DisplayClass15_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr))
			{
			}

			// Token: 0x17003E8C RID: 16012
			// (get) Token: 0x0600C946 RID: 51526 RVA: 0x003128F4 File Offset: 0x00310AF4
			// (set) Token: 0x0600C947 RID: 51527 RVA: 0x000619C3 File Offset: 0x0005FBC3
			public unsafe UseMixingStationTask __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseMixingStationTask>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E8D RID: 16013
			// (get) Token: 0x0600C948 RID: 51528 RVA: 0x00312924 File Offset: 0x00310B24
			// (set) Token: 0x0600C949 RID: 51529 RVA: 0x000619E2 File Offset: 0x0005FBE2
			public unsafe MixingStation station
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008896 RID: 34966
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008897 RID: 34967
			private static readonly System.IntPtr NativeFieldInfoPtr_station;
		}
	}
}
