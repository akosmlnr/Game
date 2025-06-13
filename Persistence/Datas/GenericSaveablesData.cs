using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027A RID: 634
	[Serializable]
	public class GenericSaveablesData : SaveData
	{
		// Token: 0x0600303F RID: 12351 RVA: 0x0010DEAC File Offset: 0x0010C0AC
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveablesData()
		{
			Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveablesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr);
			GenericSaveablesData.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr, "Saveables");
			GenericSaveablesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr, 100668978);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0010DF04 File Offset: 0x0010C104
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveablesData(Il2CppReferenceArray<GenericSaveData> saveables) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveables);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x00019408 File Offset: 0x00017608
		public GenericSaveablesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x0010DF50 File Offset: 0x0010C150
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x00019411 File Offset: 0x00017611
		public unsafe Il2CppReferenceArray<GenericSaveData> Saveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesData.NativeFieldInfoPtr_Saveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GenericSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveablesData.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GenericSaveData_0;
	}
}
