using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000223 RID: 547
	public class PourWaterTask : PourOntoTargetTask
	{
		// Token: 0x06002D0E RID: 11534 RVA: 0x001021A8 File Offset: 0x001003A8
		// Note: this type is marked as 'beforefieldinit'.
		static PourWaterTask()
		{
			Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourWaterTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr);
			PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, "NORMALIZED_FILL_PER_TARGET");
			PourWaterTask.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, "hintShown");
			PourWaterTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668405);
			PourWaterTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668406);
			PourWaterTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668407);
			PourWaterTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668408);
			PourWaterTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668409);
			PourWaterTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668410);
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x00102278 File Offset: 0x00100478
		public unsafe override bool UseCoverage
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x001022C0 File Offset: 0x001004C0
		public unsafe override bool FailOnEmpty
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x00102308 File Offset: 0x00100508
		public unsafe override Pot.ECameraPosition CameraPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 124691, RefRangeEnd = 124696, XrefRangeStart = 124691, XrefRangeEnd = 124696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00102350 File Offset: 0x00100550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127267, RefRangeEnd = 127268, XrefRangeStart = 127237, XrefRangeEnd = 127267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourWaterTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourWaterTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x001023C0 File Offset: 0x001005C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127268, XrefRangeEnd = 127272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x001023FC File Offset: 0x001005FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127272, XrefRangeEnd = 127295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000183C6 File Offset: 0x000165C6
		public PourWaterTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x00102438 File Offset: 0x00100638
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x000183CF File Offset: 0x000165CF
		public unsafe static float NORMALIZED_FILL_PER_TARGET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET, (void*)(&value));
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x00102454 File Offset: 0x00100654
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x000183DD File Offset: 0x000165DD
		public unsafe static bool hintShown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(PourWaterTask.NativeFieldInfoPtr_hintShown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourWaterTask.NativeFieldInfoPtr_hintShown, (void*)(&value));
			}
		}

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0;
	}
}
