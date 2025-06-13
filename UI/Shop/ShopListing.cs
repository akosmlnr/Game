using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000739 RID: 1849
	[System.Serializable]
	public class ShopListing : Il2CppSystem.Object
	{
		// Token: 0x0600A583 RID: 42371 RVA: 0x0029B0E0 File Offset: 0x002992E0
		// Note: this type is marked as 'beforefieldinit'.
		static ShopListing()
		{
			Il2CppClassPointerStore<ShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing>.NativeClassPtr);
			ShopListing.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "name");
			ShopListing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "Item");
			ShopListing.NativeFieldInfoPtr_OverridePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverridePrice");
			ShopListing.NativeFieldInfoPtr_OverriddenPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverriddenPrice");
			ShopListing.NativeFieldInfoPtr_LimitedStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "LimitedStock");
			ShopListing.NativeFieldInfoPtr_DefaultStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "DefaultStock");
			ShopListing.NativeFieldInfoPtr_RestockRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "RestockRate");
			ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "EnforceMinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "MinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_CanBeDelivered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CanBeDelivered");
			ShopListing.NativeFieldInfoPtr_UseIconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "UseIconTint");
			ShopListing.NativeFieldInfoPtr_IconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "IconTint");
			ShopListing.NativeFieldInfoPtr__Shop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<Shop>k__BackingField");
			ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<CurrentStock>k__BackingField");
			ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<QuantityInCart>k__BackingField");
			ShopListing.NativeFieldInfoPtr_onStockChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "onStockChanged");
			ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683653);
			ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683654);
			ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683655);
			ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683656);
			ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683657);
			ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683658);
			ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683659);
			ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683660);
			ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683661);
			ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683662);
			ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683663);
			ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683664);
			ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683665);
			ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683666);
			ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683667);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683668);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683669);
			ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683670);
			ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683671);
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600A584 RID: 42372 RVA: 0x0029B3CC File Offset: 0x002995CC
		public unsafe bool IsInStock
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0600A585 RID: 42373 RVA: 0x0029B408 File Offset: 0x00299608
		public unsafe float Price
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 290176, RefRangeEnd = 290183, XrefRangeStart = 290176, XrefRangeEnd = 290176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600A586 RID: 42374 RVA: 0x0029B444 File Offset: 0x00299644
		public unsafe bool IsUnlimitedStock
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 290183, RefRangeEnd = 290187, XrefRangeStart = 290183, XrefRangeEnd = 290183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600A587 RID: 42375 RVA: 0x0029B480 File Offset: 0x00299680
		// (set) Token: 0x0600A588 RID: 42376 RVA: 0x0029B4C0 File Offset: 0x002996C0
		public unsafe ShopInterface Shop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600A589 RID: 42377 RVA: 0x0029B504 File Offset: 0x00299704
		// (set) Token: 0x0600A58A RID: 42378 RVA: 0x0029B540 File Offset: 0x00299740
		public unsafe int CurrentStock
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49436, RefRangeEnd = 49439, XrefRangeStart = 49436, XrefRangeEnd = 49439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 51093, RefRangeEnd = 51096, XrefRangeStart = 51093, XrefRangeEnd = 51096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600A58B RID: 42379 RVA: 0x0029B580 File Offset: 0x00299780
		// (set) Token: 0x0600A58C RID: 42380 RVA: 0x0029B5BC File Offset: 0x002997BC
		public unsafe int QuantityInCart
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 71932, RefRangeEnd = 71938, XrefRangeStart = 71932, XrefRangeEnd = 71938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 261677, RefRangeEnd = 261687, XrefRangeStart = 261677, XrefRangeEnd = 261687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600A58D RID: 42381 RVA: 0x0029B5FC File Offset: 0x002997FC
		public unsafe int CurrentStockMinusCart
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 290187, RefRangeEnd = 290189, XrefRangeStart = 290187, XrefRangeEnd = 290187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A58E RID: 42382 RVA: 0x0029B638 File Offset: 0x00299838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopInterface shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A58F RID: 42383 RVA: 0x0029B67C File Offset: 0x0029987C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290189, XrefRangeEnd = 290190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Restock(bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A590 RID: 42384 RVA: 0x0029B6BC File Offset: 0x002998BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290191, RefRangeEnd = 290192, XrefRangeStart = 290190, XrefRangeEnd = 290191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStock(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A591 RID: 42385 RVA: 0x0029B6FC File Offset: 0x002998FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 290204, RefRangeEnd = 290211, XrefRangeStart = 290192, XrefRangeEnd = 290204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStock(int quantity, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A592 RID: 42386 RVA: 0x0029B748 File Offset: 0x00299948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290211, XrefRangeEnd = 290216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A593 RID: 42387 RVA: 0x0029B790 File Offset: 0x00299990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290216, XrefRangeEnd = 290223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A594 RID: 42388 RVA: 0x0029B7E4 File Offset: 0x002999E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290223, XrefRangeEnd = 290227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x0029B83C File Offset: 0x00299A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290227, RefRangeEnd = 290230, XrefRangeStart = 290227, XrefRangeEnd = 290227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantityInCart(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x0029B87C File Offset: 0x00299A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290231, RefRangeEnd = 290233, XrefRangeStart = 290230, XrefRangeEnd = 290231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x000513CF File Offset: 0x0004F5CF
		public ShopListing(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600A598 RID: 42392 RVA: 0x0029B8B8 File Offset: 0x00299AB8
		// (set) Token: 0x0600A599 RID: 42393 RVA: 0x000513D8 File Offset: 0x0004F5D8
		public unsafe string name
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600A59A RID: 42394 RVA: 0x0029B8E0 File Offset: 0x00299AE0
		// (set) Token: 0x0600A59B RID: 42395 RVA: 0x000513F7 File Offset: 0x0004F5F7
		public unsafe StorableItemDefinition Item
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600A59C RID: 42396 RVA: 0x0029B910 File Offset: 0x00299B10
		// (set) Token: 0x0600A59D RID: 42397 RVA: 0x00051416 File Offset: 0x0004F616
		public unsafe bool OverridePrice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice)) = value;
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600A59E RID: 42398 RVA: 0x0029B938 File Offset: 0x00299B38
		// (set) Token: 0x0600A59F RID: 42399 RVA: 0x00051431 File Offset: 0x0004F631
		public unsafe float OverriddenPrice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice)) = value;
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600A5A0 RID: 42400 RVA: 0x0029B960 File Offset: 0x00299B60
		// (set) Token: 0x0600A5A1 RID: 42401 RVA: 0x0005144C File Offset: 0x0004F64C
		public unsafe bool LimitedStock
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock)) = value;
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600A5A2 RID: 42402 RVA: 0x0029B988 File Offset: 0x00299B88
		// (set) Token: 0x0600A5A3 RID: 42403 RVA: 0x00051467 File Offset: 0x0004F667
		public unsafe int DefaultStock
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock)) = value;
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600A5A4 RID: 42404 RVA: 0x0029B9B0 File Offset: 0x00299BB0
		// (set) Token: 0x0600A5A5 RID: 42405 RVA: 0x00051482 File Offset: 0x0004F682
		public unsafe ShopListing.ERestockRate RestockRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate)) = value;
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600A5A6 RID: 42406 RVA: 0x0029B9D8 File Offset: 0x00299BD8
		// (set) Token: 0x0600A5A7 RID: 42407 RVA: 0x0005149D File Offset: 0x0004F69D
		public unsafe bool EnforceMinimumGameCreationVersion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600A5A8 RID: 42408 RVA: 0x0029BA00 File Offset: 0x00299C00
		// (set) Token: 0x0600A5A9 RID: 42409 RVA: 0x000514B8 File Offset: 0x0004F6B8
		public unsafe float MinimumGameCreationVersion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600A5AA RID: 42410 RVA: 0x0029BA28 File Offset: 0x00299C28
		// (set) Token: 0x0600A5AB RID: 42411 RVA: 0x000514D3 File Offset: 0x0004F6D3
		public unsafe bool CanBeDelivered
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered)) = value;
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0600A5AC RID: 42412 RVA: 0x0029BA50 File Offset: 0x00299C50
		// (set) Token: 0x0600A5AD RID: 42413 RVA: 0x000514EE File Offset: 0x0004F6EE
		public unsafe bool UseIconTint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint)) = value;
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0600A5AE RID: 42414 RVA: 0x0029BA78 File Offset: 0x00299C78
		// (set) Token: 0x0600A5AF RID: 42415 RVA: 0x00051509 File Offset: 0x0004F709
		public unsafe Color IconTint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint)) = value;
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600A5B0 RID: 42416 RVA: 0x0029BAA0 File Offset: 0x00299CA0
		// (set) Token: 0x0600A5B1 RID: 42417 RVA: 0x00051524 File Offset: 0x0004F724
		public unsafe ShopInterface _Shop_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600A5B2 RID: 42418 RVA: 0x0029BAD0 File Offset: 0x00299CD0
		// (set) Token: 0x0600A5B3 RID: 42419 RVA: 0x00051543 File Offset: 0x0004F743
		public unsafe int _CurrentStock_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField)) = value;
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600A5B4 RID: 42420 RVA: 0x0029BAF8 File Offset: 0x00299CF8
		// (set) Token: 0x0600A5B5 RID: 42421 RVA: 0x0005155E File Offset: 0x0004F75E
		public unsafe int _QuantityInCart_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField)) = value;
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600A5B6 RID: 42422 RVA: 0x0029BB20 File Offset: 0x00299D20
		// (set) Token: 0x0600A5B7 RID: 42423 RVA: 0x00051579 File Offset: 0x0004F779
		public unsafe Il2CppSystem.Action onStockChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F0B RID: 28427
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04006F0C RID: 28428
		private static readonly System.IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04006F0D RID: 28429
		private static readonly System.IntPtr NativeFieldInfoPtr_OverridePrice;

		// Token: 0x04006F0E RID: 28430
		private static readonly System.IntPtr NativeFieldInfoPtr_OverriddenPrice;

		// Token: 0x04006F0F RID: 28431
		private static readonly System.IntPtr NativeFieldInfoPtr_LimitedStock;

		// Token: 0x04006F10 RID: 28432
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultStock;

		// Token: 0x04006F11 RID: 28433
		private static readonly System.IntPtr NativeFieldInfoPtr_RestockRate;

		// Token: 0x04006F12 RID: 28434
		private static readonly System.IntPtr NativeFieldInfoPtr_EnforceMinimumGameCreationVersion;

		// Token: 0x04006F13 RID: 28435
		private static readonly System.IntPtr NativeFieldInfoPtr_MinimumGameCreationVersion;

		// Token: 0x04006F14 RID: 28436
		private static readonly System.IntPtr NativeFieldInfoPtr_CanBeDelivered;

		// Token: 0x04006F15 RID: 28437
		private static readonly System.IntPtr NativeFieldInfoPtr_UseIconTint;

		// Token: 0x04006F16 RID: 28438
		private static readonly System.IntPtr NativeFieldInfoPtr_IconTint;

		// Token: 0x04006F17 RID: 28439
		private static readonly System.IntPtr NativeFieldInfoPtr__Shop_k__BackingField;

		// Token: 0x04006F18 RID: 28440
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentStock_k__BackingField;

		// Token: 0x04006F19 RID: 28441
		private static readonly System.IntPtr NativeFieldInfoPtr__QuantityInCart_k__BackingField;

		// Token: 0x04006F1A RID: 28442
		private static readonly System.IntPtr NativeFieldInfoPtr_onStockChanged;

		// Token: 0x04006F1B RID: 28443
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0;

		// Token: 0x04006F1C RID: 28444
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04006F1D RID: 28445
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0;

		// Token: 0x04006F1E RID: 28446
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0;

		// Token: 0x04006F1F RID: 28447
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0;

		// Token: 0x04006F20 RID: 28448
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0;

		// Token: 0x04006F21 RID: 28449
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0;

		// Token: 0x04006F22 RID: 28450
		private static readonly System.IntPtr NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0;

		// Token: 0x04006F23 RID: 28451
		private static readonly System.IntPtr NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0;

		// Token: 0x04006F24 RID: 28452
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0;

		// Token: 0x04006F25 RID: 28453
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0;

		// Token: 0x04006F26 RID: 28454
		private static readonly System.IntPtr NativeMethodInfoPtr_Restock_Public_Void_Boolean_0;

		// Token: 0x04006F27 RID: 28455
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0;

		// Token: 0x04006F28 RID: 28456
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0;

		// Token: 0x04006F29 RID: 28457
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04006F2A RID: 28458
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0;

		// Token: 0x04006F2B RID: 28459
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04006F2C RID: 28460
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0;

		// Token: 0x04006F2D RID: 28461
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C0F RID: 3087
		[System.Serializable]
		public class CategoryInstance : Il2CppSystem.Object
		{
			// Token: 0x0600E2C9 RID: 58057 RVA: 0x0035B1DC File Offset: 0x003593DC
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInstance()
			{
				Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CategoryInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr);
				ShopListing.CategoryInstance.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, "Category");
				ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, 100683672);
			}

			// Token: 0x0600E2CA RID: 58058 RVA: 0x0035B230 File Offset: 0x00359430
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2CB RID: 58059 RVA: 0x0006E2FF File Offset: 0x0006C4FF
			public CategoryInstance(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F5 RID: 17909
			// (get) Token: 0x0600E2CC RID: 58060 RVA: 0x0035B26C File Offset: 0x0035946C
			// (set) Token: 0x0600E2CD RID: 58061 RVA: 0x0006E308 File Offset: 0x0006C508
			public unsafe EShopCategory Category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x040097FD RID: 38909
			private static readonly System.IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x040097FE RID: 38910
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C10 RID: 3088
		[OriginalName("Assembly-CSharp.dll", "", "ERestockRate")]
		public enum ERestockRate
		{
			// Token: 0x04009800 RID: 38912
			Daily,
			// Token: 0x04009801 RID: 38913
			Weekly,
			// Token: 0x04009802 RID: 38914
			Never
		}

		// Token: 0x02000C11 RID: 3089
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopListing+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2CE RID: 58062 RVA: 0x0035B294 File Offset: 0x00359494
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr);
				ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, "category");
				ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, 100683673);
				ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, 100683674);
			}

			// Token: 0x0600E2CF RID: 58063 RVA: 0x0035B2FC File Offset: 0x003594FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2D0 RID: 58064 RVA: 0x0035B338 File Offset: 0x00359538
			[CallerCount(0)]
			public unsafe bool _DoesListingMatchCategoryFilter_b__0(ShopListing.CategoryInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E2D1 RID: 58065 RVA: 0x0006E323 File Offset: 0x0006C523
			public __c__DisplayClass40_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F6 RID: 17910
			// (get) Token: 0x0600E2D2 RID: 58066 RVA: 0x0035B388 File Offset: 0x00359588
			// (set) Token: 0x0600E2D3 RID: 58067 RVA: 0x0006E32C File Offset: 0x0006C52C
			public unsafe EShopCategory category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x04009803 RID: 38915
			private static readonly System.IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009804 RID: 38916
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009805 RID: 38917
			private static readonly System.IntPtr NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0;
		}
	}
}
