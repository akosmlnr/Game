using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200058A RID: 1418
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x06007B3E RID: 31550 RVA: 0x00215EB8 File Offset: 0x002140B8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingTool()
		{
			Il2CppClassPointerStore<PackagingTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "PackagingTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr);
			PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<ReceiveInput>k__BackingField");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Min");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Max");
			PackagingTool.NativeFieldInfoPtr_ConveyorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorSpeed");
			PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorAcceleration");
			PackagingTool.NativeFieldInfoPtr_BaggieRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieRadius");
			PackagingTool.NativeFieldInfoPtr_JarRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarRadius");
			PackagingTool.NativeFieldInfoPtr_DeployAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DeployAngle");
			PackagingTool.NativeFieldInfoPtr_ProductInitialForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInitialForce");
			PackagingTool.NativeFieldInfoPtr_ProductRandomTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductRandomTorque");
			PackagingTool.NativeFieldInfoPtr_KickForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickForce");
			PackagingTool.NativeFieldInfoPtr_DropCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropCooldown");
			PackagingTool.NativeFieldInfoPtr_Station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "Station");
			PackagingTool.NativeFieldInfoPtr_ConveyorModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorModel");
			PackagingTool.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DoorAnim");
			PackagingTool.NativeFieldInfoPtr_CapAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "CapAnim");
			PackagingTool.NativeFieldInfoPtr_SealAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "SealAnim");
			PackagingTool.NativeFieldInfoPtr_KickAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickAnim");
			PackagingTool.NativeFieldInfoPtr_LeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "LeftButton");
			PackagingTool.NativeFieldInfoPtr_RightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "RightButton");
			PackagingTool.NativeFieldInfoPtr_DropButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropButton");
			PackagingTool.NativeFieldInfoPtr_PackagingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingContainer");
			PackagingTool.NativeFieldInfoPtr_ProductCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductCountText");
			PackagingTool.NativeFieldInfoPtr_HopperDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperDropPoint");
			PackagingTool.NativeFieldInfoPtr_BaggieStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieStartPoint");
			PackagingTool.NativeFieldInfoPtr_JarStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarStartPoint");
			PackagingTool.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductContainer");
			PackagingTool.NativeFieldInfoPtr_KickOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickOrigin");
			PackagingTool.NativeFieldInfoPtr_HopperInputCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperInputCollider");
			PackagingTool.NativeFieldInfoPtr_KickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickSound");
			PackagingTool.NativeFieldInfoPtr_MotorSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "MotorSound");
			PackagingTool.NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropSound");
			PackagingTool.NativeFieldInfoPtr_PackagingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingPrefab");
			PackagingTool.NativeFieldInfoPtr_ConcealedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConcealedPackaging");
			PackagingTool.NativeFieldInfoPtr_ProductItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductItem");
			PackagingTool.NativeFieldInfoPtr_ProductPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductPrefab");
			PackagingTool.NativeFieldInfoPtr_ProductInHopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInHopper");
			PackagingTool.NativeFieldInfoPtr_PackagingInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstances");
			PackagingTool.NativeFieldInfoPtr_ProductInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInstances");
			PackagingTool.NativeFieldInfoPtr_FinalizedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizedPackaging");
			PackagingTool.NativeFieldInfoPtr_conveyorVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "conveyorVelocity");
			PackagingTool.NativeFieldInfoPtr_directionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "directionInput");
			PackagingTool.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "task");
			PackagingTool.NativeFieldInfoPtr_finalizeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeInstance");
			PackagingTool.NativeFieldInfoPtr_finalizeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeCoroutine");
			PackagingTool.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "leftDown");
			PackagingTool.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "rightDown");
			PackagingTool.NativeFieldInfoPtr_dropDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "dropDown");
			PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "timeSinceLastDrop");
			PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678841);
			PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678842);
			PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678843);
			PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678844);
			PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678845);
			PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678846);
			PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678847);
			PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678848);
			PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678849);
			PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678850);
			PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678851);
			PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678852);
			PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678853);
			PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678854);
			PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678855);
			PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678856);
			PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678857);
			PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678858);
			PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678859);
			PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678860);
			PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678861);
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x06007B3F RID: 31551 RVA: 0x00216460 File Offset: 0x00214660
		// (set) Token: 0x06007B40 RID: 31552 RVA: 0x0021649C File Offset: 0x0021469C
		public unsafe bool ReceiveInput
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x002164DC File Offset: 0x002146DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236676, RefRangeEnd = 236677, XrefRangeStart = 236665, XrefRangeEnd = 236676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_task);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref packagingQuantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref productQuantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x00216560 File Offset: 0x00214760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236723, RefRangeEnd = 236724, XrefRangeStart = 236677, XrefRangeEnd = 236723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00216594 File Offset: 0x00214794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236724, XrefRangeEnd = 236725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x002165E4 File Offset: 0x002147E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236725, XrefRangeEnd = 236726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x00216618 File Offset: 0x00214818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236726, XrefRangeEnd = 236733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProduct(ProductItemInstance product, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x00216668 File Offset: 0x00214868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236733, XrefRangeEnd = 236738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x0021669C File Offset: 0x0021489C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236738, XrefRangeEnd = 236765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x002166D0 File Offset: 0x002148D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236784, RefRangeEnd = 236785, XrefRangeStart = 236765, XrefRangeEnd = 236784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x00216704 File Offset: 0x00214904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236789, RefRangeEnd = 236793, XrefRangeStart = 236785, XrefRangeEnd = 236789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x00216738 File Offset: 0x00214938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236793, XrefRangeEnd = 236797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConveyor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x0021676C File Offset: 0x0021496C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236825, RefRangeEnd = 236828, XrefRangeStart = 236797, XrefRangeEnd = 236825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref angle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x002167AC File Offset: 0x002149AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236835, RefRangeEnd = 236837, XrefRangeStart = 236828, XrefRangeEnd = 236835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x002167E0 File Offset: 0x002149E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236837, XrefRangeEnd = 236849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x00216814 File Offset: 0x00214A14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236864, RefRangeEnd = 236866, XrefRangeStart = 236849, XrefRangeEnd = 236864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize(PackagingTool.PackagingInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x00216858 File Offset: 0x00214A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236886, RefRangeEnd = 236887, XrefRangeStart = 236866, XrefRangeEnd = 236886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0021688C File Offset: 0x00214A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236908, RefRangeEnd = 236909, XrefRangeStart = 236887, XrefRangeEnd = 236908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInsertions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x002168C0 File Offset: 0x00214AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236920, RefRangeEnd = 236921, XrefRangeStart = 236909, XrefRangeEnd = 236920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertIntoHopper(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x00216904 File Offset: 0x00214B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236997, RefRangeEnd = 236998, XrefRangeStart = 236921, XrefRangeEnd = 236997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x00216938 File Offset: 0x00214B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236998, XrefRangeEnd = 237020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x0003A487 File Offset: 0x00038687
		public PackagingTool(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x00216974 File Offset: 0x00214B74
		// (set) Token: 0x06007B56 RID: 31574 RVA: 0x0003A490 File Offset: 0x00038690
		public unsafe bool _ReceiveInput_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField)) = value;
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06007B57 RID: 31575 RVA: 0x0021699C File Offset: 0x00214B9C
		// (set) Token: 0x06007B58 RID: 31576 RVA: 0x0003A4AB File Offset: 0x000386AB
		public unsafe static float FinalizeRange_Min
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&value));
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06007B59 RID: 31577 RVA: 0x002169B8 File Offset: 0x00214BB8
		// (set) Token: 0x06007B5A RID: 31578 RVA: 0x0003A4B9 File Offset: 0x000386B9
		public unsafe static float FinalizeRange_Max
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&value));
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x002169D4 File Offset: 0x00214BD4
		// (set) Token: 0x06007B5C RID: 31580 RVA: 0x0003A4C7 File Offset: 0x000386C7
		public unsafe float ConveyorSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed)) = value;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x002169FC File Offset: 0x00214BFC
		// (set) Token: 0x06007B5E RID: 31582 RVA: 0x0003A4E2 File Offset: 0x000386E2
		public unsafe float ConveyorAcceleration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration)) = value;
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06007B5F RID: 31583 RVA: 0x00216A24 File Offset: 0x00214C24
		// (set) Token: 0x06007B60 RID: 31584 RVA: 0x0003A4FD File Offset: 0x000386FD
		public unsafe float BaggieRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius)) = value;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x00216A4C File Offset: 0x00214C4C
		// (set) Token: 0x06007B62 RID: 31586 RVA: 0x0003A518 File Offset: 0x00038718
		public unsafe float JarRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius)) = value;
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x00216A74 File Offset: 0x00214C74
		// (set) Token: 0x06007B64 RID: 31588 RVA: 0x0003A533 File Offset: 0x00038733
		public unsafe float DeployAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle)) = value;
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06007B65 RID: 31589 RVA: 0x00216A9C File Offset: 0x00214C9C
		// (set) Token: 0x06007B66 RID: 31590 RVA: 0x0003A54E File Offset: 0x0003874E
		public unsafe float ProductInitialForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce)) = value;
			}
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x06007B67 RID: 31591 RVA: 0x00216AC4 File Offset: 0x00214CC4
		// (set) Token: 0x06007B68 RID: 31592 RVA: 0x0003A569 File Offset: 0x00038769
		public unsafe float ProductRandomTorque
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque)) = value;
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06007B69 RID: 31593 RVA: 0x00216AEC File Offset: 0x00214CEC
		// (set) Token: 0x06007B6A RID: 31594 RVA: 0x0003A584 File Offset: 0x00038784
		public unsafe float KickForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce)) = value;
			}
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06007B6B RID: 31595 RVA: 0x00216B14 File Offset: 0x00214D14
		// (set) Token: 0x06007B6C RID: 31596 RVA: 0x0003A59F File Offset: 0x0003879F
		public unsafe float DropCooldown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown)) = value;
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06007B6D RID: 31597 RVA: 0x00216B3C File Offset: 0x00214D3C
		// (set) Token: 0x06007B6E RID: 31598 RVA: 0x0003A5BA File Offset: 0x000387BA
		public unsafe PackagingStation Station
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x00216B6C File Offset: 0x00214D6C
		// (set) Token: 0x06007B70 RID: 31600 RVA: 0x0003A5D9 File Offset: 0x000387D9
		public unsafe Transform ConveyorModel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x00216B9C File Offset: 0x00214D9C
		// (set) Token: 0x06007B72 RID: 31602 RVA: 0x0003A5F8 File Offset: 0x000387F8
		public unsafe Animation DoorAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x00216BCC File Offset: 0x00214DCC
		// (set) Token: 0x06007B74 RID: 31604 RVA: 0x0003A617 File Offset: 0x00038817
		public unsafe Animation CapAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x06007B75 RID: 31605 RVA: 0x00216BFC File Offset: 0x00214DFC
		// (set) Token: 0x06007B76 RID: 31606 RVA: 0x0003A636 File Offset: 0x00038836
		public unsafe Animation SealAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251F RID: 9503
		// (get) Token: 0x06007B77 RID: 31607 RVA: 0x00216C2C File Offset: 0x00214E2C
		// (set) Token: 0x06007B78 RID: 31608 RVA: 0x0003A655 File Offset: 0x00038855
		public unsafe Animation KickAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002520 RID: 9504
		// (get) Token: 0x06007B79 RID: 31609 RVA: 0x00216C5C File Offset: 0x00214E5C
		// (set) Token: 0x06007B7A RID: 31610 RVA: 0x0003A674 File Offset: 0x00038874
		public unsafe Clickable LeftButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002521 RID: 9505
		// (get) Token: 0x06007B7B RID: 31611 RVA: 0x00216C8C File Offset: 0x00214E8C
		// (set) Token: 0x06007B7C RID: 31612 RVA: 0x0003A693 File Offset: 0x00038893
		public unsafe Clickable RightButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x06007B7D RID: 31613 RVA: 0x00216CBC File Offset: 0x00214EBC
		// (set) Token: 0x06007B7E RID: 31614 RVA: 0x0003A6B2 File Offset: 0x000388B2
		public unsafe Clickable DropButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x06007B7F RID: 31615 RVA: 0x00216CEC File Offset: 0x00214EEC
		// (set) Token: 0x06007B80 RID: 31616 RVA: 0x0003A6D1 File Offset: 0x000388D1
		public unsafe Transform PackagingContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x06007B81 RID: 31617 RVA: 0x00216D1C File Offset: 0x00214F1C
		// (set) Token: 0x06007B82 RID: 31618 RVA: 0x0003A6F0 File Offset: 0x000388F0
		public unsafe TextMeshPro ProductCountText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x00216D4C File Offset: 0x00214F4C
		// (set) Token: 0x06007B84 RID: 31620 RVA: 0x0003A70F File Offset: 0x0003890F
		public unsafe Transform HopperDropPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x00216D7C File Offset: 0x00214F7C
		// (set) Token: 0x06007B86 RID: 31622 RVA: 0x0003A72E File Offset: 0x0003892E
		public unsafe Transform BaggieStartPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x00216DAC File Offset: 0x00214FAC
		// (set) Token: 0x06007B88 RID: 31624 RVA: 0x0003A74D File Offset: 0x0003894D
		public unsafe Transform JarStartPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x00216DDC File Offset: 0x00214FDC
		// (set) Token: 0x06007B8A RID: 31626 RVA: 0x0003A76C File Offset: 0x0003896C
		public unsafe Transform ProductContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x06007B8B RID: 31627 RVA: 0x00216E0C File Offset: 0x0021500C
		// (set) Token: 0x06007B8C RID: 31628 RVA: 0x0003A78B File Offset: 0x0003898B
		public unsafe Transform KickOrigin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x00216E3C File Offset: 0x0021503C
		// (set) Token: 0x06007B8E RID: 31630 RVA: 0x0003A7AA File Offset: 0x000389AA
		public unsafe SphereCollider HopperInputCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x00216E6C File Offset: 0x0021506C
		// (set) Token: 0x06007B90 RID: 31632 RVA: 0x0003A7C9 File Offset: 0x000389C9
		public unsafe AudioSourceController KickSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x06007B91 RID: 31633 RVA: 0x00216E9C File Offset: 0x0021509C
		// (set) Token: 0x06007B92 RID: 31634 RVA: 0x0003A7E8 File Offset: 0x000389E8
		public unsafe AudioSourceController MotorSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x00216ECC File Offset: 0x002150CC
		// (set) Token: 0x06007B94 RID: 31636 RVA: 0x0003A807 File Offset: 0x00038A07
		public unsafe AudioSourceController DropSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06007B95 RID: 31637 RVA: 0x00216EFC File Offset: 0x002150FC
		// (set) Token: 0x06007B96 RID: 31638 RVA: 0x0003A826 File Offset: 0x00038A26
		public unsafe FunctionalPackaging PackagingPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x00216F2C File Offset: 0x0021512C
		// (set) Token: 0x06007B98 RID: 31640 RVA: 0x0003A845 File Offset: 0x00038A45
		public unsafe int ConcealedPackaging
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging)) = value;
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x06007B99 RID: 31641 RVA: 0x00216F54 File Offset: 0x00215154
		// (set) Token: 0x06007B9A RID: 31642 RVA: 0x0003A860 File Offset: 0x00038A60
		public unsafe ProductItemInstance ProductItem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x06007B9B RID: 31643 RVA: 0x00216F84 File Offset: 0x00215184
		// (set) Token: 0x06007B9C RID: 31644 RVA: 0x0003A87F File Offset: 0x00038A7F
		public unsafe FunctionalProduct ProductPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x00216FB4 File Offset: 0x002151B4
		// (set) Token: 0x06007B9E RID: 31646 RVA: 0x0003A89E File Offset: 0x00038A9E
		public unsafe int ProductInHopper
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper)) = value;
			}
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x00216FDC File Offset: 0x002151DC
		// (set) Token: 0x06007BA0 RID: 31648 RVA: 0x0003A8B9 File Offset: 0x00038AB9
		public unsafe List<PackagingTool.PackagingInstance> PackagingInstances
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingTool.PackagingInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x06007BA1 RID: 31649 RVA: 0x0021700C File Offset: 0x0021520C
		// (set) Token: 0x06007BA2 RID: 31650 RVA: 0x0003A8D8 File Offset: 0x00038AD8
		public unsafe List<FunctionalProduct> ProductInstances
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x0021703C File Offset: 0x0021523C
		// (set) Token: 0x06007BA4 RID: 31652 RVA: 0x0003A8F7 File Offset: 0x00038AF7
		public unsafe List<FunctionalPackaging> FinalizedPackaging
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalPackaging>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x0021706C File Offset: 0x0021526C
		// (set) Token: 0x06007BA6 RID: 31654 RVA: 0x0003A916 File Offset: 0x00038B16
		public unsafe float conveyorVelocity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity)) = value;
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x00217094 File Offset: 0x00215294
		// (set) Token: 0x06007BA8 RID: 31656 RVA: 0x0003A931 File Offset: 0x00038B31
		public unsafe int directionInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput)) = value;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x002170BC File Offset: 0x002152BC
		// (set) Token: 0x06007BAA RID: 31658 RVA: 0x0003A94C File Offset: 0x00038B4C
		public unsafe Task task
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x002170EC File Offset: 0x002152EC
		// (set) Token: 0x06007BAC RID: 31660 RVA: 0x0003A96B File Offset: 0x00038B6B
		public unsafe PackagingTool.PackagingInstance finalizeInstance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeInstance);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x0021711C File Offset: 0x0021531C
		// (set) Token: 0x06007BAE RID: 31662 RVA: 0x0003A98A File Offset: 0x00038B8A
		public unsafe Coroutine finalizeCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x0021714C File Offset: 0x0021534C
		// (set) Token: 0x06007BB0 RID: 31664 RVA: 0x0003A9A9 File Offset: 0x00038BA9
		public unsafe bool leftDown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x06007BB1 RID: 31665 RVA: 0x00217174 File Offset: 0x00215374
		// (set) Token: 0x06007BB2 RID: 31666 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		public unsafe bool rightDown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x0021719C File Offset: 0x0021539C
		// (set) Token: 0x06007BB4 RID: 31668 RVA: 0x0003A9DF File Offset: 0x00038BDF
		public unsafe bool dropDown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown)) = value;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x002171C4 File Offset: 0x002153C4
		// (set) Token: 0x06007BB6 RID: 31670 RVA: 0x0003A9FA File Offset: 0x00038BFA
		public unsafe float timeSinceLastDrop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop)) = value;
			}
		}

		// Token: 0x040053EB RID: 21483
		private static readonly System.IntPtr NativeFieldInfoPtr__ReceiveInput_k__BackingField;

		// Token: 0x040053EC RID: 21484
		private static readonly System.IntPtr NativeFieldInfoPtr_FinalizeRange_Min;

		// Token: 0x040053ED RID: 21485
		private static readonly System.IntPtr NativeFieldInfoPtr_FinalizeRange_Max;

		// Token: 0x040053EE RID: 21486
		private static readonly System.IntPtr NativeFieldInfoPtr_ConveyorSpeed;

		// Token: 0x040053EF RID: 21487
		private static readonly System.IntPtr NativeFieldInfoPtr_ConveyorAcceleration;

		// Token: 0x040053F0 RID: 21488
		private static readonly System.IntPtr NativeFieldInfoPtr_BaggieRadius;

		// Token: 0x040053F1 RID: 21489
		private static readonly System.IntPtr NativeFieldInfoPtr_JarRadius;

		// Token: 0x040053F2 RID: 21490
		private static readonly System.IntPtr NativeFieldInfoPtr_DeployAngle;

		// Token: 0x040053F3 RID: 21491
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductInitialForce;

		// Token: 0x040053F4 RID: 21492
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductRandomTorque;

		// Token: 0x040053F5 RID: 21493
		private static readonly System.IntPtr NativeFieldInfoPtr_KickForce;

		// Token: 0x040053F6 RID: 21494
		private static readonly System.IntPtr NativeFieldInfoPtr_DropCooldown;

		// Token: 0x040053F7 RID: 21495
		private static readonly System.IntPtr NativeFieldInfoPtr_Station;

		// Token: 0x040053F8 RID: 21496
		private static readonly System.IntPtr NativeFieldInfoPtr_ConveyorModel;

		// Token: 0x040053F9 RID: 21497
		private static readonly System.IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x040053FA RID: 21498
		private static readonly System.IntPtr NativeFieldInfoPtr_CapAnim;

		// Token: 0x040053FB RID: 21499
		private static readonly System.IntPtr NativeFieldInfoPtr_SealAnim;

		// Token: 0x040053FC RID: 21500
		private static readonly System.IntPtr NativeFieldInfoPtr_KickAnim;

		// Token: 0x040053FD RID: 21501
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftButton;

		// Token: 0x040053FE RID: 21502
		private static readonly System.IntPtr NativeFieldInfoPtr_RightButton;

		// Token: 0x040053FF RID: 21503
		private static readonly System.IntPtr NativeFieldInfoPtr_DropButton;

		// Token: 0x04005400 RID: 21504
		private static readonly System.IntPtr NativeFieldInfoPtr_PackagingContainer;

		// Token: 0x04005401 RID: 21505
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductCountText;

		// Token: 0x04005402 RID: 21506
		private static readonly System.IntPtr NativeFieldInfoPtr_HopperDropPoint;

		// Token: 0x04005403 RID: 21507
		private static readonly System.IntPtr NativeFieldInfoPtr_BaggieStartPoint;

		// Token: 0x04005404 RID: 21508
		private static readonly System.IntPtr NativeFieldInfoPtr_JarStartPoint;

		// Token: 0x04005405 RID: 21509
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x04005406 RID: 21510
		private static readonly System.IntPtr NativeFieldInfoPtr_KickOrigin;

		// Token: 0x04005407 RID: 21511
		private static readonly System.IntPtr NativeFieldInfoPtr_HopperInputCollider;

		// Token: 0x04005408 RID: 21512
		private static readonly System.IntPtr NativeFieldInfoPtr_KickSound;

		// Token: 0x04005409 RID: 21513
		private static readonly System.IntPtr NativeFieldInfoPtr_MotorSound;

		// Token: 0x0400540A RID: 21514
		private static readonly System.IntPtr NativeFieldInfoPtr_DropSound;

		// Token: 0x0400540B RID: 21515
		private static readonly System.IntPtr NativeFieldInfoPtr_PackagingPrefab;

		// Token: 0x0400540C RID: 21516
		private static readonly System.IntPtr NativeFieldInfoPtr_ConcealedPackaging;

		// Token: 0x0400540D RID: 21517
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductItem;

		// Token: 0x0400540E RID: 21518
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductPrefab;

		// Token: 0x0400540F RID: 21519
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductInHopper;

		// Token: 0x04005410 RID: 21520
		private static readonly System.IntPtr NativeFieldInfoPtr_PackagingInstances;

		// Token: 0x04005411 RID: 21521
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductInstances;

		// Token: 0x04005412 RID: 21522
		private static readonly System.IntPtr NativeFieldInfoPtr_FinalizedPackaging;

		// Token: 0x04005413 RID: 21523
		private static readonly System.IntPtr NativeFieldInfoPtr_conveyorVelocity;

		// Token: 0x04005414 RID: 21524
		private static readonly System.IntPtr NativeFieldInfoPtr_directionInput;

		// Token: 0x04005415 RID: 21525
		private static readonly System.IntPtr NativeFieldInfoPtr_task;

		// Token: 0x04005416 RID: 21526
		private static readonly System.IntPtr NativeFieldInfoPtr_finalizeInstance;

		// Token: 0x04005417 RID: 21527
		private static readonly System.IntPtr NativeFieldInfoPtr_finalizeCoroutine;

		// Token: 0x04005418 RID: 21528
		private static readonly System.IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x04005419 RID: 21529
		private static readonly System.IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x0400541A RID: 21530
		private static readonly System.IntPtr NativeFieldInfoPtr_dropDown;

		// Token: 0x0400541B RID: 21531
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastDrop;

		// Token: 0x0400541C RID: 21532
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0;

		// Token: 0x0400541D RID: 21533
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0;

		// Token: 0x0400541E RID: 21534
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0;

		// Token: 0x0400541F RID: 21535
		private static readonly System.IntPtr NativeMethodInfoPtr_Deinitialize_Public_Void_0;

		// Token: 0x04005420 RID: 21536
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0;

		// Token: 0x04005421 RID: 21537
		private static readonly System.IntPtr NativeMethodInfoPtr_UnloadPackaging_Private_Void_0;

		// Token: 0x04005422 RID: 21538
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0;

		// Token: 0x04005423 RID: 21539
		private static readonly System.IntPtr NativeMethodInfoPtr_UnloadProduct_Private_Void_0;

		// Token: 0x04005424 RID: 21540
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005425 RID: 21541
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04005426 RID: 21542
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScreen_Private_Void_0;

		// Token: 0x04005427 RID: 21543
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConveyor_Private_Void_0;

		// Token: 0x04005428 RID: 21544
		private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Private_Void_Single_0;

		// Token: 0x04005429 RID: 21545
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0;

		// Token: 0x0400542A RID: 21546
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckFinalize_Private_Void_0;

		// Token: 0x0400542B RID: 21547
		private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0;

		// Token: 0x0400542C RID: 21548
		private static readonly System.IntPtr NativeMethodInfoPtr_DropProduct_Private_Void_0;

		// Token: 0x0400542D RID: 21549
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckInsertions_Private_Void_0;

		// Token: 0x0400542E RID: 21550
		private static readonly System.IntPtr NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0;

		// Token: 0x0400542F RID: 21551
		private static readonly System.IntPtr NativeMethodInfoPtr_DeployPackaging_Private_Void_0;

		// Token: 0x04005430 RID: 21552
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF6 RID: 2806
		public class PackagingInstance : Il2CppSystem.Object
		{
			// Token: 0x0600D87E RID: 55422 RVA: 0x0033DCF0 File Offset: 0x0033BEF0
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingInstance()
			{
				Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr);
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Container");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "ContainerRb");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Packaging");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "AnglePosition");
				PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678862);
				PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678863);
			}

			// Token: 0x0600D87F RID: 55423 RVA: 0x0033DD94 File Offset: 0x0033BF94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236614, RefRangeEnd = 236615, XrefRangeStart = 236608, XrefRangeEnd = 236614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangePosition(float angleDelta)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref angleDelta;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D880 RID: 55424 RVA: 0x0033DDD4 File Offset: 0x0033BFD4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D881 RID: 55425 RVA: 0x000690EC File Offset: 0x000672EC
			public PackagingInstance(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D6 RID: 17110
			// (get) Token: 0x0600D882 RID: 55426 RVA: 0x0033DE10 File Offset: 0x0033C010
			// (set) Token: 0x0600D883 RID: 55427 RVA: 0x000690F5 File Offset: 0x000672F5
			public unsafe Transform Container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D7 RID: 17111
			// (get) Token: 0x0600D884 RID: 55428 RVA: 0x0033DE40 File Offset: 0x0033C040
			// (set) Token: 0x0600D885 RID: 55429 RVA: 0x00069114 File Offset: 0x00067314
			public unsafe Rigidbody ContainerRb
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D8 RID: 17112
			// (get) Token: 0x0600D886 RID: 55430 RVA: 0x0033DE70 File Offset: 0x0033C070
			// (set) Token: 0x0600D887 RID: 55431 RVA: 0x00069133 File Offset: 0x00067333
			public unsafe FunctionalPackaging Packaging
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D9 RID: 17113
			// (get) Token: 0x0600D888 RID: 55432 RVA: 0x0033DEA0 File Offset: 0x0033C0A0
			// (set) Token: 0x0600D889 RID: 55433 RVA: 0x00069152 File Offset: 0x00067352
			public unsafe float AnglePosition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition)) = value;
				}
			}

			// Token: 0x040091EC RID: 37356
			private static readonly System.IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x040091ED RID: 37357
			private static readonly System.IntPtr NativeFieldInfoPtr_ContainerRb;

			// Token: 0x040091EE RID: 37358
			private static readonly System.IntPtr NativeFieldInfoPtr_Packaging;

			// Token: 0x040091EF RID: 37359
			private static readonly System.IntPtr NativeFieldInfoPtr_AnglePosition;

			// Token: 0x040091F0 RID: 37360
			private static readonly System.IntPtr NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0;

			// Token: 0x040091F1 RID: 37361
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF7 RID: 2807
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D88A RID: 55434 RVA: 0x0033DEC8 File Offset: 0x0033C0C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr);
				PackagingTool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9");
				PackagingTool.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9__63_0");
				PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678865);
				PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678866);
			}

			// Token: 0x0600D88B RID: 55435 RVA: 0x0033DF44 File Offset: 0x0033C144
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D88C RID: 55436 RVA: 0x0033DF80 File Offset: 0x0033C180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236615, XrefRangeEnd = 236617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rotate_b__63_0(PackagingTool.PackagingInstance a, PackagingTool.PackagingInstance b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D88D RID: 55437 RVA: 0x0006916D File Offset: 0x0006736D
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DA RID: 17114
			// (get) Token: 0x0600D88E RID: 55438 RVA: 0x0033DFE0 File Offset: 0x0033C1E0
			// (set) Token: 0x0600D88F RID: 55439 RVA: 0x00069176 File Offset: 0x00067376
			public unsafe static PackagingTool.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DB RID: 17115
			// (get) Token: 0x0600D890 RID: 55440 RVA: 0x0033E008 File Offset: 0x0033C208
			// (set) Token: 0x0600D891 RID: 55441 RVA: 0x00069188 File Offset: 0x00067388
			public unsafe static Il2CppSystem.Comparison<PackagingTool.PackagingInstance> __9__63_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<PackagingTool.PackagingInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091F2 RID: 37362
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091F3 RID: 37363
			private static readonly System.IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x040091F4 RID: 37364
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091F5 RID: 37365
			private static readonly System.IntPtr NativeMethodInfoPtr__Rotate_b__63_0_Internal_Int32_PackagingInstance_PackagingInstance_0;
		}

		// Token: 0x02000AF8 RID: 2808
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D892 RID: 55442 RVA: 0x0033E030 File Offset: 0x0033C230
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr);
				PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "instance");
				PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, 100678867);
				PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, 100678868);
			}

			// Token: 0x0600D893 RID: 55443 RVA: 0x0033E0AC File Offset: 0x0033C2AC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D894 RID: 55444 RVA: 0x0033E0E8 File Offset: 0x0033C2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236660, XrefRangeEnd = 236665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D895 RID: 55445 RVA: 0x0006919A File Offset: 0x0006739A
			public __c__DisplayClass66_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DC RID: 17116
			// (get) Token: 0x0600D896 RID: 55446 RVA: 0x0033E128 File Offset: 0x0033C328
			// (set) Token: 0x0600D897 RID: 55447 RVA: 0x000691A3 File Offset: 0x000673A3
			public unsafe PackagingTool.PackagingInstance instance
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DD RID: 17117
			// (get) Token: 0x0600D898 RID: 55448 RVA: 0x0033E158 File Offset: 0x0033C358
			// (set) Token: 0x0600D899 RID: 55449 RVA: 0x000691C2 File Offset: 0x000673C2
			public unsafe PackagingTool __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091F6 RID: 37366
			private static readonly System.IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x040091F7 RID: 37367
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091F8 RID: 37368
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091F9 RID: 37369
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CBF RID: 3263
			[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass66_0+<<Finalize>g__FinalizeRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E9EB RID: 59883 RVA: 0x0036FB20 File Offset: 0x0036DD20
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0>.NativeClassPtr, "<<Finalize>g__FinalizeRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678869);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678870);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678871);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678872);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678873);
					PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678874);
				}

				// Token: 0x0600E9EC RID: 59884 RVA: 0x0036FC00 File Offset: 0x0036DE00
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9ED RID: 59885 RVA: 0x0036FC48 File Offset: 0x0036DE48
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9EE RID: 59886 RVA: 0x0036FC7C File Offset: 0x0036DE7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236617, XrefRangeEnd = 236655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004855 RID: 18517
				// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x0036FCB8 File Offset: 0x0036DEB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9F0 RID: 59888 RVA: 0x0036FCF8 File Offset: 0x0036DEF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236655, XrefRangeEnd = 236660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004856 RID: 18518
				// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x0036FD2C File Offset: 0x0036DF2C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9F2 RID: 59890 RVA: 0x00071BDE File Offset: 0x0006FDDE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004852 RID: 18514
				// (get) Token: 0x0600E9F3 RID: 59891 RVA: 0x0036FD6C File Offset: 0x0036DF6C
				// (set) Token: 0x0600E9F4 RID: 59892 RVA: 0x00071BE7 File Offset: 0x0006FDE7
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004853 RID: 18515
				// (get) Token: 0x0600E9F5 RID: 59893 RVA: 0x0036FD94 File Offset: 0x0036DF94
				// (set) Token: 0x0600E9F6 RID: 59894 RVA: 0x00071C02 File Offset: 0x0006FE02
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004854 RID: 18516
				// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x0036FDC4 File Offset: 0x0036DFC4
				// (set) Token: 0x0600E9F8 RID: 59896 RVA: 0x00071C21 File Offset: 0x0006FE21
				public unsafe PackagingTool.__c__DisplayClass66_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C85 RID: 40069
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C86 RID: 40070
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C87 RID: 40071
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C88 RID: 40072
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C89 RID: 40073
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C8A RID: 40074
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C8B RID: 40075
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C8C RID: 40076
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C8D RID: 40077
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
