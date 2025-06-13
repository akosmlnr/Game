using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006CF RID: 1743
	public class DeliveryApp : App<DeliveryApp>
	{
		// Token: 0x06009B4A RID: 39754 RVA: 0x0027BB18 File Offset: 0x00279D18
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryApp()
		{
			Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr);
			DeliveryApp.NativeFieldInfoPtr_deliveryShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "deliveryShops");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayPrefab");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedAnim");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedSound");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayContainer");
			DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "NoDeliveriesIndicator");
			DeliveryApp.NativeFieldInfoPtr_MainScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "MainScrollRect");
			DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "MainLayoutGroup");
			DeliveryApp.NativeFieldInfoPtr_statusDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "statusDisplays");
			DeliveryApp.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "started");
			DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682557);
			DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682558);
			DeliveryApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682559);
			DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682560);
			DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682561);
			DeliveryApp.NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682562);
			DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682563);
			DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682564);
			DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682565);
			DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682566);
			DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682567);
			DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682568);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682569);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682570);
			DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100682571);
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x0027BD3C File Offset: 0x00279F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277142, XrefRangeEnd = 277152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x0027BD78 File Offset: 0x00279F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277152, XrefRangeEnd = 277221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x0027BDB4 File Offset: 0x00279FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277221, XrefRangeEnd = 277224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x0027BDF0 File Offset: 0x00279FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277224, XrefRangeEnd = 277268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x0027BE3C File Offset: 0x0027A03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277268, XrefRangeEnd = 277284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x0027BE70 File Offset: 0x0027A070
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 277297, RefRangeEnd = 277302, XrefRangeStart = 277284, XrefRangeEnd = 277297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshContent(bool keepScrollPosition = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref keepScrollPosition;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x0027BEB0 File Offset: 0x0027A0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277302, XrefRangeEnd = 277304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOrderSubmittedAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x0027BEE4 File Offset: 0x0027A0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277304, XrefRangeEnd = 277323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDeliveryStatusDisplay(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x0027BF28 File Offset: 0x0027A128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277323, XrefRangeEnd = 277352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeliveryCompleted(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x0027BF6C File Offset: 0x0027A16C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277381, RefRangeEnd = 277383, XrefRangeStart = 277352, XrefRangeEnd = 277381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortStatusDisplays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x0027BFA0 File Offset: 0x0027A1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277383, XrefRangeEnd = 277387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNoDeliveriesIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x0027BFD4 File Offset: 0x0027A1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277387, XrefRangeEnd = 277408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x0027C00C File Offset: 0x0027A20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277408, XrefRangeEnd = 277423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(ShopInterface matchingShop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchingShop);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x0027C05C File Offset: 0x0027A25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277438, RefRangeEnd = 277439, XrefRangeStart = 277423, XrefRangeEnd = 277438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x0027C0AC File Offset: 0x0027A2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277439, XrefRangeEnd = 277459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x0004B72A File Offset: 0x0004992A
		public DeliveryApp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x06009B5B RID: 39771 RVA: 0x0027C0E8 File Offset: 0x0027A2E8
		// (set) Token: 0x06009B5C RID: 39772 RVA: 0x0004B733 File Offset: 0x00049933
		public unsafe List<DeliveryShop> deliveryShops
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryShop>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x06009B5D RID: 39773 RVA: 0x0027C118 File Offset: 0x0027A318
		// (set) Token: 0x06009B5E RID: 39774 RVA: 0x0004B752 File Offset: 0x00049952
		public unsafe DeliveryStatusDisplay StatusDisplayPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryStatusDisplay>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x06009B5F RID: 39775 RVA: 0x0027C148 File Offset: 0x0027A348
		// (set) Token: 0x06009B60 RID: 39776 RVA: 0x0004B771 File Offset: 0x00049971
		public unsafe Animation OrderSubmittedAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x0027C178 File Offset: 0x0027A378
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x0004B790 File Offset: 0x00049990
		public unsafe AudioSourceController OrderSubmittedSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x06009B63 RID: 39779 RVA: 0x0027C1A8 File Offset: 0x0027A3A8
		// (set) Token: 0x06009B64 RID: 39780 RVA: 0x0004B7AF File Offset: 0x000499AF
		public unsafe RectTransform StatusDisplayContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x0027C1D8 File Offset: 0x0027A3D8
		// (set) Token: 0x06009B66 RID: 39782 RVA: 0x0004B7CE File Offset: 0x000499CE
		public unsafe RectTransform NoDeliveriesIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x06009B67 RID: 39783 RVA: 0x0027C208 File Offset: 0x0027A408
		// (set) Token: 0x06009B68 RID: 39784 RVA: 0x0004B7ED File Offset: 0x000499ED
		public unsafe ScrollRect MainScrollRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainScrollRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x06009B69 RID: 39785 RVA: 0x0027C238 File Offset: 0x0027A438
		// (set) Token: 0x06009B6A RID: 39786 RVA: 0x0004B80C File Offset: 0x00049A0C
		public unsafe LayoutGroup MainLayoutGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_MainLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x0027C268 File Offset: 0x0027A468
		// (set) Token: 0x06009B6C RID: 39788 RVA: 0x0004B82B File Offset: 0x00049A2B
		public unsafe List<DeliveryStatusDisplay> statusDisplays
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryStatusDisplay>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x06009B6D RID: 39789 RVA: 0x0027C298 File Offset: 0x0027A498
		// (set) Token: 0x06009B6E RID: 39790 RVA: 0x0004B84A File Offset: 0x00049A4A
		public unsafe bool started
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x04006894 RID: 26772
		private static readonly System.IntPtr NativeFieldInfoPtr_deliveryShops;

		// Token: 0x04006895 RID: 26773
		private static readonly System.IntPtr NativeFieldInfoPtr_StatusDisplayPrefab;

		// Token: 0x04006896 RID: 26774
		private static readonly System.IntPtr NativeFieldInfoPtr_OrderSubmittedAnim;

		// Token: 0x04006897 RID: 26775
		private static readonly System.IntPtr NativeFieldInfoPtr_OrderSubmittedSound;

		// Token: 0x04006898 RID: 26776
		private static readonly System.IntPtr NativeFieldInfoPtr_StatusDisplayContainer;

		// Token: 0x04006899 RID: 26777
		private static readonly System.IntPtr NativeFieldInfoPtr_NoDeliveriesIndicator;

		// Token: 0x0400689A RID: 26778
		private static readonly System.IntPtr NativeFieldInfoPtr_MainScrollRect;

		// Token: 0x0400689B RID: 26779
		private static readonly System.IntPtr NativeFieldInfoPtr_MainLayoutGroup;

		// Token: 0x0400689C RID: 26780
		private static readonly System.IntPtr NativeFieldInfoPtr_statusDisplays;

		// Token: 0x0400689D RID: 26781
		private static readonly System.IntPtr NativeFieldInfoPtr_started;

		// Token: 0x0400689E RID: 26782
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400689F RID: 26783
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040068A0 RID: 26784
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040068A1 RID: 26785
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040068A2 RID: 26786
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040068A3 RID: 26787
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshContent_Public_Void_Boolean_0;

		// Token: 0x040068A4 RID: 26788
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0;

		// Token: 0x040068A5 RID: 26789
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0;

		// Token: 0x040068A6 RID: 26790
		private static readonly System.IntPtr NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0;

		// Token: 0x040068A7 RID: 26791
		private static readonly System.IntPtr NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0;

		// Token: 0x040068A8 RID: 26792
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0;

		// Token: 0x040068A9 RID: 26793
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0;

		// Token: 0x040068AA RID: 26794
		private static readonly System.IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_ShopInterface_0;

		// Token: 0x040068AB RID: 26795
		private static readonly System.IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0;

		// Token: 0x040068AC RID: 26796
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC5 RID: 3013
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E05C RID: 57436 RVA: 0x00354580 File Offset: 0x00352780
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr);
				DeliveryApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9");
				DeliveryApp.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__19_0");
				DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100682573);
				DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100682574);
			}

			// Token: 0x0600E05D RID: 57437 RVA: 0x003545FC File Offset: 0x003527FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E05E RID: 57438 RVA: 0x00354638 File Offset: 0x00352838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277120, XrefRangeEnd = 277122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortStatusDisplays_b__19_0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E05F RID: 57439 RVA: 0x0006CF4D File Offset: 0x0006B14D
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004549 RID: 17737
			// (get) Token: 0x0600E060 RID: 57440 RVA: 0x00354688 File Offset: 0x00352888
			// (set) Token: 0x0600E061 RID: 57441 RVA: 0x0006CF56 File Offset: 0x0006B156
			public unsafe static DeliveryApp.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454A RID: 17738
			// (get) Token: 0x0600E062 RID: 57442 RVA: 0x003546B0 File Offset: 0x003528B0
			// (set) Token: 0x0600E063 RID: 57443 RVA: 0x0006CF68 File Offset: 0x0006B168
			public unsafe static Il2CppSystem.Func<DeliveryStatusDisplay, int> __9__19_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<DeliveryStatusDisplay, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009698 RID: 38552
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009699 RID: 38553
			private static readonly System.IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x0400969A RID: 38554
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400969B RID: 38555
			private static readonly System.IntPtr NativeMethodInfoPtr__SortStatusDisplays_b__19_0_Internal_Int32_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000BC6 RID: 3014
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E064 RID: 57444 RVA: 0x003546D8 File Offset: 0x003528D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "keepScrollPosition");
				DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "scrollPos");
				DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, 100682575);
				DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, 100682576);
			}

			// Token: 0x0600E065 RID: 57445 RVA: 0x00354768 File Offset: 0x00352968
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E066 RID: 57446 RVA: 0x003547A4 File Offset: 0x003529A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277128, XrefRangeEnd = 277133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E067 RID: 57447 RVA: 0x0006CF7A File Offset: 0x0006B17A
			public __c__DisplayClass15_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454B RID: 17739
			// (get) Token: 0x0600E068 RID: 57448 RVA: 0x003547E4 File Offset: 0x003529E4
			// (set) Token: 0x0600E069 RID: 57449 RVA: 0x0006CF83 File Offset: 0x0006B183
			public unsafe DeliveryApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454C RID: 17740
			// (get) Token: 0x0600E06A RID: 57450 RVA: 0x00354814 File Offset: 0x00352A14
			// (set) Token: 0x0600E06B RID: 57451 RVA: 0x0006CFA2 File Offset: 0x0006B1A2
			public unsafe bool keepScrollPosition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_keepScrollPosition)) = value;
				}
			}

			// Token: 0x1700454D RID: 17741
			// (get) Token: 0x0600E06C RID: 57452 RVA: 0x0035483C File Offset: 0x00352A3C
			// (set) Token: 0x0600E06D RID: 57453 RVA: 0x0006CFBD File Offset: 0x0006B1BD
			public unsafe float scrollPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.NativeFieldInfoPtr_scrollPos)) = value;
				}
			}

			// Token: 0x0400969C RID: 38556
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400969D RID: 38557
			private static readonly System.IntPtr NativeFieldInfoPtr_keepScrollPosition;

			// Token: 0x0400969E RID: 38558
			private static readonly System.IntPtr NativeFieldInfoPtr_scrollPos;

			// Token: 0x0400969F RID: 38559
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A0 RID: 38560
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CDA RID: 3290
			[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass15_0+<<RefreshContent>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EBE0 RID: 60384 RVA: 0x00375630 File Offset: 0x00373830
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0>.NativeClassPtr, "<<RefreshContent>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682577);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682578);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682579);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682580);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682581);
					DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682582);
				}

				// Token: 0x0600EBE1 RID: 60385 RVA: 0x00375710 File Offset: 0x00373910
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBE2 RID: 60386 RVA: 0x00375758 File Offset: 0x00373958
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBE3 RID: 60387 RVA: 0x0037578C File Offset: 0x0037398C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277122, XrefRangeEnd = 277123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004919 RID: 18713
				// (get) Token: 0x0600EBE4 RID: 60388 RVA: 0x003757C8 File Offset: 0x003739C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBE5 RID: 60389 RVA: 0x00375808 File Offset: 0x00373A08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277123, XrefRangeEnd = 277128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700491A RID: 18714
				// (get) Token: 0x0600EBE6 RID: 60390 RVA: 0x0037583C File Offset: 0x00373A3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBE7 RID: 60391 RVA: 0x00072CC6 File Offset: 0x00070EC6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004916 RID: 18710
				// (get) Token: 0x0600EBE8 RID: 60392 RVA: 0x0037587C File Offset: 0x00373A7C
				// (set) Token: 0x0600EBE9 RID: 60393 RVA: 0x00072CCF File Offset: 0x00070ECF
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004917 RID: 18711
				// (get) Token: 0x0600EBEA RID: 60394 RVA: 0x003758A4 File Offset: 0x00373AA4
				// (set) Token: 0x0600EBEB RID: 60395 RVA: 0x00072CEA File Offset: 0x00070EEA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004918 RID: 18712
				// (get) Token: 0x0600EBEC RID: 60396 RVA: 0x003758D4 File Offset: 0x00373AD4
				// (set) Token: 0x0600EBED RID: 60397 RVA: 0x00072D09 File Offset: 0x00070F09
				public unsafe DeliveryApp.__c__DisplayClass15_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009DB6 RID: 40374
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009DB7 RID: 40375
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DB8 RID: 40376
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DB9 RID: 40377
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009DBA RID: 40378
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DBB RID: 40379
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009DBC RID: 40380
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009DBD RID: 40381
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DBE RID: 40382
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BC7 RID: 3015
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E06E RID: 57454 RVA: 0x00354864 File Offset: 0x00352A64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, "instance");
				DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, 100682583);
				DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr, 100682584);
			}

			// Token: 0x0600E06F RID: 57455 RVA: 0x003548CC File Offset: 0x00352ACC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E070 RID: 57456 RVA: 0x00354908 File Offset: 0x00352B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277133, XrefRangeEnd = 277135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeliveryCompleted_b__0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass18_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E071 RID: 57457 RVA: 0x0006CFD8 File Offset: 0x0006B1D8
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454E RID: 17742
			// (get) Token: 0x0600E072 RID: 57458 RVA: 0x00354958 File Offset: 0x00352B58
			// (set) Token: 0x0600E073 RID: 57459 RVA: 0x0006CFE1 File Offset: 0x0006B1E1
			public unsafe DeliveryInstance instance
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass18_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096A1 RID: 38561
			private static readonly System.IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x040096A2 RID: 38562
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A3 RID: 38563
			private static readonly System.IntPtr NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000BC8 RID: 3016
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E074 RID: 57460 RVA: 0x00354988 File Offset: 0x00352B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, "matchingShop");
				DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, 100682585);
				DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr, 100682586);
			}

			// Token: 0x0600E075 RID: 57461 RVA: 0x003549F0 File Offset: 0x00352BF0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass22_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E076 RID: 57462 RVA: 0x00354A2C File Offset: 0x00352C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277135, XrefRangeEnd = 277140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass22_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E077 RID: 57463 RVA: 0x0006D000 File Offset: 0x0006B200
			public __c__DisplayClass22_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454F RID: 17743
			// (get) Token: 0x0600E078 RID: 57464 RVA: 0x00354A7C File Offset: 0x00352C7C
			// (set) Token: 0x0600E079 RID: 57465 RVA: 0x0006D009 File Offset: 0x0006B209
			public unsafe ShopInterface matchingShop
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass22_0.NativeFieldInfoPtr_matchingShop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096A4 RID: 38564
			private static readonly System.IntPtr NativeFieldInfoPtr_matchingShop;

			// Token: 0x040096A5 RID: 38565
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A6 RID: 38566
			private static readonly System.IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}

		// Token: 0x02000BC9 RID: 3017
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E07A RID: 57466 RVA: 0x00354AAC File Offset: 0x00352CAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, "shopName");
				DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, 100682587);
				DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr, 100682588);
			}

			// Token: 0x0600E07B RID: 57467 RVA: 0x00354B14 File Offset: 0x00352D14
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass23_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E07C RID: 57468 RVA: 0x00354B50 File Offset: 0x00352D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277140, XrefRangeEnd = 277142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass23_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E07D RID: 57469 RVA: 0x0006D028 File Offset: 0x0006B228
			public __c__DisplayClass23_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004550 RID: 17744
			// (get) Token: 0x0600E07E RID: 57470 RVA: 0x00354BA0 File Offset: 0x00352DA0
			// (set) Token: 0x0600E07F RID: 57471 RVA: 0x0006D031 File Offset: 0x0006B231
			public unsafe string shopName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass23_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096A7 RID: 38567
			private static readonly System.IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x040096A8 RID: 38568
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A9 RID: 38569
			private static readonly System.IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}
	}
}
