using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000526 RID: 1318
	public static class PathUtility : Il2CppSystem.Object
	{
		// Token: 0x06007307 RID: 29447 RVA: 0x001FACA4 File Offset: 0x001F8EA4
		// Note: this type is marked as 'beforefieldinit'.
		static PathUtility()
		{
			Il2CppClassPointerStore<PathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathUtility>.NativeClassPtr);
			PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677858);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677859);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677860);
			PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677861);
			PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677862);
			PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677863);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677864);
			PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677865);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100677866);
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x001FAD88 File Offset: 0x001F8F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226200, XrefRangeEnd = 226204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sampleCount;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref stepSize;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x001FADF4 File Offset: 0x001F8FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226204, XrefRangeEnd = 226206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distance;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x001FAE54 File Offset: 0x001F9054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226206, XrefRangeEnd = 226207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distance;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pointLerp;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x001FAED0 File Offset: 0x001F90D0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 226235, RefRangeEnd = 226246, XrefRangeStart = 226207, XrefRangeEnd = 226235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distanceAhead;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x001FAF3C File Offset: 0x001F913C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226246, XrefRangeEnd = 226263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distanceAhead;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x001FAFA8 File Offset: 0x001F91A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226263, XrefRangeEnd = 226271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref flatCarPos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleTransform);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref wp_from;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref wp_to;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x001FB028 File Offset: 0x001F9228
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 226290, RefRangeEnd = 226303, XrefRangeStart = 226271, XrefRangeEnd = 226290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &startPointIndex;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &endPointIndex;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &pointLerp;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x001FB0A4 File Offset: 0x001F92A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226303, XrefRangeEnd = 226307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distanceAhead;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x001FB104 File Offset: 0x001F9304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226307, XrefRangeEnd = 226311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnLine(Vector3 point, Vector3 line_start, Vector3 line_end, bool clamp = true)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref line_start;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref line_end;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref clamp;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x0003666A File Offset: 0x0003486A
		public PathUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E90 RID: 20112
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0;

		// Token: 0x04004E91 RID: 20113
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04004E92 RID: 20114
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0;

		// Token: 0x04004E93 RID: 20115
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04004E94 RID: 20116
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04004E95 RID: 20117
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0;

		// Token: 0x04004E96 RID: 20118
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0;

		// Token: 0x04004E97 RID: 20119
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04004E98 RID: 20120
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0;
	}
}
