using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000521 RID: 1313
	public class NavigationUtility : Il2CppSystem.Object
	{
		// Token: 0x060072DE RID: 29406 RVA: 0x001FA46C File Offset: 0x001F866C
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationUtility()
		{
			Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr);
			NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "ROAD_MULTIPLIER");
			NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "OFFROAD_MULTIPLIER");
			NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677810);
			NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677811);
			NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677812);
			NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677813);
			NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677814);
			NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677815);
			NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677816);
			NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677817);
			NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677818);
			NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677819);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x001FA58C File Offset: 0x001F878C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226018, XrefRangeEnd = 226038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.NavigationCalculationCallback callback)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref destination;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(navSettings);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x001FA638 File Offset: 0x001F8838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226038, XrefRangeEnd = 226076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustExitPoint(PathGroup group)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x001FA670 File Offset: 0x001F8870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226076, XrefRangeEnd = 226095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustEntryPoint(PathGroup group)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x001FA6A8 File Offset: 0x001F88A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226095, XrefRangeEnd = 226110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vectorList);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref thresholdDistance;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x001FA708 File Offset: 0x001F8908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226110, XrefRangeEnd = 226118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.PathGroupEvent callback)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref entryPoint;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitLink);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref exitPoint;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref destination;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x001FA7C0 File Offset: 0x001F89C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226118, XrefRangeEnd = 226152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathGroup group, float duration = 10f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x001FA804 File Offset: 0x001F8A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226152, XrefRangeEnd = 226167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr2) : null;
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x001FA848 File Offset: 0x001F8A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226179, RefRangeEnd = 226181, XrefRangeStart = 226167, XrefRangeEnd = 226179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SampleVehicleGraph(Vector3 destination)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref destination;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x001FA888 File Offset: 0x001F8A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226181, XrefRangeEnd = 226184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref line_start;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref line_end;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x001FA8E4 File Offset: 0x001F8AE4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x0003652B File Offset: 0x0003472B
		public NavigationUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x060072EA RID: 29418 RVA: 0x001FA920 File Offset: 0x001F8B20
		// (set) Token: 0x060072EB RID: 29419 RVA: 0x00036534 File Offset: 0x00034734
		public unsafe static float ROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x060072EC RID: 29420 RVA: 0x001FA93C File Offset: 0x001F8B3C
		// (set) Token: 0x060072ED RID: 29421 RVA: 0x00036542 File Offset: 0x00034742
		public unsafe static float OFFROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x04004E7A RID: 20090
		private static readonly System.IntPtr NativeFieldInfoPtr_ROAD_MULTIPLIER;

		// Token: 0x04004E7B RID: 20091
		private static readonly System.IntPtr NativeFieldInfoPtr_OFFROAD_MULTIPLIER;

		// Token: 0x04004E7C RID: 20092
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0;

		// Token: 0x04004E7D RID: 20093
		private static readonly System.IntPtr NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04004E7E RID: 20094
		private static readonly System.IntPtr NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04004E7F RID: 20095
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0;

		// Token: 0x04004E80 RID: 20096
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0;

		// Token: 0x04004E81 RID: 20097
		private static readonly System.IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0;

		// Token: 0x04004E82 RID: 20098
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0;

		// Token: 0x04004E83 RID: 20099
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0;

		// Token: 0x04004E84 RID: 20100
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04004E85 RID: 20101
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABE RID: 2750
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationCalculationResult")]
		public enum ENavigationCalculationResult
		{
			// Token: 0x040090BA RID: 37050
			Success,
			// Token: 0x040090BB RID: 37051
			Failed
		}

		// Token: 0x02000ABF RID: 2751
		public sealed class NavigationCalculationCallback : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600D670 RID: 54896 RVA: 0x00337EC4 File Offset: 0x003360C4
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCalculationCallback()
			{
				Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "NavigationCalculationCallback");
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677820);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677821);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677822);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677823);
			}

			// Token: 0x0600D671 RID: 54897 RVA: 0x00337F38 File Offset: 0x00336138
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 225851, RefRangeEnd = 225870, XrefRangeStart = 225848, XrefRangeEnd = 225851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCalculationCallback(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D672 RID: 54898 RVA: 0x00337F94 File Offset: 0x00336194
			[CallerCount(0)]
			public unsafe void Invoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D673 RID: 54899 RVA: 0x00337FE4 File Offset: 0x003361E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225870, XrefRangeEnd = 225874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600D674 RID: 54900 RVA: 0x00338068 File Offset: 0x00336268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D675 RID: 54901 RVA: 0x0006813B File Offset: 0x0006633B
			public NavigationCalculationCallback(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D676 RID: 54902 RVA: 0x00068144 File Offset: 0x00066344
			public static implicit operator NavigationUtility.NavigationCalculationCallback(System.Action<NavigationUtility.ENavigationCalculationResult, PathSmoothingUtility.SmoothedPath> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.NavigationCalculationCallback>(A_0);
			}

			// Token: 0x0600D677 RID: 54903 RVA: 0x0006814C File Offset: 0x0006634C
			public static NavigationUtility.NavigationCalculationCallback operator +(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<NavigationUtility.NavigationCalculationCallback>();
			}

			// Token: 0x0600D678 RID: 54904 RVA: 0x0006815A File Offset: 0x0006635A
			public static NavigationUtility.NavigationCalculationCallback operator -(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.NavigationCalculationCallback>();
				}
				return result;
			}

			// Token: 0x040090BC RID: 37052
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040090BD RID: 37053
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0;

			// Token: 0x040090BE RID: 37054
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0;

			// Token: 0x040090BF RID: 37055
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000AC0 RID: 2752
		public sealed class PathGroupEvent : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600D679 RID: 54905 RVA: 0x003380AC File Offset: 0x003362AC
			// Note: this type is marked as 'beforefieldinit'.
			static PathGroupEvent()
			{
				Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "PathGroupEvent");
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677824);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677825);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677826);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677827);
			}

			// Token: 0x0600D67A RID: 54906 RVA: 0x00338120 File Offset: 0x00336320
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 110018, RefRangeEnd = 110108, XrefRangeStart = 110018, XrefRangeEnd = 110108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathGroupEvent(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D67B RID: 54907 RVA: 0x0033817C File Offset: 0x0033637C
			[CallerCount(0)]
			public unsafe void Invoke(PathGroup calculatedGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D67C RID: 54908 RVA: 0x003381C0 File Offset: 0x003363C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(PathGroup calculatedGroup, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600D67D RID: 54909 RVA: 0x00338234 File Offset: 0x00336434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D67E RID: 54910 RVA: 0x0006816B File Offset: 0x0006636B
			public PathGroupEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D67F RID: 54911 RVA: 0x00068174 File Offset: 0x00066374
			public static implicit operator NavigationUtility.PathGroupEvent(System.Action<PathGroup> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.PathGroupEvent>(A_0);
			}

			// Token: 0x0600D680 RID: 54912 RVA: 0x0006817C File Offset: 0x0006637C
			public static NavigationUtility.PathGroupEvent operator +(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<NavigationUtility.PathGroupEvent>();
			}

			// Token: 0x0600D681 RID: 54913 RVA: 0x0006818A File Offset: 0x0006638A
			public static NavigationUtility.PathGroupEvent operator -(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.PathGroupEvent>();
				}
				return result;
			}

			// Token: 0x040090C0 RID: 37056
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040090C1 RID: 37057
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0;

			// Token: 0x040090C2 RID: 37058
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0;

			// Token: 0x040090C3 RID: 37059
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000AC1 RID: 2753
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D682 RID: 54914 RVA: 0x00338278 File Offset: 0x00336478
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr);
				NavigationUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9");
				NavigationUtility.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9__5_5");
				NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100677829);
				NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100677830);
			}

			// Token: 0x0600D683 RID: 54915 RVA: 0x003382F4 File Offset: 0x003364F4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D684 RID: 54916 RVA: 0x00338330 File Offset: 0x00336530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225874, XrefRangeEnd = 225879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculatePath_b__5_5(PathGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D685 RID: 54917 RVA: 0x0006819B File Offset: 0x0006639B
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004245 RID: 16965
			// (get) Token: 0x0600D686 RID: 54918 RVA: 0x00338380 File Offset: 0x00336580
			// (set) Token: 0x0600D687 RID: 54919 RVA: 0x000681A4 File Offset: 0x000663A4
			public unsafe static NavigationUtility.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004246 RID: 16966
			// (get) Token: 0x0600D688 RID: 54920 RVA: 0x003383A8 File Offset: 0x003365A8
			// (set) Token: 0x0600D689 RID: 54921 RVA: 0x000681B6 File Offset: 0x000663B6
			public unsafe static Il2CppSystem.Func<PathGroup, float> __9__5_5
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<PathGroup, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090C4 RID: 37060
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040090C5 RID: 37061
			private static readonly System.IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x040090C6 RID: 37062
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090C7 RID: 37063
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0;
		}

		// Token: 0x02000AC2 RID: 2754
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D68A RID: 54922 RVA: 0x003383D0 File Offset: 0x003365D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastGeneratedPathGroup");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "pathGroupGenerated");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "flags");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "startPosition");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "destination");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "generalSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "roadSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "navSettings");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<>9__4");
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677831);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677832);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677833);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677834);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677835);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677836);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677837);
			}

			// Token: 0x0600D68B RID: 54923 RVA: 0x00338564 File Offset: 0x00336764
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D68C RID: 54924 RVA: 0x003385A0 File Offset: 0x003367A0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D68D RID: 54925 RVA: 0x003385E4 File Offset: 0x003367E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225948, XrefRangeEnd = 225949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PathGroup_PDM_0(PathGroup pg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pg);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D68E RID: 54926 RVA: 0x00338628 File Offset: 0x00336828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225949, XrefRangeEnd = 225954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D68F RID: 54927 RVA: 0x00338668 File Offset: 0x00336868
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D690 RID: 54928 RVA: 0x003386A4 File Offset: 0x003368A4
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 225954, RefRangeEnd = 225971, XrefRangeStart = 225954, XrefRangeEnd = 225954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D691 RID: 54929 RVA: 0x003386E0 File Offset: 0x003368E0
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 225954, RefRangeEnd = 225971, XrefRangeStart = 225954, XrefRangeEnd = 225971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D692 RID: 54930 RVA: 0x000681C8 File Offset: 0x000663C8
			public __c__DisplayClass5_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004247 RID: 16967
			// (get) Token: 0x0600D693 RID: 54931 RVA: 0x0033871C File Offset: 0x0033691C
			// (set) Token: 0x0600D694 RID: 54932 RVA: 0x000681D1 File Offset: 0x000663D1
			public unsafe Path lastCalculatedPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004248 RID: 16968
			// (get) Token: 0x0600D695 RID: 54933 RVA: 0x0033874C File Offset: 0x0033694C
			// (set) Token: 0x0600D696 RID: 54934 RVA: 0x000681F0 File Offset: 0x000663F0
			public unsafe PathGroup lastGeneratedPathGroup
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004249 RID: 16969
			// (get) Token: 0x0600D697 RID: 54935 RVA: 0x0033877C File Offset: 0x0033697C
			// (set) Token: 0x0600D698 RID: 54936 RVA: 0x0006820F File Offset: 0x0006640F
			public unsafe bool pathGroupGenerated
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated)) = value;
				}
			}

			// Token: 0x1700424A RID: 16970
			// (get) Token: 0x0600D699 RID: 54937 RVA: 0x003387A4 File Offset: 0x003369A4
			// (set) Token: 0x0600D69A RID: 54938 RVA: 0x0006822A File Offset: 0x0006642A
			public unsafe DriveFlags flags
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424B RID: 16971
			// (get) Token: 0x0600D69B RID: 54939 RVA: 0x003387D4 File Offset: 0x003369D4
			// (set) Token: 0x0600D69C RID: 54940 RVA: 0x00068249 File Offset: 0x00066449
			public unsafe Vector3 startPosition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x1700424C RID: 16972
			// (get) Token: 0x0600D69D RID: 54941 RVA: 0x003387FC File Offset: 0x003369FC
			// (set) Token: 0x0600D69E RID: 54942 RVA: 0x00068264 File Offset: 0x00066464
			public unsafe Vector3 destination
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x1700424D RID: 16973
			// (get) Token: 0x0600D69F RID: 54943 RVA: 0x00338824 File Offset: 0x00336A24
			// (set) Token: 0x0600D6A0 RID: 54944 RVA: 0x0006827F File Offset: 0x0006647F
			public unsafe Seeker generalSeeker
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424E RID: 16974
			// (get) Token: 0x0600D6A1 RID: 54945 RVA: 0x00338854 File Offset: 0x00336A54
			// (set) Token: 0x0600D6A2 RID: 54946 RVA: 0x0006829E File Offset: 0x0006649E
			public unsafe Seeker roadSeeker
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700424F RID: 16975
			// (get) Token: 0x0600D6A3 RID: 54947 RVA: 0x00338884 File Offset: 0x00336A84
			// (set) Token: 0x0600D6A4 RID: 54948 RVA: 0x000682BD File Offset: 0x000664BD
			public unsafe NavigationSettings navSettings
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004250 RID: 16976
			// (get) Token: 0x0600D6A5 RID: 54949 RVA: 0x003388B4 File Offset: 0x00336AB4
			// (set) Token: 0x0600D6A6 RID: 54950 RVA: 0x000682DC File Offset: 0x000664DC
			public unsafe NavigationUtility.NavigationCalculationCallback callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.NavigationCalculationCallback>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004251 RID: 16977
			// (get) Token: 0x0600D6A7 RID: 54951 RVA: 0x003388E4 File Offset: 0x00336AE4
			// (set) Token: 0x0600D6A8 RID: 54952 RVA: 0x000682FB File Offset: 0x000664FB
			public unsafe Il2CppSystem.Func<bool> __9__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090C8 RID: 37064
			private static readonly System.IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x040090C9 RID: 37065
			private static readonly System.IntPtr NativeFieldInfoPtr_lastGeneratedPathGroup;

			// Token: 0x040090CA RID: 37066
			private static readonly System.IntPtr NativeFieldInfoPtr_pathGroupGenerated;

			// Token: 0x040090CB RID: 37067
			private static readonly System.IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x040090CC RID: 37068
			private static readonly System.IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x040090CD RID: 37069
			private static readonly System.IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x040090CE RID: 37070
			private static readonly System.IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x040090CF RID: 37071
			private static readonly System.IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x040090D0 RID: 37072
			private static readonly System.IntPtr NativeFieldInfoPtr_navSettings;

			// Token: 0x040090D1 RID: 37073
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040090D2 RID: 37074
			private static readonly System.IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040090D3 RID: 37075
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090D4 RID: 37076
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x040090D5 RID: 37077
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0;

			// Token: 0x040090D6 RID: 37078
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040090D7 RID: 37079
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0;

			// Token: 0x040090D8 RID: 37080
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0;

			// Token: 0x040090D9 RID: 37081
			private static readonly System.IntPtr NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0;

			// Token: 0x02000CBC RID: 3260
			[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0+<<CalculatePath>g__Routine|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E9A9 RID: 59817 RVA: 0x0036EFA4 File Offset: 0x0036D1A4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique()
				{
					Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<<CalculatePath>g__Routine|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>1__state");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>2__current");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>4__this");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<finalGroup>5__2");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<closestNodeLinks>5__3");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<nodeLinksClosestToLocation>5__4");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<entryPointChecks>5__5");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<checkedEntryPoints>5__6");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<groups>5__7");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<i>5__8");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<entryPoint>5__9");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<exitPointChecks>5__10");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<checkedExitPoints>5__11");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<j>5__12");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677838);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677839);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677840);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677841);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677842);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677843);
				}

				// Token: 0x0600E9AA RID: 59818 RVA: 0x0036F160 File Offset: 0x0036D360
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9AB RID: 59819 RVA: 0x0036F1A8 File Offset: 0x0036D3A8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9AC RID: 59820 RVA: 0x0036F1DC File Offset: 0x0036D3DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225879, XrefRangeEnd = 225943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004845 RID: 18501
				// (get) Token: 0x0600E9AD RID: 59821 RVA: 0x0036F218 File Offset: 0x0036D418
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9AE RID: 59822 RVA: 0x0036F258 File Offset: 0x0036D458
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225943, XrefRangeEnd = 225948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004846 RID: 18502
				// (get) Token: 0x0600E9AF RID: 59823 RVA: 0x0036F28C File Offset: 0x0036D48C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9B0 RID: 59824 RVA: 0x0007195C File Offset: 0x0006FB5C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004837 RID: 18487
				// (get) Token: 0x0600E9B1 RID: 59825 RVA: 0x0036F2CC File Offset: 0x0036D4CC
				// (set) Token: 0x0600E9B2 RID: 59826 RVA: 0x00071965 File Offset: 0x0006FB65
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004838 RID: 18488
				// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x0036F2F4 File Offset: 0x0036D4F4
				// (set) Token: 0x0600E9B4 RID: 59828 RVA: 0x00071980 File Offset: 0x0006FB80
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004839 RID: 18489
				// (get) Token: 0x0600E9B5 RID: 59829 RVA: 0x0036F324 File Offset: 0x0036D524
				// (set) Token: 0x0600E9B6 RID: 59830 RVA: 0x0007199F File Offset: 0x0006FB9F
				public unsafe NavigationUtility.__c__DisplayClass5_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700483A RID: 18490
				// (get) Token: 0x0600E9B7 RID: 59831 RVA: 0x0036F354 File Offset: 0x0036D554
				// (set) Token: 0x0600E9B8 RID: 59832 RVA: 0x000719BE File Offset: 0x0006FBBE
				public unsafe PathGroup _finalGroup_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700483B RID: 18491
				// (get) Token: 0x0600E9B9 RID: 59833 RVA: 0x0036F384 File Offset: 0x0036D584
				// (set) Token: 0x0600E9BA RID: 59834 RVA: 0x000719DD File Offset: 0x0006FBDD
				public unsafe List<NodeLink> _closestNodeLinks_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700483C RID: 18492
				// (get) Token: 0x0600E9BB RID: 59835 RVA: 0x0036F3B4 File Offset: 0x0036D5B4
				// (set) Token: 0x0600E9BC RID: 59836 RVA: 0x000719FC File Offset: 0x0006FBFC
				public unsafe List<NodeLink> _nodeLinksClosestToLocation_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700483D RID: 18493
				// (get) Token: 0x0600E9BD RID: 59837 RVA: 0x0036F3E4 File Offset: 0x0036D5E4
				// (set) Token: 0x0600E9BE RID: 59838 RVA: 0x00071A1B File Offset: 0x0006FC1B
				public unsafe int _entryPointChecks_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5)) = value;
					}
				}

				// Token: 0x1700483E RID: 18494
				// (get) Token: 0x0600E9BF RID: 59839 RVA: 0x0036F40C File Offset: 0x0036D60C
				// (set) Token: 0x0600E9C0 RID: 59840 RVA: 0x00071A36 File Offset: 0x0006FC36
				public unsafe List<Vector3> _checkedEntryPoints_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700483F RID: 18495
				// (get) Token: 0x0600E9C1 RID: 59841 RVA: 0x0036F43C File Offset: 0x0036D63C
				// (set) Token: 0x0600E9C2 RID: 59842 RVA: 0x00071A55 File Offset: 0x0006FC55
				public unsafe List<PathGroup> _groups_5__7
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathGroup>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004840 RID: 18496
				// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x0036F46C File Offset: 0x0036D66C
				// (set) Token: 0x0600E9C4 RID: 59844 RVA: 0x00071A74 File Offset: 0x0006FC74
				public unsafe int _i_5__8
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8)) = value;
					}
				}

				// Token: 0x17004841 RID: 18497
				// (get) Token: 0x0600E9C5 RID: 59845 RVA: 0x0036F494 File Offset: 0x0036D694
				// (set) Token: 0x0600E9C6 RID: 59846 RVA: 0x00071A8F File Offset: 0x0006FC8F
				public unsafe Vector3 _entryPoint_5__9
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9)) = value;
					}
				}

				// Token: 0x17004842 RID: 18498
				// (get) Token: 0x0600E9C7 RID: 59847 RVA: 0x0036F4BC File Offset: 0x0036D6BC
				// (set) Token: 0x0600E9C8 RID: 59848 RVA: 0x00071AAA File Offset: 0x0006FCAA
				public unsafe int _exitPointChecks_5__10
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10)) = value;
					}
				}

				// Token: 0x17004843 RID: 18499
				// (get) Token: 0x0600E9C9 RID: 59849 RVA: 0x0036F4E4 File Offset: 0x0036D6E4
				// (set) Token: 0x0600E9CA RID: 59850 RVA: 0x00071AC5 File Offset: 0x0006FCC5
				public unsafe List<Vector3> _checkedExitPoints_5__11
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004844 RID: 18500
				// (get) Token: 0x0600E9CB RID: 59851 RVA: 0x0036F514 File Offset: 0x0036D714
				// (set) Token: 0x0600E9CC RID: 59852 RVA: 0x00071AE4 File Offset: 0x0006FCE4
				public unsafe int _j_5__12
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12)) = value;
					}
				}

				// Token: 0x04009C5E RID: 40030
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C5F RID: 40031
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C60 RID: 40032
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C61 RID: 40033
				private static readonly System.IntPtr NativeFieldInfoPtr__finalGroup_5__2;

				// Token: 0x04009C62 RID: 40034
				private static readonly System.IntPtr NativeFieldInfoPtr__closestNodeLinks_5__3;

				// Token: 0x04009C63 RID: 40035
				private static readonly System.IntPtr NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4;

				// Token: 0x04009C64 RID: 40036
				private static readonly System.IntPtr NativeFieldInfoPtr__entryPointChecks_5__5;

				// Token: 0x04009C65 RID: 40037
				private static readonly System.IntPtr NativeFieldInfoPtr__checkedEntryPoints_5__6;

				// Token: 0x04009C66 RID: 40038
				private static readonly System.IntPtr NativeFieldInfoPtr__groups_5__7;

				// Token: 0x04009C67 RID: 40039
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__8;

				// Token: 0x04009C68 RID: 40040
				private static readonly System.IntPtr NativeFieldInfoPtr__entryPoint_5__9;

				// Token: 0x04009C69 RID: 40041
				private static readonly System.IntPtr NativeFieldInfoPtr__exitPointChecks_5__10;

				// Token: 0x04009C6A RID: 40042
				private static readonly System.IntPtr NativeFieldInfoPtr__checkedExitPoints_5__11;

				// Token: 0x04009C6B RID: 40043
				private static readonly System.IntPtr NativeFieldInfoPtr__j_5__12;

				// Token: 0x04009C6C RID: 40044
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C6D RID: 40045
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C6E RID: 40046
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C6F RID: 40047
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C70 RID: 40048
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C71 RID: 40049
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AC3 RID: 2755
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6A9 RID: 54953 RVA: 0x00338914 File Offset: 0x00336B14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677844);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677845);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677846);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677847);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677848);
			}

			// Token: 0x0600D6AA RID: 54954 RVA: 0x003389B8 File Offset: 0x00336BB8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6AB RID: 54955 RVA: 0x003389F4 File Offset: 0x00336BF4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6AC RID: 54956 RVA: 0x00338A38 File Offset: 0x00336C38
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 225954, RefRangeEnd = 225971, XrefRangeStart = 225954, XrefRangeEnd = 225971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6AD RID: 54957 RVA: 0x00338A74 File Offset: 0x00336C74
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 225954, RefRangeEnd = 225971, XrefRangeStart = 225954, XrefRangeEnd = 225971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6AE RID: 54958 RVA: 0x00338AB0 File Offset: 0x00336CB0
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 225954, RefRangeEnd = 225971, XrefRangeStart = 225954, XrefRangeEnd = 225971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6AF RID: 54959 RVA: 0x0006831A File Offset: 0x0006651A
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004252 RID: 16978
			// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x00338AEC File Offset: 0x00336CEC
			// (set) Token: 0x0600D6B1 RID: 54961 RVA: 0x00068323 File Offset: 0x00066523
			public unsafe Path lastCalculatedPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090DA RID: 37082
			private static readonly System.IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x040090DB RID: 37083
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090DC RID: 37084
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x040090DD RID: 37085
			private static readonly System.IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0;

			// Token: 0x040090DE RID: 37086
			private static readonly System.IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0;

			// Token: 0x040090DF RID: 37087
			private static readonly System.IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0;
		}

		// Token: 0x02000AC4 RID: 2756
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<GenerateNavigationGroup>d__9")]
		public sealed class _GenerateNavigationGroup_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D6B2 RID: 54962 RVA: 0x00338B1C File Offset: 0x00336D1C
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateNavigationGroup_d__9()
			{
				Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<GenerateNavigationGroup>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>1__state");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>2__current");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "startPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "destination");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "generalSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "entryPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>8__1");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "callback");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "roadSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitLink");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<destinationOnGraph>5__2");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_StartToEntry>5__3");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_EntryToExit>5__4");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677849);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677850);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677851);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677852);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677853);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677854);
			}

			// Token: 0x0600D6B3 RID: 54963 RVA: 0x00338CD8 File Offset: 0x00336ED8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GenerateNavigationGroup_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6B4 RID: 54964 RVA: 0x00338D20 File Offset: 0x00336F20
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6B5 RID: 54965 RVA: 0x00338D54 File Offset: 0x00336F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225971, XrefRangeEnd = 226013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004261 RID: 16993
			// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x00338D90 File Offset: 0x00336F90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D6B7 RID: 54967 RVA: 0x00338DD0 File Offset: 0x00336FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226013, XrefRangeEnd = 226018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004262 RID: 16994
			// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x00338E04 File Offset: 0x00337004
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D6B9 RID: 54969 RVA: 0x00068342 File Offset: 0x00066542
			public _GenerateNavigationGroup_d__9(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004253 RID: 16979
			// (get) Token: 0x0600D6BA RID: 54970 RVA: 0x00338E44 File Offset: 0x00337044
			// (set) Token: 0x0600D6BB RID: 54971 RVA: 0x0006834B File Offset: 0x0006654B
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004254 RID: 16980
			// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x00338E6C File Offset: 0x0033706C
			// (set) Token: 0x0600D6BD RID: 54973 RVA: 0x00068366 File Offset: 0x00066566
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004255 RID: 16981
			// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x00338E9C File Offset: 0x0033709C
			// (set) Token: 0x0600D6BF RID: 54975 RVA: 0x00068385 File Offset: 0x00066585
			public unsafe Vector3 startPoint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint)) = value;
				}
			}

			// Token: 0x17004256 RID: 16982
			// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x00338EC4 File Offset: 0x003370C4
			// (set) Token: 0x0600D6C1 RID: 54977 RVA: 0x000683A0 File Offset: 0x000665A0
			public unsafe Vector3 destination
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17004257 RID: 16983
			// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x00338EEC File Offset: 0x003370EC
			// (set) Token: 0x0600D6C3 RID: 54979 RVA: 0x000683BB File Offset: 0x000665BB
			public unsafe Seeker generalSeeker
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004258 RID: 16984
			// (get) Token: 0x0600D6C4 RID: 54980 RVA: 0x00338F1C File Offset: 0x0033711C
			// (set) Token: 0x0600D6C5 RID: 54981 RVA: 0x000683DA File Offset: 0x000665DA
			public unsafe Vector3 entryPoint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint)) = value;
				}
			}

			// Token: 0x17004259 RID: 16985
			// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x00338F44 File Offset: 0x00337144
			// (set) Token: 0x0600D6C7 RID: 54983 RVA: 0x000683F5 File Offset: 0x000665F5
			public unsafe NavigationUtility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425A RID: 16986
			// (get) Token: 0x0600D6C8 RID: 54984 RVA: 0x00338F74 File Offset: 0x00337174
			// (set) Token: 0x0600D6C9 RID: 54985 RVA: 0x00068414 File Offset: 0x00066614
			public unsafe NavigationUtility.PathGroupEvent callback
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.PathGroupEvent>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425B RID: 16987
			// (get) Token: 0x0600D6CA RID: 54986 RVA: 0x00338FA4 File Offset: 0x003371A4
			// (set) Token: 0x0600D6CB RID: 54987 RVA: 0x00068433 File Offset: 0x00066633
			public unsafe Seeker roadSeeker
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425C RID: 16988
			// (get) Token: 0x0600D6CC RID: 54988 RVA: 0x00338FD4 File Offset: 0x003371D4
			// (set) Token: 0x0600D6CD RID: 54989 RVA: 0x00068452 File Offset: 0x00066652
			public unsafe NodeLink exitLink
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodeLink>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425D RID: 16989
			// (get) Token: 0x0600D6CE RID: 54990 RVA: 0x00339004 File Offset: 0x00337204
			// (set) Token: 0x0600D6CF RID: 54991 RVA: 0x00068471 File Offset: 0x00066671
			public unsafe Vector3 exitPoint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint)) = value;
				}
			}

			// Token: 0x1700425E RID: 16990
			// (get) Token: 0x0600D6D0 RID: 54992 RVA: 0x0033902C File Offset: 0x0033722C
			// (set) Token: 0x0600D6D1 RID: 54993 RVA: 0x0006848C File Offset: 0x0006668C
			public unsafe Vector3 _destinationOnGraph_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2)) = value;
				}
			}

			// Token: 0x1700425F RID: 16991
			// (get) Token: 0x0600D6D2 RID: 54994 RVA: 0x00339054 File Offset: 0x00337254
			// (set) Token: 0x0600D6D3 RID: 54995 RVA: 0x000684A7 File Offset: 0x000666A7
			public unsafe Path _path_StartToEntry_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004260 RID: 16992
			// (get) Token: 0x0600D6D4 RID: 54996 RVA: 0x00339084 File Offset: 0x00337284
			// (set) Token: 0x0600D6D5 RID: 54997 RVA: 0x000684C6 File Offset: 0x000666C6
			public unsafe Path _path_EntryToExit_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090E0 RID: 37088
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090E1 RID: 37089
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090E2 RID: 37090
			private static readonly System.IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x040090E3 RID: 37091
			private static readonly System.IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x040090E4 RID: 37092
			private static readonly System.IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x040090E5 RID: 37093
			private static readonly System.IntPtr NativeFieldInfoPtr_entryPoint;

			// Token: 0x040090E6 RID: 37094
			private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040090E7 RID: 37095
			private static readonly System.IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040090E8 RID: 37096
			private static readonly System.IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x040090E9 RID: 37097
			private static readonly System.IntPtr NativeFieldInfoPtr_exitLink;

			// Token: 0x040090EA RID: 37098
			private static readonly System.IntPtr NativeFieldInfoPtr_exitPoint;

			// Token: 0x040090EB RID: 37099
			private static readonly System.IntPtr NativeFieldInfoPtr__destinationOnGraph_5__2;

			// Token: 0x040090EC RID: 37100
			private static readonly System.IntPtr NativeFieldInfoPtr__path_StartToEntry_5__3;

			// Token: 0x040090ED RID: 37101
			private static readonly System.IntPtr NativeFieldInfoPtr__path_EntryToExit_5__4;

			// Token: 0x040090EE RID: 37102
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090EF RID: 37103
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090F0 RID: 37104
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090F1 RID: 37105
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090F2 RID: 37106
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090F3 RID: 37107
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
