using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000580 RID: 1408
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x06007AC6 RID: 31430 RVA: 0x00214794 File Offset: 0x00212994
		// Note: this type is marked as 'beforefieldinit'.
		static SeedDefinition()
		{
			Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr);
			SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "FunctionSeedPrefab");
			SeedDefinition.NativeFieldInfoPtr_PlantPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "PlantPrefab");
			SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, 100678787);
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x00214800 File Offset: 0x00212A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236388, XrefRangeEnd = 236389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x0003A064 File Offset: 0x00038264
		public SeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x06007AC9 RID: 31433 RVA: 0x0021483C File Offset: 0x00212A3C
		// (set) Token: 0x06007ACA RID: 31434 RVA: 0x0003A06D File Offset: 0x0003826D
		public unsafe FunctionalSeed FunctionSeedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0021486C File Offset: 0x00212A6C
		// (set) Token: 0x06007ACC RID: 31436 RVA: 0x0003A08C File Offset: 0x0003828C
		public unsafe Plant PlantPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053A4 RID: 21412
		private static readonly IntPtr NativeFieldInfoPtr_FunctionSeedPrefab;

		// Token: 0x040053A5 RID: 21413
		private static readonly IntPtr NativeFieldInfoPtr_PlantPrefab;

		// Token: 0x040053A6 RID: 21414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
