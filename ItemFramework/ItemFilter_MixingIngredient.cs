using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005FE RID: 1534
	public class ItemFilter_MixingIngredient : ItemFilter
	{
		// Token: 0x0600857C RID: 34172 RVA: 0x00239D50 File Offset: 0x00237F50
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_MixingIngredient()
		{
			Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_MixingIngredient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100680089);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100680090);
		}

		// Token: 0x0600857D RID: 34173 RVA: 0x00239DA8 File Offset: 0x00237FA8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_MixingIngredient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600857E RID: 34174 RVA: 0x00239DE4 File Offset: 0x00237FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250903, XrefRangeEnd = 250912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600857F RID: 34175 RVA: 0x0003F282 File Offset: 0x0003D482
		public ItemFilter_MixingIngredient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005AE1 RID: 23265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AE2 RID: 23266
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
