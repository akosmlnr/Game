using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000291 RID: 657
	[Serializable]
	public class CleanerConfigurationData : SaveData
	{
		// Token: 0x060030D1 RID: 12497 RVA: 0x0010F8C8 File Offset: 0x0010DAC8
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigurationData()
		{
			Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CleanerConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr);
			CleanerConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, "Bed");
			CleanerConfigurationData.NativeFieldInfoPtr_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, "Bins");
			CleanerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, 100669022);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0010F934 File Offset: 0x0010DB34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigurationData(ObjectFieldData bed, ObjectListFieldData bins) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bins);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000199A9 File Offset: 0x00017BA9
		public CleanerConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x0010F994 File Offset: 0x0010DB94
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x000199B2 File Offset: 0x00017BB2
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x0010F9C4 File Offset: 0x0010DBC4
		// (set) Token: 0x060030D7 RID: 12503 RVA: 0x000199D1 File Offset: 0x00017BD1
		public unsafe ObjectListFieldData Bins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_Bins;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0;
	}
}
