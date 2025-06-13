using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004D5 RID: 1237
	public class BuildManager : Singleton<BuildManager>
	{
		// Token: 0x06006BBF RID: 27583 RVA: 0x001E3CFC File Offset: 0x001E1EFC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildManager()
		{
			Il2CppClassPointerStore<BuildManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager>.NativeClassPtr);
			BuildManager.NativeFieldInfoPtr_PlaceSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "PlaceSounds");
			BuildManager.NativeFieldInfoPtr_tempContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "tempContainer");
			BuildManager.NativeFieldInfoPtr_networkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "networkObject");
			BuildManager.NativeFieldInfoPtr_storedItemBuildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "storedItemBuildHandler");
			BuildManager.NativeFieldInfoPtr_cashBuildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "cashBuildHandler");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_White");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_Red");
			BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<isBuilding>k__BackingField");
			BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<currentBuildHandler>k__BackingField");
			BuildManager.NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677067);
			BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677068);
			BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677069);
			BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677070);
			BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677071);
			BuildManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677072);
			BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677073);
			BuildManager.NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677074);
			BuildManager.NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677075);
			BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677076);
			BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677077);
			BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677078);
			BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677079);
			BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677080);
			BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677081);
			BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677082);
			BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677083);
			BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677084);
			BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677085);
			BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677086);
			BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677087);
			BuildManager.NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677088);
			BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100677089);
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x001E3FAC File Offset: 0x001E21AC
		public unsafe Transform _tempContainer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x001E3FEC File Offset: 0x001E21EC
		// (set) Token: 0x06006BC2 RID: 27586 RVA: 0x001E4028 File Offset: 0x001E2228
		public unsafe bool isBuilding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x001E4068 File Offset: 0x001E2268
		// (set) Token: 0x06006BC4 RID: 27588 RVA: 0x001E40A8 File Offset: 0x001E22A8
		public unsafe GameObject currentBuildHandler
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 24360, RefRangeEnd = 24376, XrefRangeStart = 24360, XrefRangeEnd = 24376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x001E40EC File Offset: 0x001E22EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217281, XrefRangeEnd = 217284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x001E4128 File Offset: 0x001E2328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217320, RefRangeEnd = 217322, XrefRangeStart = 217284, XrefRangeEnd = 217320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x001E416C File Offset: 0x001E236C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217348, RefRangeEnd = 217349, XrefRangeStart = 217322, XrefRangeEnd = 217348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuildingStoredItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x001E41B0 File Offset: 0x001E23B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217369, RefRangeEnd = 217370, XrefRangeStart = 217349, XrefRangeEnd = 217369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPlacingCash(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x001E41F4 File Offset: 0x001E23F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 217374, RefRangeEnd = 217381, XrefRangeStart = 217370, XrefRangeEnd = 217374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBuilding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x001E4228 File Offset: 0x001E2428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217396, RefRangeEnd = 217398, XrefRangeStart = 217381, XrefRangeEnd = 217396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref point;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x001E4274 File Offset: 0x001E2474
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217403, RefRangeEnd = 217408, XrefRangeStart = 217398, XrefRangeEnd = 217403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableColliders(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x001E42B8 File Offset: 0x001E24B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217408, XrefRangeEnd = 217417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLights(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x001E42FC File Offset: 0x001E24FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217425, RefRangeEnd = 217429, XrefRangeStart = 217417, XrefRangeEnd = 217425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNetworking(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x001E4340 File Offset: 0x001E2540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217429, XrefRangeEnd = 217434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSpriteRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x001E4384 File Offset: 0x001E2584
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 217453, RefRangeEnd = 217460, XrefRangeStart = 217434, XrefRangeEnd = 217453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref allMaterials;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x001E43E8 File Offset: 0x001E25E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217475, RefRangeEnd = 217479, XrefRangeStart = 217460, XrefRangeEnd = 217475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNavigation(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x001E442C File Offset: 0x001E262C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217484, RefRangeEnd = 217486, XrefRangeStart = 217479, XrefRangeEnd = 217484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCanvases(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x001E4470 File Offset: 0x001E2670
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 217524, RefRangeEnd = 217539, XrefRangeStart = 217486, XrefRangeEnd = 217524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
		}

		// Token: 0x06006BD3 RID: 27603 RVA: 0x001E4504 File Offset: 0x001E2704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217539, XrefRangeEnd = 217568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotationAngle;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
		}

		// Token: 0x06006BD4 RID: 27604 RVA: 0x001E4588 File Offset: 0x001E2788
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217598, RefRangeEnd = 217603, XrefRangeStart = 217568, XrefRangeEnd = 217598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSurface);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref relativeRotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
		}

		// Token: 0x06006BD5 RID: 27605 RVA: 0x001E461C File Offset: 0x001E281C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217603, XrefRangeEnd = 217618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem(StorableItemInstance item, IStorageEntity parentStorageEntity, StorageGrid grid, Vector2 originCoord, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentStorageEntity);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x001E46A0 File Offset: 0x001E28A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217618, XrefRangeEnd = 217628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x00032B5C File Offset: 0x00030D5C
		public BuildManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x001E46DC File Offset: 0x001E28DC
		// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x00032B65 File Offset: 0x00030D65
		public unsafe List<BuildManager.BuildSound> PlaceSounds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildManager.BuildSound>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x001E470C File Offset: 0x001E290C
		// (set) Token: 0x06006BDB RID: 27611 RVA: 0x00032B84 File Offset: 0x00030D84
		public unsafe Transform tempContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_tempContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_tempContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06006BDC RID: 27612 RVA: 0x001E473C File Offset: 0x001E293C
		// (set) Token: 0x06006BDD RID: 27613 RVA: 0x00032BA3 File Offset: 0x00030DA3
		public unsafe NetworkObject networkObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_networkObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_networkObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06006BDE RID: 27614 RVA: 0x001E476C File Offset: 0x001E296C
		// (set) Token: 0x06006BDF RID: 27615 RVA: 0x00032BC2 File Offset: 0x00030DC2
		public unsafe GameObject storedItemBuildHandler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_storedItemBuildHandler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_storedItemBuildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06006BE0 RID: 27616 RVA: 0x001E479C File Offset: 0x001E299C
		// (set) Token: 0x06006BE1 RID: 27617 RVA: 0x00032BE1 File Offset: 0x00030DE1
		public unsafe GameObject cashBuildHandler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_cashBuildHandler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_cashBuildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x001E47CC File Offset: 0x001E29CC
		// (set) Token: 0x06006BE3 RID: 27619 RVA: 0x00032C00 File Offset: 0x00030E00
		public unsafe Material ghostMaterial_White
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x001E47FC File Offset: 0x001E29FC
		// (set) Token: 0x06006BE5 RID: 27621 RVA: 0x00032C1F File Offset: 0x00030E1F
		public unsafe Material ghostMaterial_Red
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x001E482C File Offset: 0x001E2A2C
		// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x00032C3E File Offset: 0x00030E3E
		public unsafe bool _isBuilding_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField)) = value;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x001E4854 File Offset: 0x001E2A54
		// (set) Token: 0x06006BE9 RID: 27625 RVA: 0x00032C59 File Offset: 0x00030E59
		public unsafe GameObject _currentBuildHandler_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049CB RID: 18891
		private static readonly System.IntPtr NativeFieldInfoPtr_PlaceSounds;

		// Token: 0x040049CC RID: 18892
		private static readonly System.IntPtr NativeFieldInfoPtr_tempContainer;

		// Token: 0x040049CD RID: 18893
		private static readonly System.IntPtr NativeFieldInfoPtr_networkObject;

		// Token: 0x040049CE RID: 18894
		private static readonly System.IntPtr NativeFieldInfoPtr_storedItemBuildHandler;

		// Token: 0x040049CF RID: 18895
		private static readonly System.IntPtr NativeFieldInfoPtr_cashBuildHandler;

		// Token: 0x040049D0 RID: 18896
		private static readonly System.IntPtr NativeFieldInfoPtr_ghostMaterial_White;

		// Token: 0x040049D1 RID: 18897
		private static readonly System.IntPtr NativeFieldInfoPtr_ghostMaterial_Red;

		// Token: 0x040049D2 RID: 18898
		private static readonly System.IntPtr NativeFieldInfoPtr__isBuilding_k__BackingField;

		// Token: 0x040049D3 RID: 18899
		private static readonly System.IntPtr NativeFieldInfoPtr__currentBuildHandler_k__BackingField;

		// Token: 0x040049D4 RID: 18900
		private static readonly System.IntPtr NativeMethodInfoPtr_get__tempContainer_Public_get_Transform_0;

		// Token: 0x040049D5 RID: 18901
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0;

		// Token: 0x040049D6 RID: 18902
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0;

		// Token: 0x040049D7 RID: 18903
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0;

		// Token: 0x040049D8 RID: 18904
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0;

		// Token: 0x040049D9 RID: 18905
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040049DA RID: 18906
		private static readonly System.IntPtr NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0;

		// Token: 0x040049DB RID: 18907
		private static readonly System.IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Public_Void_ItemInstance_0;

		// Token: 0x040049DC RID: 18908
		private static readonly System.IntPtr NativeMethodInfoPtr_StartPlacingCash_Public_Void_ItemInstance_0;

		// Token: 0x040049DD RID: 18909
		private static readonly System.IntPtr NativeMethodInfoPtr_StopBuilding_Public_Void_0;

		// Token: 0x040049DE RID: 18910
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0;

		// Token: 0x040049DF RID: 18911
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0;

		// Token: 0x040049E0 RID: 18912
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0;

		// Token: 0x040049E1 RID: 18913
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0;

		// Token: 0x040049E2 RID: 18914
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0;

		// Token: 0x040049E3 RID: 18915
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0;

		// Token: 0x040049E4 RID: 18916
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0;

		// Token: 0x040049E5 RID: 18917
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0;

		// Token: 0x040049E6 RID: 18918
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x040049E7 RID: 18919
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x040049E8 RID: 18920
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0;

		// Token: 0x040049E9 RID: 18921
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateStoredItem_Public_Void_StorableItemInstance_IStorageEntity_StorageGrid_Vector2_Single_0;

		// Token: 0x040049EA RID: 18922
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9F RID: 2719
		[System.Serializable]
		public class BuildSound : Il2CppSystem.Object
		{
			// Token: 0x0600D576 RID: 54646 RVA: 0x003355F4 File Offset: 0x003337F4
			// Note: this type is marked as 'beforefieldinit'.
			static BuildSound()
			{
				Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "BuildSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr);
				BuildManager.BuildSound.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Type");
				BuildManager.BuildSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Sound");
				BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, 100677090);
			}

			// Token: 0x0600D577 RID: 54647 RVA: 0x0033565C File Offset: 0x0033385C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D578 RID: 54648 RVA: 0x000678FB File Offset: 0x00065AFB
			public BuildSound(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FD RID: 16893
			// (get) Token: 0x0600D579 RID: 54649 RVA: 0x00335698 File Offset: 0x00333898
			// (set) Token: 0x0600D57A RID: 54650 RVA: 0x00067904 File Offset: 0x00065B04
			public unsafe BuildableItemDefinition.EBuildSoundType Type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x170041FE RID: 16894
			// (get) Token: 0x0600D57B RID: 54651 RVA: 0x003356C0 File Offset: 0x003338C0
			// (set) Token: 0x0600D57C RID: 54652 RVA: 0x0006791F File Offset: 0x00065B1F
			public unsafe AudioSourceController Sound
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400901A RID: 36890
			private static readonly System.IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x0400901B RID: 36891
			private static readonly System.IntPtr NativeFieldInfoPtr_Sound;

			// Token: 0x0400901C RID: 36892
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AA0 RID: 2720
		[ObfuscatedName("ScheduleOne.Building.BuildManager+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D57D RID: 54653 RVA: 0x003356F0 File Offset: 0x003338F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr);
				BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, "type");
				BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, 100677091);
				BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr, 100677092);
			}

			// Token: 0x0600D57E RID: 54654 RVA: 0x00335758 File Offset: 0x00333958
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.__c__DisplayClass23_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D57F RID: 54655 RVA: 0x00335794 File Offset: 0x00333994
			[CallerCount(0)]
			public unsafe bool _PlayBuildSound_b__0(BuildManager.BuildSound s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass23_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D580 RID: 54656 RVA: 0x0006793E File Offset: 0x00065B3E
			public __c__DisplayClass23_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FF RID: 16895
			// (get) Token: 0x0600D581 RID: 54657 RVA: 0x003357E4 File Offset: 0x003339E4
			// (set) Token: 0x0600D582 RID: 54658 RVA: 0x00067947 File Offset: 0x00065B47
			public unsafe BuildableItemDefinition.EBuildSoundType type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass23_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x0400901D RID: 36893
			private static readonly System.IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400901E RID: 36894
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400901F RID: 36895
			private static readonly System.IntPtr NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0;
		}
	}
}
