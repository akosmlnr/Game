using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020006D2 RID: 1746
	public class ListingEntry : MonoBehaviour
	{
		// Token: 0x06009BE7 RID: 39911 RVA: 0x0027D860 File Offset: 0x0027BA60
		// Note: this type is marked as 'beforefieldinit'.
		static ListingEntry()
		{
			Il2CppClassPointerStore<ListingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "ListingEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr);
			ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<MatchingListing>k__BackingField");
			ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<SelectedQuantity>k__BackingField");
			ListingEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "Icon");
			ListingEntry.NativeFieldInfoPtr_ItemNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemNameLabel");
			ListingEntry.NativeFieldInfoPtr_ItemPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemPriceLabel");
			ListingEntry.NativeFieldInfoPtr_QuantityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "QuantityInput");
			ListingEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "IncrementButton");
			ListingEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "DecrementButton");
			ListingEntry.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "LockedContainer");
			ListingEntry.NativeFieldInfoPtr_onQuantityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "onQuantityChanged");
			ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682625);
			ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682626);
			ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682627);
			ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682628);
			ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682629);
			ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682630);
			ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682631);
			ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682632);
			ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682633);
			ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682634);
			ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682635);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682636);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682637);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100682638);
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x06009BE8 RID: 39912 RVA: 0x0027DA70 File Offset: 0x0027BC70
		// (set) Token: 0x06009BE9 RID: 39913 RVA: 0x0027DAB0 File Offset: 0x0027BCB0
		public unsafe ShopListing MatchingListing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x06009BEA RID: 39914 RVA: 0x0027DAF4 File Offset: 0x0027BCF4
		// (set) Token: 0x06009BEB RID: 39915 RVA: 0x0027DB30 File Offset: 0x0027BD30
		public unsafe int SelectedQuantity
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 31426, RefRangeEnd = 31454, XrefRangeStart = 31426, XrefRangeEnd = 31454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31454, RefRangeEnd = 31455, XrefRangeStart = 31454, XrefRangeEnd = 31455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009BEC RID: 39916 RVA: 0x0027DB70 File Offset: 0x0027BD70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278074, RefRangeEnd = 278075, XrefRangeStart = 278036, XrefRangeEnd = 278074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopListing match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x0027DBB4 File Offset: 0x0027BDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278075, XrefRangeEnd = 278081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BEE RID: 39918 RVA: 0x0027DBE8 File Offset: 0x0027BDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278081, XrefRangeEnd = 278086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quant, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quant;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BEF RID: 39919 RVA: 0x0027DC34 File Offset: 0x0027BE34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278091, RefRangeEnd = 278093, XrefRangeStart = 278086, XrefRangeEnd = 278091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x0027DC74 File Offset: 0x0027BE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278093, XrefRangeEnd = 278098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuantityInputSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF1 RID: 39921 RVA: 0x0027DCB8 File Offset: 0x0027BEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278098, XrefRangeEnd = 278107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF2 RID: 39922 RVA: 0x0027DCEC File Offset: 0x0027BEEC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF3 RID: 39923 RVA: 0x0027DD28 File Offset: 0x0027BF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278107, XrefRangeEnd = 278116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_0(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF4 RID: 39924 RVA: 0x0027DD6C File Offset: 0x0027BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278116, XrefRangeEnd = 278117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF5 RID: 39925 RVA: 0x0027DDA0 File Offset: 0x0027BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278117, XrefRangeEnd = 278118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__16_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x0004BCEB File Offset: 0x00049EEB
		public ListingEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x0027DDD4 File Offset: 0x0027BFD4
		// (set) Token: 0x06009BF8 RID: 39928 RVA: 0x0004BCF4 File Offset: 0x00049EF4
		public unsafe ShopListing _MatchingListing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x06009BF9 RID: 39929 RVA: 0x0027DE04 File Offset: 0x0027C004
		// (set) Token: 0x06009BFA RID: 39930 RVA: 0x0004BD13 File Offset: 0x00049F13
		public unsafe int _SelectedQuantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x06009BFB RID: 39931 RVA: 0x0027DE2C File Offset: 0x0027C02C
		// (set) Token: 0x06009BFC RID: 39932 RVA: 0x0004BD2E File Offset: 0x00049F2E
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x06009BFD RID: 39933 RVA: 0x0027DE5C File Offset: 0x0027C05C
		// (set) Token: 0x06009BFE RID: 39934 RVA: 0x0004BD4D File Offset: 0x00049F4D
		public unsafe Text ItemNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x06009BFF RID: 39935 RVA: 0x0027DE8C File Offset: 0x0027C08C
		// (set) Token: 0x06009C00 RID: 39936 RVA: 0x0004BD6C File Offset: 0x00049F6C
		public unsafe Text ItemPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x06009C01 RID: 39937 RVA: 0x0027DEBC File Offset: 0x0027C0BC
		// (set) Token: 0x06009C02 RID: 39938 RVA: 0x0004BD8B File Offset: 0x00049F8B
		public unsafe InputField QuantityInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x06009C03 RID: 39939 RVA: 0x0027DEEC File Offset: 0x0027C0EC
		// (set) Token: 0x06009C04 RID: 39940 RVA: 0x0004BDAA File Offset: 0x00049FAA
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x06009C05 RID: 39941 RVA: 0x0027DF1C File Offset: 0x0027C11C
		// (set) Token: 0x06009C06 RID: 39942 RVA: 0x0004BDC9 File Offset: 0x00049FC9
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x0027DF4C File Offset: 0x0027C14C
		// (set) Token: 0x06009C08 RID: 39944 RVA: 0x0004BDE8 File Offset: 0x00049FE8
		public unsafe RectTransform LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x06009C09 RID: 39945 RVA: 0x0027DF7C File Offset: 0x0027C17C
		// (set) Token: 0x06009C0A RID: 39946 RVA: 0x0004BE07 File Offset: 0x0004A007
		public unsafe UnityEvent onQuantityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068F9 RID: 26873
		private static readonly IntPtr NativeFieldInfoPtr__MatchingListing_k__BackingField;

		// Token: 0x040068FA RID: 26874
		private static readonly IntPtr NativeFieldInfoPtr__SelectedQuantity_k__BackingField;

		// Token: 0x040068FB RID: 26875
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040068FC RID: 26876
		private static readonly IntPtr NativeFieldInfoPtr_ItemNameLabel;

		// Token: 0x040068FD RID: 26877
		private static readonly IntPtr NativeFieldInfoPtr_ItemPriceLabel;

		// Token: 0x040068FE RID: 26878
		private static readonly IntPtr NativeFieldInfoPtr_QuantityInput;

		// Token: 0x040068FF RID: 26879
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04006900 RID: 26880
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04006901 RID: 26881
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04006902 RID: 26882
		private static readonly IntPtr NativeFieldInfoPtr_onQuantityChanged;

		// Token: 0x04006903 RID: 26883
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0;

		// Token: 0x04006904 RID: 26884
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0;

		// Token: 0x04006905 RID: 26885
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0;

		// Token: 0x04006906 RID: 26886
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0;

		// Token: 0x04006907 RID: 26887
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0;

		// Token: 0x04006908 RID: 26888
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLocked_Public_Void_0;

		// Token: 0x04006909 RID: 26889
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x0400690A RID: 26890
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0;

		// Token: 0x0400690B RID: 26891
		private static readonly IntPtr NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0;

		// Token: 0x0400690C RID: 26892
		private static readonly IntPtr NativeMethodInfoPtr_ValidateInput_Private_Void_0;

		// Token: 0x0400690D RID: 26893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400690E RID: 26894
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_0_Private_Void_String_0;

		// Token: 0x0400690F RID: 26895
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_1_Private_Void_0;

		// Token: 0x04006910 RID: 26896
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_2_Private_Void_0;
	}
}
