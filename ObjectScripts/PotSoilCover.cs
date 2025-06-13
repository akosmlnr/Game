using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000760 RID: 1888
	public class PotSoilCover : MonoBehaviour
	{
		// Token: 0x0600AC76 RID: 44150 RVA: 0x002B2D6C File Offset: 0x002B0F6C
		// Note: this type is marked as 'beforefieldinit'.
		static PotSoilCover()
		{
			Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "PotSoilCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr);
			PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "TEXTURE_SIZE");
			PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "POUR_RADIUS");
			PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "UPDATES_PER_SECOND");
			PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "COVERAGE_THRESHOLD");
			PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "BASE_COVERAGE");
			PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "SUCCESS_COVERAGE_THRESHOLD");
			PotSoilCover.NativeFieldInfoPtr_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "DELAY");
			PotSoilCover.NativeFieldInfoPtr_CurrentCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "CurrentCoverage");
			PotSoilCover.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "Radius");
			PotSoilCover.NativeFieldInfoPtr_MeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "MeshRenderer");
			PotSoilCover.NativeFieldInfoPtr_PourMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "PourMask");
			PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "onSufficientCoverage");
			PotSoilCover.NativeFieldInfoPtr_queued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "queued");
			PotSoilCover.NativeFieldInfoPtr_queuedWorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "queuedWorldPos");
			PotSoilCover.NativeFieldInfoPtr_mainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "mainTex");
			PotSoilCover.NativeFieldInfoPtr_relative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "relative");
			PotSoilCover.NativeFieldInfoPtr_vector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "vector2");
			PotSoilCover.NativeFieldInfoPtr_normalizedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "normalizedOffset");
			PotSoilCover.NativeFieldInfoPtr_originPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "originPixel");
			PotSoilCover.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684536);
			PotSoilCover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684537);
			PotSoilCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684538);
			PotSoilCover.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684539);
			PotSoilCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684540);
			PotSoilCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684541);
			PotSoilCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684542);
			PotSoilCover.NativeMethodInfoPtr_Blank_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684543);
			PotSoilCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684544);
			PotSoilCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684545);
			PotSoilCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684546);
			PotSoilCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684547);
			PotSoilCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100684548);
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x002B301C File Offset: 0x002B121C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x002B3050 File Offset: 0x002B1250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299445, XrefRangeEnd = 299451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x002B3084 File Offset: 0x002B1284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 299460, RefRangeEnd = 299462, XrefRangeStart = 299451, XrefRangeEnd = 299460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureAppearance(Color col, float transparency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref transparency;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x002B30D0 File Offset: 0x002B12D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299475, RefRangeEnd = 299476, XrefRangeStart = 299462, XrefRangeEnd = 299475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x002B3104 File Offset: 0x002B1304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299476, RefRangeEnd = 299477, XrefRangeStart = 299476, XrefRangeEnd = 299476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePour(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldSpacePosition;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x002B3144 File Offset: 0x002B1344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299477, RefRangeEnd = 299478, XrefRangeStart = 299477, XrefRangeEnd = 299477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNormalizedProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x002B3180 File Offset: 0x002B1380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299478, XrefRangeEnd = 299483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x002B31C0 File Offset: 0x002B13C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299483, XrefRangeEnd = 299498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Blank_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x002B31F4 File Offset: 0x002B13F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299498, XrefRangeEnd = 299510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldSpace;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x002B3234 File Offset: 0x002B1434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299510, XrefRangeEnd = 299524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldSpace;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x002B3274 File Offset: 0x002B1474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299525, RefRangeEnd = 299526, XrefRangeStart = 299524, XrefRangeEnd = 299525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPourMaskValue(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref y;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x002B32CC File Offset: 0x002B14CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299526, XrefRangeEnd = 299527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCoverage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x002B3308 File Offset: 0x002B1508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299527, XrefRangeEnd = 299530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotSoilCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x00054B28 File Offset: 0x00052D28
		public PotSoilCover(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x002B3344 File Offset: 0x002B1544
		// (set) Token: 0x0600AC86 RID: 44166 RVA: 0x00054B31 File Offset: 0x00052D31
		public unsafe static int TEXTURE_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x002B3360 File Offset: 0x002B1560
		// (set) Token: 0x0600AC88 RID: 44168 RVA: 0x00054B3F File Offset: 0x00052D3F
		public unsafe static int POUR_RADIUS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600AC89 RID: 44169 RVA: 0x002B337C File Offset: 0x002B157C
		// (set) Token: 0x0600AC8A RID: 44170 RVA: 0x00054B4D File Offset: 0x00052D4D
		public unsafe static int UPDATES_PER_SECOND
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND, (void*)(&value));
			}
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x002B3398 File Offset: 0x002B1598
		// (set) Token: 0x0600AC8C RID: 44172 RVA: 0x00054B5B File Offset: 0x00052D5B
		public unsafe static float COVERAGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x002B33B4 File Offset: 0x002B15B4
		// (set) Token: 0x0600AC8E RID: 44174 RVA: 0x00054B69 File Offset: 0x00052D69
		public unsafe static float BASE_COVERAGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE, (void*)(&value));
			}
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x002B33D0 File Offset: 0x002B15D0
		// (set) Token: 0x0600AC90 RID: 44176 RVA: 0x00054B77 File Offset: 0x00052D77
		public unsafe static float SUCCESS_COVERAGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600AC91 RID: 44177 RVA: 0x002B33EC File Offset: 0x002B15EC
		// (set) Token: 0x0600AC92 RID: 44178 RVA: 0x00054B85 File Offset: 0x00052D85
		public unsafe static float DELAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_DELAY, (void*)(&value));
			}
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600AC93 RID: 44179 RVA: 0x002B3408 File Offset: 0x002B1608
		// (set) Token: 0x0600AC94 RID: 44180 RVA: 0x00054B93 File Offset: 0x00052D93
		public unsafe float CurrentCoverage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_CurrentCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_CurrentCoverage)) = value;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600AC95 RID: 44181 RVA: 0x002B3430 File Offset: 0x002B1630
		// (set) Token: 0x0600AC96 RID: 44182 RVA: 0x00054BAE File Offset: 0x00052DAE
		public unsafe float Radius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x002B3458 File Offset: 0x002B1658
		// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x00054BC9 File Offset: 0x00052DC9
		public unsafe MeshRenderer MeshRenderer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_MeshRenderer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_MeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x002B3488 File Offset: 0x002B1688
		// (set) Token: 0x0600AC9A RID: 44186 RVA: 0x00054BE8 File Offset: 0x00052DE8
		public unsafe Texture2D PourMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_PourMask);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_PourMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600AC9B RID: 44187 RVA: 0x002B34B8 File Offset: 0x002B16B8
		// (set) Token: 0x0600AC9C RID: 44188 RVA: 0x00054C07 File Offset: 0x00052E07
		public unsafe UnityEvent onSufficientCoverage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600AC9D RID: 44189 RVA: 0x002B34E8 File Offset: 0x002B16E8
		// (set) Token: 0x0600AC9E RID: 44190 RVA: 0x00054C26 File Offset: 0x00052E26
		public unsafe bool queued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queued)) = value;
			}
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600AC9F RID: 44191 RVA: 0x002B3510 File Offset: 0x002B1710
		// (set) Token: 0x0600ACA0 RID: 44192 RVA: 0x00054C41 File Offset: 0x00052E41
		public unsafe Vector3 queuedWorldPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queuedWorldPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queuedWorldPos)) = value;
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x002B3538 File Offset: 0x002B1738
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x00054C5C File Offset: 0x00052E5C
		public unsafe Texture2D mainTex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_mainTex);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_mainTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x002B3568 File Offset: 0x002B1768
		// (set) Token: 0x0600ACA4 RID: 44196 RVA: 0x00054C7B File Offset: 0x00052E7B
		public unsafe Vector3 relative
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_relative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_relative)) = value;
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600ACA5 RID: 44197 RVA: 0x002B3590 File Offset: 0x002B1790
		// (set) Token: 0x0600ACA6 RID: 44198 RVA: 0x00054C96 File Offset: 0x00052E96
		public unsafe Vector2 vector2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_vector2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_vector2)) = value;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600ACA7 RID: 44199 RVA: 0x002B35B8 File Offset: 0x002B17B8
		// (set) Token: 0x0600ACA8 RID: 44200 RVA: 0x00054CB1 File Offset: 0x00052EB1
		public unsafe Vector2 normalizedOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_normalizedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_normalizedOffset)) = value;
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600ACA9 RID: 44201 RVA: 0x002B35E0 File Offset: 0x002B17E0
		// (set) Token: 0x0600ACAA RID: 44202 RVA: 0x00054CCC File Offset: 0x00052ECC
		public unsafe Vector2 originPixel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_originPixel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_originPixel)) = value;
			}
		}

		// Token: 0x040073D1 RID: 29649
		private static readonly System.IntPtr NativeFieldInfoPtr_TEXTURE_SIZE;

		// Token: 0x040073D2 RID: 29650
		private static readonly System.IntPtr NativeFieldInfoPtr_POUR_RADIUS;

		// Token: 0x040073D3 RID: 29651
		private static readonly System.IntPtr NativeFieldInfoPtr_UPDATES_PER_SECOND;

		// Token: 0x040073D4 RID: 29652
		private static readonly System.IntPtr NativeFieldInfoPtr_COVERAGE_THRESHOLD;

		// Token: 0x040073D5 RID: 29653
		private static readonly System.IntPtr NativeFieldInfoPtr_BASE_COVERAGE;

		// Token: 0x040073D6 RID: 29654
		private static readonly System.IntPtr NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD;

		// Token: 0x040073D7 RID: 29655
		private static readonly System.IntPtr NativeFieldInfoPtr_DELAY;

		// Token: 0x040073D8 RID: 29656
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCoverage;

		// Token: 0x040073D9 RID: 29657
		private static readonly System.IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040073DA RID: 29658
		private static readonly System.IntPtr NativeFieldInfoPtr_MeshRenderer;

		// Token: 0x040073DB RID: 29659
		private static readonly System.IntPtr NativeFieldInfoPtr_PourMask;

		// Token: 0x040073DC RID: 29660
		private static readonly System.IntPtr NativeFieldInfoPtr_onSufficientCoverage;

		// Token: 0x040073DD RID: 29661
		private static readonly System.IntPtr NativeFieldInfoPtr_queued;

		// Token: 0x040073DE RID: 29662
		private static readonly System.IntPtr NativeFieldInfoPtr_queuedWorldPos;

		// Token: 0x040073DF RID: 29663
		private static readonly System.IntPtr NativeFieldInfoPtr_mainTex;

		// Token: 0x040073E0 RID: 29664
		private static readonly System.IntPtr NativeFieldInfoPtr_relative;

		// Token: 0x040073E1 RID: 29665
		private static readonly System.IntPtr NativeFieldInfoPtr_vector2;

		// Token: 0x040073E2 RID: 29666
		private static readonly System.IntPtr NativeFieldInfoPtr_normalizedOffset;

		// Token: 0x040073E3 RID: 29667
		private static readonly System.IntPtr NativeFieldInfoPtr_originPixel;

		// Token: 0x040073E4 RID: 29668
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040073E5 RID: 29669
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040073E6 RID: 29670
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0;

		// Token: 0x040073E7 RID: 29671
		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040073E8 RID: 29672
		private static readonly System.IntPtr NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0;

		// Token: 0x040073E9 RID: 29673
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0;

		// Token: 0x040073EA RID: 29674
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0;

		// Token: 0x040073EB RID: 29675
		private static readonly System.IntPtr NativeMethodInfoPtr_Blank_Private_Void_0;

		// Token: 0x040073EC RID: 29676
		private static readonly System.IntPtr NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0;

		// Token: 0x040073ED RID: 29677
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0;

		// Token: 0x040073EE RID: 29678
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0;

		// Token: 0x040073EF RID: 29679
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCoverage_Private_Single_0;

		// Token: 0x040073F0 RID: 29680
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C37 RID: 3127
		[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E465 RID: 58469 RVA: 0x0035F984 File Offset: 0x0035DB84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr);
				PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "worldSpace");
				PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, 100684549);
				PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, 100684550);
			}

			// Token: 0x0600E466 RID: 58470 RVA: 0x0035FA00 File Offset: 0x0035DC00
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E467 RID: 58471 RVA: 0x0035FA3C File Offset: 0x0035DC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299414, XrefRangeEnd = 299419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E468 RID: 58472 RVA: 0x0006F0C5 File Offset: 0x0006D2C5
			public __c__DisplayClass27_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467B RID: 18043
			// (get) Token: 0x0600E469 RID: 58473 RVA: 0x0035FA7C File Offset: 0x0035DC7C
			// (set) Token: 0x0600E46A RID: 58474 RVA: 0x0006F0CE File Offset: 0x0006D2CE
			public unsafe PotSoilCover __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700467C RID: 18044
			// (get) Token: 0x0600E46B RID: 58475 RVA: 0x0035FAAC File Offset: 0x0035DCAC
			// (set) Token: 0x0600E46C RID: 58476 RVA: 0x0006F0ED File Offset: 0x0006D2ED
			public unsafe Vector3 worldSpace
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x040098F7 RID: 39159
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098F8 RID: 39160
			private static readonly System.IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x040098F9 RID: 39161
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098FA RID: 39162
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CE5 RID: 3301
			[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<>c__DisplayClass27_0+<<DelayedApplyPour>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600ECA3 RID: 60579 RVA: 0x0037792C File Offset: 0x00375B2C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "<<DelayedApplyPour>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684551);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684552);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684553);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684554);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684555);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684556);
				}

				// Token: 0x0600ECA4 RID: 60580 RVA: 0x00377A0C File Offset: 0x00375C0C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600ECA5 RID: 60581 RVA: 0x00377A54 File Offset: 0x00375C54
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600ECA6 RID: 60582 RVA: 0x00377A88 File Offset: 0x00375C88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299404, XrefRangeEnd = 299409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004965 RID: 18789
				// (get) Token: 0x0600ECA7 RID: 60583 RVA: 0x00377AC4 File Offset: 0x00375CC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600ECA8 RID: 60584 RVA: 0x00377B04 File Offset: 0x00375D04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299409, XrefRangeEnd = 299414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004966 RID: 18790
				// (get) Token: 0x0600ECA9 RID: 60585 RVA: 0x00377B38 File Offset: 0x00375D38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600ECAA RID: 60586 RVA: 0x00073371 File Offset: 0x00071571
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004962 RID: 18786
				// (get) Token: 0x0600ECAB RID: 60587 RVA: 0x00377B78 File Offset: 0x00375D78
				// (set) Token: 0x0600ECAC RID: 60588 RVA: 0x0007337A File Offset: 0x0007157A
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004963 RID: 18787
				// (get) Token: 0x0600ECAD RID: 60589 RVA: 0x00377BA0 File Offset: 0x00375DA0
				// (set) Token: 0x0600ECAE RID: 60590 RVA: 0x00073395 File Offset: 0x00071595
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004964 RID: 18788
				// (get) Token: 0x0600ECAF RID: 60591 RVA: 0x00377BD0 File Offset: 0x00375DD0
				// (set) Token: 0x0600ECB0 RID: 60592 RVA: 0x000733B4 File Offset: 0x000715B4
				public unsafe PotSoilCover.__c__DisplayClass27_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009E2B RID: 40491
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009E2C RID: 40492
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009E2D RID: 40493
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009E2E RID: 40494
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009E2F RID: 40495
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E30 RID: 40496
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009E31 RID: 40497
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009E32 RID: 40498
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E33 RID: 40499
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C38 RID: 3128
		[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<CheckQueue>d__25")]
		public sealed class _CheckQueue_d__25 : Il2CppSystem.Object
		{
			// Token: 0x0600E46D RID: 58477 RVA: 0x0035FAD4 File Offset: 0x0035DCD4
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckQueue_d__25()
			{
				Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "<CheckQueue>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr);
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>1__state");
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>2__current");
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>4__this");
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684557);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684558);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684559);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684560);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684561);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100684562);
			}

			// Token: 0x0600E46E RID: 58478 RVA: 0x0035FBB4 File Offset: 0x0035DDB4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckQueue_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E46F RID: 58479 RVA: 0x0035FBFC File Offset: 0x0035DDFC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E470 RID: 58480 RVA: 0x0035FC30 File Offset: 0x0035DE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299419, XrefRangeEnd = 299440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004680 RID: 18048
			// (get) Token: 0x0600E471 RID: 58481 RVA: 0x0035FC6C File Offset: 0x0035DE6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E472 RID: 58482 RVA: 0x0035FCAC File Offset: 0x0035DEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299440, XrefRangeEnd = 299445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004681 RID: 18049
			// (get) Token: 0x0600E473 RID: 58483 RVA: 0x0035FCE0 File Offset: 0x0035DEE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E474 RID: 58484 RVA: 0x0006F108 File Offset: 0x0006D308
			public _CheckQueue_d__25(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467D RID: 18045
			// (get) Token: 0x0600E475 RID: 58485 RVA: 0x0035FD20 File Offset: 0x0035DF20
			// (set) Token: 0x0600E476 RID: 58486 RVA: 0x0006F111 File Offset: 0x0006D311
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700467E RID: 18046
			// (get) Token: 0x0600E477 RID: 58487 RVA: 0x0035FD48 File Offset: 0x0035DF48
			// (set) Token: 0x0600E478 RID: 58488 RVA: 0x0006F12C File Offset: 0x0006D32C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700467F RID: 18047
			// (get) Token: 0x0600E479 RID: 58489 RVA: 0x0035FD78 File Offset: 0x0035DF78
			// (set) Token: 0x0600E47A RID: 58490 RVA: 0x0006F14B File Offset: 0x0006D34B
			public unsafe PotSoilCover __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098FB RID: 39163
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040098FC RID: 39164
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040098FD RID: 39165
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098FE RID: 39166
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040098FF RID: 39167
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009900 RID: 39168
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009901 RID: 39169
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009902 RID: 39170
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009903 RID: 39171
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
