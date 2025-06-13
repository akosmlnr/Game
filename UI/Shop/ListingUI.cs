using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000734 RID: 1844
	public class ListingUI : MonoBehaviour
	{
		// Token: 0x0600A491 RID: 42129 RVA: 0x0029804C File Offset: 0x0029624C
		// Note: this type is marked as 'beforefieldinit'.
		static ListingUI()
		{
			Il2CppClassPointerStore<ListingUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ListingUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingUI>.NativeClassPtr);
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_Normal");
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_NoStock");
			ListingUI.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "<Listing>k__BackingField");
			ListingUI.NativeFieldInfoPtr_StockLabelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelDefault");
			ListingUI.NativeFieldInfoPtr_StockLabelNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelNone");
			ListingUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Icon");
			ListingUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "NameLabel");
			ListingUI.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabel");
			ListingUI.NativeFieldInfoPtr_StockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabel");
			ListingUI.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "LockedContainer");
			ListingUI.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "BuyButton");
			ListingUI.NativeFieldInfoPtr_DropdownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownButton");
			ListingUI.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Trigger");
			ListingUI.NativeFieldInfoPtr_DetailPanelAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DetailPanelAnchor");
			ListingUI.NativeFieldInfoPtr_DropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownAnchor");
			ListingUI.NativeFieldInfoPtr_TopDropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "TopDropdownAnchor");
			ListingUI.NativeFieldInfoPtr_hoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverStart");
			ListingUI.NativeFieldInfoPtr_hoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverEnd");
			ListingUI.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onClicked");
			ListingUI.NativeFieldInfoPtr_onDropdownClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onDropdownClicked");
			ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683525);
			ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683526);
			ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683527);
			ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683528);
			ListingUI.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683529);
			ListingUI.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683530);
			ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683531);
			ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683532);
			ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683533);
			ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683534);
			ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683535);
			ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683536);
			ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683537);
			ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683538);
			ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683539);
			ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683540);
			ListingUI.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683542);
			ListingUI.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100683543);
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600A492 RID: 42130 RVA: 0x00298374 File Offset: 0x00296574
		// (set) Token: 0x0600A493 RID: 42131 RVA: 0x002983B4 File Offset: 0x002965B4
		public unsafe ShopListing Listing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x002983F8 File Offset: 0x002965F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288823, XrefRangeEnd = 288893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x00298448 File Offset: 0x00296648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288893, XrefRangeEnd = 288904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform GetIconCopy(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x002984A4 File Offset: 0x002966A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288904, XrefRangeEnd = 288908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x002984D8 File Offset: 0x002966D8
		[CallerCount(0)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x0029850C File Offset: 0x0029670C
		[CallerCount(0)]
		public unsafe void DropdownClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x00298540 File Offset: 0x00296740
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x00298574 File Offset: 0x00296774
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x002985A8 File Offset: 0x002967A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288908, XrefRangeEnd = 288911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StockChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x002985DC File Offset: 0x002967DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288917, RefRangeEnd = 288919, XrefRangeStart = 288911, XrefRangeEnd = 288917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x00298610 File Offset: 0x00296810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288936, RefRangeEnd = 288938, XrefRangeStart = 288919, XrefRangeEnd = 288936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x00298644 File Offset: 0x00296844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288944, RefRangeEnd = 288946, XrefRangeStart = 288938, XrefRangeEnd = 288944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x00298678 File Offset: 0x00296878
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288947, RefRangeEnd = 288951, XrefRangeStart = 288946, XrefRangeEnd = 288947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAddToCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x002986B4 File Offset: 0x002968B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288955, RefRangeEnd = 288957, XrefRangeStart = 288951, XrefRangeEnd = 288955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x002986E8 File Offset: 0x002968E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288957, XrefRangeEnd = 288958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x00298724 File Offset: 0x00296924
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x00298768 File Offset: 0x00296968
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x00050BAF File Offset: 0x0004EDAF
		public ListingUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A4A5 RID: 42149 RVA: 0x002987AC File Offset: 0x002969AC
		// (set) Token: 0x0600A4A6 RID: 42150 RVA: 0x00050BB8 File Offset: 0x0004EDB8
		public unsafe static Color32 PriceLabelColor_Normal
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&value));
			}
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A4A7 RID: 42151 RVA: 0x002987C8 File Offset: 0x002969C8
		// (set) Token: 0x0600A4A8 RID: 42152 RVA: 0x00050BC6 File Offset: 0x0004EDC6
		public unsafe static Color32 PriceLabelColor_NoStock
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&value));
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600A4A9 RID: 42153 RVA: 0x002987E4 File Offset: 0x002969E4
		// (set) Token: 0x0600A4AA RID: 42154 RVA: 0x00050BD4 File Offset: 0x0004EDD4
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600A4AB RID: 42155 RVA: 0x00298814 File Offset: 0x00296A14
		// (set) Token: 0x0600A4AC RID: 42156 RVA: 0x00050BF3 File Offset: 0x0004EDF3
		public unsafe Color32 StockLabelDefault
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault)) = value;
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A4AD RID: 42157 RVA: 0x0029883C File Offset: 0x00296A3C
		// (set) Token: 0x0600A4AE RID: 42158 RVA: 0x00050C0E File Offset: 0x0004EE0E
		public unsafe Color32 StockLabelNone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone)) = value;
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A4AF RID: 42159 RVA: 0x00298864 File Offset: 0x00296A64
		// (set) Token: 0x0600A4B0 RID: 42160 RVA: 0x00050C29 File Offset: 0x0004EE29
		public unsafe Image Icon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A4B1 RID: 42161 RVA: 0x00298894 File Offset: 0x00296A94
		// (set) Token: 0x0600A4B2 RID: 42162 RVA: 0x00050C48 File Offset: 0x0004EE48
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600A4B3 RID: 42163 RVA: 0x002988C4 File Offset: 0x00296AC4
		// (set) Token: 0x0600A4B4 RID: 42164 RVA: 0x00050C67 File Offset: 0x0004EE67
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600A4B5 RID: 42165 RVA: 0x002988F4 File Offset: 0x00296AF4
		// (set) Token: 0x0600A4B6 RID: 42166 RVA: 0x00050C86 File Offset: 0x0004EE86
		public unsafe TextMeshProUGUI StockLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600A4B7 RID: 42167 RVA: 0x00298924 File Offset: 0x00296B24
		// (set) Token: 0x0600A4B8 RID: 42168 RVA: 0x00050CA5 File Offset: 0x0004EEA5
		public unsafe GameObject LockedContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x00298954 File Offset: 0x00296B54
		// (set) Token: 0x0600A4BA RID: 42170 RVA: 0x00050CC4 File Offset: 0x0004EEC4
		public unsafe Button BuyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x00298984 File Offset: 0x00296B84
		// (set) Token: 0x0600A4BC RID: 42172 RVA: 0x00050CE3 File Offset: 0x0004EEE3
		public unsafe Button DropdownButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x002989B4 File Offset: 0x00296BB4
		// (set) Token: 0x0600A4BE RID: 42174 RVA: 0x00050D02 File Offset: 0x0004EF02
		public unsafe EventTrigger Trigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x002989E4 File Offset: 0x00296BE4
		// (set) Token: 0x0600A4C0 RID: 42176 RVA: 0x00050D21 File Offset: 0x0004EF21
		public unsafe RectTransform DetailPanelAnchor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600A4C1 RID: 42177 RVA: 0x00298A14 File Offset: 0x00296C14
		// (set) Token: 0x0600A4C2 RID: 42178 RVA: 0x00050D40 File Offset: 0x0004EF40
		public unsafe RectTransform DropdownAnchor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600A4C3 RID: 42179 RVA: 0x00298A44 File Offset: 0x00296C44
		// (set) Token: 0x0600A4C4 RID: 42180 RVA: 0x00050D5F File Offset: 0x0004EF5F
		public unsafe RectTransform TopDropdownAnchor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600A4C5 RID: 42181 RVA: 0x00298A74 File Offset: 0x00296C74
		// (set) Token: 0x0600A4C6 RID: 42182 RVA: 0x00050D7E File Offset: 0x0004EF7E
		public unsafe Il2CppSystem.Action hoverStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600A4C7 RID: 42183 RVA: 0x00298AA4 File Offset: 0x00296CA4
		// (set) Token: 0x0600A4C8 RID: 42184 RVA: 0x00050D9D File Offset: 0x0004EF9D
		public unsafe Il2CppSystem.Action hoverEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600A4C9 RID: 42185 RVA: 0x00298AD4 File Offset: 0x00296CD4
		// (set) Token: 0x0600A4CA RID: 42186 RVA: 0x00050DBC File Offset: 0x0004EFBC
		public unsafe Il2CppSystem.Action onClicked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600A4CB RID: 42187 RVA: 0x00298B04 File Offset: 0x00296D04
		// (set) Token: 0x0600A4CC RID: 42188 RVA: 0x00050DDB File Offset: 0x0004EFDB
		public unsafe Il2CppSystem.Action onDropdownClicked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E68 RID: 28264
		private static readonly System.IntPtr NativeFieldInfoPtr_PriceLabelColor_Normal;

		// Token: 0x04006E69 RID: 28265
		private static readonly System.IntPtr NativeFieldInfoPtr_PriceLabelColor_NoStock;

		// Token: 0x04006E6A RID: 28266
		private static readonly System.IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04006E6B RID: 28267
		private static readonly System.IntPtr NativeFieldInfoPtr_StockLabelDefault;

		// Token: 0x04006E6C RID: 28268
		private static readonly System.IntPtr NativeFieldInfoPtr_StockLabelNone;

		// Token: 0x04006E6D RID: 28269
		private static readonly System.IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04006E6E RID: 28270
		private static readonly System.IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006E6F RID: 28271
		private static readonly System.IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006E70 RID: 28272
		private static readonly System.IntPtr NativeFieldInfoPtr_StockLabel;

		// Token: 0x04006E71 RID: 28273
		private static readonly System.IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04006E72 RID: 28274
		private static readonly System.IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006E73 RID: 28275
		private static readonly System.IntPtr NativeFieldInfoPtr_DropdownButton;

		// Token: 0x04006E74 RID: 28276
		private static readonly System.IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04006E75 RID: 28277
		private static readonly System.IntPtr NativeFieldInfoPtr_DetailPanelAnchor;

		// Token: 0x04006E76 RID: 28278
		private static readonly System.IntPtr NativeFieldInfoPtr_DropdownAnchor;

		// Token: 0x04006E77 RID: 28279
		private static readonly System.IntPtr NativeFieldInfoPtr_TopDropdownAnchor;

		// Token: 0x04006E78 RID: 28280
		private static readonly System.IntPtr NativeFieldInfoPtr_hoverStart;

		// Token: 0x04006E79 RID: 28281
		private static readonly System.IntPtr NativeFieldInfoPtr_hoverEnd;

		// Token: 0x04006E7A RID: 28282
		private static readonly System.IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x04006E7B RID: 28283
		private static readonly System.IntPtr NativeFieldInfoPtr_onDropdownClicked;

		// Token: 0x04006E7C RID: 28284
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04006E7D RID: 28285
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04006E7E RID: 28286
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0;

		// Token: 0x04006E7F RID: 28287
		private static readonly System.IntPtr NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x04006E80 RID: 28288
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006E81 RID: 28289
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006E82 RID: 28290
		private static readonly System.IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_0;

		// Token: 0x04006E83 RID: 28291
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04006E84 RID: 28292
		private static readonly System.IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04006E85 RID: 28293
		private static readonly System.IntPtr NativeMethodInfoPtr_StockChanged_Private_Void_0;

		// Token: 0x04006E86 RID: 28294
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006E87 RID: 28295
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStock_Private_Void_0;

		// Token: 0x04006E88 RID: 28296
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04006E89 RID: 28297
		private static readonly System.IntPtr NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0;

		// Token: 0x04006E8A RID: 28298
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0;

		// Token: 0x04006E8B RID: 28299
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E8C RID: 28300
		private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_BaseEventData_0;

		// Token: 0x04006E8D RID: 28301
		private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0;
	}
}
