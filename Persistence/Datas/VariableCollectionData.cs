using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002DB RID: 731
	[Serializable]
	public class VariableCollectionData : SaveData
	{
		// Token: 0x0600335B RID: 13147 RVA: 0x00116C30 File Offset: 0x00114E30
		// Note: this type is marked as 'beforefieldinit'.
		static VariableCollectionData()
		{
			Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VariableCollectionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr);
			VariableCollectionData.NativeFieldInfoPtr_Variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr, "Variables");
			VariableCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr, 100669104);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00116C88 File Offset: 0x00114E88
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableCollectionData(Il2CppReferenceArray<VariableData> variables) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x0001B4A4 File Offset: 0x000196A4
		public VariableCollectionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x00116CD4 File Offset: 0x00114ED4
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x0001B4AD File Offset: 0x000196AD
		public unsafe Il2CppReferenceArray<VariableData> Variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCollectionData.NativeFieldInfoPtr_Variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCollectionData.NativeFieldInfoPtr_Variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeFieldInfoPtr_Variables;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VariableData_0;
	}
}
