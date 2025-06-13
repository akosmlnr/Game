using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003EC RID: 1004
	[Serializable]
	public class TransportingIllicitItems : Crime
	{
		// Token: 0x06004CC8 RID: 19656 RVA: 0x0017478C File Offset: 0x0017298C
		// Note: this type is marked as 'beforefieldinit'.
		static TransportingIllicitItems()
		{
			Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "TransportingIllicitItems");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr);
			TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, "<CrimeName>k__BackingField");
			TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672887);
			TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672888);
			TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672889);
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x06004CC9 RID: 19657 RVA: 0x0017480C File Offset: 0x00172A0C
		// (set) Token: 0x06004CCA RID: 19658 RVA: 0x00174850 File Offset: 0x00172A50
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x001748A0 File Offset: 0x00172AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169302, RefRangeEnd = 169303, XrefRangeStart = 169293, XrefRangeEnd = 169302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportingIllicitItems() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x00024C66 File Offset: 0x00022E66
		public TransportingIllicitItems(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x001748DC File Offset: 0x00172ADC
		// (set) Token: 0x06004CCE RID: 19662 RVA: 0x00024C6F File Offset: 0x00022E6F
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
