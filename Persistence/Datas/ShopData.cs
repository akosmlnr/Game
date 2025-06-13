using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D2 RID: 722
	[Serializable]
	public class ShopData : SaveData
	{
		// Token: 0x06003312 RID: 13074 RVA: 0x00116068 File Offset: 0x00114268
		// Note: this type is marked as 'beforefieldinit'.
		static ShopData()
		{
			Il2CppClassPointerStore<ShopData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShopData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopData>.NativeClassPtr);
			ShopData.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ShopCode");
			ShopData.NativeFieldInfoPtr_ItemStockQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ItemStockQuantities");
			ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopData>.NativeClassPtr, 100669093);
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x001160D4 File Offset: 0x001142D4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopData(string shopCode, Il2CppReferenceArray<StringIntPair> itemStockQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemStockQuantities);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0001B190 File Offset: 0x00019390
		public ShopData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x00116134 File Offset: 0x00114334
		// (set) Token: 0x06003316 RID: 13078 RVA: 0x0001B199 File Offset: 0x00019399
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x0011615C File Offset: 0x0011435C
		// (set) Token: 0x06003318 RID: 13080 RVA: 0x0001B1B8 File Offset: 0x000193B8
		public unsafe Il2CppReferenceArray<StringIntPair> ItemStockQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400212C RID: 8492
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x0400212D RID: 8493
		private static readonly IntPtr NativeFieldInfoPtr_ItemStockQuantities;

		// Token: 0x0400212E RID: 8494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0;
	}
}
