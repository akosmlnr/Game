using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000294 RID: 660
	[Serializable]
	public class LabOvenConfigurationData : SaveData
	{
		// Token: 0x060030E4 RID: 12516 RVA: 0x0010FBEC File Offset: 0x0010DDEC
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenConfigurationData()
		{
			Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr);
			LabOvenConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, "Destination");
			LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, 100669025);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0010FC44 File Offset: 0x0010DE44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x00019A5F File Offset: 0x00017C5F
		public LabOvenConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x0010FC90 File Offset: 0x0010DE90
		// (set) Token: 0x060030E8 RID: 12520 RVA: 0x00019A68 File Offset: 0x00017C68
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
