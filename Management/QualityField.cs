using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B8 RID: 952
	public class QualityField : ConfigField
	{
		// Token: 0x060049A7 RID: 18855 RVA: 0x00169844 File Offset: 0x00167A44
		// Note: this type is marked as 'beforefieldinit'.
		static QualityField()
		{
			Il2CppClassPointerStore<QualityField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "QualityField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityField>.NativeClassPtr);
			QualityField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "<Value>k__BackingField");
			QualityField.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "onValueChanged");
			QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672477);
			QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672478);
			QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672479);
			QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672480);
			QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672481);
			QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672482);
			QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672483);
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x060049A8 RID: 18856 RVA: 0x00169928 File Offset: 0x00167B28
		// (set) Token: 0x060049A9 RID: 18857 RVA: 0x00169964 File Offset: 0x00167B64
		public unsafe EQuality Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21910, RefRangeEnd = 21913, XrefRangeStart = 21910, XrefRangeEnd = 21913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31462, RefRangeEnd = 31464, XrefRangeStart = 31462, XrefRangeEnd = 31464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x001699A4 File Offset: 0x00167BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166429, RefRangeEnd = 166430, XrefRangeStart = 166421, XrefRangeEnd = 166429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x001699F0 File Offset: 0x00167BF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166434, RefRangeEnd = 166439, XrefRangeStart = 166430, XrefRangeEnd = 166434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(EQuality value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x00169A3C File Offset: 0x00167C3C
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x00169A84 File Offset: 0x00167C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166443, RefRangeEnd = 166444, XrefRangeStart = 166439, XrefRangeEnd = 166443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr2) : null;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x00169AC4 File Offset: 0x00167CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166448, RefRangeEnd = 166450, XrefRangeStart = 166444, XrefRangeEnd = 166448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(QualityFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x00023701 File Offset: 0x00021901
		public QualityField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x00169B08 File Offset: 0x00167D08
		// (set) Token: 0x060049B1 RID: 18865 RVA: 0x0002370A File Offset: 0x0002190A
		public unsafe EQuality _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060049B2 RID: 18866 RVA: 0x00169B30 File Offset: 0x00167D30
		// (set) Token: 0x060049B3 RID: 18867 RVA: 0x00023725 File Offset: 0x00021925
		public unsafe UnityEvent<EQuality> onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_EQuality_0;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_QualityFieldData_0;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0;
	}
}
