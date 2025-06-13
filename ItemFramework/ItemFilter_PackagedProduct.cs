using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005FF RID: 1535
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		// Token: 0x06008580 RID: 34176 RVA: 0x00239E3C File Offset: 0x0023803C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_PackagedProduct()
		{
			Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_PackagedProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr);
			ItemFilter_PackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr, 100680091);
			ItemFilter_PackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr, 100680092);
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00239E94 File Offset: 0x00238094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250925, RefRangeEnd = 250927, XrefRangeStart = 250912, XrefRangeEnd = 250925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_PackagedProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_PackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00239ED0 File Offset: 0x002380D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250927, XrefRangeEnd = 250937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_PackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x0003F28B File Offset: 0x0003D48B
		public ItemFilter_PackagedProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005AE3 RID: 23267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AE4 RID: 23268
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
