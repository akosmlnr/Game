using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000613 RID: 1555
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x060086D8 RID: 34520 RVA: 0x0023EEA8 File Offset: 0x0023D0A8
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemDefinition()
		{
			Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "StorableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr);
			StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "BasePurchasePrice");
			StorableItemDefinition.NativeFieldInfoPtr_ShopCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ShopCategories");
			StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiresLevelToPurchase");
			StorableItemDefinition.NativeFieldInfoPtr_RequiredRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiredRank");
			StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ResellMultiplier");
			StorableItemDefinition.NativeFieldInfoPtr_StoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StoredItem");
			StorableItemDefinition.NativeFieldInfoPtr_StationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StationItem");
			StorableItemDefinition.NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100680275);
			StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100680276);
			StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100680277);
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x060086D9 RID: 34521 RVA: 0x0023EFA0 File Offset: 0x0023D1A0
		public unsafe bool IsPurchasable
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 252968, RefRangeEnd = 252990, XrefRangeStart = 252967, XrefRangeEnd = 252968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x0023EFDC File Offset: 0x0023D1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252990, XrefRangeEnd = 252994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x0023F034 File Offset: 0x0023D234
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 253002, RefRangeEnd = 253013, XrefRangeStart = 252994, XrefRangeEnd = 253002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x0003FA64 File Offset: 0x0003DC64
		public StorableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x0023F070 File Offset: 0x0023D270
		// (set) Token: 0x060086DE RID: 34526 RVA: 0x0003FA6D File Offset: 0x0003DC6D
		public unsafe float BasePurchasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice)) = value;
			}
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x0023F098 File Offset: 0x0023D298
		// (set) Token: 0x060086E0 RID: 34528 RVA: 0x0003FA88 File Offset: 0x0003DC88
		public unsafe List<ShopListing.CategoryInstance> ShopCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing.CategoryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x060086E1 RID: 34529 RVA: 0x0023F0C8 File Offset: 0x0023D2C8
		// (set) Token: 0x060086E2 RID: 34530 RVA: 0x0003FAA7 File Offset: 0x0003DCA7
		public unsafe bool RequiresLevelToPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase)) = value;
			}
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x0023F0F0 File Offset: 0x0023D2F0
		// (set) Token: 0x060086E4 RID: 34532 RVA: 0x0003FAC2 File Offset: 0x0003DCC2
		public unsafe FullRank RequiredRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank)) = value;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x060086E5 RID: 34533 RVA: 0x0023F118 File Offset: 0x0023D318
		// (set) Token: 0x060086E6 RID: 34534 RVA: 0x0003FADD File Offset: 0x0003DCDD
		public unsafe float ResellMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier)) = value;
			}
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x060086E7 RID: 34535 RVA: 0x0023F140 File Offset: 0x0023D340
		// (set) Token: 0x060086E8 RID: 34536 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		public unsafe StoredItem StoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x060086E9 RID: 34537 RVA: 0x0023F170 File Offset: 0x0023D370
		// (set) Token: 0x060086EA RID: 34538 RVA: 0x0003FB17 File Offset: 0x0003DD17
		public unsafe StationItem StationItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BDE RID: 23518
		private static readonly IntPtr NativeFieldInfoPtr_BasePurchasePrice;

		// Token: 0x04005BDF RID: 23519
		private static readonly IntPtr NativeFieldInfoPtr_ShopCategories;

		// Token: 0x04005BE0 RID: 23520
		private static readonly IntPtr NativeFieldInfoPtr_RequiresLevelToPurchase;

		// Token: 0x04005BE1 RID: 23521
		private static readonly IntPtr NativeFieldInfoPtr_RequiredRank;

		// Token: 0x04005BE2 RID: 23522
		private static readonly IntPtr NativeFieldInfoPtr_ResellMultiplier;

		// Token: 0x04005BE3 RID: 23523
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem;

		// Token: 0x04005BE4 RID: 23524
		private static readonly IntPtr NativeFieldInfoPtr_StationItem;

		// Token: 0x04005BE5 RID: 23525
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0;

		// Token: 0x04005BE6 RID: 23526
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005BE7 RID: 23527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
