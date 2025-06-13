using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003DC RID: 988
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct FullRank
	{
		// Token: 0x06004BDB RID: 19419 RVA: 0x001711FC File Offset: 0x0016F3FC
		// Note: this type is marked as 'beforefieldinit'.
		static FullRank()
		{
			Il2CppClassPointerStore<FullRank>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "FullRank");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullRank>.NativeClassPtr);
			FullRank.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Rank");
			FullRank.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Tier");
			FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672772);
			FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672773);
			FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672774);
			FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672775);
			FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672776);
			FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672777);
			FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672778);
			FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672779);
			FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672780);
			FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672781);
			FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672782);
			FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672783);
			FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100672784);
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00171358 File Offset: 0x0016F558
		[CallerCount(486)]
		[CachedScanResults(RefRangeStart = 35745, RefRangeEnd = 36231, XrefRangeStart = 35745, XrefRangeEnd = 36231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank(ERank rank, int tier)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00171398 File Offset: 0x0016F598
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 168531, RefRangeEnd = 168540, XrefRangeStart = 168515, XrefRangeEnd = 168531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x001713C4 File Offset: 0x0016F5C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168540, RefRangeEnd = 168542, XrefRangeStart = 168540, XrefRangeEnd = 168540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank NextRank()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x001713F4 File Offset: 0x0016F5F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168558, RefRangeEnd = 168561, XrefRangeStart = 168542, XrefRangeEnd = 168558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(FullRank rank)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rank;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x0017142C File Offset: 0x0016F62C
		[CallerCount(0)]
		public unsafe static bool operator >(FullRank a, FullRank b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x00171478 File Offset: 0x0016F678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168561, RefRangeEnd = 168563, XrefRangeStart = 168561, XrefRangeEnd = 168561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(FullRank a, FullRank b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x001714C4 File Offset: 0x0016F6C4
		[CallerCount(0)]
		public unsafe static bool operator <=(FullRank a, FullRank b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x00171510 File Offset: 0x0016F710
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 168563, RefRangeEnd = 168567, XrefRangeStart = 168563, XrefRangeEnd = 168563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(FullRank a, FullRank b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x0017155C File Offset: 0x0016F75C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 61335, RefRangeEnd = 61348, XrefRangeStart = 61335, XrefRangeEnd = 61348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FullRank a, FullRank b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x001715A8 File Offset: 0x0016F7A8
		[CallerCount(0)]
		public unsafe static bool operator !=(FullRank a, FullRank b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x001715F4 File Offset: 0x0016F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168567, XrefRangeEnd = 168570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x00171638 File Offset: 0x0016F838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168570, XrefRangeEnd = 168574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x00171668 File Offset: 0x0016F868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168574, RefRangeEnd = 168576, XrefRangeStart = 168574, XrefRangeEnd = 168574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FullRank other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref other;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x000246BD File Offset: 0x000228BD
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullRank>.NativeClassPtr, ref this));
		}

		// Token: 0x04003310 RID: 13072
		private static readonly System.IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003311 RID: 13073
		private static readonly System.IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x04003312 RID: 13074
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0;

		// Token: 0x04003313 RID: 13075
		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003314 RID: 13076
		private static readonly System.IntPtr NativeMethodInfoPtr_NextRank_Public_FullRank_0;

		// Token: 0x04003315 RID: 13077
		private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0;

		// Token: 0x04003316 RID: 13078
		private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003317 RID: 13079
		private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003318 RID: 13080
		private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x04003319 RID: 13081
		private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400331A RID: 13082
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400331B RID: 13083
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x0400331C RID: 13084
		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400331D RID: 13085
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400331E RID: 13086
		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0;

		// Token: 0x0400331F RID: 13087
		[FieldOffset(0)]
		public ERank Rank;

		// Token: 0x04003320 RID: 13088
		[FieldOffset(4)]
		public int Tier;
	}
}
