using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000603 RID: 1539
	public class IntegerItemInstance : StorableItemInstance
	{
		// Token: 0x06008599 RID: 34201 RVA: 0x0023A56C File Offset: 0x0023876C
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemInstance()
		{
			Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr);
			IntegerItemInstance.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, "Value");
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100680109);
			IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100680110);
			IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100680111);
			IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100680112);
			IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100680113);
			IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr, 100680114);
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x0023A628 File Offset: 0x00238828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211216, RefRangeEnd = 211218, XrefRangeStart = 211216, XrefRangeEnd = 211218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x0023A664 File Offset: 0x00238864
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211219, RefRangeEnd = 211224, XrefRangeStart = 211219, XrefRangeEnd = 211224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemInstance(ItemDefinition definition, int quantity, int value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x0023A6CC File Offset: 0x002388CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251057, XrefRangeEnd = 251062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x0023A724 File Offset: 0x00238924
		[CallerCount(0)]
		public unsafe void ChangeValue(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x0023A764 File Offset: 0x00238964
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 251062, RefRangeEnd = 251067, XrefRangeStart = 251062, XrefRangeEnd = 251062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemInstance.NativeMethodInfoPtr_SetValue_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x0023A7A4 File Offset: 0x002389A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251067, XrefRangeEnd = 251071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x0003F2CA File Offset: 0x0003D4CA
		public IntegerItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x060085A1 RID: 34209 RVA: 0x0023A7F0 File Offset: 0x002389F0
		// (set) Token: 0x060085A2 RID: 34210 RVA: 0x0003F2D3 File Offset: 0x0003D4D3
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemInstance.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04005AF3 RID: 23283
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04005AF4 RID: 23284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AF5 RID: 23285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Int32_0;

		// Token: 0x04005AF6 RID: 23286
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005AF7 RID: 23287
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Int32_0;

		// Token: 0x04005AF8 RID: 23288
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Int32_0;

		// Token: 0x04005AF9 RID: 23289
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
