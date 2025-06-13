using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C2 RID: 706
	[Serializable]
	public class OrganisationData : SaveData
	{
		// Token: 0x06003261 RID: 12897 RVA: 0x001141E4 File Offset: 0x001123E4
		// Note: this type is marked as 'beforefieldinit'.
		static OrganisationData()
		{
			Il2CppClassPointerStore<OrganisationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "OrganisationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr);
			OrganisationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "Name");
			OrganisationData.NativeFieldInfoPtr_NetWorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "NetWorth");
			OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, 100669072);
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00114250 File Offset: 0x00112450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137012, XrefRangeEnd = 137014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrganisationData(string name, float netWorth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x0001A9E4 File Offset: 0x00018BE4
		public OrganisationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06003264 RID: 12900 RVA: 0x001142AC File Offset: 0x001124AC
		// (set) Token: 0x06003265 RID: 12901 RVA: 0x0001A9ED File Offset: 0x00018BED
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06003266 RID: 12902 RVA: 0x001142D4 File Offset: 0x001124D4
		// (set) Token: 0x06003267 RID: 12903 RVA: 0x0001AA0C File Offset: 0x00018C0C
		public unsafe float NetWorth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth)) = value;
			}
		}

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeFieldInfoPtr_NetWorth;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
	}
}
