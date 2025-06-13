using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005DB RID: 1499
	public class Equippable_Seed : Equippable_Viewmodel
	{
		// Token: 0x060082A9 RID: 33449 RVA: 0x00230CC4 File Offset: 0x0022EEC4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Seed()
		{
			Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Seed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr);
			Equippable_Seed.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, "Seed");
			Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679791);
			Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679792);
			Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679793);
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x00230D44 File Offset: 0x0022EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248183, XrefRangeEnd = 248229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x00230D80 File Offset: 0x0022EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248229, XrefRangeEnd = 248233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartSowSeedTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x00230DD0 File Offset: 0x0022EFD0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 248176, RefRangeEnd = 248183, XrefRangeStart = 248176, XrefRangeEnd = 248183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Seed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x0003DBCD File Offset: 0x0003BDCD
		public Equippable_Seed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002744 RID: 10052
		// (get) Token: 0x060082AE RID: 33454 RVA: 0x00230E0C File Offset: 0x0022F00C
		// (set) Token: 0x060082AF RID: 33455 RVA: 0x0003DBD6 File Offset: 0x0003BDD6
		public unsafe SeedDefinition Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005905 RID: 22789
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04005906 RID: 22790
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005907 RID: 22791
		private static readonly IntPtr NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x04005908 RID: 22792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
