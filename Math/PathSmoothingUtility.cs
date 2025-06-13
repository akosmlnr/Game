using System;
using Il2CppFluffyUnderware.Curvy;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Math
{
	// Token: 0x02000399 RID: 921
	public class PathSmoothingUtility : MonoBehaviour
	{
		// Token: 0x0600473C RID: 18236 RVA: 0x0015FD88 File Offset: 0x0015DF88
		// Note: this type is marked as 'beforefieldinit'.
		static PathSmoothingUtility()
		{
			Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Math", "PathSmoothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr);
			PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "MinControlPointDistance");
			PathSmoothingUtility.NativeFieldInfoPtr_spline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "spline");
			PathSmoothingUtility.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100672136);
			PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100672137);
			PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100672138);
			PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100672139);
			PathSmoothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100672140);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x0015FE44 File Offset: 0x0015E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162490, XrefRangeEnd = 162508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0015FE78 File Offset: 0x0015E078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162557, RefRangeEnd = 162558, XrefRangeStart = 162508, XrefRangeEnd = 162557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 5f)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxCPDistance;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr2) : null;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0015FECC File Offset: 0x0015E0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162558, XrefRangeEnd = 162569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0015FF20 File Offset: 0x0015E120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162586, RefRangeEnd = 162587, XrefRangeStart = 162569, XrefRangeEnd = 162586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxDistance;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0015FF74 File Offset: 0x0015E174
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathSmoothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x00022804 File Offset: 0x00020A04
		public PathSmoothingUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x0015FFB0 File Offset: 0x0015E1B0
		// (set) Token: 0x06004744 RID: 18244 RVA: 0x0002280D File Offset: 0x00020A0D
		public unsafe static float MinControlPointDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&value));
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x0015FFCC File Offset: 0x0015E1CC
		// (set) Token: 0x06004746 RID: 18246 RVA: 0x0002281B File Offset: 0x00020A1B
		public unsafe static CurvySpline spline
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_spline, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurvySpline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_spline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FC2 RID: 12226
		private static readonly System.IntPtr NativeFieldInfoPtr_MinControlPointDistance;

		// Token: 0x04002FC3 RID: 12227
		private static readonly System.IntPtr NativeFieldInfoPtr_spline;

		// Token: 0x04002FC4 RID: 12228
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0;

		// Token: 0x04002FC6 RID: 12230
		private static readonly System.IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly System.IntPtr NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009C0 RID: 2496
		public class SmoothedPath : Il2CppSystem.Object
		{
			// Token: 0x0600CEBF RID: 52927 RVA: 0x003228E8 File Offset: 0x00320AE8
			// Note: this type is marked as 'beforefieldinit'.
			static SmoothedPath()
			{
				Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "SmoothedPath");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr);
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "MARGIN");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "vectorPath");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "segmentBounds");
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100672141);
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100672142);
			}

			// Token: 0x0600CEC0 RID: 52928 RVA: 0x00322978 File Offset: 0x00320B78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 162472, RefRangeEnd = 162473, XrefRangeStart = 162453, XrefRangeEnd = 162472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InitializePath()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEC1 RID: 52929 RVA: 0x003229AC File Offset: 0x00320BAC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 162488, RefRangeEnd = 162490, XrefRangeStart = 162473, XrefRangeEnd = 162488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SmoothedPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEC2 RID: 52930 RVA: 0x00064391 File Offset: 0x00062591
			public SmoothedPath(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004024 RID: 16420
			// (get) Token: 0x0600CEC3 RID: 52931 RVA: 0x003229E8 File Offset: 0x00320BE8
			// (set) Token: 0x0600CEC4 RID: 52932 RVA: 0x0006439A File Offset: 0x0006259A
			public unsafe static float MARGIN
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&value));
				}
			}

			// Token: 0x17004025 RID: 16421
			// (get) Token: 0x0600CEC5 RID: 52933 RVA: 0x00322A04 File Offset: 0x00320C04
			// (set) Token: 0x0600CEC6 RID: 52934 RVA: 0x000643A8 File Offset: 0x000625A8
			public unsafe List<Vector3> vectorPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004026 RID: 16422
			// (get) Token: 0x0600CEC7 RID: 52935 RVA: 0x00322A34 File Offset: 0x00320C34
			// (set) Token: 0x0600CEC8 RID: 52936 RVA: 0x000643C7 File Offset: 0x000625C7
			public unsafe List<Bounds> segmentBounds
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bounds>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BF3 RID: 35827
			private static readonly System.IntPtr NativeFieldInfoPtr_MARGIN;

			// Token: 0x04008BF4 RID: 35828
			private static readonly System.IntPtr NativeFieldInfoPtr_vectorPath;

			// Token: 0x04008BF5 RID: 35829
			private static readonly System.IntPtr NativeFieldInfoPtr_segmentBounds;

			// Token: 0x04008BF6 RID: 35830
			private static readonly System.IntPtr NativeMethodInfoPtr_InitializePath_Public_Void_0;

			// Token: 0x04008BF7 RID: 35831
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
