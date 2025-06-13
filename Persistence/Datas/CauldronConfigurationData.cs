using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028E RID: 654
	[Serializable]
	public class CauldronConfigurationData : SaveData
	{
		// Token: 0x060030BE RID: 12478 RVA: 0x0010F59C File Offset: 0x0010D79C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfigurationData()
		{
			Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr);
			CauldronConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr, "Destination");
			CauldronConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr, 100669019);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0010F5F4 File Offset: 0x0010D7F4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136201, RefRangeEnd = 136212, XrefRangeStart = 136201, XrefRangeEnd = 136212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x000198F3 File Offset: 0x00017AF3
		public CauldronConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0010F640 File Offset: 0x0010D840
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x000198FC File Offset: 0x00017AFC
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
