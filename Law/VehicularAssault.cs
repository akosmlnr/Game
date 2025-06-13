using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003E9 RID: 1001
	[Serializable]
	public class VehicularAssault : Crime
	{
		// Token: 0x06004CB3 RID: 19635 RVA: 0x00174324 File Offset: 0x00172524
		// Note: this type is marked as 'beforefieldinit'.
		static VehicularAssault()
		{
			Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehicularAssault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr);
			VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, "<CrimeName>k__BackingField");
			VehicularAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100672878);
			VehicularAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100672879);
			VehicularAssault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr, 100672880);
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x001743A4 File Offset: 0x001725A4
		// (set) Token: 0x06004CB5 RID: 19637 RVA: 0x001743E8 File Offset: 0x001725E8
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicularAssault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicularAssault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x00174438 File Offset: 0x00172638
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 169269, RefRangeEnd = 169273, XrefRangeStart = 169260, XrefRangeEnd = 169269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicularAssault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicularAssault>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicularAssault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00024BEE File Offset: 0x00022DEE
		public VehicularAssault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06004CB8 RID: 19640 RVA: 0x00174474 File Offset: 0x00172674
		// (set) Token: 0x06004CB9 RID: 19641 RVA: 0x00024BF7 File Offset: 0x00022DF7
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicularAssault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
