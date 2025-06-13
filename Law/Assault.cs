using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003EF RID: 1007
	[Serializable]
	public class Assault : Crime
	{
		// Token: 0x06004CDD RID: 19677 RVA: 0x00174BF4 File Offset: 0x00172DF4
		// Note: this type is marked as 'beforefieldinit'.
		static Assault()
		{
			Il2CppClassPointerStore<Assault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Assault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assault>.NativeClassPtr);
			Assault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assault>.NativeClassPtr, "<CrimeName>k__BackingField");
			Assault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100672896);
			Assault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100672897);
			Assault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100672898);
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x00174C74 File Offset: 0x00172E74
		// (set) Token: 0x06004CDF RID: 19679 RVA: 0x00174CB8 File Offset: 0x00172EB8
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x00174D08 File Offset: 0x00172F08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169332, RefRangeEnd = 169335, XrefRangeStart = 169323, XrefRangeEnd = 169332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assault>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00024CDE File Offset: 0x00022EDE
		public Assault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x00174D44 File Offset: 0x00172F44
		// (set) Token: 0x06004CE3 RID: 19683 RVA: 0x00024CE7 File Offset: 0x00022EE7
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033CC RID: 13260
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033CD RID: 13261
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033CE RID: 13262
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033CF RID: 13263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
