using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public class Theft : Crime
	{
		// Token: 0x06004CF2 RID: 19698 RVA: 0x0017505C File Offset: 0x0017325C
		// Note: this type is marked as 'beforefieldinit'.
		static Theft()
		{
			Il2CppClassPointerStore<Theft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Theft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Theft>.NativeClassPtr);
			Theft.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Theft>.NativeClassPtr, "<CrimeName>k__BackingField");
			Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672905);
			Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672906);
			Theft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Theft>.NativeClassPtr, 100672907);
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x06004CF3 RID: 19699 RVA: 0x001750DC File Offset: 0x001732DC
		// (set) Token: 0x06004CF4 RID: 19700 RVA: 0x00175120 File Offset: 0x00173320
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Theft.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x00175170 File Offset: 0x00173370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169364, RefRangeEnd = 169365, XrefRangeStart = 169355, XrefRangeEnd = 169364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Theft() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Theft>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Theft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00024D56 File Offset: 0x00022F56
		public Theft(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x001751AC File Offset: 0x001733AC
		// (set) Token: 0x06004CF8 RID: 19704 RVA: 0x00024D5F File Offset: 0x00022F5F
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Theft.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033D8 RID: 13272
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033D9 RID: 13273
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033DA RID: 13274
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033DB RID: 13275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
