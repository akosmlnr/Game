using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200017E RID: 382
	[Serializable]
	public class UniqueVisibilityAttribute : VisibilityAttribute
	{
		// Token: 0x06001E43 RID: 7747 RVA: 0x000D1774 File Offset: 0x000CF974
		// Note: this type is marked as 'beforefieldinit'.
		static UniqueVisibilityAttribute()
		{
			Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "UniqueVisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr);
			UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr, "uniquenessCode");
			UniqueVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr, 100666769);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x000D17CC File Offset: 0x000CF9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109977, XrefRangeEnd = 109979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniqueVisibilityAttribute(string _name, float _pointsChange, string _uniquenessCode, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniqueVisibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_uniquenessCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniqueVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00010F98 File Offset: 0x0000F198
		public UniqueVisibilityAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x000D1854 File Offset: 0x000CFA54
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x00010FA1 File Offset: 0x0000F1A1
		public unsafe string uniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniqueVisibilityAttribute.NativeFieldInfoPtr_uniquenessCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr_uniquenessCode;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_String_Single_Int32_0;
	}
}
