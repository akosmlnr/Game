using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003ED RID: 1005
	[Serializable]
	public class ViolatingCurfew : Crime
	{
		// Token: 0x06004CCF RID: 19663 RVA: 0x00174904 File Offset: 0x00172B04
		// Note: this type is marked as 'beforefieldinit'.
		static ViolatingCurfew()
		{
			Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "ViolatingCurfew");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr);
			ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, "<CrimeName>k__BackingField");
			ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672890);
			ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672891);
			ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr, 100672892);
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x00174984 File Offset: 0x00172B84
		// (set) Token: 0x06004CD1 RID: 19665 RVA: 0x001749C8 File Offset: 0x00172BC8
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViolatingCurfew.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00174A18 File Offset: 0x00172C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169312, RefRangeEnd = 169313, XrefRangeStart = 169303, XrefRangeEnd = 169312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViolatingCurfew() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViolatingCurfew>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViolatingCurfew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x00024C8E File Offset: 0x00022E8E
		public ViolatingCurfew(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x00174A54 File Offset: 0x00172C54
		// (set) Token: 0x06004CD5 RID: 19669 RVA: 0x00024C97 File Offset: 0x00022E97
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViolatingCurfew.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
