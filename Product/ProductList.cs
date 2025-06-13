using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005CB RID: 1483
	[System.Serializable]
	public class ProductList : Il2CppSystem.Object
	{
		// Token: 0x060080C0 RID: 32960 RVA: 0x00229124 File Offset: 0x00227324
		// Note: this type is marked as 'beforefieldinit'.
		static ProductList()
		{
			Il2CppClassPointerStore<ProductList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList>.NativeClassPtr);
			ProductList.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "entries");
			ProductList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679512);
			ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679513);
			ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679514);
			ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679515);
			ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679516);
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x002291CC File Offset: 0x002273CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 243498, RefRangeEnd = 243504, XrefRangeStart = 243490, XrefRangeEnd = 243498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x00229208 File Offset: 0x00227408
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 243533, RefRangeEnd = 243538, XrefRangeStart = 243504, XrefRangeEnd = 243533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCommaSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x00229240 File Offset: 0x00227440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243538, XrefRangeEnd = 243566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLineSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x00229278 File Offset: 0x00227478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243592, RefRangeEnd = 243595, XrefRangeStart = 243566, XrefRangeEnd = 243592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x002292B0 File Offset: 0x002274B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 243609, RefRangeEnd = 243613, XrefRangeStart = 243595, XrefRangeEnd = 243609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x0003CE62 File Offset: 0x0003B062
		public ProductList(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x060080C7 RID: 32967 RVA: 0x002292EC File Offset: 0x002274EC
		// (set) Token: 0x060080C8 RID: 32968 RVA: 0x0003CE6B File Offset: 0x0003B06B
		public unsafe List<ProductList.Entry> entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductList.Entry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057A9 RID: 22441
		private static readonly System.IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040057AA RID: 22442
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040057AB RID: 22443
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0;

		// Token: 0x040057AC RID: 22444
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0;

		// Token: 0x040057AD RID: 22445
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x040057AE RID: 22446
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0;

		// Token: 0x02000B1A RID: 2842
		[System.Serializable]
		public class Entry : Il2CppSystem.Object
		{
			// Token: 0x0600D98E RID: 55694 RVA: 0x00340CA4 File Offset: 0x0033EEA4
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr);
				ProductList.Entry.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "ProductID");
				ProductList.Entry.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quality");
				ProductList.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quantity");
				ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, 100679517);
			}

			// Token: 0x0600D98F RID: 55695 RVA: 0x00340D20 File Offset: 0x0033EF20
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D990 RID: 55696 RVA: 0x000698E0 File Offset: 0x00067AE0
			public Entry(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004321 RID: 17185
			// (get) Token: 0x0600D991 RID: 55697 RVA: 0x00340D5C File Offset: 0x0033EF5C
			// (set) Token: 0x0600D992 RID: 55698 RVA: 0x000698E9 File Offset: 0x00067AE9
			public unsafe string ProductID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004322 RID: 17186
			// (get) Token: 0x0600D993 RID: 55699 RVA: 0x00340D84 File Offset: 0x0033EF84
			// (set) Token: 0x0600D994 RID: 55700 RVA: 0x00069908 File Offset: 0x00067B08
			public unsafe EQuality Quality
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality)) = value;
				}
			}

			// Token: 0x17004323 RID: 17187
			// (get) Token: 0x0600D995 RID: 55701 RVA: 0x00340DAC File Offset: 0x0033EFAC
			// (set) Token: 0x0600D996 RID: 55702 RVA: 0x00069923 File Offset: 0x00067B23
			public unsafe int Quantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04009283 RID: 37507
			private static readonly System.IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04009284 RID: 37508
			private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

			// Token: 0x04009285 RID: 37509
			private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009286 RID: 37510
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
