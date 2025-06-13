using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E0 RID: 1248
	public class BuildUpdate_Grid : BuildUpdate_Base
	{
		// Token: 0x06006C28 RID: 27688 RVA: 0x001E5690 File Offset: 0x001E3890
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Grid()
		{
			Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr);
			BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "GhostModel");
			BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionRange");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionMask");
			BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "AllowRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "validPosition");
			BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "closestIntersection");
			BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "verticalOffset");
			BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677125);
			BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677126);
			BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677127);
			BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677128);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677129);
			BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677130);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677131);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677132);
			BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677133);
			BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677134);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677135);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677136);
			BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100677137);
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x001E58B4 File Offset: 0x001E3AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218172, XrefRangeEnd = 218204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x001E58F0 File Offset: 0x001E3AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218204, XrefRangeEnd = 218222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x001E592C File Offset: 0x001E3B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218222, XrefRangeEnd = 218332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x001E5968 File Offset: 0x001E3B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218375, RefRangeEnd = 218376, XrefRangeStart = 218332, XrefRangeEnd = 218375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buildPointAsOrigin;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x001E59C4 File Offset: 0x001E3BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218376, XrefRangeEnd = 218389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C2E RID: 27694 RVA: 0x001E59F8 File Offset: 0x001E3BF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218420, RefRangeEnd = 218422, XrefRangeStart = 218389, XrefRangeEnd = 218420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C2F RID: 27695 RVA: 0x001E5A2C File Offset: 0x001E3C2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218452, RefRangeEnd = 218455, XrefRangeStart = 218422, XrefRangeEnd = 218452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TileIntersection> GetRelevantIntersections(FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TileIntersection>>(intPtr2) : null;
		}

		// Token: 0x06006C30 RID: 27696 RVA: 0x001E5A7C File Offset: 0x001E3C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218455, XrefRangeEnd = 218593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x001E5AB8 File Offset: 0x001E3CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218609, RefRangeEnd = 218610, XrefRangeStart = 218593, XrefRangeEnd = 218609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x001E5AEC File Offset: 0x001E3CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218610, XrefRangeEnd = 218646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C33 RID: 27699 RVA: 0x001E5B28 File Offset: 0x001E3D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218646, XrefRangeEnd = 218652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006C34 RID: 27700 RVA: 0x001E5B64 File Offset: 0x001E3D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218652, XrefRangeEnd = 218667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid GetHoveredGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
		}

		// Token: 0x06006C35 RID: 27701 RVA: 0x001E5BA4 File Offset: 0x001E3DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218667, XrefRangeEnd = 218668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C36 RID: 27702 RVA: 0x00032D69 File Offset: 0x00030F69
		public BuildUpdate_Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x06006C37 RID: 27703 RVA: 0x001E5BE0 File Offset: 0x001E3DE0
		// (set) Token: 0x06006C38 RID: 27704 RVA: 0x00032D72 File Offset: 0x00030F72
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x06006C39 RID: 27705 RVA: 0x001E5C10 File Offset: 0x001E3E10
		// (set) Token: 0x06006C3A RID: 27706 RVA: 0x00032D91 File Offset: 0x00030F91
		public unsafe GridItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x06006C3B RID: 27707 RVA: 0x001E5C40 File Offset: 0x001E3E40
		// (set) Token: 0x06006C3C RID: 27708 RVA: 0x00032DB0 File Offset: 0x00030FB0
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x001E5C70 File Offset: 0x001E3E70
		// (set) Token: 0x06006C3E RID: 27710 RVA: 0x00032DCF File Offset: 0x00030FCF
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x06006C3F RID: 27711 RVA: 0x001E5C98 File Offset: 0x001E3E98
		// (set) Token: 0x06006C40 RID: 27712 RVA: 0x00032DEA File Offset: 0x00030FEA
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x06006C41 RID: 27713 RVA: 0x001E5CC0 File Offset: 0x001E3EC0
		// (set) Token: 0x06006C42 RID: 27714 RVA: 0x00032E05 File Offset: 0x00031005
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06006C43 RID: 27715 RVA: 0x001E5CE8 File Offset: 0x001E3EE8
		// (set) Token: 0x06006C44 RID: 27716 RVA: 0x00032E20 File Offset: 0x00031020
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06006C45 RID: 27717 RVA: 0x001E5D10 File Offset: 0x001E3F10
		// (set) Token: 0x06006C46 RID: 27718 RVA: 0x00032E3B File Offset: 0x0003103B
		public unsafe bool AllowRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation)) = value;
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06006C47 RID: 27719 RVA: 0x001E5D38 File Offset: 0x001E3F38
		// (set) Token: 0x06006C48 RID: 27720 RVA: 0x00032E56 File Offset: 0x00031056
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06006C49 RID: 27721 RVA: 0x001E5D60 File Offset: 0x001E3F60
		// (set) Token: 0x06006C4A RID: 27722 RVA: 0x00032E71 File Offset: 0x00031071
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x06006C4B RID: 27723 RVA: 0x001E5D90 File Offset: 0x001E3F90
		// (set) Token: 0x06006C4C RID: 27724 RVA: 0x00032E90 File Offset: 0x00031090
		public unsafe TileIntersection closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06006C4D RID: 27725 RVA: 0x001E5DC0 File Offset: 0x001E3FC0
		// (set) Token: 0x06006C4E RID: 27726 RVA: 0x00032EAF File Offset: 0x000310AF
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x04004A10 RID: 18960
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004A11 RID: 18961
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x04004A12 RID: 18962
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x04004A13 RID: 18963
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x04004A14 RID: 18964
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004A15 RID: 18965
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004A16 RID: 18966
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x04004A17 RID: 18967
		private static readonly IntPtr NativeFieldInfoPtr_AllowRotation;

		// Token: 0x04004A18 RID: 18968
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x04004A19 RID: 18969
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x04004A1A RID: 18970
		private static readonly IntPtr NativeFieldInfoPtr_closestIntersection;

		// Token: 0x04004A1B RID: 18971
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x04004A1C RID: 18972
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004A1D RID: 18973
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004A1E RID: 18974
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004A1F RID: 18975
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0;

		// Token: 0x04004A20 RID: 18976
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004A21 RID: 18977
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x04004A22 RID: 18978
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0;

		// Token: 0x04004A23 RID: 18979
		private static readonly IntPtr NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x04004A24 RID: 18980
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004A25 RID: 18981
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x04004A26 RID: 18982
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x04004A27 RID: 18983
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0;

		// Token: 0x04004A28 RID: 18984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
