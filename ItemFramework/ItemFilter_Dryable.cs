using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005FB RID: 1531
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x06008569 RID: 34153 RVA: 0x0023995C File Offset: 0x00237B5C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Dryable()
		{
			Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Dryable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr);
			ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100680082);
			ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100680083);
			ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100680084);
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x002399C8 File Offset: 0x00237BC8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Dryable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x00239A04 File Offset: 0x00237C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250852, XrefRangeEnd = 250868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x00239A5C File Offset: 0x00237C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250884, RefRangeEnd = 250885, XrefRangeStart = 250868, XrefRangeEnd = 250884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsItemDryable(ItemInstance instance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x0003F212 File Offset: 0x0003D412
		public ItemFilter_Dryable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005AD7 RID: 23255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AD8 RID: 23256
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x04005AD9 RID: 23257
		private static readonly IntPtr NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0;
	}
}
