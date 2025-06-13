using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F8 RID: 1528
	public class ItemFilter : Il2CppSystem.Object
	{
		// Token: 0x06008557 RID: 34135 RVA: 0x00239558 File Offset: 0x00237758
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter()
		{
			Il2CppClassPointerStore<ItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr);
			ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100680074);
			ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100680075);
		}

		// Token: 0x06008558 RID: 34136 RVA: 0x002395B0 File Offset: 0x002377B0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008559 RID: 34137 RVA: 0x00239608 File Offset: 0x00237808
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600855A RID: 34138 RVA: 0x0003F1BD File Offset: 0x0003D3BD
		public ItemFilter(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005ACD RID: 23245
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005ACE RID: 23246
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
