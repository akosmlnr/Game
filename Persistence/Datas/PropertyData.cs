using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002CA RID: 714
	[Serializable]
	public class PropertyData : SaveData
	{
		// Token: 0x060032B2 RID: 12978 RVA: 0x00114FE0 File Offset: 0x001131E0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyData()
		{
			Il2CppClassPointerStore<PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PropertyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyData>.NativeClassPtr);
			PropertyData.NativeFieldInfoPtr_PropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "PropertyCode");
			PropertyData.NativeFieldInfoPtr_IsOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "IsOwned");
			PropertyData.NativeFieldInfoPtr_SwitchStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "SwitchStates");
			PropertyData.NativeFieldInfoPtr_ToggleableStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "ToggleableStates");
			PropertyData.NativeFieldInfoPtr_Employees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "Employees");
			PropertyData.NativeFieldInfoPtr_Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, "Objects");
			PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyData>.NativeClassPtr, 100669081);
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0011509C File Offset: 0x0011329C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137059, RefRangeEnd = 137060, XrefRangeStart = 137053, XrefRangeEnd = 137059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates, Il2CppReferenceArray<DynamicSaveData> employees, Il2CppReferenceArray<DynamicSaveData> objects) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employees);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0001AD6C File Offset: 0x00018F6C
		public PropertyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060032B5 RID: 12981 RVA: 0x00115140 File Offset: 0x00113340
		// (set) Token: 0x060032B6 RID: 12982 RVA: 0x0001AD75 File Offset: 0x00018F75
		public unsafe string PropertyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_PropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060032B7 RID: 12983 RVA: 0x00115168 File Offset: 0x00113368
		// (set) Token: 0x060032B8 RID: 12984 RVA: 0x0001AD94 File Offset: 0x00018F94
		public unsafe bool IsOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_IsOwned)) = value;
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060032B9 RID: 12985 RVA: 0x00115190 File Offset: 0x00113390
		// (set) Token: 0x060032BA RID: 12986 RVA: 0x0001ADAF File Offset: 0x00018FAF
		public unsafe Il2CppStructArray<bool> SwitchStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_SwitchStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060032BB RID: 12987 RVA: 0x001151C0 File Offset: 0x001133C0
		// (set) Token: 0x060032BC RID: 12988 RVA: 0x0001ADCE File Offset: 0x00018FCE
		public unsafe Il2CppStructArray<bool> ToggleableStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_ToggleableStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060032BD RID: 12989 RVA: 0x001151F0 File Offset: 0x001133F0
		// (set) Token: 0x060032BE RID: 12990 RVA: 0x0001ADED File Offset: 0x00018FED
		public unsafe Il2CppReferenceArray<DynamicSaveData> Employees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Employees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Employees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x00115220 File Offset: 0x00113420
		// (set) Token: 0x060032C0 RID: 12992 RVA: 0x0001AE0C File Offset: 0x0001900C
		public unsafe Il2CppReferenceArray<DynamicSaveData> Objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyData.NativeFieldInfoPtr_Objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeFieldInfoPtr_PropertyCode;

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_IsOwned;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_SwitchStates;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeFieldInfoPtr_ToggleableStates;

		// Token: 0x04002102 RID: 8450
		private static readonly IntPtr NativeFieldInfoPtr_Employees;

		// Token: 0x04002103 RID: 8451
		private static readonly IntPtr NativeFieldInfoPtr_Objects;

		// Token: 0x04002104 RID: 8452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_0;
	}
}
