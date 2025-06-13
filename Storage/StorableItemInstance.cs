using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000596 RID: 1430
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		// Token: 0x06007CC8 RID: 31944 RVA: 0x0021B4B8 File Offset: 0x002196B8
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemInstance()
		{
			Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorableItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr);
			StorableItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100679020);
			StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100679021);
			StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100679022);
			StorableItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100679023);
			StorableItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100679024);
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x0021B54C File Offset: 0x0021974C
		public unsafe virtual StoredItem StoredItem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 238586, RefRangeEnd = 238588, XrefRangeStart = 238574, XrefRangeEnd = 238586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x0021B598 File Offset: 0x00219798
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 238589, RefRangeEnd = 238598, XrefRangeStart = 238588, XrefRangeEnd = 238589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x0021B5D4 File Offset: 0x002197D4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 238611, RefRangeEnd = 238629, XrefRangeStart = 238598, XrefRangeEnd = 238611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x0021B630 File Offset: 0x00219830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238629, XrefRangeEnd = 238646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x0021B688 File Offset: 0x00219888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238646, XrefRangeEnd = 238649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x0003B112 File Offset: 0x00039312
		public StorableItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040054F1 RID: 21745
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0;

		// Token: 0x040054F2 RID: 21746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040054F3 RID: 21747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x040054F4 RID: 21748
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040054F5 RID: 21749
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;
	}
}
