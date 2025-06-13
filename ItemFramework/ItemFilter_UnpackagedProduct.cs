using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000600 RID: 1536
	public class ItemFilter_UnpackagedProduct : ItemFilter_Category
	{
		// Token: 0x06008584 RID: 34180 RVA: 0x00239F28 File Offset: 0x00238128
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_UnpackagedProduct()
		{
			Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_UnpackagedProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr);
			ItemFilter_UnpackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr, 100680093);
			ItemFilter_UnpackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr, 100680094);
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00239F80 File Offset: 0x00238180
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250950, RefRangeEnd = 250954, XrefRangeStart = 250937, XrefRangeEnd = 250950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_UnpackagedProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_UnpackagedProduct>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_UnpackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00239FBC File Offset: 0x002381BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250954, XrefRangeEnd = 250964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_UnpackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008587 RID: 34183 RVA: 0x0003F294 File Offset: 0x0003D494
		public ItemFilter_UnpackagedProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005AE5 RID: 23269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AE6 RID: 23270
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
