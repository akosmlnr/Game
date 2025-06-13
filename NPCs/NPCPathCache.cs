using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002FB RID: 763
	public class NPCPathCache : Il2CppSystem.Object
	{
		// Token: 0x06003766 RID: 14182 RVA: 0x00126644 File Offset: 0x00124844
		// Note: this type is marked as 'beforefieldinit'.
		static NPCPathCache()
		{
			Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCPathCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr);
			NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "<Paths>k__BackingField");
			NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669671);
			NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669672);
			NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669673);
			NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669674);
			NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, 100669675);
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x001266EC File Offset: 0x001248EC
		// (set) Token: 0x06003768 RID: 14184 RVA: 0x0012672C File Offset: 0x0012492C
		public unsafe List<NPCPathCache.PathCache> Paths
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00126770 File Offset: 0x00124970
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143692, RefRangeEnd = 143693, XrefRangeStart = 143682, XrefRangeEnd = 143692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sqrMaxDistance;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x001267D8 File Offset: 0x001249D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143693, XrefRangeEnd = 143701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00126838 File Offset: 0x00124A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143701, XrefRangeEnd = 143709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCPathCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x0001CD98 File Offset: 0x0001AF98
		public NPCPathCache(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x00126874 File Offset: 0x00124A74
		// (set) Token: 0x0600376E RID: 14190 RVA: 0x0001CDA1 File Offset: 0x0001AFA1
		public unsafe List<NPCPathCache.PathCache> _Paths_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCPathCache.PathCache>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.NativeFieldInfoPtr__Paths_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400243B RID: 9275
		private static readonly System.IntPtr NativeFieldInfoPtr__Paths_k__BackingField;

		// Token: 0x0400243C RID: 9276
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Paths_Public_get_List_1_PathCache_0;

		// Token: 0x0400243D RID: 9277
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Paths_Private_set_Void_List_1_PathCache_0;

		// Token: 0x0400243E RID: 9278
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPath_Public_NavMeshPath_Vector3_Vector3_Single_0;

		// Token: 0x0400243F RID: 9279
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPath_Public_Void_Vector3_Vector3_NavMeshPath_0;

		// Token: 0x04002440 RID: 9280
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000971 RID: 2417
		[System.Serializable]
		public class PathCache : Il2CppSystem.Object
		{
			// Token: 0x0600CB90 RID: 52112 RVA: 0x00318CDC File Offset: 0x00316EDC
			// Note: this type is marked as 'beforefieldinit'.
			static PathCache()
			{
				Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCPathCache>.NativeClassPtr, "PathCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr);
				NPCPathCache.PathCache.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Start");
				NPCPathCache.PathCache.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "End");
				NPCPathCache.PathCache.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, "Path");
				NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr, 100669676);
			}

			// Token: 0x0600CB91 RID: 52113 RVA: 0x00318D58 File Offset: 0x00316F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143680, XrefRangeEnd = 143682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathCache(Vector3 start, Vector3 end, NavMeshPath path) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCPathCache.PathCache>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCPathCache.PathCache.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB92 RID: 52114 RVA: 0x00062C3D File Offset: 0x00060E3D
			public PathCache(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F1C RID: 16156
			// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x00318DC0 File Offset: 0x00316FC0
			// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x00062C46 File Offset: 0x00060E46
			public unsafe Vector3 Start
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x17003F1D RID: 16157
			// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x00318DE8 File Offset: 0x00316FE8
			// (set) Token: 0x0600CB96 RID: 52118 RVA: 0x00062C61 File Offset: 0x00060E61
			public unsafe Vector3 End
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x17003F1E RID: 16158
			// (get) Token: 0x0600CB97 RID: 52119 RVA: 0x00318E10 File Offset: 0x00317010
			// (set) Token: 0x0600CB98 RID: 52120 RVA: 0x00062C7C File Offset: 0x00060E7C
			public unsafe NavMeshPath Path
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCPathCache.PathCache.NativeFieldInfoPtr_Path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089DB RID: 35291
			private static readonly System.IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x040089DC RID: 35292
			private static readonly System.IntPtr NativeFieldInfoPtr_End;

			// Token: 0x040089DD RID: 35293
			private static readonly System.IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x040089DE RID: 35294
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_NavMeshPath_0;
		}
	}
}
