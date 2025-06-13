using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200021C RID: 540
	public class SowSeedTask : Task
	{
		// Token: 0x06002C53 RID: 11347 RVA: 0x000FFBBC File Offset: 0x000FDDBC
		// Note: this type is marked as 'beforefieldinit'.
		static SowSeedTask()
		{
			Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "SowSeedTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr);
			SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "<TaskName>k__BackingField");
			SowSeedTask.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "pot");
			SowSeedTask.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "definition");
			SowSeedTask.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seed");
			SowSeedTask.NativeFieldInfoPtr_seedExitedVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seedExitedVial");
			SowSeedTask.NativeFieldInfoPtr_seedReachedDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seedReachedDestination");
			SowSeedTask.NativeFieldInfoPtr_successfullyPlanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "successfullyPlanted");
			SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "weedSeedStationaryTime");
			SowSeedTask.NativeFieldInfoPtr_capRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "capRemoved");
			SowSeedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668312);
			SowSeedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668313);
			SowSeedTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668314);
			SowSeedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668315);
			SowSeedTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668316);
			SowSeedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668317);
			SowSeedTask.NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668318);
			SowSeedTask.NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668319);
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x000FFD40 File Offset: 0x000FDF40
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x000FFD84 File Offset: 0x000FDF84
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000FFDD4 File Offset: 0x000FDFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126044, RefRangeEnd = 126045, XrefRangeStart = 125929, XrefRangeEnd = 126044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SowSeedTask(Pot _pot, SeedDefinition def) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000FFE34 File Offset: 0x000FE034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126045, XrefRangeEnd = 126079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000FFE70 File Offset: 0x000FE070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126079, XrefRangeEnd = 126115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000FFEAC File Offset: 0x000FE0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126115, XrefRangeEnd = 126156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000FFEE8 File Offset: 0x000FE0E8
		[CallerCount(0)]
		public unsafe void OnSeedExitVial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000FFF1C File Offset: 0x000FE11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126172, RefRangeEnd = 126173, XrefRangeStart = 126156, XrefRangeEnd = 126172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSeedReachedDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x00017E13 File Offset: 0x00016013
		public SowSeedTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000FFF50 File Offset: 0x000FE150
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x00017E1C File Offset: 0x0001601C
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000FFF78 File Offset: 0x000FE178
		// (set) Token: 0x06002C60 RID: 11360 RVA: 0x00017E3B File Offset: 0x0001603B
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x000FFFA8 File Offset: 0x000FE1A8
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00017E5A File Offset: 0x0001605A
		public unsafe SeedDefinition definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000FFFD8 File Offset: 0x000FE1D8
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x00017E79 File Offset: 0x00016079
		public unsafe FunctionalSeed seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00100008 File Offset: 0x000FE208
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x00017E98 File Offset: 0x00016098
		public unsafe bool seedExitedVial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedExitedVial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedExitedVial)) = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x00100030 File Offset: 0x000FE230
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00017EB3 File Offset: 0x000160B3
		public unsafe bool seedReachedDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedReachedDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedReachedDestination)) = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00100058 File Offset: 0x000FE258
		// (set) Token: 0x06002C6A RID: 11370 RVA: 0x00017ECE File Offset: 0x000160CE
		public unsafe bool successfullyPlanted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_successfullyPlanted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_successfullyPlanted)) = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x00100080 File Offset: 0x000FE280
		// (set) Token: 0x06002C6C RID: 11372 RVA: 0x00017EE9 File Offset: 0x000160E9
		public unsafe float weedSeedStationaryTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime)) = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x001000A8 File Offset: 0x000FE2A8
		// (set) Token: 0x06002C6E RID: 11374 RVA: 0x00017F04 File Offset: 0x00016104
		public unsafe bool capRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_capRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_capRemoved)) = value;
			}
		}

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeFieldInfoPtr_definition;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_seedExitedVial;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeFieldInfoPtr_seedReachedDestination;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeFieldInfoPtr_successfullyPlanted;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeFieldInfoPtr_weedSeedStationaryTime;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeFieldInfoPtr_capRemoved;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0;
	}
}
