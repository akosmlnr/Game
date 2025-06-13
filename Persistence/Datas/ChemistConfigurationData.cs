using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028F RID: 655
	[Serializable]
	public class ChemistConfigurationData : SaveData
	{
		// Token: 0x060030C3 RID: 12483 RVA: 0x0010F670 File Offset: 0x0010D870
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfigurationData()
		{
			Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr);
			ChemistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, "Bed");
			ChemistConfigurationData.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, "Stations");
			ChemistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, 100669020);
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0010F6DC File Offset: 0x0010D8DC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfigurationData(ObjectFieldData bed, ObjectListFieldData stations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stations);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0001991B File Offset: 0x00017B1B
		public ChemistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060030C6 RID: 12486 RVA: 0x0010F73C File Offset: 0x0010D93C
		// (set) Token: 0x060030C7 RID: 12487 RVA: 0x00019924 File Offset: 0x00017B24
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x0010F76C File Offset: 0x0010D96C
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x00019943 File Offset: 0x00017B43
		public unsafe ObjectListFieldData Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0;
	}
}
