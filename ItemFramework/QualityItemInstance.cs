using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000611 RID: 1553
	[Serializable]
	public class QualityItemInstance : StorableItemInstance
	{
		// Token: 0x060086C2 RID: 34498 RVA: 0x0023E988 File Offset: 0x0023CB88
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemInstance()
		{
			Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "QualityItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr);
			QualityItemInstance.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, "Quality");
			QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100680265);
			QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100680266);
			QualityItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100680267);
			QualityItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100680268);
			QualityItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100680269);
			QualityItemInstance.NativeMethodInfoPtr_SetQuality_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100680270);
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x0023EA44 File Offset: 0x0023CC44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 252854, RefRangeEnd = 252858, XrefRangeStart = 252853, XrefRangeEnd = 252854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x0023EA80 File Offset: 0x0023CC80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252861, RefRangeEnd = 252863, XrefRangeStart = 252858, XrefRangeEnd = 252861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x0023EAE8 File Offset: 0x0023CCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252866, RefRangeEnd = 252867, XrefRangeStart = 252863, XrefRangeEnd = 252866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x0023EB50 File Offset: 0x0023CD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252867, XrefRangeEnd = 252874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x0023EBA8 File Offset: 0x0023CDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252874, XrefRangeEnd = 252881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x0023EBF4 File Offset: 0x0023CDF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 251062, RefRangeEnd = 251067, XrefRangeStart = 251062, XrefRangeEnd = 251067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuality(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInstance.NativeMethodInfoPtr_SetQuality_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x0003F9DE File Offset: 0x0003DBDE
		public QualityItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x060086CA RID: 34506 RVA: 0x0023EC34 File Offset: 0x0023CE34
		// (set) Token: 0x060086CB RID: 34507 RVA: 0x0003F9E7 File Offset: 0x0003DBE7
		public unsafe EQuality Quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInstance.NativeFieldInfoPtr_Quality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInstance.NativeFieldInfoPtr_Quality)) = value;
			}
		}

		// Token: 0x04005BD0 RID: 23504
		private static readonly IntPtr NativeFieldInfoPtr_Quality;

		// Token: 0x04005BD1 RID: 23505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BD2 RID: 23506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_0;

		// Token: 0x04005BD3 RID: 23507
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0;

		// Token: 0x04005BD4 RID: 23508
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005BD5 RID: 23509
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005BD6 RID: 23510
		private static readonly IntPtr NativeMethodInfoPtr_SetQuality_Public_Void_EQuality_0;
	}
}
