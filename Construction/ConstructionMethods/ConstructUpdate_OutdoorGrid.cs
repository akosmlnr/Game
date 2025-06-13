using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004AF RID: 1199
	public class ConstructUpdate_OutdoorGrid : ConstructUpdate_Base
	{
		// Token: 0x060066B5 RID: 26293 RVA: 0x001D2048 File Offset: 0x001D0248
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_OutdoorGrid()
		{
			Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_OutdoorGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr);
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "detectionMask");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "ConstructableClass");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "GhostModel");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "validPosition");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "currentRotation");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "currentGhostMaterial");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "closestIntersection");
			ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, "listingPrice");
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676402);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676403);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676404);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676405);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676406);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676407);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676408);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676409);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676410);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676411);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676412);
			ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr, 100676413);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x001D2208 File Offset: 0x001D0408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209107, RefRangeEnd = 209108, XrefRangeStart = 209094, XrefRangeEnd = 209107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x001D2244 File Offset: 0x001D0444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209125, RefRangeEnd = 209126, XrefRangeStart = 209108, XrefRangeEnd = 209125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x001D2280 File Offset: 0x001D0480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209145, RefRangeEnd = 209146, XrefRangeStart = 209126, XrefRangeEnd = 209145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x001D22BC File Offset: 0x001D04BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209146, XrefRangeEnd = 209153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x001D22F0 File Offset: 0x001D04F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209163, RefRangeEnd = 209164, XrefRangeStart = 209153, XrefRangeEnd = 209163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x001D2324 File Offset: 0x001D0524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209164, XrefRangeEnd = 209264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x001D2360 File Offset: 0x001D0560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209282, RefRangeEnd = 209283, XrefRangeStart = 209264, XrefRangeEnd = 209282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x001D2394 File Offset: 0x001D0594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209291, RefRangeEnd = 209293, XrefRangeStart = 209283, XrefRangeEnd = 209291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreMetaReqsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x001D23D0 File Offset: 0x001D05D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209329, RefRangeEnd = 209330, XrefRangeStart = 209293, XrefRangeEnd = 209329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Constructable_GridBased PlaceNewConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
		}

		// Token: 0x060066BF RID: 26303 RVA: 0x001D241C File Offset: 0x001D061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209330, XrefRangeEnd = 209344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinalizeMoveConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066C0 RID: 26304 RVA: 0x001D2458 File Offset: 0x001D0658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209352, RefRangeEnd = 209354, XrefRangeStart = 209344, XrefRangeEnd = 209352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060066C1 RID: 26305 RVA: 0x001D2494 File Offset: 0x001D0694
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_OutdoorGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_OutdoorGrid>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_OutdoorGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066C2 RID: 26306 RVA: 0x0003052C File Offset: 0x0002E72C
		public ConstructUpdate_OutdoorGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x060066C3 RID: 26307 RVA: 0x001D24D0 File Offset: 0x001D06D0
		// (set) Token: 0x060066C4 RID: 26308 RVA: 0x00030535 File Offset: 0x0002E735
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x060066C5 RID: 26309 RVA: 0x001D24F8 File Offset: 0x001D06F8
		// (set) Token: 0x060066C6 RID: 26310 RVA: 0x00030550 File Offset: 0x0002E750
		public unsafe Constructable_GridBased ConstructableClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_ConstructableClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x060066C7 RID: 26311 RVA: 0x001D2528 File Offset: 0x001D0728
		// (set) Token: 0x060066C8 RID: 26312 RVA: 0x0003056F File Offset: 0x0002E76F
		public unsafe Transform GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x060066C9 RID: 26313 RVA: 0x001D2558 File Offset: 0x001D0758
		// (set) Token: 0x060066CA RID: 26314 RVA: 0x0003058E File Offset: 0x0002E78E
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x060066CB RID: 26315 RVA: 0x001D2580 File Offset: 0x001D0780
		// (set) Token: 0x060066CC RID: 26316 RVA: 0x000305A9 File Offset: 0x0002E7A9
		public unsafe float currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x060066CD RID: 26317 RVA: 0x001D25A8 File Offset: 0x001D07A8
		// (set) Token: 0x060066CE RID: 26318 RVA: 0x000305C4 File Offset: 0x0002E7C4
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x060066CF RID: 26319 RVA: 0x001D25D8 File Offset: 0x001D07D8
		// (set) Token: 0x060066D0 RID: 26320 RVA: 0x000305E3 File Offset: 0x0002E7E3
		public unsafe ConstructionManager.WorldIntersection closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructionManager.WorldIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x060066D1 RID: 26321 RVA: 0x001D2608 File Offset: 0x001D0808
		// (set) Token: 0x060066D2 RID: 26322 RVA: 0x00030602 File Offset: 0x0002E802
		public unsafe float listingPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_OutdoorGrid.NativeFieldInfoPtr_listingPrice)) = value;
			}
		}

		// Token: 0x04004615 RID: 17941
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004616 RID: 17942
		private static readonly IntPtr NativeFieldInfoPtr_ConstructableClass;

		// Token: 0x04004617 RID: 17943
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004618 RID: 17944
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x04004619 RID: 17945
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x0400461A RID: 17946
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x0400461B RID: 17947
		private static readonly IntPtr NativeFieldInfoPtr_closestIntersection;

		// Token: 0x0400461C RID: 17948
		private static readonly IntPtr NativeFieldInfoPtr_listingPrice;

		// Token: 0x0400461D RID: 17949
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400461E RID: 17950
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400461F RID: 17951
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004620 RID: 17952
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004621 RID: 17953
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x04004622 RID: 17954
		private static readonly IntPtr NativeMethodInfoPtr_CheckTileIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x04004623 RID: 17955
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004624 RID: 17956
		private static readonly IntPtr NativeMethodInfoPtr_AreMetaReqsMet_Private_Boolean_0;

		// Token: 0x04004625 RID: 17957
		private static readonly IntPtr NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_New_Constructable_GridBased_0;

		// Token: 0x04004626 RID: 17958
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMoveConstructable_Protected_Virtual_New_Void_0;

		// Token: 0x04004627 RID: 17959
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x04004628 RID: 17960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
