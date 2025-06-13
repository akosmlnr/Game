using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B5 RID: 949
	public class NumberField : ConfigField
	{
		// Token: 0x06004967 RID: 18791 RVA: 0x00168A38 File Offset: 0x00166C38
		// Note: this type is marked as 'beforefieldinit'.
		static NumberField()
		{
			Il2CppClassPointerStore<NumberField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NumberField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberField>.NativeClassPtr);
			NumberField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<Value>k__BackingField");
			NumberField.NativeFieldInfoPtr__MinValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MinValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MaxValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<WholeNumbers>k__BackingField");
			NumberField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "onItemChanged");
			NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672449);
			NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672450);
			NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672451);
			NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672452);
			NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672453);
			NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672454);
			NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672455);
			NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672456);
			NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672457);
			NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672458);
			NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672459);
			NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672460);
			NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672461);
			NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672462);
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06004968 RID: 18792 RVA: 0x00168BE4 File Offset: 0x00166DE4
		// (set) Token: 0x06004969 RID: 18793 RVA: 0x00168C20 File Offset: 0x00166E20
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 93540, RefRangeEnd = 93544, XrefRangeStart = 93540, XrefRangeEnd = 93544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x00168C60 File Offset: 0x00166E60
		// (set) Token: 0x0600496B RID: 18795 RVA: 0x00168C9C File Offset: 0x00166E9C
		public unsafe float MinValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 31464, RefRangeEnd = 31475, XrefRangeStart = 31464, XrefRangeEnd = 31475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x0600496C RID: 18796 RVA: 0x00168CDC File Offset: 0x00166EDC
		// (set) Token: 0x0600496D RID: 18797 RVA: 0x00168D18 File Offset: 0x00166F18
		public unsafe float MaxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x00168D58 File Offset: 0x00166F58
		// (set) Token: 0x0600496F RID: 18799 RVA: 0x00168D94 File Offset: 0x00166F94
		public unsafe bool WholeNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00168DD4 File Offset: 0x00166FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166057, RefRangeEnd = 166058, XrefRangeStart = 166049, XrefRangeEnd = 166057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00168E20 File Offset: 0x00167020
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166062, RefRangeEnd = 166066, XrefRangeStart = 166058, XrefRangeEnd = 166062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00168E6C File Offset: 0x0016706C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166066, RefRangeEnd = 166067, XrefRangeStart = 166066, XrefRangeEnd = 166066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeNumbers;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00168EC8 File Offset: 0x001670C8
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00168F10 File Offset: 0x00167110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166071, RefRangeEnd = 166072, XrefRangeStart = 166067, XrefRangeEnd = 166071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr2) : null;
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00168F50 File Offset: 0x00167150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166076, RefRangeEnd = 166078, XrefRangeStart = 166072, XrefRangeEnd = 166076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NumberFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x0002352D File Offset: 0x0002172D
		public NumberField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x00168F94 File Offset: 0x00167194
		// (set) Token: 0x06004978 RID: 18808 RVA: 0x00023536 File Offset: 0x00021736
		public unsafe float _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06004979 RID: 18809 RVA: 0x00168FBC File Offset: 0x001671BC
		// (set) Token: 0x0600497A RID: 18810 RVA: 0x00023551 File Offset: 0x00021751
		public unsafe float _MinValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x00168FE4 File Offset: 0x001671E4
		// (set) Token: 0x0600497C RID: 18812 RVA: 0x0002356C File Offset: 0x0002176C
		public unsafe float _MaxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x0600497D RID: 18813 RVA: 0x0016900C File Offset: 0x0016720C
		// (set) Token: 0x0600497E RID: 18814 RVA: 0x00023587 File Offset: 0x00021787
		public unsafe bool _WholeNumbers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField)) = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x00169034 File Offset: 0x00167234
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x000235A2 File Offset: 0x000217A2
		public unsafe UnityEvent<float> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeFieldInfoPtr__MinValue_k__BackingField;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeFieldInfoPtr__MaxValue_k__BackingField;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeFieldInfoPtr__WholeNumbers_k__BackingField;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_get_Single_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NumberFieldData_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0;
	}
}
