using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006CC RID: 1740
	public class ProductAppDetailPanel : MonoBehaviour
	{
		// Token: 0x06009AD0 RID: 39632 RVA: 0x0027A5AC File Offset: 0x002787AC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductAppDetailPanel()
		{
			Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductAppDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr);
			ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "<ActiveProduct>k__BackingField");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Min");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Max");
			ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NothingSelected");
			ProductAppDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Container");
			ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NameLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ValueLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "SuggestedPriceLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ListedForSale");
			ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "DescLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "PropertyLabels");
			ProductAppDetailPanel.NativeFieldInfoPtr_Listed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Listed");
			ProductAppDetailPanel.NativeFieldInfoPtr_Delisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Delisted");
			ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NotDiscovered");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipesLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipeEntries");
			ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "LayoutGroup");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionSlider");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ScrollRect");
			ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682505);
			ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682506);
			ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682507);
			ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682508);
			ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682509);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682510);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682511);
			ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682512);
			ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682513);
			ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682514);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682515);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682516);
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x06009AD1 RID: 39633 RVA: 0x0027A85C File Offset: 0x00278A5C
		// (set) Token: 0x06009AD2 RID: 39634 RVA: 0x0027A89C File Offset: 0x00278A9C
		public unsafe ProductDefinition ActiveProduct
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x0027A8E0 File Offset: 0x00278AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276366, XrefRangeEnd = 276385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x0027A914 File Offset: 0x00278B14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276581, RefRangeEnd = 276585, XrefRangeStart = 276385, XrefRangeEnd = 276581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveProduct(ProductDefinition productDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x0027A958 File Offset: 0x00278B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276585, XrefRangeEnd = 276591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x0027A98C File Offset: 0x00278B8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276600, RefRangeEnd = 276603, XrefRangeStart = 276591, XrefRangeEnd = 276600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x0027A9C0 File Offset: 0x00278BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276610, RefRangeEnd = 276612, XrefRangeStart = 276603, XrefRangeEnd = 276610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x0027A9F4 File Offset: 0x00278BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276612, XrefRangeEnd = 276637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingToggled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x0027AA28 File Offset: 0x00278C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276662, RefRangeEnd = 276663, XrefRangeStart = 276637, XrefRangeEnd = 276662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x0027AA6C File Offset: 0x00278C6C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductAppDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x0027AAA8 File Offset: 0x00278CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__23_0(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x0027AAE8 File Offset: 0x00278CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276663, XrefRangeEnd = 276664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__23_1(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x0004B203 File Offset: 0x00049403
		public ProductAppDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x06009ADE RID: 39646 RVA: 0x0027AB2C File Offset: 0x00278D2C
		// (set) Token: 0x06009ADF RID: 39647 RVA: 0x0004B20C File Offset: 0x0004940C
		public unsafe ProductDefinition _ActiveProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x06009AE0 RID: 39648 RVA: 0x0027AB5C File Offset: 0x00278D5C
		// (set) Token: 0x06009AE1 RID: 39649 RVA: 0x0004B22B File Offset: 0x0004942B
		public unsafe Color AddictionColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min)) = value;
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x06009AE2 RID: 39650 RVA: 0x0027AB84 File Offset: 0x00278D84
		// (set) Token: 0x06009AE3 RID: 39651 RVA: 0x0004B246 File Offset: 0x00049446
		public unsafe Color AddictionColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max)) = value;
			}
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x06009AE4 RID: 39652 RVA: 0x0027ABAC File Offset: 0x00278DAC
		// (set) Token: 0x06009AE5 RID: 39653 RVA: 0x0004B261 File Offset: 0x00049461
		public unsafe GameObject NothingSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x06009AE6 RID: 39654 RVA: 0x0027ABDC File Offset: 0x00278DDC
		// (set) Token: 0x06009AE7 RID: 39655 RVA: 0x0004B280 File Offset: 0x00049480
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x06009AE8 RID: 39656 RVA: 0x0027AC0C File Offset: 0x00278E0C
		// (set) Token: 0x06009AE9 RID: 39657 RVA: 0x0004B29F File Offset: 0x0004949F
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x06009AEA RID: 39658 RVA: 0x0027AC3C File Offset: 0x00278E3C
		// (set) Token: 0x06009AEB RID: 39659 RVA: 0x0004B2BE File Offset: 0x000494BE
		public unsafe InputField ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x06009AEC RID: 39660 RVA: 0x0027AC6C File Offset: 0x00278E6C
		// (set) Token: 0x06009AED RID: 39661 RVA: 0x0004B2DD File Offset: 0x000494DD
		public unsafe Text SuggestedPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x06009AEE RID: 39662 RVA: 0x0027AC9C File Offset: 0x00278E9C
		// (set) Token: 0x06009AEF RID: 39663 RVA: 0x0004B2FC File Offset: 0x000494FC
		public unsafe Toggle ListedForSale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x06009AF0 RID: 39664 RVA: 0x0027ACCC File Offset: 0x00278ECC
		// (set) Token: 0x06009AF1 RID: 39665 RVA: 0x0004B31B File Offset: 0x0004951B
		public unsafe Text DescLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x0027ACFC File Offset: 0x00278EFC
		// (set) Token: 0x06009AF3 RID: 39667 RVA: 0x0004B33A File Offset: 0x0004953A
		public unsafe Il2CppReferenceArray<Text> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x06009AF4 RID: 39668 RVA: 0x0027AD2C File Offset: 0x00278F2C
		// (set) Token: 0x06009AF5 RID: 39669 RVA: 0x0004B359 File Offset: 0x00049559
		public unsafe RectTransform Listed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Listed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Listed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x06009AF6 RID: 39670 RVA: 0x0027AD5C File Offset: 0x00278F5C
		// (set) Token: 0x06009AF7 RID: 39671 RVA: 0x0004B378 File Offset: 0x00049578
		public unsafe RectTransform Delisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Delisted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Delisted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x06009AF8 RID: 39672 RVA: 0x0027AD8C File Offset: 0x00278F8C
		// (set) Token: 0x06009AF9 RID: 39673 RVA: 0x0004B397 File Offset: 0x00049597
		public unsafe RectTransform NotDiscovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x06009AFA RID: 39674 RVA: 0x0027ADBC File Offset: 0x00278FBC
		// (set) Token: 0x06009AFB RID: 39675 RVA: 0x0004B3B6 File Offset: 0x000495B6
		public unsafe RectTransform RecipesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x06009AFC RID: 39676 RVA: 0x0027ADEC File Offset: 0x00278FEC
		// (set) Token: 0x06009AFD RID: 39677 RVA: 0x0004B3D5 File Offset: 0x000495D5
		public unsafe Il2CppReferenceArray<RectTransform> RecipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x06009AFE RID: 39678 RVA: 0x0027AE1C File Offset: 0x0027901C
		// (set) Token: 0x06009AFF RID: 39679 RVA: 0x0004B3F4 File Offset: 0x000495F4
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x06009B00 RID: 39680 RVA: 0x0027AE4C File Offset: 0x0027904C
		// (set) Token: 0x06009B01 RID: 39681 RVA: 0x0004B413 File Offset: 0x00049613
		public unsafe Scrollbar AddictionSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x06009B02 RID: 39682 RVA: 0x0027AE7C File Offset: 0x0027907C
		// (set) Token: 0x06009B03 RID: 39683 RVA: 0x0004B432 File Offset: 0x00049632
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x06009B04 RID: 39684 RVA: 0x0027AEAC File Offset: 0x002790AC
		// (set) Token: 0x06009B05 RID: 39685 RVA: 0x0004B451 File Offset: 0x00049651
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400684B RID: 26699
		private static readonly IntPtr NativeFieldInfoPtr__ActiveProduct_k__BackingField;

		// Token: 0x0400684C RID: 26700
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Min;

		// Token: 0x0400684D RID: 26701
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Max;

		// Token: 0x0400684E RID: 26702
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelected;

		// Token: 0x0400684F RID: 26703
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006850 RID: 26704
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04006851 RID: 26705
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006852 RID: 26706
		private static readonly IntPtr NativeFieldInfoPtr_SuggestedPriceLabel;

		// Token: 0x04006853 RID: 26707
		private static readonly IntPtr NativeFieldInfoPtr_ListedForSale;

		// Token: 0x04006854 RID: 26708
		private static readonly IntPtr NativeFieldInfoPtr_DescLabel;

		// Token: 0x04006855 RID: 26709
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x04006856 RID: 26710
		private static readonly IntPtr NativeFieldInfoPtr_Listed;

		// Token: 0x04006857 RID: 26711
		private static readonly IntPtr NativeFieldInfoPtr_Delisted;

		// Token: 0x04006858 RID: 26712
		private static readonly IntPtr NativeFieldInfoPtr_NotDiscovered;

		// Token: 0x04006859 RID: 26713
		private static readonly IntPtr NativeFieldInfoPtr_RecipesLabel;

		// Token: 0x0400685A RID: 26714
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntries;

		// Token: 0x0400685B RID: 26715
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x0400685C RID: 26716
		private static readonly IntPtr NativeFieldInfoPtr_AddictionSlider;

		// Token: 0x0400685D RID: 26717
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x0400685E RID: 26718
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x0400685F RID: 26719
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0;

		// Token: 0x04006860 RID: 26720
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0;

		// Token: 0x04006861 RID: 26721
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006862 RID: 26722
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0;

		// Token: 0x04006863 RID: 26723
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006864 RID: 26724
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Private_Void_0;

		// Token: 0x04006865 RID: 26725
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04006866 RID: 26726
		private static readonly IntPtr NativeMethodInfoPtr_ListingToggled_Private_Void_0;

		// Token: 0x04006867 RID: 26727
		private static readonly IntPtr NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0;

		// Token: 0x04006868 RID: 26728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006869 RID: 26729
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0;

		// Token: 0x0400686A RID: 26730
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0;
	}
}
