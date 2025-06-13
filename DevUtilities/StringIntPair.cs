using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200048D RID: 1165
	[System.Serializable]
	public class StringIntPair : Il2CppSystem.Object
	{
		// Token: 0x060063E2 RID: 25570 RVA: 0x001C8940 File Offset: 0x001C6B40
		// Note: this type is marked as 'beforefieldinit'.
		static StringIntPair()
		{
			Il2CppClassPointerStore<StringIntPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "StringIntPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr);
			StringIntPair.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "String");
			StringIntPair.NativeFieldInfoPtr_Int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, "Int");
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100676071);
			StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr, 100676072);
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x001C89C0 File Offset: 0x001C6BC0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 110827, RefRangeEnd = 110836, XrefRangeStart = 110827, XrefRangeEnd = 110836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair(string str, int i) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref i;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x001C8A1C File Offset: 0x001C6C1C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringIntPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringIntPair>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringIntPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0002EF74 File Offset: 0x0002D174
		public StringIntPair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x060063E6 RID: 25574 RVA: 0x001C8A58 File Offset: 0x001C6C58
		// (set) Token: 0x060063E7 RID: 25575 RVA: 0x0002EF7D File Offset: 0x0002D17D
		public unsafe string String
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x060063E8 RID: 25576 RVA: 0x001C8A80 File Offset: 0x001C6C80
		// (set) Token: 0x060063E9 RID: 25577 RVA: 0x0002EF9C File Offset: 0x0002D19C
		public unsafe int Int
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StringIntPair.NativeFieldInfoPtr_Int)) = value;
			}
		}

		// Token: 0x04004420 RID: 17440
		private static readonly System.IntPtr NativeFieldInfoPtr_String;

		// Token: 0x04004421 RID: 17441
		private static readonly System.IntPtr NativeFieldInfoPtr_Int;

		// Token: 0x04004422 RID: 17442
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04004423 RID: 17443
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
