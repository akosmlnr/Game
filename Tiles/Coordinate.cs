using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A0 RID: 416
	[System.Serializable]
	public class Coordinate : Il2CppSystem.Object
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x000DDBC4 File Offset: 0x000DBDC4
		// Note: this type is marked as 'beforefieldinit'.
		static Coordinate()
		{
			Il2CppClassPointerStore<Coordinate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Coordinate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Coordinate>.NativeClassPtr);
			Coordinate.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, "x");
			Coordinate.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, "y");
			Coordinate.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667182);
			Coordinate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667183);
			Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667184);
			Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667185);
			Coordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667186);
			Coordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667187);
			Coordinate.NativeMethodInfoPtr_op_Addition_Public_Static_Coordinate_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667188);
			Coordinate.NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinate_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667189);
			Coordinate.NativeMethodInfoPtr_CantorPair_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667190);
			Coordinate.NativeMethodInfoPtr_SignedCantorPair_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667191);
			Coordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667192);
			Coordinate.NativeMethodInfoPtr_BuildCoordinateMatches_Public_Static_List_1_CoordinatePair_Coordinate_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667193);
			Coordinate.NativeMethodInfoPtr_RotateCoordinates_Public_Static_Coordinate_Coordinate_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667194);
			Coordinate.NativeMethodInfoPtr_MathMod_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Coordinate>.NativeClassPtr, 100667195);
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x000DDD34 File Offset: 0x000DBF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113999, RefRangeEnd = 114001, XrefRangeStart = 113999, XrefRangeEnd = 113999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(Coordinate c)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Coordinate_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x000DDD78 File Offset: 0x000DBF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114002, RefRangeEnd = 114004, XrefRangeStart = 114001, XrefRangeEnd = 114002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coordinate>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x000DDDB4 File Offset: 0x000DBFB4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 114005, RefRangeEnd = 114023, XrefRangeStart = 114004, XrefRangeEnd = 114005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate(int _x, int _y) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coordinate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _y;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000DDE0C File Offset: 0x000DC00C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 114024, RefRangeEnd = 114031, XrefRangeStart = 114023, XrefRangeEnd = 114024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate(Vector2 vector) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Coordinate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vector;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr__ctor_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x000DDE54 File Offset: 0x000DC054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114031, XrefRangeEnd = 114033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Coordinate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000DDE9C File Offset: 0x000DC09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114033, XrefRangeEnd = 114035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Coordinate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000DDEF4 File Offset: 0x000DC0F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114039, RefRangeEnd = 114043, XrefRangeStart = 114035, XrefRangeEnd = 114039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate operator +(Coordinate a, Coordinate b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_op_Addition_Public_Static_Coordinate_Coordinate_Coordinate_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000DDF4C File Offset: 0x000DC14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114043, XrefRangeEnd = 114047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate operator -(Coordinate a, Coordinate b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinate_Coordinate_Coordinate_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x000DDFA4 File Offset: 0x000DC1A4
		[CallerCount(0)]
		public unsafe int CantorPair(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref y;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_CantorPair_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x000DDFFC File Offset: 0x000DC1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114047, XrefRangeEnd = 114049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SignedCantorPair(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref y;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_SignedCantorPair_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000DE054 File Offset: 0x000DC254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114049, XrefRangeEnd = 114068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Coordinate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000DE098 File Offset: 0x000DC298
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114104, RefRangeEnd = 114108, XrefRangeStart = 114068, XrefRangeEnd = 114104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CoordinatePair> BuildCoordinateMatches(Coordinate originCoord, int sizeX, int sizeY, float rot)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(originCoord);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sizeX;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sizeY;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_BuildCoordinateMatches_Public_Static_List_1_CoordinatePair_Coordinate_Int32_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x000DE108 File Offset: 0x000DC308
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114117, RefRangeEnd = 114121, XrefRangeStart = 114108, XrefRangeEnd = 114117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate RotateCoordinates(Coordinate coord, float angle)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref angle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_RotateCoordinates_Public_Static_Coordinate_Coordinate_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x000DE15C File Offset: 0x000DC35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114121, XrefRangeEnd = 114124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MathMod(int a, int b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Coordinate.NativeMethodInfoPtr_MathMod_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00012DA4 File Offset: 0x00010FA4
		public Coordinate(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x000DE1A8 File Offset: 0x000DC3A8
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x00012DAD File Offset: 0x00010FAD
		public unsafe int x
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000DE1D0 File Offset: 0x000DC3D0
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public unsafe int y
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Coordinate.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x040016A6 RID: 5798
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040016A7 RID: 5799
		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040016A8 RID: 5800
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Coordinate_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016AA RID: 5802
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040016AB RID: 5803
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_0;

		// Token: 0x040016AC RID: 5804
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016AD RID: 5805
		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016AE RID: 5806
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Coordinate_Coordinate_Coordinate_0;

		// Token: 0x040016AF RID: 5807
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Coordinate_Coordinate_Coordinate_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly System.IntPtr NativeMethodInfoPtr_CantorPair_Private_Int32_Int32_Int32_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly System.IntPtr NativeMethodInfoPtr_SignedCantorPair_Private_Int32_Int32_Int32_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly System.IntPtr NativeMethodInfoPtr_BuildCoordinateMatches_Public_Static_List_1_CoordinatePair_Coordinate_Int32_Int32_Single_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly System.IntPtr NativeMethodInfoPtr_RotateCoordinates_Public_Static_Coordinate_Coordinate_Single_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly System.IntPtr NativeMethodInfoPtr_MathMod_Private_Static_Int32_Int32_Int32_0;
	}
}
