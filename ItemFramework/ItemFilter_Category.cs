using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F9 RID: 1529
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x0600855B RID: 34139 RVA: 0x00239644 File Offset: 0x00237844
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Category()
		{
			Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Category");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr);
			ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, "AcceptedCategories");
			ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100680076);
			ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100680077);
		}

		// Token: 0x0600855C RID: 34140 RVA: 0x002396B0 File Offset: 0x002378B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250834, RefRangeEnd = 250840, XrefRangeStart = 250825, XrefRangeEnd = 250834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Category(List<EItemCategory> acceptedCategories) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptedCategories);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600855D RID: 34141 RVA: 0x002396FC File Offset: 0x002378FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250840, XrefRangeEnd = 250843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600855E RID: 34142 RVA: 0x0003F1C6 File Offset: 0x0003D3C6
		public ItemFilter_Category(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x0600855F RID: 34143 RVA: 0x00239754 File Offset: 0x00237954
		// (set) Token: 0x06008560 RID: 34144 RVA: 0x0003F1CF File Offset: 0x0003D3CF
		public unsafe List<EItemCategory> AcceptedCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EItemCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ACF RID: 23247
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedCategories;

		// Token: 0x04005AD0 RID: 23248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0;

		// Token: 0x04005AD1 RID: 23249
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
