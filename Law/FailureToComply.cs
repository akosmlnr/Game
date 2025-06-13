using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003EB RID: 1003
	[Serializable]
	public class FailureToComply : Crime
	{
		// Token: 0x06004CC1 RID: 19649 RVA: 0x00174614 File Offset: 0x00172814
		// Note: this type is marked as 'beforefieldinit'.
		static FailureToComply()
		{
			Il2CppClassPointerStore<FailureToComply>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "FailureToComply");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr);
			FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, "<CrimeName>k__BackingField");
			FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672884);
			FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672885);
			FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672886);
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x00174694 File Offset: 0x00172894
		// (set) Token: 0x06004CC3 RID: 19651 RVA: 0x001746D8 File Offset: 0x001728D8
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00174728 File Offset: 0x00172928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169292, RefRangeEnd = 169293, XrefRangeStart = 169283, XrefRangeEnd = 169292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailureToComply() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00024C3E File Offset: 0x00022E3E
		public FailureToComply(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00174764 File Offset: 0x00172964
		// (set) Token: 0x06004CC7 RID: 19655 RVA: 0x00024C47 File Offset: 0x00022E47
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
