using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003E4 RID: 996
	[Serializable]
	public class PossessingControlledSubstances : Crime
	{
		// Token: 0x06004C90 RID: 19600 RVA: 0x00173BCC File Offset: 0x00171DCC
		// Note: this type is marked as 'beforefieldinit'.
		static PossessingControlledSubstances()
		{
			Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PossessingControlledSubstances");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr);
			PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, "<CrimeName>k__BackingField");
			PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672863);
			PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672864);
			PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr, 100672865);
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x00173C4C File Offset: 0x00171E4C
		// (set) Token: 0x06004C92 RID: 19602 RVA: 0x00173C90 File Offset: 0x00171E90
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PossessingControlledSubstances.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00173CE0 File Offset: 0x00171EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169219, RefRangeEnd = 169220, XrefRangeStart = 169210, XrefRangeEnd = 169219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PossessingControlledSubstances() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossessingControlledSubstances>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PossessingControlledSubstances.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00024B26 File Offset: 0x00022D26
		public PossessingControlledSubstances(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x00173D1C File Offset: 0x00171F1C
		// (set) Token: 0x06004C96 RID: 19606 RVA: 0x00024B2F File Offset: 0x00022D2F
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PossessingControlledSubstances.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
