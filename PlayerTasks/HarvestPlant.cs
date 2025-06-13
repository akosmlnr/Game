using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000218 RID: 536
	public class HarvestPlant : Task
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x000FEA28 File Offset: 0x000FCC28
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestPlant()
		{
			Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "HarvestPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr);
			HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "<TaskName>k__BackingField");
			HarvestPlant.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "pot");
			HarvestPlant.NativeFieldInfoPtr_HarvestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "HarvestCount");
			HarvestPlant.NativeFieldInfoPtr_HarvestTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "HarvestTotal");
			HarvestPlant.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "rotation");
			HarvestPlant.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "hintShown");
			HarvestPlant.NativeFieldInfoPtr_CanDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "CanDrag");
			HarvestPlant.NativeFieldInfoPtr_SoundLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "SoundLoop");
			HarvestPlant.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668277);
			HarvestPlant.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668278);
			HarvestPlant.NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668279);
			HarvestPlant.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668280);
			HarvestPlant.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668281);
			HarvestPlant.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668282);
			HarvestPlant.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668283);
			HarvestPlant.NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668284);
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000FEB98 File Offset: 0x000FCD98
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x000FEBDC File Offset: 0x000FCDDC
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000FEC2C File Offset: 0x000FCE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125243, XrefRangeEnd = 125337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canDrag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(soundLoopPrefab);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000FEC98 File Offset: 0x000FCE98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125372, RefRangeEnd = 125374, XrefRangeStart = 125337, XrefRangeEnd = 125372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000FECCC File Offset: 0x000FCECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125374, XrefRangeEnd = 125425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000FED08 File Offset: 0x000FCF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125425, XrefRangeEnd = 125439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000FED44 File Offset: 0x000FCF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125439, XrefRangeEnd = 125518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000FED80 File Offset: 0x000FCF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125528, RefRangeEnd = 125530, XrefRangeStart = 125518, XrefRangeEnd = 125528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable GetHoveredHarvestable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00017B7B File Offset: 0x00015D7B
		public HarvestPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000FEDC0 File Offset: 0x000FCFC0
		// (set) Token: 0x06002C07 RID: 11271 RVA: 0x00017B84 File Offset: 0x00015D84
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x000FEDE8 File Offset: 0x000FCFE8
		// (set) Token: 0x06002C09 RID: 11273 RVA: 0x00017BA3 File Offset: 0x00015DA3
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002C0A RID: 11274 RVA: 0x000FEE18 File Offset: 0x000FD018
		// (set) Token: 0x06002C0B RID: 11275 RVA: 0x00017BC2 File Offset: 0x00015DC2
		public unsafe int HarvestCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestCount)) = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002C0C RID: 11276 RVA: 0x000FEE40 File Offset: 0x000FD040
		// (set) Token: 0x06002C0D RID: 11277 RVA: 0x00017BDD File Offset: 0x00015DDD
		public unsafe int HarvestTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestTotal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestTotal)) = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000FEE68 File Offset: 0x000FD068
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x000FEE90 File Offset: 0x000FD090
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x00017C13 File Offset: 0x00015E13
		public unsafe static bool hintShown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(HarvestPlant.NativeFieldInfoPtr_hintShown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HarvestPlant.NativeFieldInfoPtr_hintShown, (void*)(&value));
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x000FEEAC File Offset: 0x000FD0AC
		// (set) Token: 0x06002C13 RID: 11283 RVA: 0x00017C21 File Offset: 0x00015E21
		public unsafe static bool CanDrag
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(HarvestPlant.NativeFieldInfoPtr_CanDrag, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HarvestPlant.NativeFieldInfoPtr_CanDrag, (void*)(&value));
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x000FEEC8 File Offset: 0x000FD0C8
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x00017C2F File Offset: 0x00015E2F
		public unsafe AudioSourceController SoundLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_SoundLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_SoundLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeFieldInfoPtr_HarvestCount;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTotal;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeFieldInfoPtr_CanDrag;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoop;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0;
	}
}
