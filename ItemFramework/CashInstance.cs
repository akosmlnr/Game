using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F0 RID: 1520
	[Serializable]
	public class CashInstance : StorableItemInstance
	{
		// Token: 0x06008515 RID: 34069 RVA: 0x0023887C File Offset: 0x00236A7C
		// Note: this type is marked as 'beforefieldinit'.
		static CashInstance()
		{
			Il2CppClassPointerStore<CashInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "CashInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashInstance>.NativeClassPtr);
			CashInstance.NativeFieldInfoPtr_MAX_BALANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, "MAX_BALANCE");
			CashInstance.NativeFieldInfoPtr__Balance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, "<Balance>k__BackingField");
			CashInstance.NativeMethodInfoPtr_get_Balance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680050);
			CashInstance.NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680051);
			CashInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680052);
			CashInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680053);
			CashInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680054);
			CashInstance.NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680055);
			CashInstance.NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680056);
			CashInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680057);
			CashInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashInstance>.NativeClassPtr, 100680058);
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x06008516 RID: 34070 RVA: 0x00238988 File Offset: 0x00236B88
		// (set) Token: 0x06008517 RID: 34071 RVA: 0x002389C4 File Offset: 0x00236BC4
		public unsafe float Balance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_get_Balance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 51528, RefRangeEnd = 51531, XrefRangeStart = 51528, XrefRangeEnd = 51531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008518 RID: 34072 RVA: 0x00238A04 File Offset: 0x00236C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211216, RefRangeEnd = 211218, XrefRangeStart = 211216, XrefRangeEnd = 211218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashInstance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008519 RID: 34073 RVA: 0x00238A40 File Offset: 0x00236C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250741, RefRangeEnd = 250743, XrefRangeStart = 250740, XrefRangeEnd = 250741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600851A RID: 34074 RVA: 0x00238A9C File Offset: 0x00236C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250743, XrefRangeEnd = 250748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600851B RID: 34075 RVA: 0x00238AF4 File Offset: 0x00236CF4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 250749, RefRangeEnd = 250758, XrefRangeStart = 250748, XrefRangeEnd = 250749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeBalance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600851C RID: 34076 RVA: 0x00238B34 File Offset: 0x00236D34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 250759, RefRangeEnd = 250766, XrefRangeStart = 250758, XrefRangeEnd = 250759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float newBalance, bool blockClear = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockClear;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashInstance.NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600851D RID: 34077 RVA: 0x00238B80 File Offset: 0x00236D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250766, XrefRangeEnd = 250770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x0600851E RID: 34078 RVA: 0x00238BCC File Offset: 0x00236DCC
		[CallerCount(0)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600851F RID: 34079 RVA: 0x0003EFFD File Offset: 0x0003D1FD
		public CashInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x00238C14 File Offset: 0x00236E14
		// (set) Token: 0x06008521 RID: 34081 RVA: 0x0003F006 File Offset: 0x0003D206
		public unsafe static float MAX_BALANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashInstance.NativeFieldInfoPtr_MAX_BALANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashInstance.NativeFieldInfoPtr_MAX_BALANCE, (void*)(&value));
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x06008522 RID: 34082 RVA: 0x00238C30 File Offset: 0x00236E30
		// (set) Token: 0x06008523 RID: 34083 RVA: 0x0003F014 File Offset: 0x0003D214
		public unsafe float _Balance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashInstance.NativeFieldInfoPtr__Balance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashInstance.NativeFieldInfoPtr__Balance_k__BackingField)) = value;
			}
		}

		// Token: 0x04005A99 RID: 23193
		private static readonly IntPtr NativeFieldInfoPtr_MAX_BALANCE;

		// Token: 0x04005A9A RID: 23194
		private static readonly IntPtr NativeFieldInfoPtr__Balance_k__BackingField;

		// Token: 0x04005A9B RID: 23195
		private static readonly IntPtr NativeMethodInfoPtr_get_Balance_Public_get_Single_0;

		// Token: 0x04005A9C RID: 23196
		private static readonly IntPtr NativeMethodInfoPtr_set_Balance_Protected_set_Void_Single_0;

		// Token: 0x04005A9D RID: 23197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005A9E RID: 23198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04005A9F RID: 23199
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005AA0 RID: 23200
		private static readonly IntPtr NativeMethodInfoPtr_ChangeBalance_Public_Void_Single_0;

		// Token: 0x04005AA1 RID: 23201
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_Boolean_0;

		// Token: 0x04005AA2 RID: 23202
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005AA3 RID: 23203
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;
	}
}
