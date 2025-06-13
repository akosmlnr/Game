using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003EA RID: 1002
	[Serializable]
	public class DrugTrafficking : Crime
	{
		// Token: 0x06004CBA RID: 19642 RVA: 0x0017449C File Offset: 0x0017269C
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTrafficking()
		{
			Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "DrugTrafficking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr);
			DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, "<CrimeName>k__BackingField");
			DrugTrafficking.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672881);
			DrugTrafficking.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672882);
			DrugTrafficking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr, 100672883);
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x0017451C File Offset: 0x0017271C
		// (set) Token: 0x06004CBC RID: 19644 RVA: 0x00174560 File Offset: 0x00172760
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrugTrafficking.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DrugTrafficking.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x001745B0 File Offset: 0x001727B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169282, RefRangeEnd = 169283, XrefRangeStart = 169273, XrefRangeEnd = 169282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTrafficking() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTrafficking>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTrafficking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x00024C16 File Offset: 0x00022E16
		public DrugTrafficking(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x001745EC File Offset: 0x001727EC
		// (set) Token: 0x06004CC0 RID: 19648 RVA: 0x00024C1F File Offset: 0x00022E1F
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTrafficking.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
