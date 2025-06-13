using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000721 RID: 1825
	public class CharacterCustomizationOption : MonoBehaviour
	{
		// Token: 0x0600A2B1 RID: 41649 RVA: 0x00291DC0 File Offset: 0x0028FFC0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationOption()
		{
			Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr);
			CharacterCustomizationOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Name");
			CharacterCustomizationOption.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Label");
			CharacterCustomizationOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Price");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequireLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequiredLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "NameLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "PriceLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LevelLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LockDisplay");
			CharacterCustomizationOption.NativeFieldInfoPtr_MainButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "MainButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "BuyButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "SelectionIndicator");
			CharacterCustomizationOption.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onSelect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onDeselect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onPurchase");
			CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "<purchased>k__BackingField");
			CharacterCustomizationOption.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "selected");
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683297);
			CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683298);
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683299);
			CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683300);
			CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683301);
			CharacterCustomizationOption.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683302);
			CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683303);
			CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683304);
			CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683305);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683306);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683307);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683308);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683309);
			CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683310);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683311);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683312);
			CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100683313);
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600A2B2 RID: 41650 RVA: 0x00292098 File Offset: 0x00290298
		// (set) Token: 0x0600A2B3 RID: 41651 RVA: 0x002920D4 File Offset: 0x002902D4
		public unsafe bool purchased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600A2B4 RID: 41652 RVA: 0x00292114 File Offset: 0x00290314
		public unsafe bool purchaseable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 286666, RefRangeEnd = 286670, XrefRangeStart = 286665, XrefRangeEnd = 286666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x00292150 File Offset: 0x00290350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286670, XrefRangeEnd = 286690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x00292184 File Offset: 0x00290384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x002921B8 File Offset: 0x002903B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286690, XrefRangeEnd = 286696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x002921EC File Offset: 0x002903EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286696, XrefRangeEnd = 286697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x00292220 File Offset: 0x00290420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286697, XrefRangeEnd = 286698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x00292254 File Offset: 0x00290454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286698, XrefRangeEnd = 286714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Purchased()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x00292288 File Offset: 0x00290488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286727, RefRangeEnd = 286729, XrefRangeStart = 286714, XrefRangeEnd = 286727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x002922BC File Offset: 0x002904BC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 286738, RefRangeEnd = 286749, XrefRangeStart = 286729, XrefRangeEnd = 286738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(bool _selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _selected;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x002922FC File Offset: 0x002904FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286756, RefRangeEnd = 286758, XrefRangeStart = 286749, XrefRangeEnd = 286756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPurchased(bool _purchased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _purchased;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x0029233C File Offset: 0x0029053C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 286770, RefRangeEnd = 286778, XrefRangeStart = 286758, XrefRangeEnd = 286770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x00292370 File Offset: 0x00290570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286778, XrefRangeEnd = 286780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParentCategoryClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x002923A4 File Offset: 0x002905A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286780, XrefRangeEnd = 286785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x002923E8 File Offset: 0x002905E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286785, XrefRangeEnd = 286794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x0029242C File Offset: 0x0029062C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286794, XrefRangeEnd = 286804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x0004FBE4 File Offset: 0x0004DDE4
		public CharacterCustomizationOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600A2C4 RID: 41668 RVA: 0x00292468 File Offset: 0x00290668
		// (set) Token: 0x0600A2C5 RID: 41669 RVA: 0x0004FBED File Offset: 0x0004DDED
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0600A2C6 RID: 41670 RVA: 0x00292490 File Offset: 0x00290690
		// (set) Token: 0x0600A2C7 RID: 41671 RVA: 0x0004FC0C File Offset: 0x0004DE0C
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A2C8 RID: 41672 RVA: 0x002924B8 File Offset: 0x002906B8
		// (set) Token: 0x0600A2C9 RID: 41673 RVA: 0x0004FC2B File Offset: 0x0004DE2B
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x002924E0 File Offset: 0x002906E0
		// (set) Token: 0x0600A2CB RID: 41675 RVA: 0x0004FC46 File Offset: 0x0004DE46
		public unsafe bool RequireLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel)) = value;
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0600A2CC RID: 41676 RVA: 0x00292508 File Offset: 0x00290708
		// (set) Token: 0x0600A2CD RID: 41677 RVA: 0x0004FC61 File Offset: 0x0004DE61
		public unsafe FullRank RequiredLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel)) = value;
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x00292530 File Offset: 0x00290730
		// (set) Token: 0x0600A2CF RID: 41679 RVA: 0x0004FC7C File Offset: 0x0004DE7C
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600A2D0 RID: 41680 RVA: 0x00292560 File Offset: 0x00290760
		// (set) Token: 0x0600A2D1 RID: 41681 RVA: 0x0004FC9B File Offset: 0x0004DE9B
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600A2D2 RID: 41682 RVA: 0x00292590 File Offset: 0x00290790
		// (set) Token: 0x0600A2D3 RID: 41683 RVA: 0x0004FCBA File Offset: 0x0004DEBA
		public unsafe TextMeshProUGUI LevelLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600A2D4 RID: 41684 RVA: 0x002925C0 File Offset: 0x002907C0
		// (set) Token: 0x0600A2D5 RID: 41685 RVA: 0x0004FCD9 File Offset: 0x0004DED9
		public unsafe RectTransform LockDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x002925F0 File Offset: 0x002907F0
		// (set) Token: 0x0600A2D7 RID: 41687 RVA: 0x0004FCF8 File Offset: 0x0004DEF8
		public unsafe Button MainButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600A2D8 RID: 41688 RVA: 0x00292620 File Offset: 0x00290820
		// (set) Token: 0x0600A2D9 RID: 41689 RVA: 0x0004FD17 File Offset: 0x0004DF17
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600A2DA RID: 41690 RVA: 0x00292650 File Offset: 0x00290850
		// (set) Token: 0x0600A2DB RID: 41691 RVA: 0x0004FD36 File Offset: 0x0004DF36
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A2DC RID: 41692 RVA: 0x00292680 File Offset: 0x00290880
		// (set) Token: 0x0600A2DD RID: 41693 RVA: 0x0004FD55 File Offset: 0x0004DF55
		public unsafe UnityEvent onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A2DE RID: 41694 RVA: 0x002926B0 File Offset: 0x002908B0
		// (set) Token: 0x0600A2DF RID: 41695 RVA: 0x0004FD74 File Offset: 0x0004DF74
		public unsafe UnityEvent onDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A2E0 RID: 41696 RVA: 0x002926E0 File Offset: 0x002908E0
		// (set) Token: 0x0600A2E1 RID: 41697 RVA: 0x0004FD93 File Offset: 0x0004DF93
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A2E2 RID: 41698 RVA: 0x00292710 File Offset: 0x00290910
		// (set) Token: 0x0600A2E3 RID: 41699 RVA: 0x0004FDB2 File Offset: 0x0004DFB2
		public unsafe bool _purchased_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField)) = value;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A2E4 RID: 41700 RVA: 0x00292738 File Offset: 0x00290938
		// (set) Token: 0x0600A2E5 RID: 41701 RVA: 0x0004FDCD File Offset: 0x0004DFCD
		public unsafe bool selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected)) = value;
			}
		}

		// Token: 0x04006D1B RID: 27931
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04006D1C RID: 27932
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006D1D RID: 27933
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04006D1E RID: 27934
		private static readonly IntPtr NativeFieldInfoPtr_RequireLevel;

		// Token: 0x04006D1F RID: 27935
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLevel;

		// Token: 0x04006D20 RID: 27936
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006D21 RID: 27937
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04006D22 RID: 27938
		private static readonly IntPtr NativeFieldInfoPtr_LevelLabel;

		// Token: 0x04006D23 RID: 27939
		private static readonly IntPtr NativeFieldInfoPtr_LockDisplay;

		// Token: 0x04006D24 RID: 27940
		private static readonly IntPtr NativeFieldInfoPtr_MainButton;

		// Token: 0x04006D25 RID: 27941
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006D26 RID: 27942
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006D27 RID: 27943
		private static readonly IntPtr NativeFieldInfoPtr_onSelect;

		// Token: 0x04006D28 RID: 27944
		private static readonly IntPtr NativeFieldInfoPtr_onDeselect;

		// Token: 0x04006D29 RID: 27945
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x04006D2A RID: 27946
		private static readonly IntPtr NativeFieldInfoPtr__purchased_k__BackingField;

		// Token: 0x04006D2B RID: 27947
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04006D2C RID: 27948
		private static readonly IntPtr NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0;

		// Token: 0x04006D2D RID: 27949
		private static readonly IntPtr NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0;

		// Token: 0x04006D2E RID: 27950
		private static readonly IntPtr NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0;

		// Token: 0x04006D2F RID: 27951
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006D30 RID: 27952
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006D31 RID: 27953
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006D32 RID: 27954
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006D33 RID: 27955
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Private_Void_0;

		// Token: 0x04006D34 RID: 27956
		private static readonly IntPtr NativeMethodInfoPtr_Purchased_Private_Void_0;

		// Token: 0x04006D35 RID: 27957
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0;

		// Token: 0x04006D36 RID: 27958
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;

		// Token: 0x04006D37 RID: 27959
		private static readonly IntPtr NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0;

		// Token: 0x04006D38 RID: 27960
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006D39 RID: 27961
		private static readonly IntPtr NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0;

		// Token: 0x04006D3A RID: 27962
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D3B RID: 27963
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D3C RID: 27964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
