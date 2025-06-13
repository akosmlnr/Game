using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200047F RID: 1151
	public static class NavMeshUtility : Il2CppSystem.Object
	{
		// Token: 0x060062DC RID: 25308 RVA: 0x001C5390 File Offset: 0x001C3590
		// Note: this type is marked as 'beforefieldinit'.
		static NavMeshUtility()
		{
			Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "NavMeshUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr);
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_MAX_DISTANCE");
			NavMeshUtility.NativeFieldInfoPtr_SampleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SampleCache");
			NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "sampleCacheKeys");
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_CACHE_MAX_SQR_DIST");
			NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "MAX_CACHE_SIZE");
			NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675966);
			NavMeshUtility.NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675967);
			NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675968);
			NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675969);
			NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675970);
			NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675971);
			NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675972);
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x001C54B0 File Offset: 0x001C36B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204175, XrefRangeEnd = 204184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPathLength(NavMeshPath path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060062DE RID: 25310 RVA: 0x001C54F4 File Offset: 0x001C36F4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 204220, RefRangeEnd = 204246, XrefRangeStart = 204184, XrefRangeEnd = 204220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetAccessPoint(ITransitEntity entity, NPC npc)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x060062DF RID: 25311 RVA: 0x001C554C File Offset: 0x001C374C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204267, RefRangeEnd = 204272, XrefRangeStart = 204246, XrefRangeEnd = 204267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distanceThreshold;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060062E0 RID: 25312 RVA: 0x001C55B0 File Offset: 0x001C37B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 204278, RefRangeEnd = 204281, XrefRangeStart = 204272, XrefRangeEnd = 204278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNavMeshAgentID(string name)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060062E1 RID: 25313 RVA: 0x001C55F4 File Offset: 0x001C37F4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 204305, RefRangeEnd = 204313, XrefRangeStart = 204281, XrefRangeEnd = 204305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sourcePosition;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref areaMask;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref useCache;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060062E2 RID: 25314 RVA: 0x001C566C File Offset: 0x001C386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204313, XrefRangeEnd = 204316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref precision;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060062E3 RID: 25315 RVA: 0x001C56B8 File Offset: 0x001C38B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204325, RefRangeEnd = 204326, XrefRangeStart = 204316, XrefRangeEnd = 204325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCache()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062E4 RID: 25316 RVA: 0x0002E7F4 File Offset: 0x0002C9F4
		public NavMeshUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x060062E5 RID: 25317 RVA: 0x001C56E0 File Offset: 0x001C38E0
		// (set) Token: 0x060062E6 RID: 25318 RVA: 0x0002E7FD File Offset: 0x0002C9FD
		public unsafe static float SAMPLE_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x060062E7 RID: 25319 RVA: 0x001C56FC File Offset: 0x001C38FC
		// (set) Token: 0x060062E8 RID: 25320 RVA: 0x0002E80B File Offset: 0x0002CA0B
		public unsafe static Dictionary<Vector3, Vector3> SampleCache
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x060062E9 RID: 25321 RVA: 0x001C5724 File Offset: 0x001C3924
		// (set) Token: 0x060062EA RID: 25322 RVA: 0x0002E81D File Offset: 0x0002CA1D
		public unsafe static List<Vector3> sampleCacheKeys
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x060062EB RID: 25323 RVA: 0x001C574C File Offset: 0x001C394C
		// (set) Token: 0x060062EC RID: 25324 RVA: 0x0002E82F File Offset: 0x0002CA2F
		public unsafe static float SAMPLE_CACHE_MAX_SQR_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&value));
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x060062ED RID: 25325 RVA: 0x001C5768 File Offset: 0x001C3968
		// (set) Token: 0x060062EE RID: 25326 RVA: 0x0002E83D File Offset: 0x0002CA3D
		public unsafe static float MAX_CACHE_SIZE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x0400437C RID: 17276
		private static readonly System.IntPtr NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE;

		// Token: 0x0400437D RID: 17277
		private static readonly System.IntPtr NativeFieldInfoPtr_SampleCache;

		// Token: 0x0400437E RID: 17278
		private static readonly System.IntPtr NativeFieldInfoPtr_sampleCacheKeys;

		// Token: 0x0400437F RID: 17279
		private static readonly System.IntPtr NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST;

		// Token: 0x04004380 RID: 17280
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CACHE_SIZE;

		// Token: 0x04004381 RID: 17281
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0;

		// Token: 0x04004382 RID: 17282
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0;

		// Token: 0x04004383 RID: 17283
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0;

		// Token: 0x04004384 RID: 17284
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0;

		// Token: 0x04004385 RID: 17285
		private static readonly System.IntPtr NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0;

		// Token: 0x04004386 RID: 17286
		private static readonly System.IntPtr NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0;

		// Token: 0x04004387 RID: 17287
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;
	}
}
