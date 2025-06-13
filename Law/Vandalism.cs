using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F1 RID: 1009
	[Serializable]
	public class Vandalism : Crime
	{
		// Token: 0x06004CEB RID: 19691 RVA: 0x00174EE4 File Offset: 0x001730E4
		// Note: this type is marked as 'beforefieldinit'.
		static Vandalism()
		{
			Il2CppClassPointerStore<Vandalism>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Vandalism");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vandalism>.NativeClassPtr);
			Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, "<CrimeName>k__BackingField");
			Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672902);
			Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672903);
			Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672904);
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06004CEC RID: 19692 RVA: 0x00174F64 File Offset: 0x00173164
		// (set) Token: 0x06004CED RID: 19693 RVA: 0x00174FA8 File Offset: 0x001731A8
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00174FF8 File Offset: 0x001731F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169354, RefRangeEnd = 169355, XrefRangeStart = 169345, XrefRangeEnd = 169354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vandalism() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vandalism>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00024D2E File Offset: 0x00022F2E
		public Vandalism(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x00175034 File Offset: 0x00173234
		// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x00024D37 File Offset: 0x00022F37
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033D4 RID: 13268
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033D5 RID: 13269
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033D6 RID: 13270
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033D7 RID: 13271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
