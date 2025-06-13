using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003E3 RID: 995
	[System.Serializable]
	public class Crime : Il2CppSystem.Object
	{
		// Token: 0x06004C89 RID: 19593 RVA: 0x00173A54 File Offset: 0x00171C54
		// Note: this type is marked as 'beforefieldinit'.
		static Crime()
		{
			Il2CppClassPointerStore<Crime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Crime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crime>.NativeClassPtr);
			Crime.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crime>.NativeClassPtr, "<CrimeName>k__BackingField");
			Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672860);
			Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672861);
			Crime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672862);
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06004C8A RID: 19594 RVA: 0x00173AD4 File Offset: 0x00171CD4
		// (set) Token: 0x06004C8B RID: 19595 RVA: 0x00173B18 File Offset: 0x00171D18
		public unsafe virtual string CrimeName
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00173B68 File Offset: 0x00171D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169209, RefRangeEnd = 169210, XrefRangeStart = 169204, XrefRangeEnd = 169209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Crime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Crime>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00024AFE File Offset: 0x00022CFE
		public Crime(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06004C8E RID: 19598 RVA: 0x00173BA4 File Offset: 0x00171DA4
		// (set) Token: 0x06004C8F RID: 19599 RVA: 0x00024B07 File Offset: 0x00022D07
		public unsafe string _CrimeName_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400339C RID: 13212
		private static readonly System.IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x0400339D RID: 13213
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0;

		// Token: 0x0400339E RID: 13214
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x0400339F RID: 13215
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
