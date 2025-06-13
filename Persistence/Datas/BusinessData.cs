using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public class BusinessData : PropertyData
	{
		// Token: 0x06002FDB RID: 12251 RVA: 0x0010CBFC File Offset: 0x0010ADFC
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessData()
		{
			Il2CppClassPointerStore<BusinessData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BusinessData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessData>.NativeClassPtr);
			BusinessData.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, "LaunderingOperations");
			BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_LaunderOperationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessData>.NativeClassPtr, 100668957);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0010CC54 File Offset: 0x0010AE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136219, RefRangeEnd = 136220, XrefRangeStart = 136212, XrefRangeEnd = 136219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates, Il2CppReferenceArray<DynamicSaveData> employees, Il2CppReferenceArray<DynamicSaveData> objects, Il2CppReferenceArray<LaunderOperationData> launderingOperations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employees);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(launderingOperations);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_LaunderOperationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00019034 File Offset: 0x00017234
		public BusinessData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x0010CD0C File Offset: 0x0010AF0C
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x0001903D File Offset: 0x0001723D
		public unsafe Il2CppReferenceArray<LaunderOperationData> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LaunderOperationData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessData.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_LaunderOperationData_0;
	}
}
