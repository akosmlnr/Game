using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.Product.Packaging
{
	// Token: 0x020005D8 RID: 1496
	[Serializable]
	public class PackagingDefinition : StorableItemDefinition
	{
		// Token: 0x06008273 RID: 33395 RVA: 0x00230444 File Offset: 0x0022E644
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingDefinition()
		{
			Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product.Packaging", "PackagingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr);
			PackagingDefinition.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Quantity");
			PackagingDefinition.NativeFieldInfoPtr_StealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StealthLevel");
			PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "FunctionalPackaging");
			PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Equippable_Filled");
			PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StoredItem_Filled");
			PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, 100679775);
		}

		// Token: 0x06008274 RID: 33396 RVA: 0x002304EC File Offset: 0x0022E6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248041, XrefRangeEnd = 248042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008275 RID: 33397 RVA: 0x0003D989 File Offset: 0x0003BB89
		public PackagingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06008276 RID: 33398 RVA: 0x00230528 File Offset: 0x0022E728
		// (set) Token: 0x06008277 RID: 33399 RVA: 0x0003D992 File Offset: 0x0003BB92
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06008278 RID: 33400 RVA: 0x00230550 File Offset: 0x0022E750
		// (set) Token: 0x06008279 RID: 33401 RVA: 0x0003D9AD File Offset: 0x0003BBAD
		public unsafe EStealthLevel StealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel)) = value;
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x00230578 File Offset: 0x0022E778
		// (set) Token: 0x0600827B RID: 33403 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
		public unsafe FunctionalPackaging FunctionalPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600827C RID: 33404 RVA: 0x002305A8 File Offset: 0x0022E7A8
		// (set) Token: 0x0600827D RID: 33405 RVA: 0x0003D9E7 File Offset: 0x0003BBE7
		public unsafe Equippable Equippable_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600827E RID: 33406 RVA: 0x002305D8 File Offset: 0x0022E7D8
		// (set) Token: 0x0600827F RID: 33407 RVA: 0x0003DA06 File Offset: 0x0003BC06
		public unsafe StoredItem StoredItem_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040058E8 RID: 22760
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040058E9 RID: 22761
		private static readonly IntPtr NativeFieldInfoPtr_StealthLevel;

		// Token: 0x040058EA RID: 22762
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalPackaging;

		// Token: 0x040058EB RID: 22763
		private static readonly IntPtr NativeFieldInfoPtr_Equippable_Filled;

		// Token: 0x040058EC RID: 22764
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem_Filled;

		// Token: 0x040058ED RID: 22765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
