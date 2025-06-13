using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006D0 RID: 1744
	public class DeliveryShop : MonoBehaviour
	{
		// Token: 0x06009B6F RID: 39791 RVA: 0x0027C2C0 File Offset: 0x0027A4C0
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryShop()
		{
			Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryShop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr);
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_VEHICLE_SLOT_CAPACITY");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_MIN");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_MAX");
			DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DELIVERY_TIME_ITEM_COUNT_DIVISOR");
			DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<MatchingShop>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsExpanded>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsAvailable>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage");
			DeliveryShop.NativeFieldInfoPtr_HeaderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderButton");
			DeliveryShop.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ContentsContainer");
			DeliveryShop.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingContainer");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFeeLabel");
			DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ItemTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButton");
			DeliveryShop.NativeFieldInfoPtr_OrderButtonNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButtonNote");
			DeliveryShop.NativeFieldInfoPtr_DestinationDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DestinationDropdown");
			DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "LoadingDockDropdown");
			DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "MatchingShopInterfaceName");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFee");
			DeliveryShop.NativeFieldInfoPtr_AvailableByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "AvailableByDefault");
			DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingEntryPrefab");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage_Hidden");
			DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderImage_Expanded");
			DeliveryShop.NativeFieldInfoPtr_HeaderArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "HeaderArrow");
			DeliveryShop.NativeFieldInfoPtr_listingEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "listingEntries");
			DeliveryShop.NativeFieldInfoPtr_destinationProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "destinationProperty");
			DeliveryShop.NativeFieldInfoPtr_loadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "loadingDockIndex");
			DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682589);
			DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682590);
			DeliveryShop.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682591);
			DeliveryShop.NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682592);
			DeliveryShop.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682593);
			DeliveryShop.NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682594);
			DeliveryShop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682595);
			DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682596);
			DeliveryShop.NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682597);
			DeliveryShop.NativeMethodInfoPtr_SetIsAvailable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682598);
			DeliveryShop.NativeMethodInfoPtr_OrderPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682599);
			DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682600);
			DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682601);
			DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682602);
			DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682603);
			DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682604);
			DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682605);
			DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682606);
			DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682607);
			DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682608);
			DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682609);
			DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682610);
			DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682611);
			DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682612);
			DeliveryShop.NativeMethodInfoPtr_GetOrderTotal_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682613);
			DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682614);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682615);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682616);
			DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682617);
			DeliveryShop.NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682618);
			DeliveryShop.NativeMethodInfoPtr__Start_b__37_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100682619);
		}

		// Token: 0x17002FA6 RID: 12198
		// (get) Token: 0x06009B70 RID: 39792 RVA: 0x0027C78C File Offset: 0x0027A98C
		// (set) Token: 0x06009B71 RID: 39793 RVA: 0x0027C7CC File Offset: 0x0027A9CC
		public unsafe ShopInterface MatchingShop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002FA7 RID: 12199
		// (get) Token: 0x06009B72 RID: 39794 RVA: 0x0027C810 File Offset: 0x0027AA10
		// (set) Token: 0x06009B73 RID: 39795 RVA: 0x0027C84C File Offset: 0x0027AA4C
		public unsafe bool IsExpanded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002FA8 RID: 12200
		// (get) Token: 0x06009B74 RID: 39796 RVA: 0x0027C88C File Offset: 0x0027AA8C
		// (set) Token: 0x06009B75 RID: 39797 RVA: 0x0027C8C8 File Offset: 0x0027AAC8
		public unsafe bool IsAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009B76 RID: 39798 RVA: 0x0027C908 File Offset: 0x0027AB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277459, XrefRangeEnd = 277557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x0027C93C File Offset: 0x0027AB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277557, XrefRangeEnd = 277563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B78 RID: 39800 RVA: 0x0027C970 File Offset: 0x0027AB70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277575, RefRangeEnd = 277577, XrefRangeStart = 277563, XrefRangeEnd = 277575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsExpanded(bool expanded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expanded;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x0027C9B0 File Offset: 0x0027ABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277577, XrefRangeEnd = 277585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SetIsAvailable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B7A RID: 39802 RVA: 0x0027C9E4 File Offset: 0x0027ABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277585, XrefRangeEnd = 277659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_OrderPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x0027CA18 File Offset: 0x0027AC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277659, XrefRangeEnd = 277665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x0027CA4C File Offset: 0x0027AC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277684, RefRangeEnd = 277685, XrefRangeStart = 277665, XrefRangeEnd = 277684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B7D RID: 39805 RVA: 0x0027CA80 File Offset: 0x0027AC80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 277690, RefRangeEnd = 277693, XrefRangeStart = 277685, XrefRangeEnd = 277690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x0027CAB4 File Offset: 0x0027ACB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 277696, RefRangeEnd = 277700, XrefRangeStart = 277693, XrefRangeEnd = 277696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOrderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x0027CAE8 File Offset: 0x0027ACE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277723, RefRangeEnd = 277725, XrefRangeStart = 277700, XrefRangeEnd = 277723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOrder(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x0027CB40 File Offset: 0x0027AD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277725, XrefRangeEnd = 277734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActiveDelivery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x0027CB7C File Offset: 0x0027AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277734, XrefRangeEnd = 277748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFitInVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x0027CBB8 File Offset: 0x0027ADB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277801, RefRangeEnd = 277803, XrefRangeStart = 277748, XrefRangeEnd = 277801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDestinationUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x0027CBEC File Offset: 0x0027ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277803, XrefRangeEnd = 277815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x0027CC2C File Offset: 0x0027AE2C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 277825, RefRangeEnd = 277830, XrefRangeStart = 277815, XrefRangeEnd = 277825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetPotentialDestinations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x0027CC6C File Offset: 0x0027AE6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 277866, RefRangeEnd = 277870, XrefRangeStart = 277830, XrefRangeEnd = 277866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLoadingDockUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x0027CCA0 File Offset: 0x0027AEA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 52321, RefRangeEnd = 52327, XrefRangeStart = 52321, XrefRangeEnd = 52327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadingDockDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x0027CCE0 File Offset: 0x0027AEE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 277885, RefRangeEnd = 277889, XrefRangeStart = 277870, XrefRangeEnd = 277885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCartCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x0027CD1C File Offset: 0x0027AF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277889, XrefRangeEnd = 277890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderTotal_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x0027CD58 File Offset: 0x0027AF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277904, RefRangeEnd = 277905, XrefRangeStart = 277890, XrefRangeEnd = 277904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrderItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x0027CD94 File Offset: 0x0027AF94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277946, RefRangeEnd = 277948, XrefRangeStart = 277905, XrefRangeEnd = 277946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntryOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x0027CDC8 File Offset: 0x0027AFC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277968, RefRangeEnd = 277970, XrefRangeStart = 277948, XrefRangeEnd = 277968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntriesLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x0027CDFC File Offset: 0x0027AFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277970, XrefRangeEnd = 277982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x0027CE38 File Offset: 0x0027B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__37_0(ShopInterface x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x0027CE88 File Offset: 0x0027B088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277982, XrefRangeEnd = 277983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__37_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Start_b__37_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x0004B865 File Offset: 0x00049A65
		public DeliveryShop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x0027CEBC File Offset: 0x0027B0BC
		// (set) Token: 0x06009B91 RID: 39825 RVA: 0x0004B86E File Offset: 0x00049A6E
		public unsafe static int DELIVERY_VEHICLE_SLOT_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x06009B92 RID: 39826 RVA: 0x0027CED8 File Offset: 0x0027B0D8
		// (set) Token: 0x06009B93 RID: 39827 RVA: 0x0004B87C File Offset: 0x00049A7C
		public unsafe static int DELIVERY_TIME_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x06009B94 RID: 39828 RVA: 0x0027CEF4 File Offset: 0x0027B0F4
		// (set) Token: 0x06009B95 RID: 39829 RVA: 0x0004B88A File Offset: 0x00049A8A
		public unsafe static int DELIVERY_TIME_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x06009B96 RID: 39830 RVA: 0x0027CF10 File Offset: 0x0027B110
		// (set) Token: 0x06009B97 RID: 39831 RVA: 0x0004B898 File Offset: 0x00049A98
		public unsafe static int DELIVERY_TIME_ITEM_COUNT_DIVISOR
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeliveryShop.NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR, (void*)(&value));
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x0027CF2C File Offset: 0x0027B12C
		// (set) Token: 0x06009B99 RID: 39833 RVA: 0x0004B8A6 File Offset: 0x00049AA6
		public unsafe ShopInterface _MatchingShop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x06009B9A RID: 39834 RVA: 0x0027CF5C File Offset: 0x0027B15C
		// (set) Token: 0x06009B9B RID: 39835 RVA: 0x0004B8C5 File Offset: 0x00049AC5
		public unsafe bool _IsExpanded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsExpanded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x06009B9C RID: 39836 RVA: 0x0027CF84 File Offset: 0x0027B184
		// (set) Token: 0x06009B9D RID: 39837 RVA: 0x0004B8E0 File Offset: 0x00049AE0
		public unsafe bool _IsAvailable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsAvailable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06009B9E RID: 39838 RVA: 0x0027CFAC File Offset: 0x0027B1AC
		// (set) Token: 0x06009B9F RID: 39839 RVA: 0x0004B8FB File Offset: 0x00049AFB
		public unsafe Image HeaderImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x06009BA0 RID: 39840 RVA: 0x0027CFDC File Offset: 0x0027B1DC
		// (set) Token: 0x06009BA1 RID: 39841 RVA: 0x0004B91A File Offset: 0x00049B1A
		public unsafe Button HeaderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x06009BA2 RID: 39842 RVA: 0x0027D00C File Offset: 0x0027B20C
		// (set) Token: 0x06009BA3 RID: 39843 RVA: 0x0004B939 File Offset: 0x00049B39
		public unsafe RectTransform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F94 RID: 12180
		// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x0027D03C File Offset: 0x0027B23C
		// (set) Token: 0x06009BA5 RID: 39845 RVA: 0x0004B958 File Offset: 0x00049B58
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x06009BA6 RID: 39846 RVA: 0x0027D06C File Offset: 0x0027B26C
		// (set) Token: 0x06009BA7 RID: 39847 RVA: 0x0004B977 File Offset: 0x00049B77
		public unsafe Text DeliveryFeeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x06009BA8 RID: 39848 RVA: 0x0027D09C File Offset: 0x0027B29C
		// (set) Token: 0x06009BA9 RID: 39849 RVA: 0x0004B996 File Offset: 0x00049B96
		public unsafe Text ItemTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x06009BAA RID: 39850 RVA: 0x0027D0CC File Offset: 0x0027B2CC
		// (set) Token: 0x06009BAB RID: 39851 RVA: 0x0004B9B5 File Offset: 0x00049BB5
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x06009BAC RID: 39852 RVA: 0x0027D0FC File Offset: 0x0027B2FC
		// (set) Token: 0x06009BAD RID: 39853 RVA: 0x0004B9D4 File Offset: 0x00049BD4
		public unsafe Button OrderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x06009BAE RID: 39854 RVA: 0x0027D12C File Offset: 0x0027B32C
		// (set) Token: 0x06009BAF RID: 39855 RVA: 0x0004B9F3 File Offset: 0x00049BF3
		public unsafe Text OrderButtonNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x06009BB0 RID: 39856 RVA: 0x0027D15C File Offset: 0x0027B35C
		// (set) Token: 0x06009BB1 RID: 39857 RVA: 0x0004BA12 File Offset: 0x00049C12
		public unsafe Dropdown DestinationDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x06009BB2 RID: 39858 RVA: 0x0027D18C File Offset: 0x0027B38C
		// (set) Token: 0x06009BB3 RID: 39859 RVA: 0x0004BA31 File Offset: 0x00049C31
		public unsafe Dropdown LoadingDockDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x06009BB4 RID: 39860 RVA: 0x0027D1BC File Offset: 0x0027B3BC
		// (set) Token: 0x06009BB5 RID: 39861 RVA: 0x0004BA50 File Offset: 0x00049C50
		public unsafe string MatchingShopInterfaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x06009BB6 RID: 39862 RVA: 0x0027D1E4 File Offset: 0x0027B3E4
		// (set) Token: 0x06009BB7 RID: 39863 RVA: 0x0004BA6F File Offset: 0x00049C6F
		public unsafe float DeliveryFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFee)) = value;
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x06009BB8 RID: 39864 RVA: 0x0027D20C File Offset: 0x0027B40C
		// (set) Token: 0x06009BB9 RID: 39865 RVA: 0x0004BA8A File Offset: 0x00049C8A
		public unsafe bool AvailableByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault)) = value;
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x06009BBA RID: 39866 RVA: 0x0027D234 File Offset: 0x0027B434
		// (set) Token: 0x06009BBB RID: 39867 RVA: 0x0004BAA5 File Offset: 0x00049CA5
		public unsafe ListingEntry ListingEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x06009BBC RID: 39868 RVA: 0x0027D264 File Offset: 0x0027B464
		// (set) Token: 0x06009BBD RID: 39869 RVA: 0x0004BAC4 File Offset: 0x00049CC4
		public unsafe Sprite HeaderImage_Hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Hidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x06009BBE RID: 39870 RVA: 0x0027D294 File Offset: 0x0027B494
		// (set) Token: 0x06009BBF RID: 39871 RVA: 0x0004BAE3 File Offset: 0x00049CE3
		public unsafe Sprite HeaderImage_Expanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderImage_Expanded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x0027D2C4 File Offset: 0x0027B4C4
		// (set) Token: 0x06009BC1 RID: 39873 RVA: 0x0004BB02 File Offset: 0x00049D02
		public unsafe RectTransform HeaderArrow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderArrow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_HeaderArrow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x0027D2F4 File Offset: 0x0027B4F4
		// (set) Token: 0x06009BC3 RID: 39875 RVA: 0x0004BB21 File Offset: 0x00049D21
		public unsafe List<ListingEntry> listingEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x06009BC4 RID: 39876 RVA: 0x0027D324 File Offset: 0x0027B524
		// (set) Token: 0x06009BC5 RID: 39877 RVA: 0x0004BB40 File Offset: 0x00049D40
		public unsafe Property destinationProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FA5 RID: 12197
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x0027D354 File Offset: 0x0027B554
		// (set) Token: 0x06009BC7 RID: 39879 RVA: 0x0004BB5F File Offset: 0x00049D5F
		public unsafe int loadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex)) = value;
			}
		}

		// Token: 0x040068AD RID: 26797
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_VEHICLE_SLOT_CAPACITY;

		// Token: 0x040068AE RID: 26798
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_MIN;

		// Token: 0x040068AF RID: 26799
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_MAX;

		// Token: 0x040068B0 RID: 26800
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_TIME_ITEM_COUNT_DIVISOR;

		// Token: 0x040068B1 RID: 26801
		private static readonly IntPtr NativeFieldInfoPtr__MatchingShop_k__BackingField;

		// Token: 0x040068B2 RID: 26802
		private static readonly IntPtr NativeFieldInfoPtr__IsExpanded_k__BackingField;

		// Token: 0x040068B3 RID: 26803
		private static readonly IntPtr NativeFieldInfoPtr__IsAvailable_k__BackingField;

		// Token: 0x040068B4 RID: 26804
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage;

		// Token: 0x040068B5 RID: 26805
		private static readonly IntPtr NativeFieldInfoPtr_HeaderButton;

		// Token: 0x040068B6 RID: 26806
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x040068B7 RID: 26807
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x040068B8 RID: 26808
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFeeLabel;

		// Token: 0x040068B9 RID: 26809
		private static readonly IntPtr NativeFieldInfoPtr_ItemTotalLabel;

		// Token: 0x040068BA RID: 26810
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x040068BB RID: 26811
		private static readonly IntPtr NativeFieldInfoPtr_OrderButton;

		// Token: 0x040068BC RID: 26812
		private static readonly IntPtr NativeFieldInfoPtr_OrderButtonNote;

		// Token: 0x040068BD RID: 26813
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDropdown;

		// Token: 0x040068BE RID: 26814
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockDropdown;

		// Token: 0x040068BF RID: 26815
		private static readonly IntPtr NativeFieldInfoPtr_MatchingShopInterfaceName;

		// Token: 0x040068C0 RID: 26816
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFee;

		// Token: 0x040068C1 RID: 26817
		private static readonly IntPtr NativeFieldInfoPtr_AvailableByDefault;

		// Token: 0x040068C2 RID: 26818
		private static readonly IntPtr NativeFieldInfoPtr_ListingEntryPrefab;

		// Token: 0x040068C3 RID: 26819
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage_Hidden;

		// Token: 0x040068C4 RID: 26820
		private static readonly IntPtr NativeFieldInfoPtr_HeaderImage_Expanded;

		// Token: 0x040068C5 RID: 26821
		private static readonly IntPtr NativeFieldInfoPtr_HeaderArrow;

		// Token: 0x040068C6 RID: 26822
		private static readonly IntPtr NativeFieldInfoPtr_listingEntries;

		// Token: 0x040068C7 RID: 26823
		private static readonly IntPtr NativeFieldInfoPtr_destinationProperty;

		// Token: 0x040068C8 RID: 26824
		private static readonly IntPtr NativeFieldInfoPtr_loadingDockIndex;

		// Token: 0x040068C9 RID: 26825
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0;

		// Token: 0x040068CA RID: 26826
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0;

		// Token: 0x040068CB RID: 26827
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExpanded_Public_get_Boolean_0;

		// Token: 0x040068CC RID: 26828
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExpanded_Private_set_Void_Boolean_0;

		// Token: 0x040068CD RID: 26829
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0;

		// Token: 0x040068CE RID: 26830
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAvailable_Private_set_Void_Boolean_0;

		// Token: 0x040068CF RID: 26831
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040068D0 RID: 26832
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040068D1 RID: 26833
		private static readonly IntPtr NativeMethodInfoPtr_SetIsExpanded_Public_Void_Boolean_0;

		// Token: 0x040068D2 RID: 26834
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAvailable_Public_Void_0;

		// Token: 0x040068D3 RID: 26835
		private static readonly IntPtr NativeMethodInfoPtr_OrderPressed_Public_Void_0;

		// Token: 0x040068D4 RID: 26836
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShop_Public_Void_0;

		// Token: 0x040068D5 RID: 26837
		private static readonly IntPtr NativeMethodInfoPtr_ResetCart_Public_Void_0;

		// Token: 0x040068D6 RID: 26838
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCart_Private_Void_0;

		// Token: 0x040068D7 RID: 26839
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0;

		// Token: 0x040068D8 RID: 26840
		private static readonly IntPtr NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0;

		// Token: 0x040068D9 RID: 26841
		private static readonly IntPtr NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0;

		// Token: 0x040068DA RID: 26842
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0;

		// Token: 0x040068DB RID: 26843
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0;

		// Token: 0x040068DC RID: 26844
		private static readonly IntPtr NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0;

		// Token: 0x040068DD RID: 26845
		private static readonly IntPtr NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0;

		// Token: 0x040068DE RID: 26846
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0;

		// Token: 0x040068DF RID: 26847
		private static readonly IntPtr NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0;

		// Token: 0x040068E0 RID: 26848
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCost_Private_Single_0;

		// Token: 0x040068E1 RID: 26849
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_0;

		// Token: 0x040068E2 RID: 26850
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0;

		// Token: 0x040068E3 RID: 26851
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0;

		// Token: 0x040068E4 RID: 26852
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0;

		// Token: 0x040068E5 RID: 26853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040068E6 RID: 26854
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__37_0_Private_Boolean_ShopInterface_0;

		// Token: 0x040068E7 RID: 26855
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__37_1_Private_Void_0;
	}
}
