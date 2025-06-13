using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200072E RID: 1838
	public class CartEntry : MonoBehaviour
	{
		// Token: 0x0600A448 RID: 42056 RVA: 0x002970F8 File Offset: 0x002952F8
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry()
		{
			Il2CppClassPointerStore<CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry>.NativeClassPtr);
			CartEntry.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "NameLabel");
			CartEntry.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "PriceLabel");
			CartEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "IncrementButton");
			CartEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "DecrementButton");
			CartEntry.NativeFieldInfoPtr_RemoveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "RemoveButton");
			CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Quantity>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Cart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Cart>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Listing>k__BackingField");
			CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683492);
			CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683493);
			CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683494);
			CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683495);
			CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683496);
			CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683497);
			CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683498);
			CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683499);
			CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683500);
			CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683501);
			CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683502);
			CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683503);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683504);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683505);
			CartEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100683506);
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A449 RID: 42057 RVA: 0x002972F4 File Offset: 0x002954F4
		// (set) Token: 0x0600A44A RID: 42058 RVA: 0x00297330 File Offset: 0x00295530
		public unsafe int Quantity
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 45096, RefRangeEnd = 45102, XrefRangeStart = 45096, XrefRangeEnd = 45102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 51195, RefRangeEnd = 51199, XrefRangeStart = 51195, XrefRangeEnd = 51199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x00297370 File Offset: 0x00295570
		// (set) Token: 0x0600A44C RID: 42060 RVA: 0x002973B0 File Offset: 0x002955B0
		public unsafe Cart Cart
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A44D RID: 42061 RVA: 0x002973F4 File Offset: 0x002955F4
		// (set) Token: 0x0600A44E RID: 42062 RVA: 0x00297434 File Offset: 0x00295634
		public unsafe ShopListing Listing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x00297478 File Offset: 0x00295678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288652, RefRangeEnd = 288653, XrefRangeStart = 288628, XrefRangeEnd = 288652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cart cart, ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x002974DC File Offset: 0x002956DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288656, RefRangeEnd = 288657, XrefRangeStart = 288653, XrefRangeEnd = 288656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x0029751C File Offset: 0x0029571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288657, XrefRangeEnd = 288661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x00297558 File Offset: 0x00295758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288661, XrefRangeEnd = 288664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0029758C File Offset: 0x0029578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288664, XrefRangeEnd = 288665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x002975CC File Offset: 0x002957CC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x00297608 File Offset: 0x00295808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288665, XrefRangeEnd = 288666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0029763C File Offset: 0x0029583C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288666, XrefRangeEnd = 288667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x00297670 File Offset: 0x00295870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288667, XrefRangeEnd = 288668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x000509C1 File Offset: 0x0004EBC1
		public CartEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A459 RID: 42073 RVA: 0x002976A4 File Offset: 0x002958A4
		// (set) Token: 0x0600A45A RID: 42074 RVA: 0x000509CA File Offset: 0x0004EBCA
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x002976D4 File Offset: 0x002958D4
		// (set) Token: 0x0600A45C RID: 42076 RVA: 0x000509E9 File Offset: 0x0004EBE9
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x00297704 File Offset: 0x00295904
		// (set) Token: 0x0600A45E RID: 42078 RVA: 0x00050A08 File Offset: 0x0004EC08
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A45F RID: 42079 RVA: 0x00297734 File Offset: 0x00295934
		// (set) Token: 0x0600A460 RID: 42080 RVA: 0x00050A27 File Offset: 0x0004EC27
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x00297764 File Offset: 0x00295964
		// (set) Token: 0x0600A462 RID: 42082 RVA: 0x00050A46 File Offset: 0x0004EC46
		public unsafe Button RemoveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A463 RID: 42083 RVA: 0x00297794 File Offset: 0x00295994
		// (set) Token: 0x0600A464 RID: 42084 RVA: 0x00050A65 File Offset: 0x0004EC65
		public unsafe int _Quantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A465 RID: 42085 RVA: 0x002977BC File Offset: 0x002959BC
		// (set) Token: 0x0600A466 RID: 42086 RVA: 0x00050A80 File Offset: 0x0004EC80
		public unsafe Cart _Cart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A467 RID: 42087 RVA: 0x002977EC File Offset: 0x002959EC
		// (set) Token: 0x0600A468 RID: 42088 RVA: 0x00050A9F File Offset: 0x0004EC9F
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E25 RID: 28197
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006E26 RID: 28198
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006E27 RID: 28199
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04006E28 RID: 28200
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04006E29 RID: 28201
		private static readonly IntPtr NativeFieldInfoPtr_RemoveButton;

		// Token: 0x04006E2A RID: 28202
		private static readonly IntPtr NativeFieldInfoPtr__Quantity_k__BackingField;

		// Token: 0x04006E2B RID: 28203
		private static readonly IntPtr NativeFieldInfoPtr__Cart_k__BackingField;

		// Token: 0x04006E2C RID: 28204
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04006E2D RID: 28205
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04006E2E RID: 28206
		private static readonly IntPtr NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0;

		// Token: 0x04006E2F RID: 28207
		private static readonly IntPtr NativeMethodInfoPtr_get_Cart_Public_get_Cart_0;

		// Token: 0x04006E30 RID: 28208
		private static readonly IntPtr NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0;

		// Token: 0x04006E31 RID: 28209
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04006E32 RID: 28210
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04006E33 RID: 28211
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0;

		// Token: 0x04006E34 RID: 28212
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x04006E35 RID: 28213
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0;

		// Token: 0x04006E36 RID: 28214
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006E37 RID: 28215
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0;

		// Token: 0x04006E38 RID: 28216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E39 RID: 28217
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_0;

		// Token: 0x04006E3A RID: 28218
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0;

		// Token: 0x04006E3B RID: 28219
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0;
	}
}
