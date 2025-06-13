using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000789 RID: 1929
	[Serializable]
	public class WateringCanInstance : StorableItemInstance
	{
		// Token: 0x0600B74C RID: 46924 RVA: 0x002DE074 File Offset: 0x002DC274
		// Note: this type is marked as 'beforefieldinit'.
		static WateringCanInstance()
		{
			Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WateringCanInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr);
			WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, "CurrentFillAmount");
			WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100686055);
			WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100686056);
			WateringCanInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100686057);
			WateringCanInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100686058);
			WateringCanInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr, 100686059);
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x002DE11C File Offset: 0x002DC31C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211216, RefRangeEnd = 211218, XrefRangeStart = 211216, XrefRangeEnd = 211218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x002DE158 File Offset: 0x002DC358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314808, RefRangeEnd = 314809, XrefRangeStart = 314807, XrefRangeEnd = 314808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WateringCanInstance(ItemDefinition definition, int quantity, float fillAmount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WateringCanInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillAmount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x002DE1C0 File Offset: 0x002DC3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314809, XrefRangeEnd = 314814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x002DE218 File Offset: 0x002DC418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314815, RefRangeEnd = 314817, XrefRangeStart = 314814, XrefRangeEnd = 314815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFillAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WateringCanInstance.NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B751 RID: 46929 RVA: 0x002DE258 File Offset: 0x002DC458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314817, XrefRangeEnd = 314821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WateringCanInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x0005970E File Offset: 0x0005790E
		public WateringCanInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600B753 RID: 46931 RVA: 0x002DE2A4 File Offset: 0x002DC4A4
		// (set) Token: 0x0600B754 RID: 46932 RVA: 0x00059717 File Offset: 0x00057917
		public unsafe float CurrentFillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WateringCanInstance.NativeFieldInfoPtr_CurrentFillAmount)) = value;
			}
		}

		// Token: 0x04007BCC RID: 31692
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillAmount;

		// Token: 0x04007BCD RID: 31693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007BCE RID: 31694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_Single_0;

		// Token: 0x04007BCF RID: 31695
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04007BD0 RID: 31696
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFillAmount_Public_Void_Single_0;

		// Token: 0x04007BD1 RID: 31697
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
