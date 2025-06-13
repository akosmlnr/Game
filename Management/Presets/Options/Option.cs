using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003D0 RID: 976
	public class Option : Il2CppSystem.Object
	{
		// Token: 0x06004B32 RID: 19250 RVA: 0x0016F448 File Offset: 0x0016D648
		// Note: this type is marked as 'beforefieldinit'.
		static Option()
		{
			Il2CppClassPointerStore<Option>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "Option");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Option>.NativeClassPtr);
			Option.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "<Name>k__BackingField");
			Option.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672704);
			Option.NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672705);
			Option.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672706);
			Option.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672707);
			Option.NativeMethodInfoPtr_GetDisplayString_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672708);
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004B33 RID: 19251 RVA: 0x0016F4F0 File Offset: 0x0016D6F0
		// (set) Token: 0x06004B34 RID: 19252 RVA: 0x0016F528 File Offset: 0x0016D728
		public unsafe string Name
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x0016F56C File Offset: 0x0016D76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168146, XrefRangeEnd = 168152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Option(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Option>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x0016F5B8 File Offset: 0x0016D7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168152, XrefRangeEnd = 168154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Option other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Option.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x0016F608 File Offset: 0x0016D808
		[CallerCount(0)]
		public unsafe virtual string GetDisplayString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Option.NativeMethodInfoPtr_GetDisplayString_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x000240BA File Offset: 0x000222BA
		public Option(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004B39 RID: 19257 RVA: 0x0016F64C File Offset: 0x0016D84C
		// (set) Token: 0x06004B3A RID: 19258 RVA: 0x000240C3 File Offset: 0x000222C3
		public unsafe string _Name_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032AF RID: 12975
		private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040032B0 RID: 12976
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040032B1 RID: 12977
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0;

		// Token: 0x040032B2 RID: 12978
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040032B3 RID: 12979
		private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Option_0;

		// Token: 0x040032B4 RID: 12980
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayString_Public_Abstract_Virtual_New_String_0;
	}
}
