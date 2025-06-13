using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003EE RID: 1006
	[Serializable]
	public class AttemptingToSell : Crime
	{
		// Token: 0x06004CD6 RID: 19670 RVA: 0x00174A7C File Offset: 0x00172C7C
		// Note: this type is marked as 'beforefieldinit'.
		static AttemptingToSell()
		{
			Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "AttemptingToSell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr);
			AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, "<CrimeName>k__BackingField");
			AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672893);
			AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672894);
			AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672895);
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00174AFC File Offset: 0x00172CFC
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00174B40 File Offset: 0x00172D40
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00174B90 File Offset: 0x00172D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169322, RefRangeEnd = 169323, XrefRangeStart = 169313, XrefRangeEnd = 169322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttemptingToSell() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00024CB6 File Offset: 0x00022EB6
		public AttemptingToSell(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x00174BCC File Offset: 0x00172DCC
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x00024CBF File Offset: 0x00022EBF
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033CA RID: 13258
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033CB RID: 13259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
