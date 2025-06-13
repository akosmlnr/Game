using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E1 RID: 1249
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x06006C4F RID: 27727 RVA: 0x001E5DE8 File Offset: 0x001E3FE8
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_ProceduralGrid()
		{
			Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_ProceduralGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr);
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "GhostModel");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemClass");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionRange");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionMask");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentRotation");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "validPosition");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "bestIntersection");
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677138);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677139);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677140);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677141);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677142);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677143);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677144);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677145);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677146);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100677147);
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x001E5FA8 File Offset: 0x001E41A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218668, XrefRangeEnd = 218686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x001E5FE4 File Offset: 0x001E41E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218686, XrefRangeEnd = 218727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x001E6020 File Offset: 0x001E4220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218727, XrefRangeEnd = 218740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x001E6054 File Offset: 0x001E4254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218771, RefRangeEnd = 218772, XrefRangeStart = 218740, XrefRangeEnd = 218771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x001E6088 File Offset: 0x001E4288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218772, XrefRangeEnd = 218853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x001E60C4 File Offset: 0x001E42C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218869, RefRangeEnd = 218870, XrefRangeStart = 218853, XrefRangeEnd = 218869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x001E60F8 File Offset: 0x001E42F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218888, RefRangeEnd = 218890, XrefRangeStart = 218870, XrefRangeEnd = 218888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprintTile);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x001E6158 File Offset: 0x001E4358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218933, RefRangeEnd = 218934, XrefRangeStart = 218890, XrefRangeEnd = 218933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x001E618C File Offset: 0x001E438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218934, XrefRangeEnd = 218949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetNearbyProcTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x001E61CC File Offset: 0x001E43CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218949, XrefRangeEnd = 218950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_ProceduralGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00032ECA File Offset: 0x000310CA
		public BuildUpdate_ProceduralGrid(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x001E6208 File Offset: 0x001E4408
		// (set) Token: 0x06006C5C RID: 27740 RVA: 0x00032ED3 File Offset: 0x000310D3
		public unsafe GameObject GhostModel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06006C5D RID: 27741 RVA: 0x001E6238 File Offset: 0x001E4438
		// (set) Token: 0x06006C5E RID: 27742 RVA: 0x00032EF2 File Offset: 0x000310F2
		public unsafe ProceduralGridItem ItemClass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x06006C5F RID: 27743 RVA: 0x001E6268 File Offset: 0x001E4468
		// (set) Token: 0x06006C60 RID: 27744 RVA: 0x00032F11 File Offset: 0x00031111
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x06006C61 RID: 27745 RVA: 0x001E6298 File Offset: 0x001E4498
		// (set) Token: 0x06006C62 RID: 27746 RVA: 0x00032F30 File Offset: 0x00031130
		public unsafe float detectionRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x001E62C0 File Offset: 0x001E44C0
		// (set) Token: 0x06006C64 RID: 27748 RVA: 0x00032F4B File Offset: 0x0003114B
		public unsafe LayerMask detectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x06006C65 RID: 27749 RVA: 0x001E62E8 File Offset: 0x001E44E8
		// (set) Token: 0x06006C66 RID: 27750 RVA: 0x00032F66 File Offset: 0x00031166
		public unsafe float rotation_Smoothing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x06006C67 RID: 27751 RVA: 0x001E6310 File Offset: 0x001E4510
		// (set) Token: 0x06006C68 RID: 27752 RVA: 0x00032F81 File Offset: 0x00031181
		public unsafe float currentRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x001E6338 File Offset: 0x001E4538
		// (set) Token: 0x06006C6A RID: 27754 RVA: 0x00032F9C File Offset: 0x0003119C
		public unsafe bool validPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x001E6360 File Offset: 0x001E4560
		// (set) Token: 0x06006C6C RID: 27756 RVA: 0x00032FB7 File Offset: 0x000311B7
		public unsafe Material currentGhostMaterial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06006C6D RID: 27757 RVA: 0x001E6390 File Offset: 0x001E4590
		// (set) Token: 0x06006C6E RID: 27758 RVA: 0x00032FD6 File Offset: 0x000311D6
		public unsafe BuildUpdate_ProceduralGrid.Intersection bestIntersection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_ProceduralGrid.Intersection>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A29 RID: 18985
		private static readonly System.IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004A2A RID: 18986
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemClass;

		// Token: 0x04004A2B RID: 18987
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x04004A2C RID: 18988
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004A2D RID: 18989
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004A2E RID: 18990
		private static readonly System.IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x04004A2F RID: 18991
		private static readonly System.IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x04004A30 RID: 18992
		private static readonly System.IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x04004A31 RID: 18993
		private static readonly System.IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x04004A32 RID: 18994
		private static readonly System.IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x04004A33 RID: 18995
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004A34 RID: 18996
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004A35 RID: 18997
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004A36 RID: 18998
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x04004A37 RID: 18999
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x04004A38 RID: 19000
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004A39 RID: 19001
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0;

		// Token: 0x04004A3A RID: 19002
		private static readonly System.IntPtr NativeMethodInfoPtr_Place_Protected_Void_0;

		// Token: 0x04004A3B RID: 19003
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0;

		// Token: 0x04004A3C RID: 19004
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA1 RID: 2721
		public class Intersection : Il2CppSystem.Object
		{
			// Token: 0x0600D583 RID: 54659 RVA: 0x0033580C File Offset: 0x00333A0C
			// Note: this type is marked as 'beforefieldinit'.
			static Intersection()
			{
				Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "Intersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr);
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "procTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, 100677148);
			}

			// Token: 0x0600D584 RID: 54660 RVA: 0x00335874 File Offset: 0x00333A74
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D585 RID: 54661 RVA: 0x00067962 File Offset: 0x00065B62
			public Intersection(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004200 RID: 16896
			// (get) Token: 0x0600D586 RID: 54662 RVA: 0x003358B0 File Offset: 0x00333AB0
			// (set) Token: 0x0600D587 RID: 54663 RVA: 0x0006796B File Offset: 0x00065B6B
			public unsafe FootprintTile footprintTile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004201 RID: 16897
			// (get) Token: 0x0600D588 RID: 54664 RVA: 0x003358E0 File Offset: 0x00333AE0
			// (set) Token: 0x0600D589 RID: 54665 RVA: 0x0006798A File Offset: 0x00065B8A
			public unsafe ProceduralTile procTile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009020 RID: 36896
			private static readonly System.IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04009021 RID: 36897
			private static readonly System.IntPtr NativeFieldInfoPtr_procTile;

			// Token: 0x04009022 RID: 36898
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
