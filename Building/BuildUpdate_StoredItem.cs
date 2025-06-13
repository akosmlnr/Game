using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E2 RID: 1250
	public class BuildUpdate_StoredItem : BuildUpdate_Base
	{
		// Token: 0x06006C6F RID: 27759 RVA: 0x001E63C0 File Offset: 0x001E45C0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_StoredItem()
		{
			Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr);
			BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "itemInstance");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "ghostModel");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "storedItemClass");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "bestIntersection");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "detectionRange");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "detectionMask");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "storedItemHoldDistance");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "currentRotation");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "validPosition");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "mouseUpSinceStart");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "mouseUpSincePlace");
			BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "positionDuringLastValidPosition");
			BuildUpdate_StoredItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677149);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677150);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677151);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677152);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677153);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677154);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677155);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677156);
			BuildUpdate_StoredItem.NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677157);
			BuildUpdate_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, 100677158);
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x001E65BC File Offset: 0x001E47BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218950, XrefRangeEnd = 218964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x001E65F8 File Offset: 0x001E47F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219023, RefRangeEnd = 219024, XrefRangeStart = 218964, XrefRangeEnd = 219023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x001E6634 File Offset: 0x001E4834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219024, XrefRangeEnd = 219031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x001E6668 File Offset: 0x001E4868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219041, RefRangeEnd = 219042, XrefRangeStart = 219031, XrefRangeEnd = 219041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x001E669C File Offset: 0x001E489C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219042, XrefRangeEnd = 219170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x001E66D8 File Offset: 0x001E48D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219186, RefRangeEnd = 219188, XrefRangeStart = 219170, XrefRangeEnd = 219186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x001E670C File Offset: 0x001E490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219188, XrefRangeEnd = 219220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x001E6748 File Offset: 0x001E4948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219220, XrefRangeEnd = 219227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostPlace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_StoredItem.NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x001E6784 File Offset: 0x001E4984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219235, RefRangeEnd = 219237, XrefRangeStart = 219227, XrefRangeEnd = 219235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x001E67C0 File Offset: 0x001E49C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219237, XrefRangeEnd = 219240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00032FF5 File Offset: 0x000311F5
		public BuildUpdate_StoredItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06006C7B RID: 27771 RVA: 0x001E67FC File Offset: 0x001E49FC
		// (set) Token: 0x06006C7C RID: 27772 RVA: 0x00032FFE File Offset: 0x000311FE
		public unsafe StorableItemInstance itemInstance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x001E682C File Offset: 0x001E4A2C
		// (set) Token: 0x06006C7E RID: 27774 RVA: 0x0003301D File Offset: 0x0003121D
		public unsafe GameObject ghostModel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_ghostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x06006C7F RID: 27775 RVA: 0x001E685C File Offset: 0x001E4A5C
		// (set) Token: 0x06006C80 RID: 27776 RVA: 0x0003303C File Offset: 0x0003123C
		public unsafe StoredItem storedItemClass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x001E688C File Offset: 0x001E4A8C
		// (set) Token: 0x06006C82 RID: 27778 RVA: 0x0003305B File Offset: 0x0003125B
		public unsafe BuildUpdate_StoredItem.StorageTileIntersection bestIntersection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_StoredItem.StorageTileIntersection>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x06006C83 RID: 27779 RVA: 0x001E68BC File Offset: 0x001E4ABC
		// (set) Token: 0x06006C84 RID: 27780 RVA: 0x0003307A File Offset: 0x0003127A
		public unsafe float detectionRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06006C85 RID: 27781 RVA: 0x001E68E4 File Offset: 0x001E4AE4
		// (set) Token: 0x06006C86 RID: 27782 RVA: 0x00033095 File Offset: 0x00031295
		public unsafe LayerMask detectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06006C87 RID: 27783 RVA: 0x001E690C File Offset: 0x001E4B0C
		// (set) Token: 0x06006C88 RID: 27784 RVA: 0x000330B0 File Offset: 0x000312B0
		public unsafe float storedItemHoldDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_storedItemHoldDistance)) = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06006C89 RID: 27785 RVA: 0x001E6934 File Offset: 0x001E4B34
		// (set) Token: 0x06006C8A RID: 27786 RVA: 0x000330CB File Offset: 0x000312CB
		public unsafe float currentRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x001E695C File Offset: 0x001E4B5C
		// (set) Token: 0x06006C8C RID: 27788 RVA: 0x000330E6 File Offset: 0x000312E6
		public unsafe bool validPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x001E6984 File Offset: 0x001E4B84
		// (set) Token: 0x06006C8E RID: 27790 RVA: 0x00033101 File Offset: 0x00031301
		public unsafe Material currentGhostMaterial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x06006C8F RID: 27791 RVA: 0x001E69B4 File Offset: 0x001E4BB4
		// (set) Token: 0x06006C90 RID: 27792 RVA: 0x00033120 File Offset: 0x00031320
		public unsafe bool mouseUpSinceStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSinceStart)) = value;
			}
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06006C91 RID: 27793 RVA: 0x001E69DC File Offset: 0x001E4BDC
		// (set) Token: 0x06006C92 RID: 27794 RVA: 0x0003313B File Offset: 0x0003133B
		public unsafe bool mouseUpSincePlace
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_mouseUpSincePlace)) = value;
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06006C93 RID: 27795 RVA: 0x001E6A04 File Offset: 0x001E4C04
		// (set) Token: 0x06006C94 RID: 27796 RVA: 0x00033156 File Offset: 0x00031356
		public unsafe Vector3 positionDuringLastValidPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.NativeFieldInfoPtr_positionDuringLastValidPosition)) = value;
			}
		}

		// Token: 0x04004A3D RID: 19005
		private static readonly System.IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04004A3E RID: 19006
		private static readonly System.IntPtr NativeFieldInfoPtr_ghostModel;

		// Token: 0x04004A3F RID: 19007
		private static readonly System.IntPtr NativeFieldInfoPtr_storedItemClass;

		// Token: 0x04004A40 RID: 19008
		private static readonly System.IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x04004A41 RID: 19009
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004A42 RID: 19010
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004A43 RID: 19011
		private static readonly System.IntPtr NativeFieldInfoPtr_storedItemHoldDistance;

		// Token: 0x04004A44 RID: 19012
		private static readonly System.IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x04004A45 RID: 19013
		private static readonly System.IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x04004A46 RID: 19014
		private static readonly System.IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x04004A47 RID: 19015
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseUpSinceStart;

		// Token: 0x04004A48 RID: 19016
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseUpSincePlace;

		// Token: 0x04004A49 RID: 19017
		private static readonly System.IntPtr NativeFieldInfoPtr_positionDuringLastValidPosition;

		// Token: 0x04004A4A RID: 19018
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004A4B RID: 19019
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004A4C RID: 19020
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004A4D RID: 19021
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x04004A4E RID: 19022
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x04004A4F RID: 19023
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004A50 RID: 19024
		private static readonly System.IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x04004A51 RID: 19025
		private static readonly System.IntPtr NativeMethodInfoPtr_PostPlace_Protected_Virtual_New_Void_0;

		// Token: 0x04004A52 RID: 19026
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Protected_Vector2_0;

		// Token: 0x04004A53 RID: 19027
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA2 RID: 2722
		public class StorageTileIntersection : Il2CppSystem.Object
		{
			// Token: 0x0600D58A RID: 54666 RVA: 0x00335910 File Offset: 0x00333B10
			// Note: this type is marked as 'beforefieldinit'.
			static StorageTileIntersection()
			{
				Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_StoredItem>.NativeClassPtr, "StorageTileIntersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr);
				BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, "storageTile");
				BuildUpdate_StoredItem.StorageTileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr, 100677159);
			}

			// Token: 0x0600D58B RID: 54667 RVA: 0x00335978 File Offset: 0x00333B78
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StorageTileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_StoredItem.StorageTileIntersection>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_StoredItem.StorageTileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D58C RID: 54668 RVA: 0x000679A9 File Offset: 0x00065BA9
			public StorageTileIntersection(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004202 RID: 16898
			// (get) Token: 0x0600D58D RID: 54669 RVA: 0x003359B4 File Offset: 0x00333BB4
			// (set) Token: 0x0600D58E RID: 54670 RVA: 0x000679B2 File Offset: 0x00065BB2
			public unsafe FootprintTile footprintTile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004203 RID: 16899
			// (get) Token: 0x0600D58F RID: 54671 RVA: 0x003359E4 File Offset: 0x00333BE4
			// (set) Token: 0x0600D590 RID: 54672 RVA: 0x000679D1 File Offset: 0x00065BD1
			public unsafe StorageTile storageTile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_StoredItem.StorageTileIntersection.NativeFieldInfoPtr_storageTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009023 RID: 36899
			private static readonly System.IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04009024 RID: 36900
			private static readonly System.IntPtr NativeFieldInfoPtr_storageTile;

			// Token: 0x04009025 RID: 36901
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
