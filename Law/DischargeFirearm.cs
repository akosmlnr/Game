using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F4 RID: 1012
	[Serializable]
	public class DischargeFirearm : Crime
	{
		// Token: 0x06004D00 RID: 19712 RVA: 0x0017534C File Offset: 0x0017354C
		// Note: this type is marked as 'beforefieldinit'.
		static DischargeFirearm()
		{
			Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DischargeFirearm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr);
			DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, "<CrimeName>k__BackingField");
			DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672911);
			DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672912);
			DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr, 100672913);
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06004D01 RID: 19713 RVA: 0x001753CC File Offset: 0x001735CC
		// (set) Token: 0x06004D02 RID: 19714 RVA: 0x00175410 File Offset: 0x00173610
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DischargeFirearm.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00175460 File Offset: 0x00173660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169385, RefRangeEnd = 169387, XrefRangeStart = 169376, XrefRangeEnd = 169385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DischargeFirearm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DischargeFirearm>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DischargeFirearm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00024DA6 File Offset: 0x00022FA6
		public DischargeFirearm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06004D05 RID: 19717 RVA: 0x0017549C File Offset: 0x0017369C
		// (set) Token: 0x06004D06 RID: 19718 RVA: 0x00024DAF File Offset: 0x00022FAF
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DischargeFirearm.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033E0 RID: 13280
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033E1 RID: 13281
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033E2 RID: 13282
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033E3 RID: 13283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
