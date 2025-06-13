using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004FE RID: 1278
	public class Zone : MonoBehaviour
	{
		// Token: 0x06006EAA RID: 28330 RVA: 0x001ECBE0 File Offset: 0x001EADE0
		// Note: this type is marked as 'beforefieldinit'.
		static Zone()
		{
			Il2CppClassPointerStore<Zone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "Zone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zone>.NativeClassPtr);
			Zone.NativeFieldInfoPtr_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "UPDATE_INTERVAL");
			Zone.NativeFieldInfoPtr_PointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "PointContainer");
			Zone.NativeFieldInfoPtr_IsClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "IsClosed");
			Zone.NativeFieldInfoPtr_VerticalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "VerticalSize");
			Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "<LocalPlayerDistance>k__BackingField");
			Zone.NativeFieldInfoPtr_ZoneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "ZoneColor");
			Zone.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "points");
			Zone.NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677372);
			Zone.NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677373);
			Zone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677374);
			Zone.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677375);
			Zone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677376);
			Zone.NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677377);
			Zone.NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677378);
			Zone.NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677379);
			Zone.NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677380);
			Zone.NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677381);
			Zone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677382);
			Zone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677383);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677384);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677385);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677386);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677387);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677388);
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06006EAB RID: 28331 RVA: 0x001ECDF0 File Offset: 0x001EAFF0
		// (set) Token: 0x06006EAC RID: 28332 RVA: 0x001ECE2C File Offset: 0x001EB02C
		public unsafe float LocalPlayerDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31486, RefRangeEnd = 31487, XrefRangeStart = 31486, XrefRangeEnd = 31487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31487, RefRangeEnd = 31489, XrefRangeStart = 31487, XrefRangeEnd = 31489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x001ECE6C File Offset: 0x001EB06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221413, XrefRangeEnd = 221418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x001ECEA0 File Offset: 0x001EB0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221418, XrefRangeEnd = 221449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x001ECED4 File Offset: 0x001EB0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221449, XrefRangeEnd = 221471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x001ECF08 File Offset: 0x001EB108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 221483, RefRangeEnd = 221486, XrefRangeStart = 221471, XrefRangeEnd = 221483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x001ECF48 File Offset: 0x001EB148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221486, XrefRangeEnd = 221489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x001ECF94 File Offset: 0x001EB194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221563, RefRangeEnd = 221565, XrefRangeStart = 221489, XrefRangeEnd = 221563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Tuple<Vector3, Vector3>>(intPtr2) : null;
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x001ECFD4 File Offset: 0x001EB1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221565, XrefRangeEnd = 221570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsidePolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x001ED030 File Offset: 0x001EB230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221574, RefRangeEnd = 221576, XrefRangeStart = 221570, XrefRangeEnd = 221574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateWindingNumber(Il2CppStructArray<Vector2> polygon, Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polygon);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x001ED08C File Offset: 0x001EB28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221591, RefRangeEnd = 221592, XrefRangeStart = 221576, XrefRangeEnd = 221591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetClosestPointOnPolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x001ED0E8 File Offset: 0x001EB2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221592, XrefRangeEnd = 221595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Zone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zone>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x001ED124 File Offset: 0x001EB324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221595, XrefRangeEnd = 221596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x001ED180 File Offset: 0x001EB380
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x001ED1DC File Offset: 0x001EB3DC
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1(Vector2 start, Vector2 end, Vector2 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x001ED238 File Offset: 0x001EB438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221596, RefRangeEnd = 221598, XrefRangeStart = 221596, XrefRangeEnd = 221596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0(Vector2 start, Vector2 end, Vector2 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x001ED294 File Offset: 0x001EB494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221608, RefRangeEnd = 221610, XrefRangeStart = 221598, XrefRangeEnd = 221608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lineStart;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lineEnd;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x00034298 File Offset: 0x00032498
		public Zone(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06006EBD RID: 28349 RVA: 0x001ED2F0 File Offset: 0x001EB4F0
		// (set) Token: 0x06006EBE RID: 28350 RVA: 0x000342A1 File Offset: 0x000324A1
		public unsafe static float UPDATE_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Zone.NativeFieldInfoPtr_UPDATE_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Zone.NativeFieldInfoPtr_UPDATE_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06006EBF RID: 28351 RVA: 0x001ED30C File Offset: 0x001EB50C
		// (set) Token: 0x06006EC0 RID: 28352 RVA: 0x000342AF File Offset: 0x000324AF
		public unsafe Transform PointContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_PointContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_PointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06006EC1 RID: 28353 RVA: 0x001ED33C File Offset: 0x001EB53C
		// (set) Token: 0x06006EC2 RID: 28354 RVA: 0x000342CE File Offset: 0x000324CE
		public unsafe bool IsClosed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_IsClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_IsClosed)) = value;
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x001ED364 File Offset: 0x001EB564
		// (set) Token: 0x06006EC4 RID: 28356 RVA: 0x000342E9 File Offset: 0x000324E9
		public unsafe float VerticalSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_VerticalSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_VerticalSize)) = value;
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06006EC5 RID: 28357 RVA: 0x001ED38C File Offset: 0x001EB58C
		// (set) Token: 0x06006EC6 RID: 28358 RVA: 0x00034304 File Offset: 0x00032504
		public unsafe float _LocalPlayerDistance_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField)) = value;
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006EC7 RID: 28359 RVA: 0x001ED3B4 File Offset: 0x001EB5B4
		// (set) Token: 0x06006EC8 RID: 28360 RVA: 0x0003431F File Offset: 0x0003251F
		public unsafe Color ZoneColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_ZoneColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_ZoneColor)) = value;
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x001ED3DC File Offset: 0x001EB5DC
		// (set) Token: 0x06006ECA RID: 28362 RVA: 0x0003433A File Offset: 0x0003253A
		public unsafe Il2CppStructArray<Vector3> points
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_points);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BA5 RID: 19365
		private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_INTERVAL;

		// Token: 0x04004BA6 RID: 19366
		private static readonly System.IntPtr NativeFieldInfoPtr_PointContainer;

		// Token: 0x04004BA7 RID: 19367
		private static readonly System.IntPtr NativeFieldInfoPtr_IsClosed;

		// Token: 0x04004BA8 RID: 19368
		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalSize;

		// Token: 0x04004BA9 RID: 19369
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField;

		// Token: 0x04004BAA RID: 19370
		private static readonly System.IntPtr NativeFieldInfoPtr_ZoneColor;

		// Token: 0x04004BAB RID: 19371
		private static readonly System.IntPtr NativeFieldInfoPtr_points;

		// Token: 0x04004BAC RID: 19372
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0;

		// Token: 0x04004BAD RID: 19373
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0;

		// Token: 0x04004BAE RID: 19374
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004BAF RID: 19375
		private static readonly System.IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04004BB0 RID: 19376
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004BB1 RID: 19377
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04004BB2 RID: 19378
		private static readonly System.IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0;

		// Token: 0x04004BB3 RID: 19379
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0;

		// Token: 0x04004BB4 RID: 19380
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x04004BB5 RID: 19381
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0;

		// Token: 0x04004BB6 RID: 19382
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x04004BB7 RID: 19383
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004BB8 RID: 19384
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x04004BB9 RID: 19385
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x04004BBA RID: 19386
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1;

		// Token: 0x04004BBB RID: 19387
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0;

		// Token: 0x04004BBC RID: 19388
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x02000AB1 RID: 2737
		[ObfuscatedName("ScheduleOne.Audio.Zone+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D605 RID: 54789 RVA: 0x00336C5C File Offset: 0x00334E5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Zone.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Zone>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr);
				Zone.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9");
				Zone.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_0");
				Zone.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_1");
				Zone.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_2");
				Zone.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_3");
				Zone.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677390);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677391);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677392);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677393);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677394);
			}

			// Token: 0x0600D606 RID: 54790 RVA: 0x00336D50 File Offset: 0x00334F50
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D607 RID: 54791 RVA: 0x00336D8C File Offset: 0x00334F8C
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_0(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref p;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D608 RID: 54792 RVA: 0x00336DD8 File Offset: 0x00334FD8
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_1(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref p;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D609 RID: 54793 RVA: 0x00336E24 File Offset: 0x00335024
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_2(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref p;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D60A RID: 54794 RVA: 0x00336E70 File Offset: 0x00335070
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_3(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref p;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D60B RID: 54795 RVA: 0x00067E30 File Offset: 0x00066030
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422A RID: 16938
			// (get) Token: 0x0600D60C RID: 54796 RVA: 0x00336EBC File Offset: 0x003350BC
			// (set) Token: 0x0600D60D RID: 54797 RVA: 0x00067E39 File Offset: 0x00066039
			public unsafe static Zone.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Zone.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422B RID: 16939
			// (get) Token: 0x0600D60E RID: 54798 RVA: 0x00336EE4 File Offset: 0x003350E4
			// (set) Token: 0x0600D60F RID: 54799 RVA: 0x00067E4B File Offset: 0x0006604B
			public unsafe static Il2CppSystem.Func<Vector3, float> __9__15_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422C RID: 16940
			// (get) Token: 0x0600D610 RID: 54800 RVA: 0x00336F0C File Offset: 0x0033510C
			// (set) Token: 0x0600D611 RID: 54801 RVA: 0x00067E5D File Offset: 0x0006605D
			public unsafe static Il2CppSystem.Func<Vector3, float> __9__15_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422D RID: 16941
			// (get) Token: 0x0600D612 RID: 54802 RVA: 0x00336F34 File Offset: 0x00335134
			// (set) Token: 0x0600D613 RID: 54803 RVA: 0x00067E6F File Offset: 0x0006606F
			public unsafe static Il2CppSystem.Func<Vector3, float> __9__15_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700422E RID: 16942
			// (get) Token: 0x0600D614 RID: 54804 RVA: 0x00336F5C File Offset: 0x0033515C
			// (set) Token: 0x0600D615 RID: 54805 RVA: 0x00067E81 File Offset: 0x00066081
			public unsafe static Il2CppSystem.Func<Vector3, float> __9__15_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400907B RID: 36987
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400907C RID: 36988
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400907D RID: 36989
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x0400907E RID: 36990
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x0400907F RID: 36991
			private static readonly System.IntPtr NativeFieldInfoPtr___9__15_3;

			// Token: 0x04009080 RID: 36992
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009081 RID: 36993
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0;

			// Token: 0x04009082 RID: 36994
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0;

			// Token: 0x04009083 RID: 36995
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0;

			// Token: 0x04009084 RID: 36996
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0;
		}
	}
}
