using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x020004C0 RID: 1216
	public static class ClothingColorExtensions : Il2CppSystem.Object
	{
		// Token: 0x0600684B RID: 26699 RVA: 0x001D7178 File Offset: 0x001D5378
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingColorExtensions()
		{
			Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingColorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr);
			ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676581);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676582);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676583);
			ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676584);
			ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676585);
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x001D720C File Offset: 0x001D540C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 211440, RefRangeEnd = 211449, XrefRangeStart = 211435, XrefRangeEnd = 211440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetActualColor(this EClothingColor color)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x001D724C File Offset: 0x001D544C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211449, XrefRangeEnd = 211454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetLabelColor(this EClothingColor color)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x001D728C File Offset: 0x001D548C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211457, RefRangeEnd = 211460, XrefRangeStart = 211454, XrefRangeEnd = 211457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLabel(this EClothingColor color)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x001D72C4 File Offset: 0x001D54C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211488, RefRangeEnd = 211491, XrefRangeStart = 211460, XrefRangeEnd = 211488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EClothingColor GetClothingColor(Color color)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x001D7304 File Offset: 0x001D5504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211491, RefRangeEnd = 211492, XrefRangeStart = 211491, XrefRangeEnd = 211491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tolerance;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00031191 File Offset: 0x0002F391
		public ClothingColorExtensions(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400474D RID: 18253
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x0400474E RID: 18254
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x0400474F RID: 18255
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0;

		// Token: 0x04004750 RID: 18256
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0;

		// Token: 0x04004751 RID: 18257
		private static readonly System.IntPtr NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0;
	}
}
